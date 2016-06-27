namespace Kodowanie
{
    partial class Form3
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda wsparcia projektanta - nie należy modyfikować
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.wpisz = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doPlikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zobaczPomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.File2File = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wpisz
            // 
            resources.ApplyResources(this.wpisz, "wpisz");
            this.wpisz.Name = "wpisz";
            this.wpisz.TextChanged += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            resources.ApplyResources(this.checkedListBox1, "checkedListBox1");
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            resources.GetString("checkedListBox1.Items"),
            resources.GetString("checkedListBox1.Items1"),
            resources.GetString("checkedListBox1.Items2"),
            resources.GetString("checkedListBox1.Items3"),
            resources.GetString("checkedListBox1.Items4"),
            resources.GetString("checkedListBox1.Items5"),
            resources.GetString("checkedListBox1.Items6"),
            resources.GetString("checkedListBox1.Items7"),
            resources.GetString("checkedListBox1.Items8"),
            resources.GetString("checkedListBox1.Items9"),
            resources.GetString("checkedListBox1.Items10"),
            resources.GetString("checkedListBox1.Items11"),
            resources.GetString("checkedListBox1.Items12"),
            resources.GetString("checkedListBox1.Items13"),
            resources.GetString("checkedListBox1.Items14"),
            resources.GetString("checkedListBox1.Items15"),
            resources.GetString("checkedListBox1.Items16"),
            resources.GetString("checkedListBox1.Items17"),
            resources.GetString("checkedListBox1.Items18"),
            resources.GetString("checkedListBox1.Items19")});
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikiToolStripMenuItem,
            this.poToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // plikiToolStripMenuItem
            // 
            this.plikiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzToolStripMenuItem,
            this.zapiszToolStripMenuItem});
            this.plikiToolStripMenuItem.Name = "plikiToolStripMenuItem";
            resources.ApplyResources(this.plikiToolStripMenuItem, "plikiToolStripMenuItem");
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doProgramuToolStripMenuItem,
            this.doPlikuToolStripMenuItem});
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            resources.ApplyResources(this.otwórzToolStripMenuItem, "otwórzToolStripMenuItem");
            // 
            // doProgramuToolStripMenuItem
            // 
            this.doProgramuToolStripMenuItem.Name = "doProgramuToolStripMenuItem";
            resources.ApplyResources(this.doProgramuToolStripMenuItem, "doProgramuToolStripMenuItem");
            this.doProgramuToolStripMenuItem.Click += new System.EventHandler(this.button3_Click);
            // 
            // doPlikuToolStripMenuItem
            // 
            this.doPlikuToolStripMenuItem.Name = "doPlikuToolStripMenuItem";
            resources.ApplyResources(this.doPlikuToolStripMenuItem, "doPlikuToolStripMenuItem");
            this.doPlikuToolStripMenuItem.Click += new System.EventHandler(this.File2File_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            resources.ApplyResources(this.zapiszToolStripMenuItem, "zapiszToolStripMenuItem");
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // poToolStripMenuItem
            // 
            this.poToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zobaczPomocToolStripMenuItem,
            this.oProgramieToolStripMenuItem});
            this.poToolStripMenuItem.Name = "poToolStripMenuItem";
            resources.ApplyResources(this.poToolStripMenuItem, "poToolStripMenuItem");
            // 
            // zobaczPomocToolStripMenuItem
            // 
            this.zobaczPomocToolStripMenuItem.Name = "zobaczPomocToolStripMenuItem";
            resources.ApplyResources(this.zobaczPomocToolStripMenuItem, "zobaczPomocToolStripMenuItem");
            this.zobaczPomocToolStripMenuItem.Click += new System.EventHandler(this.zobaczPomocToolStripMenuItem_Click);
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            resources.ApplyResources(this.oProgramieToolStripMenuItem, "oProgramieToolStripMenuItem");
            this.oProgramieToolStripMenuItem.Click += new System.EventHandler(this.oProgramieToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2"),
            resources.GetString("comboBox1.Items3"),
            resources.GetString("comboBox1.Items4"),
            resources.GetString("comboBox1.Items5"),
            resources.GetString("comboBox1.Items6"),
            resources.GetString("comboBox1.Items7"),
            resources.GetString("comboBox1.Items8"),
            resources.GetString("comboBox1.Items9"),
            resources.GetString("comboBox1.Items10"),
            resources.GetString("comboBox1.Items11"),
            resources.GetString("comboBox1.Items12"),
            resources.GetString("comboBox1.Items13"),
            resources.GetString("comboBox1.Items14"),
            resources.GetString("comboBox1.Items15"),
            resources.GetString("comboBox1.Items16"),
            resources.GetString("comboBox1.Items17"),
            resources.GetString("comboBox1.Items18"),
            resources.GetString("comboBox1.Items19")});
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // File2File
            // 
            resources.ApplyResources(this.File2File, "File2File");
            this.File2File.Name = "File2File";
            this.File2File.UseVisualStyleBackColor = true;
            this.File2File.Click += new System.EventHandler(this.File2File_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuBar;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.MenuBar;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.MenuBar;
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form3
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::Kodowanie.Properties.Resources.tlo;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.File2File);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wpisz);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wpisz;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doProgramuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doPlikuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zobaczPomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button File2File;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

