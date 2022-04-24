namespace Telefon_Rehberi
{
    partial class Person_List
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Menu_New_Person = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_Person_List = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_Edit_Person = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_Vcard = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_PrintPerson = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_Settings = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_About_Me = new System.Windows.Forms.ToolStripButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1157, 467);
            this.dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(549, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Kişi Listesi";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_New_Person,
            this.toolStripSeparator1,
            this.Menu_Person_List,
            this.toolStripSeparator4,
            this.Menu_Edit_Person,
            this.toolStripSeparator2,
            this.Menu_Vcard,
            this.toolStripSeparator7,
            this.menu_PrintPerson,
            this.toolStripSeparator3,
            this.menu_Settings,
            this.toolStripSeparator6,
            this.Menu_About_Me});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1157, 25);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "--";
            // 
            // Menu_New_Person
            // 
            this.Menu_New_Person.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Menu_New_Person.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Menu_New_Person.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Menu_New_Person.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.Menu_New_Person.Name = "Menu_New_Person";
            this.Menu_New_Person.Size = new System.Drawing.Size(64, 22);
            this.Menu_New_Person.Text = "Yeni Kişi";
            this.Menu_New_Person.Click += new System.EventHandler(this.Menu_New_Person_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Menu_Person_List
            // 
            this.Menu_Person_List.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Menu_Person_List.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Menu_Person_List.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Menu_Person_List.Name = "Menu_Person_List";
            this.Menu_Person_List.Size = new System.Drawing.Size(77, 22);
            this.Menu_Person_List.Text = "Kişi Listesi";
            this.Menu_Person_List.ToolTipText = "Person List";
            this.Menu_Person_List.Click += new System.EventHandler(this.Menu_Person_List_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // Menu_Edit_Person
            // 
            this.Menu_Edit_Person.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Menu_Edit_Person.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Menu_Edit_Person.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Menu_Edit_Person.Name = "Menu_Edit_Person";
            this.Menu_Edit_Person.Size = new System.Drawing.Size(107, 22);
            this.Menu_Edit_Person.Text = "Kişi Düzenleme";
            this.Menu_Edit_Person.Click += new System.EventHandler(this.Menu_Edit_Person_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Menu_Vcard
            // 
            this.Menu_Vcard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Menu_Vcard.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Menu_Vcard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Menu_Vcard.Name = "Menu_Vcard";
            this.Menu_Vcard.Size = new System.Drawing.Size(58, 22);
            this.Menu_Vcard.Text = "QR Kod";
            this.Menu_Vcard.Click += new System.EventHandler(this.Menu_Vcard_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // menu_PrintPerson
            // 
            this.menu_PrintPerson.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.menu_PrintPerson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_PrintPerson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu_PrintPerson.Name = "menu_PrintPerson";
            this.menu_PrintPerson.Size = new System.Drawing.Size(49, 22);
            this.menu_PrintPerson.Text = "Yazdır";
            
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // menu_Settings
            // 
            this.menu_Settings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.menu_Settings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menu_Settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu_Settings.Name = "menu_Settings";
            this.menu_Settings.Size = new System.Drawing.Size(56, 22);
            this.menu_Settings.Text = "Ayarlar";
            this.menu_Settings.Click += new System.EventHandler(this.menu_Settings_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // Menu_About_Me
            // 
            this.Menu_About_Me.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Menu_About_Me.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Menu_About_Me.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Menu_About_Me.Name = "Menu_About_Me";
            this.Menu_About_Me.Size = new System.Drawing.Size(70, 22);
            this.Menu_About_Me.Text = "Hakkında";
            this.Menu_About_Me.Click += new System.EventHandler(this.Menu_About_Me_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 20);
            this.textBox1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(221, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Kişi_Listesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 539);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Kişi_Listesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kişi Listesi";
            this.Load += new System.EventHandler(this.Kişi_Listesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Menu_New_Person;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Menu_Person_List;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton Menu_Edit_Person;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Menu_Vcard;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton menu_PrintPerson;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton menu_Settings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton Menu_About_Me;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}