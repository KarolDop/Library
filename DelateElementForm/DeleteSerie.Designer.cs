﻿namespace Library.DelateElementForm
{
    partial class frmDeleteSerie
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ctxtSeries = new System.Windows.Forms.ComboBox();
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
            this.btnCancel.Location = new System.Drawing.Point(196, 80);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ctxtSeries
            // 
            this.ctxtSeries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctxtSeries.FormattingEnabled = true;
            this.ctxtSeries.Location = new System.Drawing.Point(113, 14);
            this.ctxtSeries.Name = "ctxtSeries";
            this.ctxtSeries.Size = new System.Drawing.Size(206, 28);
            this.ctxtSeries.TabIndex = 4;
            // 
            // frmDeleteSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 143);
            this.ControlBox = false;
            this.Controls.Add(this.ctxtSeries);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.labSeriesName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDeleteSerie";
            this.Text = "Usuń serię";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeleteSeries_closing);
            this.Load += new System.EventHandler(this.DeleteSeries_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labSeriesName;
        private Button btnDelete;
        private Button btnCancel;
        private ComboBox ctxtSeries;
    }
}