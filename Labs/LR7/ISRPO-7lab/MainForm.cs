using System;
using System.Windows.Forms;
using Lab7;

namespace Lab7
{
    public partial class MainForm : Form
    {
        private DatabaseHelper dbHelper;
        private Book selectedBook;

        public MainForm()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            SetupDataGridViewColumns();
            LoadBooks();
        }

        private void SetupDataGridViewColumns()
        {
            dataGridView1.Columns.Clear();

            // Создаем столбцы
            dataGridView1.Columns.Add("Id", "ID");
            dataGridView1.Columns.Add("Title", "Название");
            dataGridView1.Columns.Add("AuthorName", "Автор");
            dataGridView1.Columns.Add("ReleaseYear", "Год издания");
            dataGridView1.Columns.Add("Pages", "Страниц");
            dataGridView1.Columns.Add("Circulation", "Тираж");

            // Настройка ширины
            dataGridView1.Columns["Id"].Width = 50;
            dataGridView1.Columns["Title"].Width = 200;
            dataGridView1.Columns["AuthorName"].Width = 150;
            dataGridView1.Columns["ReleaseYear"].Width = 80;
            dataGridView1.Columns["Pages"].Width = 70;
            dataGridView1.Columns["Circulation"].Width = 70;

            // Настройка выравнивания
            dataGridView1.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["ReleaseYear"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["Pages"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["Circulation"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void LoadBooks()
        {
            try
            {
                dataGridView1.Rows.Clear();
                var books = dbHelper.GetBooks();

                if (books == null || books.Count == 0)
                {
                    MessageBox.Show("В базе данных нет книг.", "Информация",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (var book in books)
                {
                    dataGridView1.Rows.Add(
                        book.Id,
                        book.Title,
                        book.AuthorName,
                        book.ReleaseYear,
                        book.Pages,
                        book.Circulation
                    );
                }

                // Выбираем первую книгу, если есть
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows[0].Selected = true;
                    UpdateSelectedBook(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки книг: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateSelectedBook(int rowIndex)
        {
            try
            {
                if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
                {
                    var row = dataGridView1.Rows[rowIndex];

                    // Проверяем, что строка не пустая
                    if (row.Cells[0].Value == null)
                        return;

                    selectedBook = new Book
                    {
                        Id = Convert.ToInt32(row.Cells["Id"].Value),
                        Title = row.Cells["Title"].Value?.ToString() ?? "",
                        AuthorName = row.Cells["AuthorName"].Value?.ToString() ?? "",
                        ReleaseYear = Convert.ToInt32(row.Cells["ReleaseYear"].Value),
                        Pages = Convert.ToInt32(row.Cells["Pages"].Value),
                        Circulation = Convert.ToInt32(row.Cells["Circulation"].Value)
                    };

                    // Обновляем текстовые поля
                    txtNazvanie.Text = selectedBook.Title;
                    txtAvtor.Text = selectedBook.AuthorName;
                    txtIzdanie.Text = selectedBook.ReleaseYear.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обновления книги: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Обработчики событий
        private void btnPredzakaz_Click(object sender, EventArgs e)
        {
            if (selectedBook == null)
            {
                MessageBox.Show("Выберите книгу для предзаказа.", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Проверяем, что книга выбрана корректно
                if (string.IsNullOrEmpty(selectedBook.Title) || selectedBook.Id <= 0)
                {
                    MessageBox.Show("Некорректные данные книги. Выберите книгу заново.", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var orderForm = new FormOrder(selectedBook);
                orderForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка открытия формы заказа: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UpdateSelectedBook(e.RowIndex);
            }

            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Index >= 0)
            {
                UpdateSelectedBook(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void btnVixod_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение выхода",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}