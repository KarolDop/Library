namespace Library.AddNewElementForm
{
    partial class frmAddNewAuthor
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
            this.labFirstName = new System.Windows.Forms.Label();
            this.labLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labFirstName
            // 
            this.labFirstName.AutoSize = true;
            this.labFirstName.Location = new System.Drawing.Point(12, 17);
            this.labFirstName.Name = "labFirstName";
            this.labFirstName.Size = new System.Drawing.Size(38, 20);
            this.labFirstName.TabIndex = 0;
            this.labFirstName.Text = "Imię";
            // 
            // labLastName
            // 
            this.labLastName.AutoSize = true;
            this.labLastName.Location = new System.Drawing.Point(12, 74);
            this.labLastName.Name = "labLastName";
            this.labLastName.Size = new System.Drawing.Size(72, 20);
            this.labLastName.TabIndex = 1;
            this.labLastName.Text = "Nazwisko";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(113, 14);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(206, 27);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.goNext);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(113, 71);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(206, 27);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.goNext);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(30, 147);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(196, 147);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddNewAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 206);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.labLastName);
            this.Controls.Add(this.labFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddNewAuthor";
            this.Text = "Dodaj nowego autora";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddNewAuthor_closing);
            this.Load += new System.EventHandler(this.frmAddNewAuthor_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labFirstName;
        private Label labLastName;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Button btnSave;
        private Button btnCancel;
    }
}