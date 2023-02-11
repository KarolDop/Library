namespace Library.AddNewElementForm
{
    partial class frmAddNewSeries
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
            this.labSeriesName = new System.Windows.Forms.Label();
            this.txtSeriesName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labSeriesName
            // 
            this.labSeriesName.AutoSize = true;
            this.labSeriesName.Location = new System.Drawing.Point(12, 17);
            this.labSeriesName.Name = "labSeriesName";
            this.labSeriesName.Size = new System.Drawing.Size(42, 20);
            this.labSeriesName.TabIndex = 0;
            this.labSeriesName.Text = "Seria";
            // 
            // txtSeriesName
            // 
            this.txtSeriesName.Location = new System.Drawing.Point(113, 14);
            this.txtSeriesName.Name = "txtSeriesName";
            this.txtSeriesName.Size = new System.Drawing.Size(206, 27);
            this.txtSeriesName.TabIndex = 1;
            this.txtSeriesName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.goNext);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(30, 80);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(196, 80);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddNewSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 143);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSeriesName);
            this.Controls.Add(this.labSeriesName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddNewSeries";
            this.Text = "Dodaj nową serię";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddNewSeries_closing);
            this.Load += new System.EventHandler(this.frmAddNewSeries_load);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.MaximizeBox = false;

        }

        #endregion

        private Label labSeriesName;
        private TextBox txtSeriesName;
        private Button btnSave;
        private Button btnCancel;
    }
}