namespace Library
{
    partial class frmLibrary
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
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvAllBooks = new System.Windows.Forms.DataGridView();
            this.btnAddNewBook = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddNewSeries = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAddNewTranslator = new System.Windows.Forms.Button();
            this.btnAddNewAuthor = new System.Windows.Forms.Button();
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
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // dgvAllBooks
            // 
            this.dgvAllBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllBooks.Location = new System.Drawing.Point(12, 42);
            this.dgvAllBooks.Name = "dgvAllBooks";
            this.dgvAllBooks.RowHeadersWidth = 51;
            this.dgvAllBooks.RowTemplate.Height = 29;
            this.dgvAllBooks.Size = new System.Drawing.Size(1405, 267);
            this.dgvAllBooks.TabIndex = 1;
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.Location = new System.Drawing.Point(12, 327);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.Size = new System.Drawing.Size(198, 29);
            this.btnAddNewBook.TabIndex = 2;
            this.btnAddNewBook.Text = "Dodaj nową książkę";
            this.btnAddNewBook.UseVisualStyleBackColor = true;
            this.btnAddNewBook.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(12, 362);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(167, 29);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "Modyfikuj pozycję";
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(12, 397);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(167, 29);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Usuń pozycję";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAddNewSeries
            // 
            this.btnAddNewSeries.Location = new System.Drawing.Point(828, 327);
            this.btnAddNewSeries.Name = "btnAddNewSeries";
            this.btnAddNewSeries.Size = new System.Drawing.Size(198, 29);
            this.btnAddNewSeries.TabIndex = 5;
            this.btnAddNewSeries.Text = "Dodaj nową serię";
            this.btnAddNewSeries.UseVisualStyleBackColor = true;
            this.btnAddNewSeries.Click += new System.EventHandler(this.btnAddNewSeries_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(624, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "Dodaj nowe wydawnictwo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddNewTranslator
            // 
            this.btnAddNewTranslator.Location = new System.Drawing.Point(420, 327);
            this.btnAddNewTranslator.Name = "btnAddNewTranslator";
            this.btnAddNewTranslator.Size = new System.Drawing.Size(198, 29);
            this.btnAddNewTranslator.TabIndex = 7;
            this.btnAddNewTranslator.Text = "Dodaj nowego tłumacza";
            this.btnAddNewTranslator.UseVisualStyleBackColor = true;
            this.btnAddNewTranslator.Click += new System.EventHandler(this.btnAddNewTranslator_Click);
            // 
            // btnAddNewAuthor
            // 
            this.btnAddNewAuthor.Location = new System.Drawing.Point(216, 327);
            this.btnAddNewAuthor.Name = "btnAddNewAuthor";
            this.btnAddNewAuthor.Size = new System.Drawing.Size(198, 29);
            this.btnAddNewAuthor.TabIndex = 8;
            this.btnAddNewAuthor.Text = "Dodaj nowego autora";
            this.btnAddNewAuthor.UseVisualStyleBackColor = true;
            this.btnAddNewAuthor.Click += new System.EventHandler(this.btnAddNewAuthor_Click);
            // 
            // frmLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 450);
            this.Controls.Add(this.btnAddNewAuthor);
            this.Controls.Add(this.btnAddNewTranslator);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddNewSeries);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAddNewBook);
            this.Controls.Add(this.dgvAllBooks);
            this.Controls.Add(this.msMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.msMenu;
            this.Name = "frmLibrary";
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
        private ToolStripMenuItem oProgramieToolStripMenuItem;
        private DataGridView dgvAllBooks;
        private Button btnAddNewBook;
        private Button btnModify;
        private Button btnRemove;
        private Button btnAddNewSeries;
        private Button button2;
        private Button btnAddNewTranslator;
        private Button btnAddNewAuthor;
    }
}