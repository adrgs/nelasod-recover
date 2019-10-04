using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NelasodDecryptor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private NelasodDecryptor NelasodDecryptor;
        private DataTable pairsDT;

        private void MainForm_Load(object sender, EventArgs e)
        {
            NelasodDecryptor = new NelasodDecryptor();
            initDataTable();
            updateDGV();
            clearLog();
        }

        private void initDataTable()
        {
            pairsDT = new DataTable();
            pairsDT.Columns.Add("Encrypted file");
            pairsDT.Columns.Add("Decrypted file");
            pairsDT.Columns.Add("Header");
            pairsDT.Columns.Add("Size of keystream");
            pairsDT.Columns.Add("ID");
            pairsDT.Columns.Add("GUID");
        }

        private void browseEncButton_Click(object sender, EventArgs e)
        {
            DialogResult result = encOFD.ShowDialog();
            if (result == DialogResult.OK && !String.IsNullOrWhiteSpace(encOFD.FileName))
            {
                encPathTB.Text = encOFD.FileName;
                if (decPathTB.Text != "")
                {
                    addPair();
                    encPathTB.Text = "";
                    decPathTB.Text = "";
                }
            }
            else
            {
                encPathTB.Text = "";
            }
        }

        private void browseDecButton_Click(object sender, EventArgs e)
        {
            DialogResult result = decOFD.ShowDialog();
            if (result == DialogResult.OK && !String.IsNullOrWhiteSpace(decOFD.FileName))
            {
                decPathTB.Text = decOFD.FileName;
                if (encPathTB.Text != "")
                {
                    addPair();
                    encPathTB.Text = "";
                    decPathTB.Text = "";
                }
            }
            else
            {
                decPathTB.Text = "";
            }
        }

        private void dirButton_Click(object sender, EventArgs e)
        {
            DialogResult result = dirFBD.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (!String.IsNullOrWhiteSpace(dirFBD.SelectedPath))
                    dirLabel.Text = String.Format("Selected dir: {0}", dirFBD.SelectedPath);
                else
                    dirLabel.Text = "No directory selected";
            }
            if (result == DialogResult.Cancel)
            {
                dirFBD.SelectedPath = "";
                dirLabel.Text = "No directory selected";
            }
        }

        delegate void SetTextCallback(string text);
        private void logEvent(string text)
        {
            if (logBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(logEvent);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                logBox.AppendText(text + "\r\n");
            }
        }

        private void clearLog()
        {
            logBox.Text = "---------------Log Start---------------\r\n";
        }

        private void addPair()
        {
            try { 
                NelasodDecryptor.AddStream(encPathTB.Text, decPathTB.Text);

                int len = NelasodDecryptor.GetStreamsLength();
                addToDataTable(NelasodDecryptor.GetStream(len - 1));

                updateDGV();

                logEvent(String.Format("Added {0} and {1} as pairs", encPathTB.Text, decPathTB.Text));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void addToDataTable(NelasodStream ns)
        {
            string col1 = new FileInfo(ns.EncryptedPath).Name;
            string col2 = new FileInfo(ns.DecryptedPath).Name;
            string col3 = Utils.ByteArrayToString(ns.Header, NelasodStream.HEADER_LENGTH);
            int col4 = ns.KeyLength;
            string col5 = ns.ID;
            string col6 = ns.GUID;

            pairsDT.Rows.Add(col1,col2,col3,col4,col5,col6);
        }

        private void updateDGV()
        {
            pairsDGV.DataSource = null;
            pairsDGV.DataSource = pairsDT;
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(dirFBD.SelectedPath))
            {
                MessageBox.Show("Please select a directory");
                return;
            }

            decryptButton.Enabled = false;

            clearLog();
            backgroundWorker.RunWorkerAsync();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            SearchOption option;
            if (recursiveCB.Checked == true)
            {
                option = SearchOption.AllDirectories;
            }
            else
            {
                option = SearchOption.TopDirectoryOnly;
            }

            IEnumerable<string> files = Directory.EnumerateFiles(dirFBD.SelectedPath, "*.nelasod", option);

            logEvent(String.Format("Decrypting {0} files...", files.Count()));
            int decrypted = 0;
            foreach (string file in files)
            {
                try
                {
                    string outPath = file.Replace(".nelasod", "");
                    outPath = outPath.Substring(0, outPath.IndexOf('.')) + ".decrypted" + outPath.Substring(outPath.IndexOf('.'));
                    NelasodDecryptor.DecryptFile(file, outPath);
                    logEvent(String.Format("SUCCESSFULLY DECRYPTED FILE {0}", file));
                    decrypted++;
                }
                catch (Exception ex)
                {
                    logEvent(String.Format("Failed to decrypt {0} - {1}", file, ex.Message));
                }
            }
            logEvent(String.Format("Decrypted {0}/{1} files", decrypted, files.Count()));
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            decryptButton.Enabled = true;
        }
    }
}
