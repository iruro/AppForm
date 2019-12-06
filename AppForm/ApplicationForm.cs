using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Security;
using System.Text;
using System.Windows.Forms;

namespace AppForm
{
    public partial class ApplicationForm : Form
    {
        public ApplicationForm()
        {
            InitializeComponent();
        }

        private void ApplicationForm_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            btnGenerate.Visible = false;
            btnFinish.Visible = false;
            labelTitle.Text = "Term and Condition";
            checkBoxSFFS.Visible = false;
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (cbAgree.Checked)
            {
                panel1.Visible = true;
                btnGenerate.Visible = true;
                textBoxTermsandConditions.Visible = false;
                btnNext.Visible = false;
                cbAgree.Visible = false;
                btnFinish.Visible = false;
                panelTitle.Visible = false;
            }
            else
            {
                MessageBox.Show("Please Check the Terms and Conditions Aggreement");
            }

        }

        int menitLast;

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            btnGenerate.Visible = false;
            textBoxTermsandConditions.Visible = false;
            //textBoxTermsandConditions.Text = "";
            btnNext.Visible = false;
            cbAgree.Visible = false;
            btnFinish.Visible = true;
            panelTitle.Visible = true;
            labelTitle.Text = "Application is completed";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            checkBoxSFFS.Visible = true;

            string headerTeks = "Customer Number,Full Name,Facebook ID,Phone Number,Email Address,Address,Processor ID," + Environment.NewLine;
            string logText = labelPONumber.Text + "," + textBoxFullName.Text + "," + textBoxFBId.Text + "," +
                textBoxPhoneNumber.Text + "," + textBoxEmailAddr.Text + "," + textBoxAddress.Text + "," + GetProcessorID() + "," + Environment.NewLine;
            string namaFile = textBoxFullName.Text;
                        
            int menitCurrent;
            menitCurrent = DateTime.Now.Minute;
            if (menitCurrent != menitLast)
            {
                writeCSV(namaFile, headerTeks);
            }
            writeCSV(namaFile, logText);
            menitLast = menitCurrent;

            string path = namaFile + ".csv";
            string cureFIle = @path;
            string fileName = Path.GetFullPath(cureFIle);

            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = @"\";
                saveFileDialog.Title = "Save Files Users";
                saveFileDialog.CheckFileExists = false;
                saveFileDialog.CheckPathExists = false;
                saveFileDialog.DefaultExt = "csv";
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                // Get FileName
                //string fileNameDest = Path.GetFileNameWithoutExtension(file);
                saveFileDialog.FileName = namaFile;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //textBox1.Text = saveFileDialog.FileName;

                    // string[] pathArr = file.Split('\\');
                    // string[] fileArr = pathArr.Last().Split('.');
                    //string fileName = fileArr.Last().ToString();
                    //Console.WriteLine(file);
                    // Encrypt the file.
                    // CryptoStuff.EncryptFile(comboBoxProcessorID.Text, file, file_path() + "\\" + fileArr[0] + ".dat");
                    //CryptoStuff.EncryptFile(comboBoxProcessorID.Text, file, saveFileDialog.FileName);
                    CryptoStuff.EncryptFile(labelPONumber.Text, cureFIle, saveFileDialog.FileName);
                    File.Delete(cureFIle);
                    Console.WriteLine("DONE!");
                }
            }
            catch (SecurityException ex)
            {
                // The user lacks appropriate permissions to read files, discover paths, etc.
                MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                    "Error message: " + ex.Message + "\n\n" +
                    "Details (send to Support):\n\n" + ex.StackTrace
                );
            }
            //// Encrypt the file.
            //CryptoStuff.EncryptFile(labelPONumber.Text, cureFIle, namaFile + "_enc" + ".csv");
            //File.Delete(cureFIle);

            // Decrypt the file.
            //CryptoStuff.DecryptFile(labelPONumber.Text, namaFile + "_enc" + ".csv", namaFile + "_dec" + ".csv");

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            string namaFile = textBoxFullName.Text;
            string path = namaFile + "_enc" + ".csv";
            string cureFIle = @path;
            //if (radioButtonOFL.Checked)
            //{
            //    if (File.Exists(cureFIle))
            //    {
            //        Process.Start("explorer.exe", "/select, " + cureFIle);
            //    }
            //    Application.Exit();
            //}
            if (checkBoxSFFS.Checked)
            {
                label2.Visible = true;
                labelPONumber.Visible = true;
                textBoxTermsandConditions.Visible = true;
                cbAgree.Visible = true;
                btnNext.Visible = true;

                panel1.Visible = false;
                btnGenerate.Visible = false;
                btnFinish.Visible = false;
                labelTitle.Text = "Term and Condition";
                checkBoxSFFS.Visible = false;
            }
            else
            {
                Application.Exit();
            }

        }

        private void writeCSV(string name, string teks)
        {
            string path = name + ".csv";
            string cureFIle = @path;
            if (!File.Exists(cureFIle))//if file doesn't exist
            {
                File.Create(cureFIle).Close();
            }

            try
            {
                File.AppendAllText(cureFIle, teks);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + Environment.NewLine + "Can't access" + cureFIle + Environment.NewLine
                               + "This file maybe used by another application.", "Write File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetProcessorID()
        {
            var mbs = new ManagementObjectSearcher("Select ProcessorId From Win32_processor");
            ManagementObjectCollection mbsList = mbs.Get();
            string id = "";
            foreach (ManagementObject mo in mbsList)
            {
                id = mo["ProcessorId"].ToString();
                break;
            }
            return id;
        }
    }
}