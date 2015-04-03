using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Windows.Forms;

namespace RESX_Translate
{
    public partial class Form1 : Form
    {
        List<Dictionary<string,string>> Dicts = new List<Dictionary<string,string>>();
        List<string> fileNames = new List<string>();

        string defaultColumn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lb_Coordinates.Text = dataGridView1.Rows.Count.ToString();
            this.Text = "RESX-Translate V" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
        }

        private void btn_SelectDir_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = Properties.Settings.Default.FilePath;
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = fbd.SelectedPath;
                Properties.Settings.Default.FilePath = fbd.SelectedPath;
                Properties.Settings.Default.Save();
                cb_DefaultSrc.Items.Clear();

                tb_path.Text = path;
                // Take a snapshot of the file system.
                System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);
                
                // This method assumes that the application has discovery permissions 
                // for all folders under the specified path.
                IEnumerable<System.IO.FileInfo> fileList = dir.GetFiles("*.*", System.IO.SearchOption.TopDirectoryOnly);
                
                //Create the query
                IEnumerable<System.IO.FileInfo> fileQuery =
                    from file in fileList
                    where file.Extension == ".resx"
                    orderby file.Name
                    select file;

                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("Key", "Key");

                //Execute the query. This might write out a lot of files! 
                foreach (System.IO.FileInfo fi in fileQuery)
                {
                    fileNames.Add(fi.Name);
                    string niceName = fi.Name.Substring(fi.Name.IndexOf('.') + 1);

                    if (!niceName.Contains('.'))
                    {
                        dataGridView1.Columns.Add(fi.Name, "Default");
                        defaultColumn = fi.Name;

                    }
                    else
                    {
                        niceName = niceName.Substring(0, niceName.IndexOf('.')).ToUpper();
                        dataGridView1.Columns.Add(fi.Name, niceName);
                    }

                    cb_DefaultSrc.Items.Add(fi.Name);
                
                }

                foreach (string file in fileNames)
                {
                    ResXResourceReader resxReader = new ResXResourceReader(Path.Combine(tb_path.Text,file));
                    foreach (DictionaryEntry entry in resxReader)
                    {
                        int row = dgvGetRow(entry.Key.ToString());
                        if (row < 0)
                        {
                            row = dataGridView1.Rows.Add(1);
                            dataGridView1.Rows[row].Cells["Key"].Value = entry.Key;
                        }

                       
                        dataGridView1.Rows[row].Cells[file].Value = entry.Value;
                    }
                }

                tb_path.Enabled = false;
                btn_SelectDir.Enabled = false;
                lb_Coordinates.Text = dataGridView1.Rows.Count.ToString();
                btn_CopyToDefault.Enabled = true;
                cb_DefaultSrc.Enabled = true;

                if (dataGridView1.ColumnCount < 6)
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private int dgvGetRow(string p)
        {
            for (var i = 0; i < dataGridView1.Rows.Count; ++i)
                if (dataGridView1.Rows[i].Cells["Key"].Value != null)
                if (dataGridView1.Rows[i].Cells["Key"].Value.ToString() == p)
                    return i;

            return -1;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            save();
        }

        private void save()
        {
            foreach (string file in fileNames)
            {
                ResXResourceWriter rw = new ResXResourceWriter(Path.Combine(tb_path.Text, file));
                for (var r = 0; r < dataGridView1.Rows.Count - 1; ++r) //Last row is empty new row. Skip that line
                {
                    if (dataGridView1.Rows[r].Cells["Key"].Value != null)
                        if (dataGridView1.Rows[r].Cells["Key"].Value.ToString().Length > 0)
                            rw.AddResource(new ResXDataNode(dataGridView1.Rows[r].Cells["Key"].Value.ToString(), dataGridView1.Rows[r].Cells[file].Value.ToString()));
                        else
                            MessageBox.Show("Zeile " + r + " überprungen; kein Key angegeben!");
                    else
                        MessageBox.Show("Zeile " + r + " überprungen; kein Key angegeben!");
                }

                rw.Close();
            }

            MessageBox.Show("Saved");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lb_Coordinates.Text = dataGridView1.Rows.Count.ToString() + "/" +  e.RowIndex.ToString();

        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 19) //STRG + S
            {
                save();
            }
            else if (e.KeyChar == 18) //STRG + S
            {
           //     reload();
            }
        }

        private void btn_CopyToDefault_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Default wirklich überschreiben?", "Sicher?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                //getColumnID
                var c = 0;
                for (c = 0; c < dataGridView1.Columns.Count; ++c)
                    if (dataGridView1.Columns[c].HeaderText == "Default")
                        break;
                

                for(var r = 0;r<dataGridView1.Rows.Count-1;++r)                    
                    dataGridView1.Rows[r].Cells[c].Value = dataGridView1.Rows[r].Cells[cb_DefaultSrc.SelectedItem.ToString()].Value;
                
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                if (dataGridView1.SelectedCells.Count > 0)
                    if (dataGridView1.SelectedCells.Count < 5 || MessageBox.Show("Alle markierten Zellen leeren?\r\n(STRG+Z funktioniert noch nicht ;))", "Sicher?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                        foreach (DataGridViewCell c in dataGridView1.SelectedCells)
                            c.Value = null;
        }

        private void btnAddLanguage_Click(object sender, EventArgs e)
        {

        }

        private void btn_Scan_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = Properties.Settings.Default.SearchFilePath;
            if (fbd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            Properties.Settings.Default.SearchFilePath = fbd.SelectedPath;
            String[] allfiles = System.IO.Directory.GetFiles(fbd.SelectedPath, "*.cs", System.IO.SearchOption.AllDirectories);
            foreach (string str in allfiles)
            {
                if (str.EndsWith(".Designer.cs") || str.Contains("TemporaryGeneratedFile"))
                    continue;

                StreamReader sr = new StreamReader(str);
                string content = sr.ReadToEnd();
                int pos = content.IndexOf("t.t(");
                while (pos > 0)
                {
                    int end = content.IndexOf("\")", pos);
                    string param = content.Substring(pos+4, end-pos-3);
                    string[] text = param.Split(',');

                    string Key = text[0].Replace("\"", "");

                    if (!KeyExists(Key))
                    {
                        int row = dataGridView1.Rows.Add(1);
                        dataGridView1["Key", row].Value = Key;

                        if (text.Length == 2)
                            dataGridView1[defaultColumn, row].Value = text[1].Replace("\"", "");
                    }


                    pos = content.IndexOf("t.t(", pos+1);
                }
            }            
        }

        private bool KeyExists(string Key)
        {
            for(int i=0;i<dataGridView1.Rows.Count;++i) {
                if (dataGridView1["Key", i].Value != null &&dataGridView1["Key", i].Value.ToString() == Key)
                    return true;
            }

            return false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
       
        }
    }
}
