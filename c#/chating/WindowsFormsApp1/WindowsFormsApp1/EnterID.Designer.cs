
namespace WindowsFormsApp1
{
    partial class EnterID
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
            this.IDInputField = new System.Windows.Forms.TextBox();
            this.IDbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IDInputField
            // 
            this.IDInputField.Location = new System.Drawing.Point(12, 26);
            this.IDInputField.Name = "IDInputField";
            this.IDInputField.Size = new System.Drawing.Size(359, 21);
            this.IDInputField.TabIndex = 0;
            // 
            // IDbtn
            // 
            this.IDbtn.Location = new System.Drawing.Point(377, 24);
            this.IDbtn.Name = "IDbtn";
            this.IDbtn.Size = new System.Drawing.Size(75, 23);
            this.IDbtn.TabIndex = 1;
            this.IDbtn.Text = "ID 입력";
            this.IDbtn.UseVisualStyleBackColor = true;
            this.IDbtn.Click += new System.EventHandler(this.IDbtn_Click);
            // 
            // EnterID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 66);
            this.Controls.Add(this.IDbtn);
            this.Controls.Add(this.IDInputField);
            this.Name = "EnterID";
            this.Text = "EnterID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDInputField;
        private System.Windows.Forms.Button IDbtn;
    }
}