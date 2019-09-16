namespace TestTaskInvoice.Dialogs
{
    partial class EditInvoiceDialog
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
            this.AmountTB = new System.Windows.Forms.TextBox();
            this.ClientTB = new System.Windows.Forms.TextBox();
            this.UpdateBT = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // AmountTB
            // 
            this.AmountTB.Location = new System.Drawing.Point(12, 104);
            this.AmountTB.Name = "AmountTB";
            this.AmountTB.Size = new System.Drawing.Size(268, 20);
            this.AmountTB.TabIndex = 3;
            // 
            // ClientTB
            // 
            this.ClientTB.Location = new System.Drawing.Point(12, 64);
            this.ClientTB.Name = "ClientTB";
            this.ClientTB.Size = new System.Drawing.Size(268, 20);
            this.ClientTB.TabIndex = 5;
            // 
            // UpdateBT
            // 
            this.UpdateBT.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.UpdateBT.Location = new System.Drawing.Point(12, 130);
            this.UpdateBT.Name = "UpdateBT";
            this.UpdateBT.Size = new System.Drawing.Size(183, 23);
            this.UpdateBT.TabIndex = 7;
            this.UpdateBT.Text = "Update";
            this.UpdateBT.UseVisualStyleBackColor = true;
            this.UpdateBT.Click += new System.EventHandler(this.UpdateBT_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(201, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Client";
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(12, 25);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(268, 20);
            this.DatePicker.TabIndex = 12;
            // 
            // EditInvoiceDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 163);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.UpdateBT);
            this.Controls.Add(this.ClientTB);
            this.Controls.Add(this.AmountTB);
            this.Name = "EditInvoiceDialog";
            this.Text = "Invoice edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox AmountTB;
        private System.Windows.Forms.TextBox ClientTB;
        private System.Windows.Forms.Button UpdateBT;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DatePicker;
    }
}