namespace TestTaskInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainDGV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TotAmoBT = new System.Windows.Forms.Button();
            this.DeleteBT = new System.Windows.Forms.Button();
            this.ChangeBT = new System.Windows.Forms.Button();
            this.AddBT = new System.Windows.Forms.Button();
            this.SearchBT = new System.Windows.Forms.Button();
            this.ALLBT = new System.Windows.Forms.Button();
            this.ConnTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConnBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainDGV
            // 
            this.MainDGV.AllowUserToAddRows = false;
            this.MainDGV.AllowUserToDeleteRows = false;
            this.MainDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDGV.Location = new System.Drawing.Point(12, 12);
            this.MainDGV.Name = "MainDGV";
            this.MainDGV.ReadOnly = true;
            this.MainDGV.Size = new System.Drawing.Size(592, 435);
            this.MainDGV.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TotAmoBT);
            this.groupBox1.Controls.Add(this.DeleteBT);
            this.groupBox1.Controls.Add(this.ChangeBT);
            this.groupBox1.Controls.Add(this.AddBT);
            this.groupBox1.Controls.Add(this.SearchBT);
            this.groupBox1.Controls.Add(this.ALLBT);
            this.groupBox1.Location = new System.Drawing.Point(621, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 464);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // TotAmoBT
            // 
            this.TotAmoBT.Location = new System.Drawing.Point(11, 164);
            this.TotAmoBT.Name = "TotAmoBT";
            this.TotAmoBT.Size = new System.Drawing.Size(100, 23);
            this.TotAmoBT.TabIndex = 5;
            this.TotAmoBT.Text = "Total amount";
            this.TotAmoBT.UseVisualStyleBackColor = true;
            this.TotAmoBT.Click += new System.EventHandler(this.TotAmoBT_Click);
            // 
            // DeleteBT
            // 
            this.DeleteBT.Location = new System.Drawing.Point(11, 135);
            this.DeleteBT.Name = "DeleteBT";
            this.DeleteBT.Size = new System.Drawing.Size(100, 23);
            this.DeleteBT.TabIndex = 4;
            this.DeleteBT.Text = "Delete";
            this.DeleteBT.UseVisualStyleBackColor = true;
            this.DeleteBT.Click += new System.EventHandler(this.DeleteBT_Click);
            // 
            // ChangeBT
            // 
            this.ChangeBT.Location = new System.Drawing.Point(11, 106);
            this.ChangeBT.Name = "ChangeBT";
            this.ChangeBT.Size = new System.Drawing.Size(100, 23);
            this.ChangeBT.TabIndex = 3;
            this.ChangeBT.Text = "Change";
            this.ChangeBT.UseVisualStyleBackColor = true;
            this.ChangeBT.Click += new System.EventHandler(this.ChangeBT_click);
            // 
            // AddBT
            // 
            this.AddBT.Location = new System.Drawing.Point(11, 77);
            this.AddBT.Name = "AddBT";
            this.AddBT.Size = new System.Drawing.Size(100, 23);
            this.AddBT.TabIndex = 2;
            this.AddBT.Text = "Add new";
            this.AddBT.UseVisualStyleBackColor = true;
            this.AddBT.Click += new System.EventHandler(this.AddBT_Click);
            // 
            // SearchBT
            // 
            this.SearchBT.Location = new System.Drawing.Point(11, 48);
            this.SearchBT.Name = "SearchBT";
            this.SearchBT.Size = new System.Drawing.Size(100, 23);
            this.SearchBT.TabIndex = 1;
            this.SearchBT.Text = "Search";
            this.SearchBT.UseVisualStyleBackColor = true;
            this.SearchBT.Click += new System.EventHandler(this.SearchBT_Click);
            // 
            // ALLBT
            // 
            this.ALLBT.Location = new System.Drawing.Point(11, 19);
            this.ALLBT.Name = "ALLBT";
            this.ALLBT.Size = new System.Drawing.Size(100, 23);
            this.ALLBT.TabIndex = 0;
            this.ALLBT.Text = "View all";
            this.ALLBT.UseVisualStyleBackColor = true;
            this.ALLBT.Click += new System.EventHandler(this.ALLBT_Click);
            // 
            // ConnTB
            // 
            this.ConnTB.Location = new System.Drawing.Point(118, 455);
            this.ConnTB.Name = "ConnTB";
            this.ConnTB.Size = new System.Drawing.Size(405, 20);
            this.ConnTB.TabIndex = 2;
            this.ConnTB.Text = resources.GetString("ConnTB.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Connection String:";
            // 
            // ConnBT
            // 
            this.ConnBT.Location = new System.Drawing.Point(529, 453);
            this.ConnBT.Name = "ConnBT";
            this.ConnBT.Size = new System.Drawing.Size(75, 23);
            this.ConnBT.TabIndex = 4;
            this.ConnBT.Text = "Connect";
            this.ConnBT.UseVisualStyleBackColor = true;
            this.ConnBT.Click += new System.EventHandler(this.ConnBT_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 488);
            this.Controls.Add(this.ConnBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConnTB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MainDGV);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.MainDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MainDGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button TotAmoBT;
        private System.Windows.Forms.Button DeleteBT;
        private System.Windows.Forms.Button ChangeBT;
        private System.Windows.Forms.Button AddBT;
        private System.Windows.Forms.Button SearchBT;
        private System.Windows.Forms.Button ALLBT;
        private System.Windows.Forms.TextBox ConnTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConnBT;
    }
}

