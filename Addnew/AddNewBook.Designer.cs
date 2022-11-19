namespace Library
{
    partial class frmAddNew
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
            this.labAuthor = new System.Windows.Forms.Label();
            this.labTitle = new System.Windows.Forms.Label();
            this.labTranslator = new System.Windows.Forms.Label();
            this.labPublisher = new System.Windows.Forms.Label();
            this.labSeriesName = new System.Windows.Forms.Label();
            this.labPlace = new System.Windows.Forms.Label();
            this.labPublisherYear = new System.Windows.Forms.Label();
            this.labRemark = new System.Windows.Forms.Label();
            this.labHaveRead = new System.Windows.Forms.Label();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtPublishedYear = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.chbTranslator = new System.Windows.Forms.CheckBox();
            this.cebHaveRead = new System.Windows.Forms.CheckBox();
            this.brnSaveNew = new System.Windows.Forms.Button();
            this.btnCancelNew = new System.Windows.Forms.Button();
            this.cobAuthor = new System.Windows.Forms.ComboBox();
            this.cobTranslator = new System.Windows.Forms.ComboBox();
            this.cobPublisher = new System.Windows.Forms.ComboBox();
            this.cobSeries = new System.Windows.Forms.ComboBox();
            this.labISBN = new System.Windows.Forms.Label();
            this.mtxtISBN = new System.Windows.Forms.MaskedTextBox();
            this.chbisbn13 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labAuthor
            // 
            this.labAuthor.AutoSize = true;
            this.labAuthor.Location = new System.Drawing.Point(12, 22);
            this.labAuthor.Name = "labAuthor";
            this.labAuthor.Size = new System.Drawing.Size(46, 20);
            this.labAuthor.TabIndex = 0;
            this.labAuthor.Text = "Autor";
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Location = new System.Drawing.Point(12, 191);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(43, 20);
            this.labTitle.TabIndex = 2;
            this.labTitle.Text = "Tytuł:";
            // 
            // labTranslator
            // 
            this.labTranslator.AutoSize = true;
            this.labTranslator.Location = new System.Drawing.Point(12, 56);
            this.labTranslator.Name = "labTranslator";
            this.labTranslator.Size = new System.Drawing.Size(105, 20);
            this.labTranslator.TabIndex = 3;
            this.labTranslator.Text = "Imię tłumacza:";
            // 
            // labPublisher
            // 
            this.labPublisher.AutoSize = true;
            this.labPublisher.Location = new System.Drawing.Point(12, 90);
            this.labPublisher.Name = "labPublisher";
            this.labPublisher.Size = new System.Drawing.Size(105, 20);
            this.labPublisher.TabIndex = 5;
            this.labPublisher.Text = "Wydawnictwo:";
            // 
            // labSeriesName
            // 
            this.labSeriesName.AutoSize = true;
            this.labSeriesName.Location = new System.Drawing.Point(12, 157);
            this.labSeriesName.Name = "labSeriesName";
            this.labSeriesName.Size = new System.Drawing.Size(129, 20);
            this.labSeriesName.TabIndex = 6;
            this.labSeriesName.Text = "Seria wydawnicza:";
            // 
            // labPlace
            // 
            this.labPlace.AutoSize = true;
            this.labPlace.Location = new System.Drawing.Point(12, 124);
            this.labPlace.Name = "labPlace";
            this.labPlace.Size = new System.Drawing.Size(121, 20);
            this.labPlace.TabIndex = 8;
            this.labPlace.Text = "Miejsce wydania:";
            // 
            // labPublisherYear
            // 
            this.labPublisherYear.AutoSize = true;
            this.labPublisherYear.Location = new System.Drawing.Point(12, 224);
            this.labPublisherYear.Name = "labPublisherYear";
            this.labPublisherYear.Size = new System.Drawing.Size(93, 20);
            this.labPublisherYear.TabIndex = 9;
            this.labPublisherYear.Text = "Rok wydania";
            // 
            // labRemark
            // 
            this.labRemark.AutoSize = true;
            this.labRemark.Location = new System.Drawing.Point(12, 318);
            this.labRemark.Name = "labRemark";
            this.labRemark.Size = new System.Drawing.Size(81, 20);
            this.labRemark.TabIndex = 10;
            this.labRemark.Text = "Komentarz";
            // 
            // labHaveRead
            // 
            this.labHaveRead.AutoSize = true;
            this.labHaveRead.Location = new System.Drawing.Point(12, 287);
            this.labHaveRead.Name = "labHaveRead";
            this.labHaveRead.Size = new System.Drawing.Size(90, 20);
            this.labHaveRead.TabIndex = 11;
            this.labHaveRead.Text = "Przeczytana:";
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(173, 121);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(278, 27);
            this.txtPlace.TabIndex = 4;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(173, 188);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(278, 27);
            this.txtTitle.TabIndex = 6;
            // 
            // txtPublishedYear
            // 
            this.txtPublishedYear.Location = new System.Drawing.Point(173, 221);
            this.txtPublishedYear.Name = "txtPublishedYear";
            this.txtPublishedYear.Size = new System.Drawing.Size(278, 27);
            this.txtPublishedYear.TabIndex = 7;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(173, 315);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(278, 27);
            this.txtComment.TabIndex = 10;
            // 
            // chbTranslator
            // 
            this.chbTranslator.AutoSize = true;
            this.chbTranslator.Location = new System.Drawing.Point(457, 52);
            this.chbTranslator.Name = "chbTranslator";
            this.chbTranslator.Size = new System.Drawing.Size(121, 24);
            this.chbTranslator.TabIndex = 13;
            this.chbTranslator.Text = "Tłumaczenie?";
            this.chbTranslator.UseVisualStyleBackColor = true;
            this.chbTranslator.CheckedChanged += new System.EventHandler(this.chbTranslator_CheckedChanged);
            // 
            // cebHaveRead
            // 
            this.cebHaveRead.AutoSize = true;
            this.cebHaveRead.Location = new System.Drawing.Point(173, 290);
            this.cebHaveRead.Name = "cebHaveRead";
            this.cebHaveRead.Size = new System.Drawing.Size(18, 17);
            this.cebHaveRead.TabIndex = 9;
            this.cebHaveRead.UseVisualStyleBackColor = true;
            this.cebHaveRead.CheckedChanged += new System.EventHandler(this.cebHaveRead_CheckedChanged);
            // 
            // brnSaveNew
            // 
            this.brnSaveNew.Location = new System.Drawing.Point(173, 375);
            this.brnSaveNew.Name = "brnSaveNew";
            this.brnSaveNew.Size = new System.Drawing.Size(94, 29);
            this.brnSaveNew.TabIndex = 11;
            this.brnSaveNew.Text = "Zapisz";
            this.brnSaveNew.UseVisualStyleBackColor = true;
            this.brnSaveNew.Click += new System.EventHandler(this.brnSaveNew_Click);
            // 
            // btnCancelNew
            // 
            this.btnCancelNew.Location = new System.Drawing.Point(357, 375);
            this.btnCancelNew.Name = "btnCancelNew";
            this.btnCancelNew.Size = new System.Drawing.Size(94, 29);
            this.btnCancelNew.TabIndex = 12;
            this.btnCancelNew.Text = "Anuluj";
            this.btnCancelNew.UseVisualStyleBackColor = true;
            this.btnCancelNew.Click += new System.EventHandler(this.btnCancelNew_Click);
            // 
            // cobAuthor
            // 
            this.cobAuthor.FormattingEnabled = true;
            this.cobAuthor.Location = new System.Drawing.Point(173, 19);
            this.cobAuthor.Name = "cobAuthor";
            this.cobAuthor.Size = new System.Drawing.Size(278, 28);
            this.cobAuthor.TabIndex = 1;
            // 
            // cobTranslator
            // 
            this.cobTranslator.Enabled = false;
            this.cobTranslator.FormattingEnabled = true;
            this.cobTranslator.Location = new System.Drawing.Point(173, 53);
            this.cobTranslator.Name = "cobTranslator";
            this.cobTranslator.Size = new System.Drawing.Size(278, 28);
            this.cobTranslator.TabIndex = 2;
            // 
            // cobPublisher
            // 
            this.cobPublisher.FormattingEnabled = true;
            this.cobPublisher.Location = new System.Drawing.Point(173, 87);
            this.cobPublisher.Name = "cobPublisher";
            this.cobPublisher.Size = new System.Drawing.Size(278, 28);
            this.cobPublisher.TabIndex = 3;
            // 
            // cobSeries
            // 
            this.cobSeries.FormattingEnabled = true;
            this.cobSeries.Location = new System.Drawing.Point(173, 154);
            this.cobSeries.Name = "cobSeries";
            this.cobSeries.Size = new System.Drawing.Size(278, 28);
            this.cobSeries.TabIndex = 5;
            // 
            // labISBN
            // 
            this.labISBN.AutoSize = true;
            this.labISBN.Location = new System.Drawing.Point(12, 257);
            this.labISBN.Name = "labISBN";
            this.labISBN.Size = new System.Drawing.Size(41, 20);
            this.labISBN.TabIndex = 32;
            this.labISBN.Text = "ISBN";
            // 
            // mtxtISBN
            // 
            this.mtxtISBN.Location = new System.Drawing.Point(173, 254);
            this.mtxtISBN.Mask = "A-AAA-AAAAA-A";
            this.mtxtISBN.Name = "mtxtISBN";
            this.mtxtISBN.Size = new System.Drawing.Size(278, 27);
            this.mtxtISBN.TabIndex = 8;
            // 
            // chbisbn13
            // 
            this.chbisbn13.AutoSize = true;
            this.chbisbn13.Location = new System.Drawing.Point(457, 253);
            this.chbisbn13.Name = "chbisbn13";
            this.chbisbn13.Size = new System.Drawing.Size(86, 24);
            this.chbisbn13.TabIndex = 14;
            this.chbisbn13.Text = "ISBN13?";
            this.chbisbn13.UseVisualStyleBackColor = true;
            this.chbisbn13.CheckedChanged += new System.EventHandler(this.chbisbn13_CheckedChanged);
            // 
            // frmAddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(584, 425);
            this.ControlBox = false;
            this.Controls.Add(this.chbisbn13);
            this.Controls.Add(this.mtxtISBN);
            this.Controls.Add(this.labISBN);
            this.Controls.Add(this.cobSeries);
            this.Controls.Add(this.cobPublisher);
            this.Controls.Add(this.cobTranslator);
            this.Controls.Add(this.cobAuthor);
            this.Controls.Add(this.btnCancelNew);
            this.Controls.Add(this.brnSaveNew);
            this.Controls.Add(this.cebHaveRead);
            this.Controls.Add(this.chbTranslator);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtPublishedYear);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.labHaveRead);
            this.Controls.Add(this.labRemark);
            this.Controls.Add(this.labPublisherYear);
            this.Controls.Add(this.labPlace);
            this.Controls.Add(this.labSeriesName);
            this.Controls.Add(this.labPublisher);
            this.Controls.Add(this.labTranslator);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.labAuthor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAddNew";
            this.Text = "Dodaj nową pozycję";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddNewBookClosing);
            this.Load += new System.EventHandler(this.AddNewBook_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labAuthor;
        private Label labTitle;
        private Label labTranslator;
        private Label labPublisher;
        private Label labSeriesName;
        private Label label5;
        private Label labPlace;
        private Label labPublisherYear;
        private Label labRemark;
        private Label labHaveRead;
        private Label label4;
        private TextBox txtPlace;
        private TextBox txtTitle;
        private TextBox txtPublishedYear;
        private TextBox txtComment;
        private CheckBox chbTranslator;
        private CheckBox cebHaveRead;
        private Button brnSaveNew;
        private Button btnCancelNew;
        private ComboBox cobAuthor;
        private ComboBox cobTranslatorFirstName;
        private ComboBox cobPublisher;
        private ComboBox cobTranslatorLastName;
        private ComboBox cobSeries;
        private Label labISBN;
        private MaskedTextBox mtxtISBN;
        private CheckBox chbisbn13;
        private ComboBox cobTranslator;
    }
}