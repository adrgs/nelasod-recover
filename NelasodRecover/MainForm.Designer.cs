namespace NelasodDecryptor
{
    partial class MainForm
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.dirLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.pairsPage = new System.Windows.Forms.TabPage();
            this.pairsDGV = new System.Windows.Forms.DataGridView();
            this.logsPage = new System.Windows.Forms.TabPage();
            this.logBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dirButton = new System.Windows.Forms.Button();
            this.recursiveCB = new System.Windows.Forms.CheckBox();
            this.decryptButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.encPathTB = new System.Windows.Forms.TextBox();
            this.decPathTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.browseEncButton = new System.Windows.Forms.Button();
            this.browseDecButton = new System.Windows.Forms.Button();
            this.encOFD = new System.Windows.Forms.OpenFileDialog();
            this.decOFD = new System.Windows.Forms.OpenFileDialog();
            this.dirFBD = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.statusStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.pairsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pairsDGV)).BeginInit();
            this.logsPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dirLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 419);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(624, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip";
            // 
            // dirLabel
            // 
            this.dirLabel.Name = "dirLabel";
            this.dirLabel.Size = new System.Drawing.Size(119, 17);
            this.dirLabel.Text = "No directory selected";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(624, 419);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.pairsPage);
            this.tabControl.Controls.Add(this.logsPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(3, 153);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(418, 263);
            this.tabControl.TabIndex = 0;
            // 
            // pairsPage
            // 
            this.pairsPage.Controls.Add(this.pairsDGV);
            this.pairsPage.Location = new System.Drawing.Point(4, 22);
            this.pairsPage.Name = "pairsPage";
            this.pairsPage.Padding = new System.Windows.Forms.Padding(3);
            this.pairsPage.Size = new System.Drawing.Size(410, 237);
            this.pairsPage.TabIndex = 0;
            this.pairsPage.Text = "Pairs";
            this.pairsPage.UseVisualStyleBackColor = true;
            // 
            // pairsDGV
            // 
            this.pairsDGV.AllowUserToAddRows = false;
            this.pairsDGV.AllowUserToDeleteRows = false;
            this.pairsDGV.AllowUserToResizeRows = false;
            this.pairsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pairsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.pairsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pairsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pairsDGV.Location = new System.Drawing.Point(3, 3);
            this.pairsDGV.Name = "pairsDGV";
            this.pairsDGV.ReadOnly = true;
            this.pairsDGV.RowHeadersVisible = false;
            this.pairsDGV.Size = new System.Drawing.Size(404, 231);
            this.pairsDGV.TabIndex = 0;
            // 
            // logsPage
            // 
            this.logsPage.Controls.Add(this.logBox);
            this.logsPage.Location = new System.Drawing.Point(4, 22);
            this.logsPage.Name = "logsPage";
            this.logsPage.Padding = new System.Windows.Forms.Padding(3);
            this.logsPage.Size = new System.Drawing.Size(410, 237);
            this.logsPage.TabIndex = 1;
            this.logsPage.Text = "Logs";
            this.logsPage.UseVisualStyleBackColor = true;
            // 
            // logBox
            // 
            this.logBox.BackColor = System.Drawing.Color.White;
            this.logBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logBox.Location = new System.Drawing.Point(3, 3);
            this.logBox.MaxLength = 13371337;
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logBox.Size = new System.Drawing.Size(404, 231);
            this.logBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dirButton);
            this.panel1.Controls.Add(this.recursiveCB);
            this.panel1.Controls.Add(this.decryptButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(427, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 263);
            this.panel1.TabIndex = 1;
            // 
            // dirButton
            // 
            this.dirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dirButton.Location = new System.Drawing.Point(14, 22);
            this.dirButton.Name = "dirButton";
            this.dirButton.Size = new System.Drawing.Size(167, 66);
            this.dirButton.TabIndex = 2;
            this.dirButton.Text = "Select directory to decrypt";
            this.dirButton.UseVisualStyleBackColor = true;
            this.dirButton.Click += new System.EventHandler(this.dirButton_Click);
            // 
            // recursiveCB
            // 
            this.recursiveCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.recursiveCB.AutoSize = true;
            this.recursiveCB.Location = new System.Drawing.Point(14, 153);
            this.recursiveCB.Name = "recursiveCB";
            this.recursiveCB.Size = new System.Drawing.Size(162, 17);
            this.recursiveCB.TabIndex = 1;
            this.recursiveCB.Text = "Decrypt inside subfolders too";
            this.recursiveCB.UseVisualStyleBackColor = true;
            // 
            // decryptButton
            // 
            this.decryptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.decryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decryptButton.Location = new System.Drawing.Point(14, 193);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(167, 66);
            this.decryptButton.TabIndex = 0;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.encPathTB);
            this.panel2.Controls.Add(this.decPathTB);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 144);
            this.panel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Decrypted file";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Encrypted file";
            // 
            // encPathTB
            // 
            this.encPathTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.encPathTB.BackColor = System.Drawing.Color.White;
            this.encPathTB.Location = new System.Drawing.Point(86, 77);
            this.encPathTB.Name = "encPathTB";
            this.encPathTB.ReadOnly = true;
            this.encPathTB.Size = new System.Drawing.Size(325, 20);
            this.encPathTB.TabIndex = 1;
            // 
            // decPathTB
            // 
            this.decPathTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.decPathTB.BackColor = System.Drawing.Color.White;
            this.decPathTB.Location = new System.Drawing.Point(86, 115);
            this.decPathTB.Name = "decPathTB";
            this.decPathTB.ReadOnly = true;
            this.decPathTB.Size = new System.Drawing.Size(325, 20);
            this.decPathTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "NelasodRecover";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please insert as many encrypted/decrypted file pairs as you have";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.browseEncButton);
            this.panel3.Controls.Add(this.browseDecButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(427, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 144);
            this.panel3.TabIndex = 3;
            // 
            // browseEncButton
            // 
            this.browseEncButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseEncButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseEncButton.Location = new System.Drawing.Point(14, 76);
            this.browseEncButton.Name = "browseEncButton";
            this.browseEncButton.Size = new System.Drawing.Size(100, 23);
            this.browseEncButton.TabIndex = 2;
            this.browseEncButton.Text = "...";
            this.browseEncButton.UseVisualStyleBackColor = true;
            this.browseEncButton.Click += new System.EventHandler(this.browseEncButton_Click);
            // 
            // browseDecButton
            // 
            this.browseDecButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseDecButton.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseDecButton.Location = new System.Drawing.Point(14, 114);
            this.browseDecButton.Name = "browseDecButton";
            this.browseDecButton.Size = new System.Drawing.Size(100, 23);
            this.browseDecButton.TabIndex = 2;
            this.browseDecButton.Text = "...";
            this.browseDecButton.UseVisualStyleBackColor = true;
            this.browseDecButton.Click += new System.EventHandler(this.browseDecButton_Click);
            // 
            // encOFD
            // 
            this.encOFD.Filter = ".nelasod file|*.nelasod";
            this.encOFD.Title = "Select encrypted file";
            // 
            // decOFD
            // 
            this.decOFD.Filter = "All files|*.*";
            this.decOFD.Title = "Select decrypted file";
            // 
            // dirFBD
            // 
            this.dirFBD.ShowNewFolderButton = false;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip);
            this.Name = "MainForm";
            this.Text = "NelasodRecover";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.pairsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pairsDGV)).EndInit();
            this.logsPage.ResumeLayout(false);
            this.logsPage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage pairsPage;
        private System.Windows.Forms.TabPage logsPage;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button dirButton;
        private System.Windows.Forms.CheckBox recursiveCB;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browseEncButton;
        private System.Windows.Forms.TextBox encPathTB;
        private System.Windows.Forms.Button browseDecButton;
        private System.Windows.Forms.TextBox decPathTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView pairsDGV;
        private System.Windows.Forms.OpenFileDialog encOFD;
        private System.Windows.Forms.OpenFileDialog decOFD;
        private System.Windows.Forms.FolderBrowserDialog dirFBD;
        private System.Windows.Forms.ToolStripStatusLabel dirLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

