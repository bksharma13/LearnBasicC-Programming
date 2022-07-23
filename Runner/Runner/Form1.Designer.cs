
namespace Runner
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {            
            System.Windows.Forms.Label LblOutputText;
            System.Windows.Forms.Label LblInput;
            System.Windows.Forms.Label LblOption;
            System.Windows.Forms.Label LblPath;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.LblBrowsePathText = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RdoSequenceAnalysis = new System.Windows.Forms.RadioButton();
            this.RdoSumSolution = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnSolve = new System.Windows.Forms.Button();
            this.TxtBxInput = new System.Windows.Forms.TextBox();
            LblOutput = new System.Windows.Forms.Label();
            LblOutputText = new System.Windows.Forms.Label();
            LblInput = new System.Windows.Forms.Label();
            LblOption = new System.Windows.Forms.Label();
            LblPath = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83F));
            this.tableLayoutPanel1.Controls.Add(LblOutput, 1, 3);
            this.tableLayoutPanel1.Controls.Add(LblOutputText, 0, 3);
            this.tableLayoutPanel1.Controls.Add(LblInput, 0, 2);
            this.tableLayoutPanel1.Controls.Add(LblOption, 0, 1);
            this.tableLayoutPanel1.Controls.Add(LblPath, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(732, 175);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LblOutput
            // 
            LblOutput.AutoSize = true;
            LblOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            LblOutput.Location = new System.Drawing.Point(134, 139);
            LblOutput.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            LblOutput.Name = "LblOutput";
            LblOutput.Size = new System.Drawing.Size(595, 36);
            LblOutput.TabIndex = 8;
            LblOutput.Text = "Press Solve";
            // 
            // LblOutputText
            // 
            LblOutputText.AutoSize = true;
            LblOutputText.Dock = System.Windows.Forms.DockStyle.Fill;
            LblOutputText.Location = new System.Drawing.Point(10, 139);
            LblOutputText.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            LblOutputText.Name = "LblOutputText";
            LblOutputText.Size = new System.Drawing.Size(111, 36);
            LblOutputText.TabIndex = 3;
            LblOutputText.Text = "Output";
            // 
            // LblInput
            // 
            LblInput.AutoSize = true;
            LblInput.Dock = System.Windows.Forms.DockStyle.Fill;
            LblInput.Location = new System.Drawing.Point(10, 96);
            LblInput.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            LblInput.Name = "LblInput";
            LblInput.Size = new System.Drawing.Size(111, 33);
            LblInput.TabIndex = 2;
            LblInput.Text = "Enter Input";
            // 
            // LblOption
            // 
            LblOption.AutoSize = true;
            LblOption.Dock = System.Windows.Forms.DockStyle.Fill;
            LblOption.Location = new System.Drawing.Point(10, 53);
            LblOption.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            LblOption.Name = "LblOption";
            LblOption.Size = new System.Drawing.Size(111, 33);
            LblOption.TabIndex = 1;
            LblOption.Text = "Select Solution";
            // 
            // LblPath
            // 
            LblPath.AutoSize = true;
            LblPath.Dock = System.Windows.Forms.DockStyle.Fill;
            LblPath.Location = new System.Drawing.Point(10, 10);
            LblPath.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            LblPath.Name = "LblPath";
            LblPath.Size = new System.Drawing.Size(111, 33);
            LblPath.TabIndex = 0;
            LblPath.Text = "Browse The DLLs";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnBrowse);
            this.groupBox1.Controls.Add(this.LblBrowsePathText);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(127, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 37);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Location = new System.Drawing.Point(6, 9);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(75, 23);
            this.BtnBrowse.TabIndex = 4;
            this.BtnBrowse.Text = "Browse";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // LblBrowsePathText
            // 
            this.LblBrowsePathText.AutoSize = true;
            this.LblBrowsePathText.Location = new System.Drawing.Point(87, 14);
            this.LblBrowsePathText.Name = "LblBrowsePathText";
            this.LblBrowsePathText.Size = new System.Drawing.Size(29, 13);
            this.LblBrowsePathText.TabIndex = 6;
            this.LblBrowsePathText.Text = "Path";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RdoSequenceAnalysis);
            this.groupBox2.Controls.Add(this.RdoSumSolution);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(127, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 37);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // RdoSequenceAnalysis
            // 
            this.RdoSequenceAnalysis.AutoSize = true;
            this.RdoSequenceAnalysis.Location = new System.Drawing.Point(133, 14);
            this.RdoSequenceAnalysis.Name = "RdoSequenceAnalysis";
            this.RdoSequenceAnalysis.Size = new System.Drawing.Size(115, 17);
            this.RdoSequenceAnalysis.TabIndex = 1;
            this.RdoSequenceAnalysis.Text = "Sequence Analysis";
            this.RdoSequenceAnalysis.UseVisualStyleBackColor = true;
            // 
            // RdoSumSolution
            // 
            this.RdoSumSolution.AutoSize = true;
            this.RdoSumSolution.Checked = true;
            this.RdoSumSolution.Location = new System.Drawing.Point(6, 14);
            this.RdoSumSolution.Name = "RdoSumSolution";
            this.RdoSumSolution.Size = new System.Drawing.Size(99, 17);
            this.RdoSumSolution.TabIndex = 0;
            this.RdoSumSolution.TabStop = true;
            this.RdoSumSolution.Text = "Sum Of Multiple";
            this.RdoSumSolution.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnSolve);
            this.groupBox3.Controls.Add(this.TxtBxInput);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(127, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(602, 37);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // BtnSolve
            // 
            this.BtnSolve.Location = new System.Drawing.Point(265, 7);
            this.BtnSolve.Name = "BtnSolve";
            this.BtnSolve.Size = new System.Drawing.Size(75, 23);
            this.BtnSolve.TabIndex = 7;
            this.BtnSolve.Text = "Solve";
            this.BtnSolve.UseVisualStyleBackColor = true;
            this.BtnSolve.Click += new System.EventHandler(this.BtnSolve_Click);
            // 
            // TxtBxInput
            // 
            this.TxtBxInput.Location = new System.Drawing.Point(6, 7);
            this.TxtBxInput.Margin = new System.Windows.Forms.Padding(8, 8, 3, 3);
            this.TxtBxInput.Name = "TxtBxInput";
            this.TxtBxInput.Size = new System.Drawing.Size(243, 20);
            this.TxtBxInput.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 175);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Runner";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblBrowsePathText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RdoSequenceAnalysis;
        private System.Windows.Forms.RadioButton RdoSumSolution;
        private System.Windows.Forms.TextBox TxtBxInput;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnSolve;
        System.Windows.Forms.Label LblOutput;
    }
}

