namespace Libary
{
    partial class frmLibary
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sfdCreateDB = new System.Windows.Forms.SaveFileDialog();
            this.ofdOpenDB = new System.Windows.Forms.OpenFileDialog();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvAllBooks = new System.Windows.Forms.DataGridView();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.msMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(1429, 28);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "Pasek";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem,
            this.zamknijToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            // 
            // dgvAllBooks
            // 
            this.dgvAllBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllBooks.Location = new System.Drawing.Point(12, 47);
            this.dgvAllBooks.Name = "dgvAllBooks";
            this.dgvAllBooks.RowHeadersWidth = 51;
            this.dgvAllBooks.RowTemplate.Height = 29;
            this.dgvAllBooks.Size = new System.Drawing.Size(1405, 267);
            this.dgvAllBooks.TabIndex = 1;
            // 
            // frmLibary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 450);
            this.Controls.Add(this.dgvAllBooks);
            this.Controls.Add(this.msMenu);
            this.MainMenuStrip = this.msMenu;
            this.Name = "frmLibary";
            this.Text = "Biblioteka";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip msMenu;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem zamknijToolStripMenuItem;
        private SaveFileDialog sfdCreateDB;
        private OpenFileDialog ofdOpenDB;
        private ToolStripMenuItem oProgramieToolStripMenuItem;
        private DataGridView dgvAllBooks;
    }
}