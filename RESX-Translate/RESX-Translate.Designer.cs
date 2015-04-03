namespace RESX_Translate
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_SelectDir = new System.Windows.Forms.Button();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btnAddLanguage = new System.Windows.Forms.Button();
            this.lb_Coordinates = new System.Windows.Forms.Label();
            this.cb_DefaultSrc = new System.Windows.Forms.ComboBox();
            this.btn_CopyToDefault = new System.Windows.Forms.Button();
            this.btn_Scan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SelectDir
            // 
            this.btn_SelectDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SelectDir.Location = new System.Drawing.Point(741, 9);
            this.btn_SelectDir.Name = "btn_SelectDir";
            this.btn_SelectDir.Size = new System.Drawing.Size(31, 23);
            this.btn_SelectDir.TabIndex = 0;
            this.btn_SelectDir.Text = "...";
            this.btn_SelectDir.UseVisualStyleBackColor = true;
            this.btn_SelectDir.Click += new System.EventHandler(this.btn_SelectDir_Click);
            // 
            // tb_path
            // 
            this.tb_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_path.Location = new System.Drawing.Point(12, 12);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(723, 20);
            this.tb_path.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(841, 389);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.Location = new System.Drawing.Point(778, 433);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Speichern";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btnAddLanguage
            // 
            this.btnAddLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddLanguage.Enabled = false;
            this.btnAddLanguage.Location = new System.Drawing.Point(778, 9);
            this.btnAddLanguage.Name = "btnAddLanguage";
            this.btnAddLanguage.Size = new System.Drawing.Size(75, 23);
            this.btnAddLanguage.TabIndex = 4;
            this.btnAddLanguage.Text = "+ Sprache";
            this.btnAddLanguage.UseVisualStyleBackColor = true;
            this.btnAddLanguage.Click += new System.EventHandler(this.btnAddLanguage_Click);
            // 
            // lb_Coordinates
            // 
            this.lb_Coordinates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_Coordinates.AutoSize = true;
            this.lb_Coordinates.Location = new System.Drawing.Point(12, 438);
            this.lb_Coordinates.Name = "lb_Coordinates";
            this.lb_Coordinates.Size = new System.Drawing.Size(35, 13);
            this.lb_Coordinates.TabIndex = 5;
            this.lb_Coordinates.Text = "label1";
            // 
            // cb_DefaultSrc
            // 
            this.cb_DefaultSrc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_DefaultSrc.Enabled = false;
            this.cb_DefaultSrc.FormattingEnabled = true;
            this.cb_DefaultSrc.Location = new System.Drawing.Point(55, 435);
            this.cb_DefaultSrc.Name = "cb_DefaultSrc";
            this.cb_DefaultSrc.Size = new System.Drawing.Size(415, 21);
            this.cb_DefaultSrc.TabIndex = 6;
            // 
            // btn_CopyToDefault
            // 
            this.btn_CopyToDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_CopyToDefault.Enabled = false;
            this.btn_CopyToDefault.Location = new System.Drawing.Point(476, 433);
            this.btn_CopyToDefault.Name = "btn_CopyToDefault";
            this.btn_CopyToDefault.Size = new System.Drawing.Size(109, 23);
            this.btn_CopyToDefault.TabIndex = 7;
            this.btn_CopyToDefault.Text = "in default Kopieren";
            this.btn_CopyToDefault.UseVisualStyleBackColor = true;
            this.btn_CopyToDefault.Click += new System.EventHandler(this.btn_CopyToDefault_Click);
            // 
            // btn_Scan
            // 
            this.btn_Scan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Scan.Location = new System.Drawing.Point(697, 433);
            this.btn_Scan.Name = "btn_Scan";
            this.btn_Scan.Size = new System.Drawing.Size(75, 23);
            this.btn_Scan.TabIndex = 8;
            this.btn_Scan.Text = "Scan Ordner";
            this.btn_Scan.UseVisualStyleBackColor = true;
            this.btn_Scan.Click += new System.EventHandler(this.btn_Scan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 468);
            this.Controls.Add(this.btn_Scan);
            this.Controls.Add(this.btn_CopyToDefault);
            this.Controls.Add(this.cb_DefaultSrc);
            this.Controls.Add(this.lb_Coordinates);
            this.Controls.Add(this.btnAddLanguage);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.btn_SelectDir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "RESX-Translate";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SelectDir;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btnAddLanguage;
        private System.Windows.Forms.Label lb_Coordinates;
        private System.Windows.Forms.ComboBox cb_DefaultSrc;
        private System.Windows.Forms.Button btn_CopyToDefault;
        private System.Windows.Forms.Button btn_Scan;
    }
}

