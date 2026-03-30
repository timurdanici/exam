namespace AutoService.Forms
{
    partial class MainForm
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
            this.tabControl         = new System.Windows.Forms.TabControl();
            this.tabClients         = new System.Windows.Forms.TabPage();
            this.dgvClients         = new System.Windows.Forms.DataGridView();
            this.pnlClientButtons   = new System.Windows.Forms.Panel();
            this.btnAddClient       = new System.Windows.Forms.Button();
            this.btnEditClient      = new System.Windows.Forms.Button();
            this.btnDeleteClient    = new System.Windows.Forms.Button();
            this.btnRefreshClients  = new System.Windows.Forms.Button();
            this.tabCars            = new System.Windows.Forms.TabPage();
            this.dgvCars            = new System.Windows.Forms.DataGridView();
            this.pnlCarTop          = new System.Windows.Forms.Panel();
            this.txtSearch          = new System.Windows.Forms.TextBox();
            this.btnSearch          = new System.Windows.Forms.Button();
            this.btnAddCar          = new System.Windows.Forms.Button();
            this.btnEditCar         = new System.Windows.Forms.Button();
            this.btnDeleteCar       = new System.Windows.Forms.Button();
            this.btnRefreshCars     = new System.Windows.Forms.Button();
            this.lblSearch          = new System.Windows.Forms.Label();
            this.tabReport          = new System.Windows.Forms.TabPage();
            this.dgvReport          = new System.Windows.Forms.DataGridView();
            this.pnlReportButtons   = new System.Windows.Forms.Panel();
            this.btnRefreshReport   = new System.Windows.Forms.Button();

            this.tabControl.SuspendLayout();
            this.tabClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.pnlClientButtons.SuspendLayout();
            this.tabCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            this.pnlCarTop.SuspendLayout();
            this.tabReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.pnlReportButtons.SuspendLayout();
            this.SuspendLayout();

            // ---- tabControl ----
            this.tabControl.Controls.Add(this.tabClients);
            this.tabControl.Controls.Add(this.tabCars);
            this.tabControl.Controls.Add(this.tabReport);
            this.tabControl.Dock         = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font         = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tabControl.Location     = new System.Drawing.Point(0, 0);
            this.tabControl.Name         = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size         = new System.Drawing.Size(960, 620);
            this.tabControl.TabIndex     = 0;

            // ==========================================
            // CLIENTS TAB
            // ==========================================
            this.tabClients.Controls.Add(this.dgvClients);
            this.tabClients.Controls.Add(this.pnlClientButtons);
            this.tabClients.Location = new System.Drawing.Point(4, 26);
            this.tabClients.Name     = "tabClients";
            this.tabClients.Padding  = new System.Windows.Forms.Padding(3);
            this.tabClients.Size     = new System.Drawing.Size(952, 590);
            this.tabClients.TabIndex = 0;
            this.tabClients.Text     = "Клиенты";
            this.tabClients.UseVisualStyleBackColor = true;

            // ---- pnlClientButtons ----
            this.pnlClientButtons.Controls.Add(this.btnAddClient);
            this.pnlClientButtons.Controls.Add(this.btnEditClient);
            this.pnlClientButtons.Controls.Add(this.btnDeleteClient);
            this.pnlClientButtons.Controls.Add(this.btnRefreshClients);
            this.pnlClientButtons.Dock     = System.Windows.Forms.DockStyle.Top;
            this.pnlClientButtons.Height   = 46;
            this.pnlClientButtons.Padding  = new System.Windows.Forms.Padding(5, 8, 5, 5);

            // btnAddClient
            this.btnAddClient.Location = new System.Drawing.Point(8, 8);
            this.btnAddClient.Size     = new System.Drawing.Size(110, 30);
            this.btnAddClient.Text     = "➕ Добавить";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click   += new System.EventHandler(this.btnAddClient_Click);

            // btnEditClient
            this.btnEditClient.Location = new System.Drawing.Point(126, 8);
            this.btnEditClient.Size     = new System.Drawing.Size(110, 30);
            this.btnEditClient.Text     = "✏ Изменить";
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click   += new System.EventHandler(this.btnEditClient_Click);

            // btnDeleteClient
            this.btnDeleteClient.Location = new System.Drawing.Point(244, 8);
            this.btnDeleteClient.Size     = new System.Drawing.Size(110, 30);
            this.btnDeleteClient.Text     = "🗑 Удалить";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click   += new System.EventHandler(this.btnDeleteClient_Click);

            // btnRefreshClients
            this.btnRefreshClients.Location = new System.Drawing.Point(362, 8);
            this.btnRefreshClients.Size     = new System.Drawing.Size(110, 30);
            this.btnRefreshClients.Text     = "🔄 Обновить";
            this.btnRefreshClients.UseVisualStyleBackColor = true;
            this.btnRefreshClients.Click   += new System.EventHandler(this.btnRefreshClients_Click);

            // ---- dgvClients ----
            this.dgvClients.AllowUserToAddRows    = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.AutoSizeColumnsMode   = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Dock                  = System.Windows.Forms.DockStyle.Fill;
            this.dgvClients.MultiSelect            = false;
            this.dgvClients.ReadOnly               = true;
            this.dgvClients.SelectionMode          = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Name                   = "dgvClients";

            // ==========================================
            // CARS TAB
            // ==========================================
            this.tabCars.Controls.Add(this.dgvCars);
            this.tabCars.Controls.Add(this.pnlCarTop);
            this.tabCars.Location = new System.Drawing.Point(4, 26);
            this.tabCars.Name     = "tabCars";
            this.tabCars.Padding  = new System.Windows.Forms.Padding(3);
            this.tabCars.Size     = new System.Drawing.Size(952, 590);
            this.tabCars.TabIndex = 1;
            this.tabCars.Text     = "Автомобили";
            this.tabCars.UseVisualStyleBackColor = true;

            // ---- pnlCarTop ----
            this.pnlCarTop.Controls.Add(this.lblSearch);
            this.pnlCarTop.Controls.Add(this.txtSearch);
            this.pnlCarTop.Controls.Add(this.btnSearch);
            this.pnlCarTop.Controls.Add(this.btnAddCar);
            this.pnlCarTop.Controls.Add(this.btnEditCar);
            this.pnlCarTop.Controls.Add(this.btnDeleteCar);
            this.pnlCarTop.Controls.Add(this.btnRefreshCars);
            this.pnlCarTop.Dock   = System.Windows.Forms.DockStyle.Top;
            this.pnlCarTop.Height = 46;
            this.pnlCarTop.Padding = new System.Windows.Forms.Padding(5, 8, 5, 5);

            // lblSearch
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(8, 14);
            this.lblSearch.Text     = "Поиск:";

            // txtSearch
            this.txtSearch.Location = new System.Drawing.Point(60, 11);
            this.txtSearch.Size     = new System.Drawing.Size(200, 22);
            this.txtSearch.Name     = "txtSearch";
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);

            // btnSearch
            this.btnSearch.Location = new System.Drawing.Point(268, 8);
            this.btnSearch.Size     = new System.Drawing.Size(80, 30);
            this.btnSearch.Text     = "🔍 Найти";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click   += new System.EventHandler(this.btnSearch_Click);

            // btnAddCar
            this.btnAddCar.Location = new System.Drawing.Point(360, 8);
            this.btnAddCar.Size     = new System.Drawing.Size(110, 30);
            this.btnAddCar.Text     = "➕ Добавить";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click   += new System.EventHandler(this.btnAddCar_Click);

            // btnEditCar
            this.btnEditCar.Location = new System.Drawing.Point(478, 8);
            this.btnEditCar.Size     = new System.Drawing.Size(110, 30);
            this.btnEditCar.Text     = "✏ Изменить";
            this.btnEditCar.UseVisualStyleBackColor = true;
            this.btnEditCar.Click   += new System.EventHandler(this.btnEditCar_Click);

            // btnDeleteCar
            this.btnDeleteCar.Location = new System.Drawing.Point(596, 8);
            this.btnDeleteCar.Size     = new System.Drawing.Size(110, 30);
            this.btnDeleteCar.Text     = "🗑 Удалить";
            this.btnDeleteCar.UseVisualStyleBackColor = true;
            this.btnDeleteCar.Click   += new System.EventHandler(this.btnDeleteCar_Click);

            // btnRefreshCars
            this.btnRefreshCars.Location = new System.Drawing.Point(714, 8);
            this.btnRefreshCars.Size     = new System.Drawing.Size(110, 30);
            this.btnRefreshCars.Text     = "🔄 Обновить";
            this.btnRefreshCars.UseVisualStyleBackColor = true;
            this.btnRefreshCars.Click   += new System.EventHandler(this.btnRefreshCars_Click);

            // ---- dgvCars ----
            this.dgvCars.AllowUserToAddRows    = false;
            this.dgvCars.AllowUserToDeleteRows = false;
            this.dgvCars.AutoSizeColumnsMode   = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.Dock                  = System.Windows.Forms.DockStyle.Fill;
            this.dgvCars.MultiSelect            = false;
            this.dgvCars.ReadOnly               = true;
            this.dgvCars.SelectionMode          = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCars.Name                   = "dgvCars";

            // ==========================================
            // REPORT TAB
            // ==========================================
            this.tabReport.Controls.Add(this.dgvReport);
            this.tabReport.Controls.Add(this.pnlReportButtons);
            this.tabReport.Location = new System.Drawing.Point(4, 26);
            this.tabReport.Name     = "tabReport";
            this.tabReport.Padding  = new System.Windows.Forms.Padding(3);
            this.tabReport.Size     = new System.Drawing.Size(952, 590);
            this.tabReport.TabIndex = 2;
            this.tabReport.Text     = "Отчёт";
            this.tabReport.UseVisualStyleBackColor = true;

            // ---- pnlReportButtons ----
            this.pnlReportButtons.Controls.Add(this.btnRefreshReport);
            this.pnlReportButtons.Dock   = System.Windows.Forms.DockStyle.Top;
            this.pnlReportButtons.Height = 46;
            this.pnlReportButtons.Padding = new System.Windows.Forms.Padding(5, 8, 5, 5);

            // btnRefreshReport
            this.btnRefreshReport.Location = new System.Drawing.Point(8, 8);
            this.btnRefreshReport.Size     = new System.Drawing.Size(130, 30);
            this.btnRefreshReport.Text     = "🔄 Обновить отчёт";
            this.btnRefreshReport.UseVisualStyleBackColor = true;
            this.btnRefreshReport.Click   += new System.EventHandler(this.btnRefreshReport_Click);

            // ---- dgvReport ----
            this.dgvReport.AllowUserToAddRows    = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AutoSizeColumnsMode   = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Dock                  = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.MultiSelect            = false;
            this.dgvReport.ReadOnly               = true;
            this.dgvReport.SelectionMode          = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.Name                   = "dgvReport";

            // ==========================================
            // MainForm
            // ==========================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(960, 620);
            this.Controls.Add(this.tabControl);
            this.MinimumSize         = new System.Drawing.Size(800, 520);
            this.Name                = "MainForm";
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text                = "АвтоСервис — Управление клиентами и автомобилями";
            this.Load               += new System.EventHandler(this.MainForm_Load);

            this.tabControl.ResumeLayout(false);
            this.tabClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.pnlClientButtons.ResumeLayout(false);
            this.tabCars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            this.pnlCarTop.ResumeLayout(false);
            this.pnlCarTop.PerformLayout();
            this.tabReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.pnlReportButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl    tabControl;
        private System.Windows.Forms.TabPage       tabClients;
        private System.Windows.Forms.DataGridView  dgvClients;
        private System.Windows.Forms.Panel         pnlClientButtons;
        private System.Windows.Forms.Button        btnAddClient;
        private System.Windows.Forms.Button        btnEditClient;
        private System.Windows.Forms.Button        btnDeleteClient;
        private System.Windows.Forms.Button        btnRefreshClients;

        private System.Windows.Forms.TabPage       tabCars;
        private System.Windows.Forms.DataGridView  dgvCars;
        private System.Windows.Forms.Panel         pnlCarTop;
        private System.Windows.Forms.Label         lblSearch;
        private System.Windows.Forms.TextBox       txtSearch;
        private System.Windows.Forms.Button        btnSearch;
        private System.Windows.Forms.Button        btnAddCar;
        private System.Windows.Forms.Button        btnEditCar;
        private System.Windows.Forms.Button        btnDeleteCar;
        private System.Windows.Forms.Button        btnRefreshCars;

        private System.Windows.Forms.TabPage       tabReport;
        private System.Windows.Forms.DataGridView  dgvReport;
        private System.Windows.Forms.Panel         pnlReportButtons;
        private System.Windows.Forms.Button        btnRefreshReport;
    }
}
