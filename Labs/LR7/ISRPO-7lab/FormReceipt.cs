using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Lab7
{
    public partial class FormReceipt : Form
    {
        private int orderId;
        private DatabaseHelper dbHelper;

        public FormReceipt(int orderId)
        {
            InitializeComponent();
            this.orderId = orderId;
            dbHelper = new DatabaseHelper();
            LoadReceiptData();
        }

        private void LoadReceiptData()
        {
            try
            {
                // Получаем данные заказа из базы
                var order = dbHelper.GetOrderDetails(orderId);

                if (order == null)
                {
                    MessageBox.Show("Заказ не найден!", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
                lblOrderNumber.Text = order.Id.ToString();
                lblDate.Text = order.OrderDate.ToString("dd.MM.yyyy HH:mm");
                lblBook.Text = $"\"{order.BookTitle}\"";
                lblClient.Text = order.CustomerName;
                lblOffice.Text = order.OfficeName;
                lblTotal.Text = $"{order.Price:F2} руб.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки чека: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnPeshati_Click(object sender, EventArgs e)
        {
            try
            {
                // Создаем диалог печати
                PrintDialog printDialog = new PrintDialog();
                PrintDocument printDocument = new PrintDocument();
                printDialog.Document = printDocument;

                // Обработчик печати
                printDocument.PrintPage += (s, ev) =>
                {
                    Font font = new Font("Arial", 12);
                    float yPos = 50;

                    ev.Graphics.DrawString("ИЗДАТЕЛЬСТВО 'КНИГА'",
                        new Font("Arial", 16, FontStyle.Bold),
                        Brushes.Black, 50, yPos);
                    yPos += 30;

                    ev.Graphics.DrawString("Кассовый чек",
                        new Font("Arial", 12, FontStyle.Bold),
                        Brushes.Black, 50, yPos);
                    yPos += 30;

                    ev.Graphics.DrawLine(Pens.Black, 50, yPos, 350, yPos);
                    yPos += 20;

                    ev.Graphics.DrawString($"Номер заказа: {lblOrderNumber.Text}",
                        font, Brushes.Black, 50, yPos);
                    yPos += 25;

                    ev.Graphics.DrawString($"Дата: {lblDate.Text}",
                        font, Brushes.Black, 50, yPos);
                    yPos += 25;

                    ev.Graphics.DrawLine(Pens.Black, 50, yPos, 350, yPos);
                    yPos += 20;

                    ev.Graphics.DrawString("ЗАКАЗ:",
                        new Font("Arial", 12, FontStyle.Bold),
                        Brushes.Black, 50, yPos);
                    yPos += 30;

                    ev.Graphics.DrawString($"Книга: {lblBook.Text}",
                        font, Brushes.Black, 50, yPos);
                    yPos += 25;

                    ev.Graphics.DrawString($"Клиент: {lblClient.Text}",
                        font, Brushes.Black, 50, yPos);
                    yPos += 25;

                    ev.Graphics.DrawString($"Офис получения: {lblOffice.Text}",
                        font, Brushes.Black, 50, yPos);
                    yPos += 30;

                    ev.Graphics.DrawLine(Pens.Black, 50, yPos, 350, yPos);
                    yPos += 20;

                    ev.Graphics.DrawString("Сумма к оплате:",
                        new Font("Arial", 12, FontStyle.Bold),
                        Brushes.Black, 50, yPos);

                    ev.Graphics.DrawString($"{lblTotal.Text}",
                        new Font("Arial", 14, FontStyle.Bold),
                        Brushes.Red, 180, yPos);
                    yPos += 40;

                    string info = "Заказ будет готов к выдаче через 14 дней.\n" +
                                  "При себе иметь данный чек и документ, удостоверяющий личность";
                    ev.Graphics.DrawString(info,
                        new Font("Arial", 10),
                        Brushes.Black,
                        new RectangleF(50, yPos, 300, 60));
                    yPos += 70;

                    ev.Graphics.DrawString("Подпись кассира",
                        font, Brushes.Black, 230, yPos);
                    ev.Graphics.DrawLine(Pens.Black, 230, yPos + 20, 330, yPos + 20);
                };

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                    MessageBox.Show("Чек отправлен на печать!", "Печать",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при печати: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnZakriti_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}