using Streaming_Encryption.domain;

namespace Streaming_Encryption
{
    public partial class Streaming_Encryption : Form
    {
        public Streaming_Encryption()
        {
            InitializeComponent();
        }

        private void GetFileButton_Click(object sender, EventArgs e)
        {
            FileContext.TakeBytesFromPath(PathTextBox.Text);

            if (FileContext.bufferDigit == null)
                return;

            FileContext.ConvertBytesToBinary();

            if (FileContext.bufferBinary != null)
                FromTextBox.Text = String.Join(Environment.NewLine, FileContext.bufferBinary);

            GetFileButton.Enabled = false;
            InsertKeyButton.Enabled = true;
        }

        private void Streaming_Encryption_Load(object sender, EventArgs e)
        {
            SetXorTable();
        }

        private void SetXorTable()
        {
            XorTable.RowCount = 41;
            XorTable.ColumnCount = 36;

            for (int i = 0; i < XorTable.RowCount; i++)
                XorTable.Rows[i].Height = 20;
            for (int i = 0; i < XorTable.ColumnCount; i++)
                XorTable.Columns[i].Width = 20;

            XorTable.Columns[35].Width = 60;

            for (int i = 1; i < XorTable.RowCount; i++)
            {
                XorTable[0, i].Value = i;
                XorTable.Rows[i].Cells[1].Style.BackColor = Color.Wheat;
                XorTable.Rows[i].Cells[20].Style.BackColor = Color.Wheat;
                XorTable.Rows[i].Cells[21].Style.BackColor = Color.Wheat;
                XorTable.Rows[i].Cells[34].Style.BackColor = Color.Wheat;
                XorTable.Rows[i].Cells[35].Style.BackColor = Color.PowderBlue;
                XorTable.Rows[i].Cells[35].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            for (int i = 1; i < XorTable.ColumnCount-1; i++)
            {
                XorTable[i, 0].Value = 35 - i;
            }

            XorTable.Rows[0].Cells[1].Style.BackColor = Color.Wheat;
            XorTable.Rows[0].Cells[20].Style.BackColor = Color.Wheat;
            XorTable.Rows[0].Cells[21].Style.BackColor = Color.Wheat;
            XorTable.Rows[0].Cells[34].Style.BackColor = Color.Wheat;
            XorTable.Rows[0].Cells[35].Style.BackColor = Color.PowderBlue;
            XorTable.Rows[0].Cells[35].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            XorTable[35, 0].Value = "xor";
        }

        private void FillXorTable(string register)
        {
            for (int i = 1; i < XorTable.RowCount; i++)
            {
                for (int j = 1; j < XorTable.ColumnCount-1; j++)
                {
                    XorTable[j, i].Value = register[j - 1];
                }

                int incryptedByte = Convert.ToInt16(register[0]) ^ Convert.ToInt16(register[19]);
                incryptedByte ^= Convert.ToInt16(register[20]);
                incryptedByte ^= Convert.ToInt16(register[33]);

                XorTable[XorTable.ColumnCount - 1, i].Value = incryptedByte;
                register = register.Substring(1);
                register += incryptedByte;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            FileContext.bufferBinary = null;
            FileContext.bufferDigit = null;
            RegisterContext.key = null;
            FileContext.bufferEncryptDecryptBinary = null;
            FileContext.bufferEncryptDecryptDigit = null;
            KeyContext.key = null;
            KeyContext.keyDigit = null;

            for (int i = 1; i < XorTable.RowCount; i++)
            {
                for (int j = 1; j < XorTable.ColumnCount; j++)
                {
                    XorTable[j, i].Value = String.Empty;
                }
            }

            FromTextBox.Text = String.Empty;
            KeyTB.Text = String.Empty;
            EncryptDecryptTextBox.Text = String.Empty;
            GetFileButton.Enabled = true;
            InitialRegisterButton.Enabled = true;
            KeyButton.Enabled = true;
            EncryptDecryptButton.Enabled = false;
            SaveEncryptDecryptFileButton.Enabled = false;
            KeySaveButton.Enabled = false;
            InsertKeyButton.Enabled = false;

        }

        private void InitialRegisterButton_Click(object sender, EventArgs e)
        {
            if (InitialRegisterTextBox.Text == String.Empty)
            {
                MessageBox.Show("Register field is empty. Please, type value in it. (34 symbols required)", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            InitialRegisterTextBox.Text = RegisterContext.FilterTextBox(InitialRegisterTextBox.Text);

            if (!RegisterContext.IsEnoughNumbers(InitialRegisterTextBox.Text))
            {
                MessageBox.Show("Not enoght parameters in register field. (34 symbols required)", "Error", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FillXorTable(InitialRegisterTextBox.Text);

            if (FileContext.bufferBinary == null)
            {
                MessageBox.Show("You have not uploaded file yet. Binary code required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RegisterContext.GenerateKey(InitialRegisterTextBox.Text);

            if (RegisterContext.key != null)
                KeyTB.Text = String.Join(Environment.NewLine, RegisterContext.key);

            InitialRegisterButton.Enabled = false;
            KeyButton.Enabled = false;
            EncryptDecryptButton.Enabled = true;
            KeySaveButton.Enabled = true;
            InsertKeyButton.Enabled = false;
        }

        private void EncryptDecryptButton_Click(object sender, EventArgs e)
        {
            if (FromTextBox.Text == String.Empty || KeyTB.Text == String.Empty)
            {
                MessageBox.Show("You have not uploaded file yet or have not generated a key. File's and key's binary codes required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FileContext.EncryptDecryptFile();

            if (FileContext.bufferEncryptDecryptBinary != null)
                EncryptDecryptTextBox.Text = String.Join(Environment.NewLine, FileContext.bufferEncryptDecryptBinary);

            EncryptDecryptButton.Enabled = false;
            SaveEncryptDecryptFileButton.Enabled = true;
            InsertKeyButton.Enabled = false;
        }

        private void SaveEncryptDecryptFileButton_Click(object sender, EventArgs e)
        {
            FileContext.Save(TempPathTextBox.Text);
            TempPathTextBox.Text = String.Empty;
        }

        private void KeyButton_Click(object sender, EventArgs e)
        {
            if (KeyTextBox.Text == String.Empty)
            {
                MessageBox.Show("Key field is empty. Please, type any binary digit value in it.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            KeyTextBox.Text = KeyContext.FilterTextBox(KeyTextBox.Text);

            if (FileContext.bufferBinary == null)
            {
                MessageBox.Show("You have not uploaded file yet. Binary code required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            KeyContext.GenerateKey(KeyTextBox.Text);

            if (KeyContext.key != null)
                KeyTB.Text = String.Join(Environment.NewLine, KeyContext.key);

            InitialRegisterButton.Enabled = false;
            KeyButton.Enabled = false;
            EncryptDecryptButton.Enabled = true;
            InsertKeyButton.Enabled = false;
            KeySaveButton.Enabled = true;
        }

        private void InsertKeyButton_Click(object sender, EventArgs e)
        {
            KeyContext.TakeBytesFromPath(TempPathTextBox.Text);

            if (KeyContext.bufferKeyDigit == null)
                return;

            KeyContext.ConvertBytesToBinary();

            if (KeyContext.bufferKeyBinary != null)
                KeyTB.Text = String.Join(Environment.NewLine, KeyContext.bufferKeyBinary);

            InsertKeyButton.Enabled = false;
            InitialRegisterButton.Enabled = false;
            KeyButton.Enabled = false;
            EncryptDecryptButton.Enabled = true;
            KeySaveButton.Enabled = true;
        }

        private void KeySaveButton_Click(object sender, EventArgs e)
        {
            KeyContext.Save(TempPathTextBox.Text);
            TempPathTextBox.Text = String.Empty;
        }
    }
}