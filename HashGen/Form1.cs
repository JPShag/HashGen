using System;
using System.Windows.Forms;

namespace MD5HashGenerator
{
    public partial class Form1 : Form
    {
        private TextBox txtInput;
        private Button btnGenerate, btnCopy, btnClearInput, btnClearOutput, btnSaveToFile, btnLoadFromFile;
        private TextBox txtMD5Hash;

        public Form1()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            // Add UI components setup here (as previously detailed)
            // Add new buttons for Save and Load functionalities
            btnSaveToFile = new Button
            {
                Text = "Save Hash",
                Location = new System.Drawing.Point(280, 100),
                Size = new System.Drawing.Size(100, 23)
            };
            btnSaveToFile.Click += BtnSaveToFile_Click;
            this.Controls.Add(btnSaveToFile);

            btnLoadFromFile = new Button
            {
                Text = "Load Text",
                Location = new System.Drawing.Point(280, 140),
                Size = new System.Drawing.Size(100, 23)
            };
            btnLoadFromFile.Click += BtnLoadFromFile_Click;
            this.Controls.Add(btnLoadFromFile);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtMD5Hash.Text = MD5Generator.GenerateMD5(txtInput.Text);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMD5Hash.Text))
            {
                Clipboard.SetText(txtMD5Hash.Text);
                MessageBox.Show("MD5 Hash copied to clipboard!");
            }
        }

        private void btnClearInput_Click(object sender, EventArgs e)
        {
            txtInput.Text = string.Empty;
        }

        private void btnClearOutput_Click(object sender, EventArgs e)
        {
            txtMD5Hash.Text = string.Empty;
        }

        private void BtnSaveToFile_Click(object sender, EventArgs e)
        {
            FileManager.SaveToFile(txtMD5Hash.Text);
        }

        private void BtnLoadFromFile_Click(object sender, EventArgs e)
        {
            txtInput.Text = FileManager.LoadFromFile();
        }
    }
}
