namespace Streaming_Encryption
{
    partial class Streaming_Encryption
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LabName = new System.Windows.Forms.Label();
            this.PathLabel = new System.Windows.Forms.Label();
            this.GetFileButton = new System.Windows.Forms.Button();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.InitialLabel = new System.Windows.Forms.Label();
            this.InitialRegisterTextBox = new System.Windows.Forms.TextBox();
            this.InitialRegisterButton = new System.Windows.Forms.Button();
            this.XorTable = new System.Windows.Forms.DataGridView();
            this.KeyStateLabel = new System.Windows.Forms.Label();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.KeyButton = new System.Windows.Forms.Button();
            this.FromTextBox = new System.Windows.Forms.TextBox();
            this.KeySaveButton = new System.Windows.Forms.Button();
            this.KeyTB = new System.Windows.Forms.TextBox();
            this.EncryptDecryptTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.EncryptDecryptButton = new System.Windows.Forms.Button();
            this.SaveEncryptDecryptFileButton = new System.Windows.Forms.Button();
            this.XorLabel = new System.Windows.Forms.Label();
            this.SourceLabel = new System.Windows.Forms.Label();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.InsertKeyButton = new System.Windows.Forms.Button();
            this.TempPathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.XorTable)).BeginInit();
            this.SuspendLayout();
            // 
            // LabName
            // 
            this.LabName.AutoSize = true;
            this.LabName.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabName.Location = new System.Drawing.Point(421, 20);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(252, 26);
            this.LabName.TabIndex = 0;
            this.LabName.Text = "Streaming Encryption";
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Font = new System.Drawing.Font("Swis721 BlkCn BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PathLabel.Location = new System.Drawing.Point(12, 76);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(278, 36);
            this.PathLabel.TabIndex = 1;
            this.PathLabel.Text = "Write down file path:";
            // 
            // GetFileButton
            // 
            this.GetFileButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GetFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GetFileButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GetFileButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GetFileButton.Location = new System.Drawing.Point(782, 76);
            this.GetFileButton.Name = "GetFileButton";
            this.GetFileButton.Size = new System.Drawing.Size(132, 36);
            this.GetFileButton.TabIndex = 2;
            this.GetFileButton.Text = "Apply";
            this.GetFileButton.UseVisualStyleBackColor = false;
            this.GetFileButton.Click += new System.EventHandler(this.GetFileButton_Click);
            // 
            // PathTextBox
            // 
            this.PathTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PathTextBox.Location = new System.Drawing.Point(313, 76);
            this.PathTextBox.Multiline = true;
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(431, 36);
            this.PathTextBox.TabIndex = 3;
            // 
            // InitialLabel
            // 
            this.InitialLabel.AutoSize = true;
            this.InitialLabel.Font = new System.Drawing.Font("Swis721 BlkCn BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InitialLabel.Location = new System.Drawing.Point(12, 144);
            this.InitialLabel.Name = "InitialLabel";
            this.InitialLabel.Size = new System.Drawing.Size(275, 36);
            this.InitialLabel.TabIndex = 4;
            this.InitialLabel.Text = "Initial register state:";
            // 
            // InitialRegisterTextBox
            // 
            this.InitialRegisterTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InitialRegisterTextBox.Location = new System.Drawing.Point(313, 144);
            this.InitialRegisterTextBox.Multiline = true;
            this.InitialRegisterTextBox.Name = "InitialRegisterTextBox";
            this.InitialRegisterTextBox.Size = new System.Drawing.Size(431, 36);
            this.InitialRegisterTextBox.TabIndex = 5;
            // 
            // InitialRegisterButton
            // 
            this.InitialRegisterButton.BackColor = System.Drawing.Color.RosyBrown;
            this.InitialRegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InitialRegisterButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InitialRegisterButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InitialRegisterButton.Location = new System.Drawing.Point(782, 144);
            this.InitialRegisterButton.Name = "InitialRegisterButton";
            this.InitialRegisterButton.Size = new System.Drawing.Size(132, 36);
            this.InitialRegisterButton.TabIndex = 6;
            this.InitialRegisterButton.Text = "Apply";
            this.InitialRegisterButton.UseVisualStyleBackColor = false;
            this.InitialRegisterButton.Click += new System.EventHandler(this.InitialRegisterButton_Click);
            // 
            // XorTable
            // 
            this.XorTable.AllowUserToAddRows = false;
            this.XorTable.AllowUserToDeleteRows = false;
            this.XorTable.AllowUserToResizeColumns = false;
            this.XorTable.AllowUserToResizeRows = false;
            this.XorTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.XorTable.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.XorTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.XorTable.EnableHeadersVisualStyles = false;
            this.XorTable.Location = new System.Drawing.Point(976, 76);
            this.XorTable.MultiSelect = false;
            this.XorTable.Name = "XorTable";
            this.XorTable.ReadOnly = true;
            this.XorTable.RowHeadersVisible = false;
            this.XorTable.RowHeadersWidth = 20;
            this.XorTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.XorTable.RowTemplate.Height = 29;
            this.XorTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.XorTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.XorTable.Size = new System.Drawing.Size(760, 820);
            this.XorTable.TabIndex = 7;
            // 
            // KeyStateLabel
            // 
            this.KeyStateLabel.AutoSize = true;
            this.KeyStateLabel.Font = new System.Drawing.Font("Swis721 BlkCn BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyStateLabel.Location = new System.Drawing.Point(12, 210);
            this.KeyStateLabel.Name = "KeyStateLabel";
            this.KeyStateLabel.Size = new System.Drawing.Size(292, 36);
            this.KeyStateLabel.TabIndex = 8;
            this.KeyStateLabel.Text = "Write down key value:";
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyTextBox.Location = new System.Drawing.Point(313, 210);
            this.KeyTextBox.Multiline = true;
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(431, 36);
            this.KeyTextBox.TabIndex = 9;
            // 
            // KeyButton
            // 
            this.KeyButton.BackColor = System.Drawing.Color.YellowGreen;
            this.KeyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KeyButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KeyButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KeyButton.Location = new System.Drawing.Point(782, 210);
            this.KeyButton.Name = "KeyButton";
            this.KeyButton.Size = new System.Drawing.Size(132, 36);
            this.KeyButton.TabIndex = 10;
            this.KeyButton.Text = "Apply";
            this.KeyButton.UseVisualStyleBackColor = false;
            this.KeyButton.Click += new System.EventHandler(this.KeyButton_Click);
            // 
            // FromTextBox
            // 
            this.FromTextBox.Location = new System.Drawing.Point(12, 316);
            this.FromTextBox.Multiline = true;
            this.FromTextBox.Name = "FromTextBox";
            this.FromTextBox.ReadOnly = true;
            this.FromTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FromTextBox.Size = new System.Drawing.Size(213, 580);
            this.FromTextBox.TabIndex = 11;
            // 
            // KeySaveButton
            // 
            this.KeySaveButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.KeySaveButton.Enabled = false;
            this.KeySaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KeySaveButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KeySaveButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KeySaveButton.Location = new System.Drawing.Point(295, 913);
            this.KeySaveButton.Name = "KeySaveButton";
            this.KeySaveButton.Size = new System.Drawing.Size(213, 36);
            this.KeySaveButton.TabIndex = 12;
            this.KeySaveButton.Text = "Save into a new file";
            this.KeySaveButton.UseVisualStyleBackColor = false;
            this.KeySaveButton.Click += new System.EventHandler(this.KeySaveButton_Click);
            // 
            // KeyTB
            // 
            this.KeyTB.Location = new System.Drawing.Point(295, 316);
            this.KeyTB.Multiline = true;
            this.KeyTB.Name = "KeyTB";
            this.KeyTB.ReadOnly = true;
            this.KeyTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.KeyTB.Size = new System.Drawing.Size(213, 580);
            this.KeyTB.TabIndex = 13;
            // 
            // EncryptDecryptTextBox
            // 
            this.EncryptDecryptTextBox.Location = new System.Drawing.Point(586, 316);
            this.EncryptDecryptTextBox.Multiline = true;
            this.EncryptDecryptTextBox.Name = "EncryptDecryptTextBox";
            this.EncryptDecryptTextBox.ReadOnly = true;
            this.EncryptDecryptTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EncryptDecryptTextBox.Size = new System.Drawing.Size(213, 580);
            this.EncryptDecryptTextBox.TabIndex = 14;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClearButton.Location = new System.Drawing.Point(825, 316);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(132, 36);
            this.ClearButton.TabIndex = 15;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // EncryptDecryptButton
            // 
            this.EncryptDecryptButton.BackColor = System.Drawing.Color.Aquamarine;
            this.EncryptDecryptButton.Enabled = false;
            this.EncryptDecryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EncryptDecryptButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EncryptDecryptButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EncryptDecryptButton.Location = new System.Drawing.Point(825, 391);
            this.EncryptDecryptButton.Name = "EncryptDecryptButton";
            this.EncryptDecryptButton.Size = new System.Drawing.Size(132, 36);
            this.EncryptDecryptButton.TabIndex = 16;
            this.EncryptDecryptButton.Text = "EnDecrypt";
            this.EncryptDecryptButton.UseVisualStyleBackColor = false;
            this.EncryptDecryptButton.Click += new System.EventHandler(this.EncryptDecryptButton_Click);
            // 
            // SaveEncryptDecryptFileButton
            // 
            this.SaveEncryptDecryptFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SaveEncryptDecryptFileButton.Enabled = false;
            this.SaveEncryptDecryptFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveEncryptDecryptFileButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveEncryptDecryptFileButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SaveEncryptDecryptFileButton.Location = new System.Drawing.Point(586, 913);
            this.SaveEncryptDecryptFileButton.Name = "SaveEncryptDecryptFileButton";
            this.SaveEncryptDecryptFileButton.Size = new System.Drawing.Size(213, 36);
            this.SaveEncryptDecryptFileButton.TabIndex = 17;
            this.SaveEncryptDecryptFileButton.Text = "Save into a new file";
            this.SaveEncryptDecryptFileButton.UseVisualStyleBackColor = false;
            this.SaveEncryptDecryptFileButton.Click += new System.EventHandler(this.SaveEncryptDecryptFileButton_Click);
            // 
            // XorLabel
            // 
            this.XorLabel.AutoSize = true;
            this.XorLabel.Font = new System.Drawing.Font("Vineta BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.XorLabel.Location = new System.Drawing.Point(1044, 20);
            this.XorLabel.Name = "XorLabel";
            this.XorLabel.Size = new System.Drawing.Size(631, 41);
            this.XorLabel.TabIndex = 18;
            this.XorLabel.Text = "Xor Key Generation Table";
            // 
            // SourceLabel
            // 
            this.SourceLabel.AutoSize = true;
            this.SourceLabel.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SourceLabel.Location = new System.Drawing.Point(55, 279);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(124, 34);
            this.SourceLabel.TabIndex = 19;
            this.SourceLabel.Text = "Source";
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyLabel.Location = new System.Drawing.Point(357, 279);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(73, 34);
            this.KeyLabel.TabIndex = 20;
            this.KeyLabel.Text = "Key";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultLabel.Location = new System.Drawing.Point(634, 279);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(121, 34);
            this.ResultLabel.TabIndex = 21;
            this.ResultLabel.Text = "Result";
            // 
            // InsertKeyButton
            // 
            this.InsertKeyButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.InsertKeyButton.Enabled = false;
            this.InsertKeyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InsertKeyButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InsertKeyButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InsertKeyButton.Location = new System.Drawing.Point(825, 469);
            this.InsertKeyButton.Name = "InsertKeyButton";
            this.InsertKeyButton.Size = new System.Drawing.Size(132, 36);
            this.InsertKeyButton.TabIndex = 22;
            this.InsertKeyButton.Text = "Insert key";
            this.InsertKeyButton.UseVisualStyleBackColor = false;
            this.InsertKeyButton.Click += new System.EventHandler(this.InsertKeyButton_Click);
            // 
            // TempPathTextBox
            // 
            this.TempPathTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TempPathTextBox.Location = new System.Drawing.Point(1305, 913);
            this.TempPathTextBox.Multiline = true;
            this.TempPathTextBox.Name = "TempPathTextBox";
            this.TempPathTextBox.Size = new System.Drawing.Size(431, 36);
            this.TempPathTextBox.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 BlkCn BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(913, 913);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 36);
            this.label1.TabIndex = 24;
            this.label1.Text = "Path for saving or inserting:";
            // 
            // Streaming_Encryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 1055);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TempPathTextBox);
            this.Controls.Add(this.InsertKeyButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.SourceLabel);
            this.Controls.Add(this.XorLabel);
            this.Controls.Add(this.SaveEncryptDecryptFileButton);
            this.Controls.Add(this.EncryptDecryptButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.EncryptDecryptTextBox);
            this.Controls.Add(this.KeyTB);
            this.Controls.Add(this.KeySaveButton);
            this.Controls.Add(this.FromTextBox);
            this.Controls.Add(this.KeyButton);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.KeyStateLabel);
            this.Controls.Add(this.XorTable);
            this.Controls.Add(this.InitialRegisterButton);
            this.Controls.Add(this.InitialRegisterTextBox);
            this.Controls.Add(this.InitialLabel);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.GetFileButton);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.LabName);
            this.Name = "Streaming_Encryption";
            this.Text = "Streaming Encryption";
            this.Load += new System.EventHandler(this.Streaming_Encryption_Load);
            ((System.ComponentModel.ISupportInitialize)(this.XorTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabName;
        private Label PathLabel;
        private Button GetFileButton;
        private TextBox PathTextBox;
        private Label InitialLabel;
        private TextBox InitialRegisterTextBox;
        private Button InitialRegisterButton;
        private DataGridView XorTable;
        private Label KeyStateLabel;
        private TextBox KeyTextBox;
        private Button KeyButton;
        private TextBox FromTextBox;
        private Button KeySaveButton;
        private TextBox KeyTB;
        private TextBox EncryptDecryptTextBox;
        private Button ClearButton;
        private Button EncryptDecryptButton;
        private Button SaveEncryptDecryptFileButton;
        private Label XorLabel;
        private Label SourceLabel;
        private Label KeyLabel;
        private Label ResultLabel;
        private Button InsertKeyButton;
        private TextBox TempPathTextBox;
        private Label label1;
    }
}