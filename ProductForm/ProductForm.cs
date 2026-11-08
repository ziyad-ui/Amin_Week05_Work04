namespace ProductForm
{
    public partial class frmProductForm : Form
    {
        // Simulates a database of saved barcodes
        private readonly List<string> _savedBarcodes = new();

        public frmProductForm()
        {
            InitializeComponent();

            // Connect events
            Load += frmProductForm_Load;
            txtBarcode.TextChanged += txtBarcode_TextChanged;
            txtCost.KeyPress += NumericOnly_KeyPress;
            txtPrice.KeyPress += NumericOnly_KeyPress;
            txtCost.TextChanged += CostPrice_TextChanged;
            txtPrice.TextChanged += CostPrice_TextChanged;
            btnSave.Click += btnSave_Click;
            btnClear.Click += btnClear_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private void frmProductForm_Load(object? sender, EventArgs e)
        {
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Items.AddRange(new object[]
            {
                "Beverages", "Snacks", "Canned Goods",
                "Personal Care", "Household", "Others"
            });
            rdoLocal.Checked = true;
            chkActive.Checked = true;
            lblBarcodeStatus.Text = "";
        }

        // ---- Barcode availability check ----
        private void txtBarcode_TextChanged(object? sender, EventArgs e)
        {
            string code = txtBarcode.Text.Trim();

            if (code.Length == 0)
            {
                lblBarcodeStatus.Text = "";
            }
            else if (_savedBarcodes.Contains(code))
            {
                lblBarcodeStatus.Text = "Barcode already exists.";
                lblBarcodeStatus.ForeColor = Color.Red;
            }
            else
            {
                lblBarcodeStatus.Text = "Barcode is available.";
                lblBarcodeStatus.ForeColor = Color.Green;
            }
        }

        // ---- Allow only numbers and one decimal point ----
        private void NumericOnly_KeyPress(object? sender, KeyPressEventArgs e)
        {
            var box = (TextBox)sender!;
            if (char.IsControl(e.KeyChar)) return;

            bool isDigit = char.IsDigit(e.KeyChar);
            bool isFirstDot = e.KeyChar == '.' && !box.Text.Contains('.');

            if (!isDigit && !isFirstDot)
                e.Handled = true;
        }

        // ---- Auto-calculate markup % = (Price - Cost) / Cost * 100 ----
        private void CostPrice_TextChanged(object? sender, EventArgs e)
        {
            if (decimal.TryParse(txtCost.Text, out decimal cost) &&
                decimal.TryParse(txtPrice.Text, out decimal price) &&
                cost > 0)
            {
                lblMarkup.Text = ((price - cost) / cost * 100).ToString("N2");
            }
            else
            {
                lblMarkup.Text = "";
            }
        }

        // ---- Validation ----
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtBarcode.Text))
                return Fail("Barcode is required.", txtBarcode);

            if (_savedBarcodes.Contains(txtBarcode.Text.Trim()))
                return Fail("This barcode already exists.", txtBarcode);

            if (string.IsNullOrWhiteSpace(txtName.Text))
                return Fail("Name is required.", txtName);

            if (cboCategory.SelectedIndex == -1)
                return Fail("Please select a category.", cboCategory);

            if (!decimal.TryParse(txtCost.Text, out decimal cost) || cost <= 0)
                return Fail("Enter a valid cost greater than 0.", txtCost);

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
                return Fail("Enter a valid price greater than 0.", txtPrice);

            if (price < cost)
                return Fail("Price cannot be lower than cost.", txtPrice);

            return true;
        }

        private bool Fail(string message, Control focusTarget)
        {
            MessageBox.Show(message, "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            focusTarget.Focus();
            return false;
        }

        // ---- Buttons ----
        private void btnSave_Click(object? sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            string origin = rdoLocal.Checked ? "Local" : "Abroad";
            string status = chkActive.Checked ? "Active" : "Inactive";

            _savedBarcodes.Add(txtBarcode.Text.Trim());

            MessageBox.Show(
                $"Product saved!\n\n" +
                $"Barcode: {txtBarcode.Text}\n" +
                $"Name: {txtName.Text}\n" +
                $"Category: {cboCategory.Text}\n" +
                $"Origin: {origin}\n" +
                $"Status: {status}\n" +
                $"Cost: {txtCost.Text}\n" +
                $"Price: {txtPrice.Text}\n" +
                $"Markup: {lblMarkup.Text}%",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearForm();
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnCancel_Click(object? sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Close the form? Unsaved data will be lost.",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) Close();
        }

        private void ClearForm()
        {
            txtBarcode.Clear();
            txtName.Clear();
            txtDescription.Clear();
            cboCategory.SelectedIndex = -1;
            rdoLocal.Checked = true;
            chkActive.Checked = true;
            txtCost.Clear();
            txtPrice.Clear();
            lblMarkup.Clear();
            lblBarcodeStatus.Text = "";
            txtBarcode.Focus();
        }
    }
}