namespace Lab7
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAvtor = new System.Windows.Forms.TextBox();
            this.txtIzdanie = new System.Windows.Forms.TextBox();
            this.txtNazvanie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPredzakaz = new System.Windows.Forms.Button();
            this.btnVixod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(781, 247);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAvtor);
            this.groupBox1.Controls.Add(this.txtIzdanie);
            this.groupBox1.Controls.Add(this.txtNazvanie);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 115);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о книге";
            // 
            // txtAvtor
            // 
            this.txtAvtor.Location = new System.Drawing.Point(482, 24);
            this.txtAvtor.Name = "txtAvtor";
            this.txtAvtor.Size = new System.Drawing.Size(292, 22);
            this.txtAvtor.TabIndex = 5;
            // 
            // txtIzdanie
            // 
            this.txtIzdanie.Location = new System.Drawing.Point(111, 68);
            this.txtIzdanie.Name = "txtIzdanie";
            this.txtIzdanie.Size = new System.Drawing.Size(310, 22);
            this.txtIzdanie.TabIndex = 4;
            // 
            // txtNazvanie
            // 
            this.txtNazvanie.Location = new System.Drawing.Point(96, 24);
            this.txtNazvanie.Name = "txtNazvanie";
            this.txtNazvanie.Size = new System.Drawing.Size(310, 22);
            this.txtNazvanie.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Автор:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Год издания:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // btnPredzakaz
            // 
            this.btnPredzakaz.Location = new System.Drawing.Point(23, 396);
            this.btnPredzakaz.Name = "btnPredzakaz";
            this.btnPredzakaz.Size = new System.Drawing.Size(234, 35);
            this.btnPredzakaz.TabIndex = 2;
            this.btnPredzakaz.Text = "Сделать предзаказ";
            this.btnPredzakaz.UseVisualStyleBackColor = true;
            this.btnPredzakaz.Click += new System.EventHandler(this.btnPredzakaz_Click);
            // 
            // btnVixod
            // 
            this.btnVixod.Location = new System.Drawing.Point(526, 396);
            this.btnVixod.Name = "btnVixod";
            this.btnVixod.Size = new System.Drawing.Size(234, 35);
            this.btnVixod.TabIndex = 3;
            this.btnVixod.Text = "Выход";
            this.btnVixod.UseVisualStyleBackColor = true;
            this.btnVixod.Click += new System.EventHandler(this.btnVixod_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVixod);
            this.Controls.Add(this.btnPredzakaz);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "Издательство - Предзаказ книг";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPredzakaz;
        private System.Windows.Forms.TextBox txtAvtor;
        private System.Windows.Forms.TextBox txtIzdanie;
        private System.Windows.Forms.TextBox txtNazvanie;
        private System.Windows.Forms.Button btnVixod;
    }
}

