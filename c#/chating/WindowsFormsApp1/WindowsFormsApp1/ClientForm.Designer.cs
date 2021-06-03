
namespace WindowsFormsApp1
{
    partial class ClientForm
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
            this.ChatterList = new System.Windows.Forms.ListBox();
            this.ChatLog = new System.Windows.Forms.RichTextBox();
            this.InputField = new System.Windows.Forms.TextBox();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChatterList
            // 
            this.ChatterList.FormattingEnabled = true;
            this.ChatterList.ItemHeight = 12;
            this.ChatterList.Location = new System.Drawing.Point(463, 42);
            this.ChatterList.Name = "ChatterList";
            this.ChatterList.Size = new System.Drawing.Size(140, 280);
            this.ChatterList.TabIndex = 3;
            // 
            // ChatLog
            // 
            this.ChatLog.Location = new System.Drawing.Point(26, 42);
            this.ChatLog.Name = "ChatLog";
            this.ChatLog.ReadOnly = true;
            this.ChatLog.Size = new System.Drawing.Size(413, 280);
            this.ChatLog.TabIndex = 2;
            this.ChatLog.Text = "";
            // 
            // InputField
            // 
            this.InputField.Location = new System.Drawing.Point(26, 348);
            this.InputField.Name = "InputField";
            this.InputField.Size = new System.Drawing.Size(413, 21);
            this.InputField.TabIndex = 4;
            // 
            // EnterBtn
            // 
            this.EnterBtn.Location = new System.Drawing.Point(463, 346);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(62, 23);
            this.EnterBtn.TabIndex = 5;
            this.EnterBtn.Text = "전송";
            this.EnterBtn.UseVisualStyleBackColor = true;
            // 
            // QuitBtn
            // 
            this.QuitBtn.Location = new System.Drawing.Point(541, 346);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(62, 23);
            this.QuitBtn.TabIndex = 6;
            this.QuitBtn.Text = "나가기";
            this.QuitBtn.UseVisualStyleBackColor = true;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 414);
            this.Controls.Add(this.QuitBtn);
            this.Controls.Add(this.EnterBtn);
            this.Controls.Add(this.InputField);
            this.Controls.Add(this.ChatterList);
            this.Controls.Add(this.ChatLog);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ChatterList;
        private System.Windows.Forms.RichTextBox ChatLog;
        private System.Windows.Forms.TextBox InputField;
        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.Button QuitBtn;
    }
}