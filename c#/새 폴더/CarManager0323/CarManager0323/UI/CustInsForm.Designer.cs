
namespace CarManager0323.UI
{
    partial class CustInsForm
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
            this.btnCancel = new CxFlatUI.CxFlatRoundButton();
            this.btnSubmit = new CxFlatUI.CxFlatRoundButton();
            this.uiLabelEmail = new Sunny.UI.UILabel();
            this.uiLabelAddr = new Sunny.UI.UILabel();
            this.txtbxCustEmail = new Sunny.UI.UITextBox();
            this.uiLabelTel = new Sunny.UI.UILabel();
            this.txtbxCustAddr = new Sunny.UI.UITextBox();
            this.txtbxCustTel = new Sunny.UI.UITextBox();
            this.uiLabelName = new Sunny.UI.UILabel();
            this.txtbxCustName = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.ButtonType = CxFlatUI.ButtonType.Danger;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancel.Location = new System.Drawing.Point(305, 287);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 49);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "취소";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.ButtonType = CxFlatUI.ButtonType.Success;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSubmit.Location = new System.Drawing.Point(191, 287);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(108, 49);
            this.btnSubmit.TabIndex = 26;
            this.btnSubmit.Text = "제출";
            this.btnSubmit.TextColor = System.Drawing.Color.White;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // uiLabelEmail
            // 
            this.uiLabelEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabelEmail.Location = new System.Drawing.Point(38, 203);
            this.uiLabelEmail.Name = "uiLabelEmail";
            this.uiLabelEmail.Size = new System.Drawing.Size(100, 29);
            this.uiLabelEmail.TabIndex = 23;
            this.uiLabelEmail.Text = "메일";
            this.uiLabelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabelAddr
            // 
            this.uiLabelAddr.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabelAddr.Location = new System.Drawing.Point(38, 164);
            this.uiLabelAddr.Name = "uiLabelAddr";
            this.uiLabelAddr.Size = new System.Drawing.Size(100, 29);
            this.uiLabelAddr.TabIndex = 24;
            this.uiLabelAddr.Text = "주소";
            this.uiLabelAddr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbxCustEmail
            // 
            this.txtbxCustEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxCustEmail.FillColor = System.Drawing.Color.White;
            this.txtbxCustEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtbxCustEmail.Location = new System.Drawing.Point(173, 203);
            this.txtbxCustEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxCustEmail.Maximum = 2147483647D;
            this.txtbxCustEmail.Minimum = -2147483648D;
            this.txtbxCustEmail.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtbxCustEmail.Name = "txtbxCustEmail";
            this.txtbxCustEmail.Padding = new System.Windows.Forms.Padding(5);
            this.txtbxCustEmail.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.txtbxCustEmail.Size = new System.Drawing.Size(240, 29);
            this.txtbxCustEmail.Style = Sunny.UI.UIStyle.Green;
            this.txtbxCustEmail.TabIndex = 20;
            this.txtbxCustEmail.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabelTel
            // 
            this.uiLabelTel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabelTel.Location = new System.Drawing.Point(38, 125);
            this.uiLabelTel.Name = "uiLabelTel";
            this.uiLabelTel.Size = new System.Drawing.Size(100, 29);
            this.uiLabelTel.TabIndex = 25;
            this.uiLabelTel.Text = "전화";
            this.uiLabelTel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbxCustAddr
            // 
            this.txtbxCustAddr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxCustAddr.FillColor = System.Drawing.Color.White;
            this.txtbxCustAddr.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtbxCustAddr.Location = new System.Drawing.Point(173, 164);
            this.txtbxCustAddr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxCustAddr.Maximum = 2147483647D;
            this.txtbxCustAddr.Minimum = -2147483648D;
            this.txtbxCustAddr.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtbxCustAddr.Name = "txtbxCustAddr";
            this.txtbxCustAddr.Padding = new System.Windows.Forms.Padding(5);
            this.txtbxCustAddr.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.txtbxCustAddr.Size = new System.Drawing.Size(240, 29);
            this.txtbxCustAddr.Style = Sunny.UI.UIStyle.Green;
            this.txtbxCustAddr.TabIndex = 21;
            this.txtbxCustAddr.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtbxCustTel
            // 
            this.txtbxCustTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxCustTel.FillColor = System.Drawing.Color.White;
            this.txtbxCustTel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtbxCustTel.Location = new System.Drawing.Point(173, 125);
            this.txtbxCustTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxCustTel.Maximum = 2147483647D;
            this.txtbxCustTel.Minimum = -2147483648D;
            this.txtbxCustTel.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtbxCustTel.Name = "txtbxCustTel";
            this.txtbxCustTel.Padding = new System.Windows.Forms.Padding(5);
            this.txtbxCustTel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.txtbxCustTel.Size = new System.Drawing.Size(240, 29);
            this.txtbxCustTel.Style = Sunny.UI.UIStyle.Green;
            this.txtbxCustTel.TabIndex = 22;
            this.txtbxCustTel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabelName
            // 
            this.uiLabelName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabelName.Location = new System.Drawing.Point(38, 86);
            this.uiLabelName.Name = "uiLabelName";
            this.uiLabelName.Size = new System.Drawing.Size(100, 29);
            this.uiLabelName.TabIndex = 19;
            this.uiLabelName.Text = "이름";
            this.uiLabelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbxCustName
            // 
            this.txtbxCustName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxCustName.FillColor = System.Drawing.Color.White;
            this.txtbxCustName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtbxCustName.Location = new System.Drawing.Point(173, 86);
            this.txtbxCustName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxCustName.Maximum = 2147483647D;
            this.txtbxCustName.Minimum = -2147483648D;
            this.txtbxCustName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtbxCustName.Name = "txtbxCustName";
            this.txtbxCustName.Padding = new System.Windows.Forms.Padding(5);
            this.txtbxCustName.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.txtbxCustName.Size = new System.Drawing.Size(240, 29);
            this.txtbxCustName.Style = Sunny.UI.UIStyle.Green;
            this.txtbxCustName.TabIndex = 18;
            this.txtbxCustName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CustInsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 348);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.uiLabelEmail);
            this.Controls.Add(this.uiLabelAddr);
            this.Controls.Add(this.txtbxCustEmail);
            this.Controls.Add(this.uiLabelTel);
            this.Controls.Add(this.txtbxCustAddr);
            this.Controls.Add(this.txtbxCustTel);
            this.Controls.Add(this.uiLabelName);
            this.Controls.Add(this.txtbxCustName);
            this.Name = "CustInsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "고객 정보 추가";
            this.ResumeLayout(false);

        }

        #endregion
        private CxFlatUI.CxFlatRoundButton btnCancel;
        private CxFlatUI.CxFlatRoundButton btnSubmit;
        private Sunny.UI.UILabel uiLabelEmail;
        private Sunny.UI.UILabel uiLabelAddr;
        private Sunny.UI.UITextBox txtbxCustEmail;
        private Sunny.UI.UILabel uiLabelTel;
        private Sunny.UI.UITextBox txtbxCustAddr;
        private Sunny.UI.UITextBox txtbxCustTel;
        private Sunny.UI.UILabel uiLabelName;
        private Sunny.UI.UITextBox txtbxCustName;
    }
}