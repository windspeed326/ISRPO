using System;
using System.Windows.Forms;

namespace Lab7
{
    public partial class FormOrder : Form
    {
        private Book selectedBook;
        private DatabaseHelper dbHelper;
        private const decimal PRICE_PER_BOOK = 500m; // Цена за одну книгу

        public FormOrder(Book book)
        {
            InitializeComponent();
            selectedBook = book ?? throw new ArgumentNullException(nameof(book));
            dbHelper = new DatabaseHelper();

            InitializeForm();
        }

        private void InitializeForm()
        {
            try
            {
                // Заполняем информацию о книге
                lblNazvanie.Text = selectedBook.Title ?? "Не указано";
                lblAvtor.Text = selectedBook.AuthorName ?? "Не указан";

                // Загружаем офисы
                LoadOffices();

                // Настраиваем NumericUpDown для количества
                numericUpDown1.Minimum = 1;
                numericUpDown1.Maximum = 100;
                numericUpDown1.Value = 1;

                // Рассчитываем итог
                CalculateTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка инициализации формы: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadOffices()
        {
            try
            {
                cmbOfic.Items.Clear();
                var offices = dbHelper.GetOffices();

                if (offices == null || offices.Count == 0)
                {
                    cmbOfic.Items.Add("Нет доступных офисов");
                    cmbOfic.Enabled = false;
                    return;
                }

                foreach (var office in offices)
                {
                    cmbOfic.Items.Add(new OfficeItem
                    {
                        Id = office.Id,
                        Name = office.Name,
                        FullInfo = $"{office.Name} ({office.Address})"
                    });
                }

                cmbOfic.DisplayMember = "FullInfo";
                cmbOfic.ValueMember = "Id";

                if (cmbOfic.Items.Count > 0)
                {
                    cmbOfic.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки офисов: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbOfic.Items.Add("Ошибка загрузки офисов");
                cmbOfic.Enabled = false;
            }
        }

        // Вспомогательный класс для отображения офисов
        private class OfficeItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string FullInfo { get; set; }
        }

        private void CalculateTotal()
        {
            try
            {
                int quantity = (int)numericUpDown1.Value;
                decimal total = quantity * PRICE_PER_BOOK;
                lblItog.Text = $"{total:F2} руб.";
            }
            catch (Exception ex)
            {
                lblItog.Text = "Ошибка расчета";
                MessageBox.Show($"Ошибка расчета суммы: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void btnPodtverditi_Click(object sender, EventArgs e)
        {
            try
            {
                // Валидация данных
                if (string.IsNullOrWhiteSpace(txtFIO.Text))
                {
                    MessageBox.Show("Введите ФИО клиента.", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFIO.Focus();
                    return;
                }

                if (cmbOfic.SelectedItem == null || cmbOfic.SelectedIndex < 0)
                {
                    MessageBox.Show("Выберите офис для получения.", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbOfic.Focus();
                    return;
                }

                // Получаем выбранный офис
                OfficeItem selectedOffice = cmbOfic.SelectedItem as OfficeItem;
                if (selectedOffice == null)
                {
                    MessageBox.Show("Некорректный выбор офиса.", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Получаем количество книг
                int quantity = (int)numericUpDown1.Value;

                // Создаем клиента
                var customer = new Customer
                {
                    Name = txtFIO.Text.Trim(),
                    Address = txtAdres.Text?.Trim(),
                    Phone = txtTelefon.Text?.Trim()
                };

                // Создаем клиента в БД
                int customerId = dbHelper.CreateCustomer(customer);

                // Создаем заказ
                var order = new Order
                {
                    OrderName = $"Предзаказ: {selectedBook.Title}",
                    BookId = selectedBook.Id,
                    CustomerId = customerId,
                    OfficeId = selectedOffice.Id,
                    OrderDate = DateTime.Now,
                    CompletionDate = DateTime.Now.AddDays(14),
                    Price = quantity * PRICE_PER_BOOK
                };

                // Сохраняем заказ в БД
                int orderId = dbHelper.CreateOrder(order);

                // Показываем чек
                var receiptForm = new FormReceipt(orderId);
                receiptForm.ShowDialog();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка оформления заказа: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOtmena_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}