namespace AutoService.Forms
{
    partial class AddEditCarForm
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
            this.lblBrand        = new System.Windows.Forms.Label();
            this.lblModel        = new System.Windows.Forms.Label();
            this.lblYear         = new System.Windows.Forms.Label();
            this.lblLicensePlate = new System.Windows.Forms.Label();
            this.lblClient       = new System.Windows.Forms.Label();
            this.txtBrand        = new System.Windows.Forms.TextBox();
            this.txtModel        = new System.Windows.Forms.TextBox();
            this.txtYear         = new System.Windows.Forms.TextBox();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.cmbClient       = new System.Windows.Forms.ComboBox();
            this.btnOk           = new System.Windows.Forms.Button();
            this.btnCancel       = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblBrand
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(12, 18);
            this.lblBrand.Text     = "Марка *:";

            // txtBrand
            this.txtBrand.Location = new System.Drawing.Point(140, 15);
            this.txtBrand.Size     = new System.Drawing.Size(220, 22);
            this.txtBrand.TabIndex = 0;

            // lblModel
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(12, 53);
            this.lblModel.Text     = "Модель *:";

            // txtModel
            this.txtModel.Location = new System.Drawing.Point(140, 50);
            this.txtModel.Size     = new System.Drawing.Size(220, 22);
            this.txtModel.TabIndex = 1;

            // lblYear
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(12, 88);
            this.lblYear.Text     = "Год выпуска *:";

            // txtYear
            this.txtYear.Location = new System.Drawing.Point(140, 85);
            this.txtYear.Size     = new System.Drawing.Size(100, 22);
            this.txtYear.TabIndex = 2;

            // lblLicensePlate
            this.lblLicensePlate.AutoSize = true;
            this.lblLicensePlate.Location = new System.Drawing.Point(12, 123);
            this.lblLicensePlate.Text     = "Гос. номер *:";

            // txtLicensePlate
            this.txtLicensePlate.Location = new System.Drawing.Point(140, 120);
            this.txtLicensePlate.Size     = new System.Drawing.Size(220, 22);
            this.txtLicensePlate.TabIndex = 3;

            // lblClient
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(12, 158);
            this.lblClient.Text     = "Клиент *:";

            // cmbClient
            this.cmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClient.Location      = new System.Drawing.Point(140, 155);
            this.cmbClient.Size          = new System.Drawing.Size(220, 23);
            this.cmbClient.TabIndex      = 4;

            // btnOk
            this.btnOk.Location    = new System.Drawing.Point(140, 200);
            this.btnOk.Size        = new System.Drawing.Size(100, 30);
            this.btnOk.TabIndex    = 5;
            this.btnOk.Text        = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click      += new System.EventHandler(this.btnOk_Click);

            // btnCancel
            this.btnCancel.Location    = new System.Drawing.Point(250, 200);
            this.btnCancel.Size        = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex    = 6;
            this.btnCancel.Text        = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click      += new System.EventHandler(this.btnCancel_Click);

            // AddEditCarForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(390, 250);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblLicensePlate);
            this.Controls.Add(this.txtLicensePlate);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle    = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox        = false;
            this.MinimizeBox        = false;
            this.StartPosition      = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text               = "Автомобиль";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label    lblBrand;
        private System.Windows.Forms.Label    lblModel;
        private System.Windows.Forms.Label    lblYear;
        private System.Windows.Forms.Label    lblLicensePlate;
        private System.Windows.Forms.Label    lblClient;
        private System.Windows.Forms.TextBox  txtBrand;
        private System.Windows.Forms.TextBox  txtModel;
        private System.Windows.Forms.TextBox  txtYear;
        private System.Windows.Forms.TextBox  txtLicensePlate;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Button   btnOk;
        private System.Windows.Forms.Button   btnCancel;
    }
}
