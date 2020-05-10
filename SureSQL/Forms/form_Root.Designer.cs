namespace SureSQL.Forms
{
    partial class form_Root
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lst_StoredProcedures = new System.Windows.Forms.ListBox();
            this.lst_Functions = new System.Windows.Forms.ListBox();
            this.lst_Views = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Stored Procedures";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Functions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(818, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Views";
            // 
            // lst_StoredProcedures
            // 
            this.lst_StoredProcedures.FormattingEnabled = true;
            this.lst_StoredProcedures.Location = new System.Drawing.Point(21, 34);
            this.lst_StoredProcedures.Name = "lst_StoredProcedures";
            this.lst_StoredProcedures.Size = new System.Drawing.Size(387, 459);
            this.lst_StoredProcedures.TabIndex = 6;
            // 
            // lst_Functions
            // 
            this.lst_Functions.FormattingEnabled = true;
            this.lst_Functions.Location = new System.Drawing.Point(421, 34);
            this.lst_Functions.Name = "lst_Functions";
            this.lst_Functions.Size = new System.Drawing.Size(387, 459);
            this.lst_Functions.TabIndex = 7;
            // 
            // lst_Views
            // 
            this.lst_Views.FormattingEnabled = true;
            this.lst_Views.Location = new System.Drawing.Point(821, 34);
            this.lst_Views.Name = "lst_Views";
            this.lst_Views.Size = new System.Drawing.Size(387, 459);
            this.lst_Views.TabIndex = 8;
            // 
            // form_Root
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1228, 516);
            this.Controls.Add(this.lst_Views);
            this.Controls.Add(this.lst_Functions);
            this.Controls.Add(this.lst_StoredProcedures);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_Root";
            this.Text = "form_Tree";
            this.Load += new System.EventHandler(this.form_Root_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lst_StoredProcedures;
        private System.Windows.Forms.ListBox lst_Functions;
        private System.Windows.Forms.ListBox lst_Views;
    }
}