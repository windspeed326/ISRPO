namespace Lab7
{
    partial class FormReceipt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPeshati = new System.Windows.Forms.Button();
            this.btnZakriti = new System.Windows.Forms.Button();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblReceiptType = new System.Windows.Forms.Label();
            this.lblOrderNumberLabel = new System.Windows.Forms.Label();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBook = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOffice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPeshati
            // 
            this.btnPeshati.Location = new System.Drawing.Point(98, 473);
            this.btnPeshati.Name = "btnPeshati";
            this.btnPeshati.Size = new System.Drawing.Size(149, 43);
            this.btnPeshati.TabIndex = 0;
            this.btnPeshati.Text = "Печать";
            this.btnPeshati.UseVisualStyleBackColor = true;
            this.btnPeshati.Click += new System.EventHandler(this.btnPeshati_Click);
            // 
            // btnZakriti
            // 
            this.btnZakriti.Location = new System.Drawing.Point(281, 475);
            this.btnZakriti.Name = "btnZakriti";
            this.btnZakriti.Size = new System.Drawing.Size(153, 40);
            this.btnZakriti.TabIndex = 1;
            this.btnZakriti.Text = "Отмена";
            this.btnZakriti.UseVisualStyleBackColor = true;
            this.btnZakriti.Click += new System.EventHandler(this.btnZakriti_Click);
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPublisher.Location = new System.Drawing.Point(50, 9);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(477, 38);
            this.lblPublisher.TabIndex = 2;
            this.lblPublisher.Text = "\"ИЗДАТЕЛЬСТВО \'КНИГА\'\" ";
            // 
            // lblReceiptType
            // 
            this.lblReceiptType.AutoSize = true;
            this.lblReceiptType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReceiptType.Location = new System.Drawing.Point(225, 59);
            this.lblReceiptType.Name = "lblReceiptType";
            this.lblReceiptType.Size = new System.Drawing.Size(136, 20);
            this.lblReceiptType.TabIndex = 3;
            this.lblReceiptType.Text = "Кассовый чек";
            // 
            // lblOrderNumberLabel
            // 
            this.lblOrderNumberLabel.AutoSize = true;
            this.lblOrderNumberLabel.Location = new System.Drawing.Point(24, 101);
            this.lblOrderNumberLabel.Name = "lblOrderNumberLabel";
            this.lblOrderNumberLabel.Size = new System.Drawing.Size(103, 16);
            this.lblOrderNumberLabel.TabIndex = 4;
            this.lblOrderNumberLabel.Text = "Номер заказа:";
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Location = new System.Drawing.Point(134, 100);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(0, 16);
            this.lblOrderNumber.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Дата:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(73, 138);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 16);
            this.lblDate.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Заказ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Книга:";
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Location = new System.Drawing.Point(81, 202);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(0, 16);
            this.lblBook.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Клиент:";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(87, 229);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(0, 16);
            this.lblClient.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Офис получения:";
            // 
            // lblOffice
            // 
            this.lblOffice.AutoSize = true;
            this.lblOffice.Location = new System.Drawing.Point(150, 261);
            this.lblOffice.Name = "lblOffice";
            this.lblOffice.Size = new System.Drawing.Size(0, 16);
            this.lblOffice.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Сумма к оплате:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(146, 292);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 16);
            this.lblTotal.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(446, 32);
            this.label7.TabIndex = 17;
            this.label7.Text = "Заказ будет готов к выдаче через 14 дней. \r\nПри себе иметь данный чек и документ," +
    " удостоверяющий личность";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(312, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Подпись кассира:";
            // 
            // FormReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 536);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblOffice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBook);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOrderNumber);
            this.Controls.Add(this.lblOrderNumberLabel);
            this.Controls.Add(this.lblReceiptType);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.btnZakriti);
            this.Controls.Add(this.btnPeshati);
            this.Name = "FormReceipt";
            this.Text = "Чек заказа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPeshati;
        private System.Windows.Forms.Button btnZakriti;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblReceiptType;
        private System.Windows.Forms.Label lblOrderNumberLabel;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOffice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}