namespace Lab7
{
    partial class FormOrder
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAvtor = new System.Windows.Forms.Label();
            this.lblNazvanie = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtFIO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbOfic = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblItog = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPodtverditi = new System.Windows.Forms.Button();
            this.btnOtmena = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAvtor);
            this.groupBox1.Controls.Add(this.lblNazvanie);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(433, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбранная книга";
            // 
            // lblAvtor
            // 
            this.lblAvtor.AutoSize = true;
            this.lblAvtor.Location = new System.Drawing.Point(51, 46);
            this.lblAvtor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvtor.Name = "lblAvtor";
            this.lblAvtor.Size = new System.Drawing.Size(0, 13);
            this.lblAvtor.TabIndex = 3;
            // 
            // lblNazvanie
            // 
            this.lblNazvanie.AutoSize = true;
            this.lblNazvanie.Location = new System.Drawing.Point(69, 23);
            this.lblNazvanie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNazvanie.Name = "lblNazvanie";
            this.lblNazvanie.Size = new System.Drawing.Size(0, 13);
            this.lblNazvanie.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Автор:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTelefon);
            this.groupBox2.Controls.Add(this.txtAdres);
            this.groupBox2.Controls.Add(this.txtFIO);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(18, 111);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(432, 110);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные клиента";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(66, 77);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(234, 20);
            this.txtTelefon.TabIndex = 8;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(44, 50);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(378, 20);
            this.txtAdres.TabIndex = 8;
            // 
            // txtFIO
            // 
            this.txtFIO.Location = new System.Drawing.Point(44, 23);
            this.txtFIO.Margin = new System.Windows.Forms.Padding(2);
            this.txtFIO.Name = "txtFIO";
            this.txtFIO.Size = new System.Drawing.Size(378, 20);
            this.txtFIO.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Телефон:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Адрес:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ФИО:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbOfic);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(18, 235);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(432, 76);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Выбор офиса получения";
            // 
            // cmbOfic
            // 
            this.cmbOfic.FormattingEnabled = true;
            this.cmbOfic.Location = new System.Drawing.Point(44, 32);
            this.cmbOfic.Margin = new System.Windows.Forms.Padding(2);
            this.cmbOfic.Name = "cmbOfic";
            this.cmbOfic.Size = new System.Drawing.Size(278, 21);
            this.cmbOfic.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Офис:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numericUpDown1);
            this.groupBox4.Controls.Add(this.lblItog);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(18, 331);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(432, 60);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Детали заказа";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(78, 26);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
            // 
            // lblItog
            // 
            this.lblItog.AutoSize = true;
            this.lblItog.Location = new System.Drawing.Point(163, 28);
            this.lblItog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItog.Name = "lblItog";
            this.lblItog.Size = new System.Drawing.Size(72, 13);
            this.lblItog.TabIndex = 2;
            this.lblItog.Text = "Итого: 0 руб.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Количество:";
            // 
            // btnPodtverditi
            // 
            this.btnPodtverditi.Location = new System.Drawing.Point(60, 422);
            this.btnPodtverditi.Margin = new System.Windows.Forms.Padding(2);
            this.btnPodtverditi.Name = "btnPodtverditi";
            this.btnPodtverditi.Size = new System.Drawing.Size(152, 28);
            this.btnPodtverditi.TabIndex = 4;
            this.btnPodtverditi.Text = "Подтвердить заказ";
            this.btnPodtverditi.UseVisualStyleBackColor = true;
            this.btnPodtverditi.Click += new System.EventHandler(this.btnPodtverditi_Click);
            // 
            // btnOtmena
            // 
            this.btnOtmena.Location = new System.Drawing.Point(230, 422);
            this.btnOtmena.Margin = new System.Windows.Forms.Padding(2);
            this.btnOtmena.Name = "btnOtmena";
            this.btnOtmena.Size = new System.Drawing.Size(144, 28);
            this.btnOtmena.TabIndex = 5;
            this.btnOtmena.Text = "Отмена";
            this.btnOtmena.UseVisualStyleBackColor = true;
            this.btnOtmena.Click += new System.EventHandler(this.btnOtmena_Click);
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 469);
            this.Controls.Add(this.btnOtmena);
            this.Controls.Add(this.btnPodtverditi);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormOrder";
            this.Text = "Оформление предзаказа";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAvtor;
        private System.Windows.Forms.Label lblNazvanie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtFIO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbOfic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblItog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPodtverditi;
        private System.Windows.Forms.Button btnOtmena;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}