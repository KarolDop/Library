namespace Library.DelateElementForm
{
    partial class frmDeleteTranslator
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
            this.labTranslator = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ctxtTranslator = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labTranslator
            // 
            this.labTranslator.AutoSize = true;
            this.labTranslator.Location = new System.Drawing.Point(11, 17);
            this.labTranslator.Name = "labTranslator";
            this.labTranslator.Size = new System.Drawing.Size(64, 20);
            this.labTranslator.TabIndex = 0;
            this.labTranslator.Text = "Tłumacz";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(30, 80);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 80);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ctxtTranslator
            // 
            this.ctxtTranslator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctxtTranslator.FormattingEnabled = true;
            this.ctxtTranslator.Location = new System.Drawing.Point(113, 13);
            this.ctxtTranslator.Name = "ctxtTranslator";
            this.ctxtTranslator.Size = new System.Drawing.Size(206, 28);
            this.ctxtTranslator.TabIndex = 4;
            // 
            // frnDeleteTranslator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 143);
            this.ControlBox = false;
            this.Controls.Add(this.ctxtTranslator);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.labTranslator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frnDeleteTranslator";
            this.Text = "Usuń tłumacza";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeleteSeries_closing);
            this.Load += new System.EventHandler(this.DeleteSeries_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labTranslator;
        private Button btnDelete;
        private Button btnCancel;
        private ComboBox ctxtTranslator;
    }
}