namespace ProductForm
{
    partial class frmProductForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBarcode = new Label();
            txtBarcode = new TextBox();
            lblBarcodeStatus = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblCategory = new Label();
            cboCategory = new ComboBox();
            lblOrigin = new Label();
            grpManufactured = new GroupBox();
            rdoAbroad = new RadioButton();
            rdoLocal = new RadioButton();
            lblStatus = new Label();
            chkActive = new CheckBox();
            lblCost = new Label();
            lblPrice = new Label();
            label1 = new Label();
            txtCost = new TextBox();
            txtPrice = new TextBox();
            lblMarkup = new TextBox();
            btnCancel = new Button();
            btnClear = new Button();
            btnSave = new Button();
            grpManufactured.SuspendLayout();
            SuspendLayout();
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.Location = new Point(158, 33);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(64, 20);
            lblBarcode.TabIndex = 0;
            lblBarcode.Text = "Barcode";
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(263, 30);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(256, 27);
            txtBarcode.TabIndex = 1;
            // 
            // lblBarcodeStatus
            // 
            lblBarcodeStatus.AutoSize = true;
            lblBarcodeStatus.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBarcodeStatus.ForeColor = SystemColors.ButtonShadow;
            lblBarcodeStatus.Location = new Point(263, 60);
            lblBarcodeStatus.Name = "lblBarcodeStatus";
            lblBarcodeStatus.Size = new Size(100, 20);
            lblBarcodeStatus.TabIndex = 2;
            lblBarcodeStatus.Text = "BarcodeStatus";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(158, 100);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 3;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(263, 97);
            txtName.Name = "txtName";
            txtName.Size = new Size(256, 27);
            txtName.TabIndex = 4;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(157, 136);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(263, 133);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(256, 73);
            txtDescription.TabIndex = 6;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(158, 232);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(69, 20);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "Category";
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(263, 229);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(256, 28);
            cboCategory.TabIndex = 8;
            // 
            // lblOrigin
            // 
            lblOrigin.AutoSize = true;
            lblOrigin.Location = new Point(157, 303);
            lblOrigin.Name = "lblOrigin";
            lblOrigin.Size = new Size(50, 20);
            lblOrigin.TabIndex = 9;
            lblOrigin.Text = "Origin";
            // 
            // grpManufactured
            // 
            grpManufactured.Controls.Add(rdoAbroad);
            grpManufactured.Controls.Add(rdoLocal);
            grpManufactured.Location = new Point(263, 277);
            grpManufactured.Name = "grpManufactured";
            grpManufactured.Size = new Size(256, 60);
            grpManufactured.TabIndex = 10;
            grpManufactured.TabStop = false;
            grpManufactured.Text = "Manufactured";
            // 
            // rdoAbroad
            // 
            rdoAbroad.AutoSize = true;
            rdoAbroad.Location = new Point(155, 26);
            rdoAbroad.Name = "rdoAbroad";
            rdoAbroad.Size = new Size(80, 24);
            rdoAbroad.TabIndex = 1;
            rdoAbroad.Text = "Abroad";
            rdoAbroad.UseVisualStyleBackColor = true;
            // 
            // rdoLocal
            // 
            rdoLocal.AutoSize = true;
            rdoLocal.Checked = true;
            rdoLocal.Location = new Point(26, 26);
            rdoLocal.Name = "rdoLocal";
            rdoLocal.Size = new Size(65, 24);
            rdoLocal.TabIndex = 0;
            rdoLocal.TabStop = true;
            rdoLocal.Text = "Local";
            rdoLocal.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(158, 350);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 20);
            lblStatus.TabIndex = 11;
            lblStatus.Text = "Status";
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Location = new Point(263, 349);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(72, 24);
            chkActive.TabIndex = 12;
            chkActive.Text = "Active";
            chkActive.UseVisualStyleBackColor = true;
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Location = new Point(158, 388);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(38, 20);
            lblCost.TabIndex = 13;
            lblCost.Text = "Cost";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(282, 388);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 14;
            lblPrice.Text = "Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(417, 388);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 15;
            label1.Text = "Markup(%)";
            // 
            // txtCost
            // 
            txtCost.Location = new Point(158, 411);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(107, 27);
            txtCost.TabIndex = 16;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(282, 411);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(111, 27);
            txtPrice.TabIndex = 17;
            // 
            // lblMarkup
            // 
            lblMarkup.BackColor = SystemColors.ScrollBar;
            lblMarkup.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMarkup.Location = new Point(408, 411);
            lblMarkup.Name = "lblMarkup";
            lblMarkup.ReadOnly = true;
            lblMarkup.Size = new Size(111, 27);
            lblMarkup.TabIndex = 18;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(158, 468);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 29);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(282, 468);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(111, 29);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(408, 468);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(111, 29);
            btnSave.TabIndex = 21;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmProductForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(932, 550);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnCancel);
            Controls.Add(lblMarkup);
            Controls.Add(txtPrice);
            Controls.Add(txtCost);
            Controls.Add(label1);
            Controls.Add(lblPrice);
            Controls.Add(lblCost);
            Controls.Add(chkActive);
            Controls.Add(lblStatus);
            Controls.Add(grpManufactured);
            Controls.Add(lblOrigin);
            Controls.Add(cboCategory);
            Controls.Add(lblCategory);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblBarcodeStatus);
            Controls.Add(txtBarcode);
            Controls.Add(lblBarcode);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductForm";
            grpManufactured.ResumeLayout(false);
            grpManufactured.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBarcode;
        private TextBox txtBarcode;
        private Label lblBarcodeStatus;
        private Label lblName;
        private TextBox txtName;
        private Label lblDescription;
        private TextBox txtDescription;
        private Label lblCategory;
        private ComboBox cboCategory;
        private Label lblOrigin;
        private GroupBox grpManufactured;
        private RadioButton rdoAbroad;
        private RadioButton rdoLocal;
        private Label lblStatus;
        private CheckBox chkActive;
        private Label lblCost;
        private Label lblPrice;
        private Label label1;
        private TextBox txtCost;
        private TextBox txtPrice;
        private TextBox lblMarkup;
        private Button btnCancel;
        private Button btnClear;
        private Button btnSave;
    }
}
