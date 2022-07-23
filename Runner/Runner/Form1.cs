using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Runner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    InitialDirectory = Environment.CurrentDirectory,
                    Title = "Browse DLL to Solve",
                    CheckFileExists = true,
                    CheckPathExists = true,
                    DefaultExt = "dll",
                    Filter = "dll files (*.dll)|*.dll",
                    FilterIndex = 2,
                    RestoreDirectory = true,
                    ReadOnlyChecked = true,
                    ShowReadOnly = true
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileExtension = Path.GetExtension(openFileDialog.FileName);
                    if (fileExtension.Equals(".dll", StringComparison.InvariantCultureIgnoreCase))
                    {
                        LblBrowsePathText.Text = openFileDialog.FileName;                        
                    }
                    else
                    {
                        DisplayMessage("Invalid file selected, please try again");
                    }
                }
            }
            catch (Exception ex)
            {                
                DisplayMessage("Error: " + ex.Message);
            }
        }

        private void BtnSolve_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TxtBxInput.Text))
                {
                    var DLL = Assembly.LoadFile(LblBrowsePathText.Text);
                    if (RdoSequenceAnalysis.Checked)
                    {
                        foreach (Type type in DLL.GetExportedTypes())
                        {
                            // Load DLL using generic
                            object instanceObj = Activator.CreateInstance(type);                            
                            LblOutput.Text = type.InvokeMember("FindUpperCaseChar", BindingFlags.InvokeMethod, null, instanceObj, new object[] { TxtBxInput.Text }) + string.Empty;
                            //LblOutput.Text = c.FindUpperCaseChar(TxtBxInput.Text);
                        }
                    }
                    else
                    {
                        int.TryParse(TxtBxInput.Text, out int inputNumber);
                        foreach (Type type in DLL.GetExportedTypes())
                        {
                            // Load DLL using dynamic
                            dynamic instanceObj = Activator.CreateInstance(type);
                            LblOutput.Text = instanceObj.GetSum(inputNumber).ToString();
                        }
                    }
                }
                else
                {
                    DisplayMessage("Enter Input to Continue");
                }

            }
            catch(Exception ex)
            {
                DisplayMessage("Error: " + ex.Message);
            }
        }

        private void DisplayMessage(string message, MessageBoxIcon messageBoxIcon = MessageBoxIcon.Error)
        {
            if (messageBoxIcon == MessageBoxIcon.Information)
            {
                MessageBox.Show(message, "Information", MessageBoxButtons.OK, messageBoxIcon);
            }
            else
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, messageBoxIcon);
            }
        }
    }
}
