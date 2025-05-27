namespace Lab5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnCreateExcel;
        private System.Windows.Forms.Button btnShowMsg;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnCreateExcel = new System.Windows.Forms.Button();
            this.btnShowMsg = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.btnCreateExcel.Location = new System.Drawing.Point(40, 30);
            this.btnCreateExcel.Name = "btnCreateExcel";
            this.btnCreateExcel.Size = new System.Drawing.Size(200, 40);
            this.btnCreateExcel.TabIndex = 0;
            this.btnCreateExcel.Text = "Создать Excel";
            this.btnCreateExcel.UseVisualStyleBackColor = true;
            this.btnCreateExcel.Click += new System.EventHandler(this.btnCreateExcel_Click);
 
            this.btnShowMsg.Location = new System.Drawing.Point(40, 90);
            this.btnShowMsg.Name = "btnShowMsg";
            this.btnShowMsg.Size = new System.Drawing.Size(200, 40);
            this.btnShowMsg.TabIndex = 1;
            this.btnShowMsg.Text = "WinAPI MessageBox";
            this.btnShowMsg.UseVisualStyleBackColor = true;
            this.btnShowMsg.Click += new System.EventHandler(this.btnShowMsg_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Controls.Add(this.btnCreateExcel);
            this.Controls.Add(this.btnShowMsg);
            this.Name = "Form1";
            this.Text = "Lab5";
            this.ResumeLayout(false);
        }
    }
}