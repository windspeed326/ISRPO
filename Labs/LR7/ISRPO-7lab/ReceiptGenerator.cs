using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Lab7
{
    public class ReceiptGenerator
    {
        private Order order;

        public ReceiptGenerator(Order order)
        {
            this.order = order;
        }

        public void PrintReceipt()
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += PrintReceiptPage;

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDoc;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }

        private void PrintReceiptPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font normalFont = new Font("Arial", 10);
            Font boldFont = new Font("Arial", 10, FontStyle.Bold);
            Font largeFont = new Font("Arial", 14, FontStyle.Bold);

            float yPos = 20;
            float leftMargin = e.MarginBounds.Left;
            float center = e.MarginBounds.Width / 2;

            // Заголовок
            g.DrawString("ИЗДАТЕЛЬСТВО 'КНИГА'", titleFont, Brushes.Black,
                center - g.MeasureString("ИЗДАТЕЛЬСТВО 'КНИГА'", titleFont).Width / 2, yPos);
            yPos += 30;

            g.DrawString("Кассовый чек", headerFont, Brushes.Black,
                center - g.MeasureString("Кассовый чек", headerFont).Width / 2, yPos);
            yPos += 30;

            // Линия
            g.DrawLine(Pens.Black, leftMargin, yPos, e.MarginBounds.Right, yPos);
            yPos += 10;

            // Номер заказа и дата
            g.DrawString("Номер заказа:", normalFont, Brushes.Black, leftMargin, yPos);
            g.DrawString(order.Id.ToString(), boldFont, Brushes.Black, leftMargin + 120, yPos);
            yPos += 25;

            g.DrawString("Дата:", normalFont, Brushes.Black, leftMargin, yPos);
            g.DrawString(order.OrderDate.ToString("dd.MM.yyyy HH:mm"), boldFont, Brushes.Black, leftMargin + 120, yPos);
            yPos += 25;

            // Линия
            g.DrawLine(Pens.Black, leftMargin, yPos, e.MarginBounds.Right, yPos);
            yPos += 10;

            // Заголовок "ЗАКАЗ:"
            g.DrawString("ЗАКАЗ:", headerFont, Brushes.Black, leftMargin, yPos);
            yPos += 30;

            // Детали заказа
            g.DrawString("Книга:", normalFont, Brushes.Black, leftMargin, yPos);
            g.DrawString($"\"{order.BookTitle}\"", boldFont, Brushes.Black, leftMargin + 70, yPos);
            yPos += 25;

            g.DrawString("Клиент:", normalFont, Brushes.Black, leftMargin, yPos);
            g.DrawString(order.CustomerName, boldFont, Brushes.Black, leftMargin + 70, yPos);
            yPos += 25;

            g.DrawString("Офис получения:", normalFont, Brushes.Black, leftMargin, yPos);
            g.DrawString(order.OfficeName, boldFont, Brushes.Black, leftMargin + 130, yPos);
            yPos += 30;

            // Линия
            g.DrawLine(Pens.Black, leftMargin, yPos, e.MarginBounds.Right, yPos);
            yPos += 10;

            // Сумма
            g.DrawString("Сумма к оплате:", headerFont, Brushes.Black, leftMargin, yPos);
            g.DrawString($"{order.Price:F2} руб.", largeFont, Brushes.Red, leftMargin + 150, yPos);
            yPos += 40;

            // Информация
            string infoText = "Заказ будет готов к выдаче через 14 дней.\n" +
                             "При себе иметь данный чек и документ, удостоверяющий личность";

            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            RectangleF rect = new RectangleF(leftMargin, yPos, e.MarginBounds.Width, 60);
            g.DrawString(infoText, normalFont, Brushes.Black, rect, format);
            yPos += 70;

            // Подпись
            g.DrawString("Подпись кассира", normalFont, Brushes.Black,
                e.MarginBounds.Right - 120, yPos);
            g.DrawLine(Pens.Black, e.MarginBounds.Right - 120, yPos + 20,
                e.MarginBounds.Right - 20, yPos + 20);
        }

        public Bitmap GenerateReceiptImage()
        {
            Bitmap bmp = new Bitmap(400, 500);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                Font titleFont = new Font("Arial", 16, FontStyle.Bold);
                Font headerFont = new Font("Arial", 12, FontStyle.Bold);
                Font normalFont = new Font("Arial", 10);
                Font boldFont = new Font("Arial", 10, FontStyle.Bold);
                Font largeFont = new Font("Arial", 14, FontStyle.Bold);

                float yPos = 20;
                float leftMargin = 20;
                float center = bmp.Width / 2;

                // Заголовок
                g.DrawString("ИЗДАТЕЛЬСТВО 'КНИГА'", titleFont, Brushes.Black,
                    center - g.MeasureString("ИЗДАТЕЛЬСТВО 'КНИГА'", titleFont).Width / 2, yPos);
                yPos += 30;

                g.DrawString("Кассовый чек", headerFont, Brushes.Black,
                    center - g.MeasureString("Кассовый чек", headerFont).Width / 2, yPos);
                yPos += 30;

                // Линия
                g.DrawLine(Pens.Black, leftMargin, yPos, bmp.Width - leftMargin, yPos);
                yPos += 10;

                // Номер заказа и дата
                g.DrawString("Номер заказа:", normalFont, Brushes.Black, leftMargin, yPos);
                g.DrawString(order.Id.ToString(), boldFont, Brushes.Black, leftMargin + 120, yPos);
                yPos += 25;

                g.DrawString("Дата:", normalFont, Brushes.Black, leftMargin, yPos);
                g.DrawString(order.OrderDate.ToString("dd.MM.yyyy HH:mm"), boldFont, Brushes.Black, leftMargin + 120, yPos);
                yPos += 25;

                // Линия
                g.DrawLine(Pens.Black, leftMargin, yPos, bmp.Width - leftMargin, yPos);
                yPos += 10;

                // Заголовок "ЗАКАЗ:"
                g.DrawString("ЗАКАЗ:", headerFont, Brushes.Black, leftMargin, yPos);
                yPos += 30;

                // Детали заказа
                g.DrawString("Книга:", normalFont, Brushes.Black, leftMargin, yPos);
                g.DrawString($"\"{order.BookTitle}\"", boldFont, Brushes.Black, leftMargin + 70, yPos);
                yPos += 25;

                g.DrawString("Клиент:", normalFont, Brushes.Black, leftMargin, yPos);
                g.DrawString(order.CustomerName, boldFont, Brushes.Black, leftMargin + 70, yPos);
                yPos += 25;

                g.DrawString("Офис получения:", normalFont, Brushes.Black, leftMargin, yPos);
                g.DrawString(order.OfficeName, boldFont, Brushes.Black, leftMargin + 130, yPos);
                yPos += 30;

                // Линия
                g.DrawLine(Pens.Black, leftMargin, yPos, bmp.Width - leftMargin, yPos);
                yPos += 10;

                // Сумма
                g.DrawString("Сумма к оплате:", headerFont, Brushes.Black, leftMargin, yPos);
                g.DrawString($"{order.Price:F2} руб.", largeFont, Brushes.Red, leftMargin + 150, yPos);
                yPos += 40;

                // Информация
                string infoText = "Заказ будет готов к выдаче через 14 дней.\n" +
                                 "При себе иметь данный чек и документ, удостоверяющий личность";

                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Center;
                RectangleF rect = new RectangleF(leftMargin, yPos, bmp.Width - 2 * leftMargin, 60);
                g.DrawString(infoText, normalFont, Brushes.Black, rect, format);
                yPos += 70;

                // Подпись
                g.DrawString("Подпись кассира", normalFont, Brushes.Black,
                    bmp.Width - leftMargin - 120, yPos);
                g.DrawLine(Pens.Black, bmp.Width - leftMargin - 120, yPos + 20,
                    bmp.Width - leftMargin - 20, yPos + 20);
            }

            return bmp;
        }
    }
}