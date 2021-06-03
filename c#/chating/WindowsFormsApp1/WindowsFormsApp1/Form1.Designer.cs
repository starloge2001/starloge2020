
namespace WindowsFormsApp1
{
    partial class ChatServerForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.myConsole = new System.Windows.Forms.RichTextBox();
            this.ClientList = new System.Windows.Forms.ListBox();
            this.ControlInput = new System.Windows.Forms.TextBox();
            this.Enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myConsole
            // 
            this.myConsole.Location = new System.Drawing.Point(22, 30);
            this.myConsole.Name = "myConsole";
            this.myConsole.ReadOnly = true;
            this.myConsole.Size = new System.Drawing.Size(413, 280);
            this.myConsole.TabIndex = 0;
            this.myConsole.Text = "";
            // 
            // ClientList
            // 
            this.ClientList.FormattingEnabled = true;
            this.ClientList.ItemHeight = 12;
            this.ClientList.Location = new System.Drawing.Point(459, 30);
            this.ClientList.Name = "ClientList";
            this.ClientList.Size = new System.Drawing.Size(140, 280);
            this.ClientList.TabIndex = 1;
            // 
            // ControlInput
            // 
            this.ControlInput.Location = new System.Drawing.Point(22, 332);
            this.ControlInput.Name = "ControlInput";
            this.ControlInput.Size = new System.Drawing.Size(492, 21);
            this.ControlInput.TabIndex = 2;
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(520, 330);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(79, 23);
            this.Enter.TabIndex = 3;
            this.Enter.Text = "전송";
            this.Enter.UseVisualStyleBackColor = true;
            // 
            // ChatServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 376);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.ControlInput);
            this.Controls.Add(this.ClientList);
            this.Controls.Add(this.myConsole);
            this.Name = "ChatServerForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox myConsole;
        private System.Windows.Forms.ListBox ClientList;
        private System.Windows.Forms.TextBox ControlInput;
        private new System.Windows.Forms.Button Enter;
    }
}

