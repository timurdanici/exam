namespace AutoService.Forms
{
    partial class AddEditClientForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblLastName   = new System.Windows.Forms.Label();
            this.lblFirstName  = new System.Windows.Forms.Label();
            this.lblPhone      = new System.Windows.Forms.Label();
            this.lblAddress    = new System.Windows.Forms.Label();
            this.txtLastName   = new System.Windows.Forms.TextBox();
            this.txtFirstName  = new System.Windows.Forms.TextBox();
            this.txtPhone      = new System.Windows.Forms.TextBox();
            this.txtAddress    = new System.Windows.Forms.TextBox();
            this.btnOk         = new System.Windows.Forms.Button();
            this.btnCancel     = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblLastName
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 18);
            this.lblLastName.Text     = "Фамилия *:";

            // txtLastName
            this.txtLastName.Location = new System.Drawing.Point(120, 15);
            this.txtLastName.Size     = new System.Drawing.Size(230, 22);
            this.txtLastName.TabIndex = 0;

            // lblFirstName
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 53);
            this.lblFirstName.Text     = "Имя *:";

            // txtFirstName
            this.txtFirstName.Location = new System.Drawing.Point(120, 50);
            this.txtFirstName.Size     = new System.Drawing.Size(230, 22);
            this.txtFirstName.TabIndex = 1;

            // lblPhone
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 88);
            this.lblPhone.Text     = "Телефон:";

            // txtPhone
            this.txtPhone.Location = new System.Drawing.Point(120, 85);
            this.txtPhone.Size     = new System.Drawing.Size(230, 22);
            this.txtPhone.TabIndex = 2;

            // lblAddress
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 123);
            this.lblAddress.Text     = "Адрес:";

            // txtAddress
            this.txtAddress.Location = new System.Drawing.Point(120, 120);
            this.txtAddress.Size     = new System.Drawing.Size(230, 22);
            this.txtAddress.TabIndex = 3;

            // btnOk
            this.btnOk.Location    = new System.Drawing.Point(120, 160);
            this.btnOk.Size        = new System.Drawing.Size(100, 30);
            this.btnOk.TabIndex    = 4;
            this.btnOk.Text        = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click      += new System.EventHandler(this.btnOk_Click);

            // btnCancel
            this.btnCancel.Location    = new System.Drawing.Point(230, 160);
            this.btnCancel.Size        = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex    = 5;
            this.btnCancel.Text        = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click      += new System.EventHandler(this.btnCancel_Click);

            // AddEditClientForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(374, 210);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle    = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox        = false;
            this.MinimizeBox        = false;
            this.StartPosition      = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text               = "Клиент";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label   lblLastName;
        private System.Windows.Forms.Label   lblFirstName;
        private System.Windows.Forms.Label   lblPhone;
        private System.Windows.Forms.Label   lblAddress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button  btnOk;
        private System.Windows.Forms.Button  btnCancel;
    }
}
