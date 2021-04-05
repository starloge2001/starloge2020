
namespace CarManager0323.UI
{
    partial class SellerInsForm
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
            this.uiLabelOfficeName = new Sunny.UI.UILabel();
            this.txtbxSellerOfficeName = new Sunny.UI.UITextBox();
            this.btnCancel = new CxFlatUI.CxFlatRoundButton();
            this.btnSubmit = new CxFlatUI.CxFlatRoundButton();
            this.uiLabelJikwi = new Sunny.UI.UILabel();
            this.uiLabelEmail = new Sunny.UI.UILabel();
            this.txtbxSellerJikwi = new Sunny.UI.UITextBox();
            this.uiLabelTel = new Sunny.UI.UILabel();
            this.txtbxSellerEmail = new Sunny.UI.UITextBox();
            this.txtbxSellerTel = new Sunny.UI.UITextBox();
            this.uiLabelName = new Sunny.UI.UILabel();
            this.txtbxSellerName = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // uiLabelOfficeName
            // 
            this.uiLabelOfficeName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabelOfficeName.Location = new System.Drawing.Point(38, 243);
            this.uiLabelOfficeName.Name = "uiLabelOfficeName";
            this.uiLabelOfficeName.Size = new System.Drawing.Size(100, 29);
            this.uiLabelOfficeName.TabIndex = 29;
            this.uiLabelOfficeName.Text = "????";
            this.uiLabelOfficeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbxSellerOfficeName
            // 
            this.txtbxSellerOfficeName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxSellerOfficeName.FillColor = System.Drawing.Color.White;
            this.txtbxSellerOfficeName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtbxSellerOfficeName.Location = new System.Drawing.Point(173, 243);
            this.txtbxSellerOfficeName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxSellerOfficeName.Maximum = 2147483647D;
            this.txtbxSellerOfficeName.Minimum = -2147483648D;
            this.txtbxSellerOfficeName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtbxSellerOfficeName.Name = "txtbxSellerOfficeName";
            this.txtbxSellerOfficeName.Padding = new System.Windows.Forms.Padding(5);
            this.txtbxSellerOfficeName.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.txtbxSellerOfficeName.Size = new System.Drawing.Size(240, 29);
            this.txtbxSellerOfficeName.Style = Sunny.UI.UIStyle.Green;
            this.txtbxSellerOfficeName.TabIndex = 28;
            this.txtbxSellerOfficeName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
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
            // uiLabelJikwi
            // 
            this.uiLabelJikwi.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabelJikwi.Location = new System.Drawing.Point(38, 203);
            this.uiLabelJikwi.Name = "uiLabelJikwi";
            this.uiLabelJikwi.Size = new System.Drawing.Size(100, 29);
            this.uiLabelJikwi.TabIndex = 23;
            this.uiLabelJikwi.Text = "직위";
            this.uiLabelJikwi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabelEmail
            // 
            this.uiLabelEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabelEmail.Location = new System.Drawing.Point(38, 164);
            this.uiLabelEmail.Name = "uiLabelEmail";
            this.uiLabelEmail.Size = new System.Drawing.Size(100, 29);
            this.uiLabelEmail.TabIndex = 24;
            this.uiLabelEmail.Text = "메일";
            this.uiLabelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbxSellerJikwi
            // 
            this.txtbxSellerJikwi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxSellerJikwi.FillColor = System.Drawing.Color.White;
            this.txtbxSellerJikwi.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtbxSellerJikwi.Location = new System.Drawing.Point(173, 203);
            this.txtbxSellerJikwi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxSellerJikwi.Maximum = 2147483647D;
            this.txtbxSellerJikwi.Minimum = -2147483648D;
            this.txtbxSellerJikwi.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtbxSellerJikwi.Name = "txtbxSellerJikwi";
            this.txtbxSellerJikwi.Padding = new System.Windows.Forms.Padding(5);
            this.txtbxSellerJikwi.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.txtbxSellerJikwi.Size = new System.Drawing.Size(240, 29);
            this.txtbxSellerJikwi.Style = Sunny.UI.UIStyle.Green;
            this.txtbxSellerJikwi.TabIndex = 20;
            this.txtbxSellerJikwi.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
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
            // txtbxSellerEmail
            // 
            this.txtbxSellerEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxSellerEmail.FillColor = System.Drawing.Color.White;
            this.txtbxSellerEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtbxSellerEmail.Location = new System.Drawing.Point(173, 164);
            this.txtbxSellerEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxSellerEmail.Maximum = 2147483647D;
            this.txtbxSellerEmail.Minimum = -2147483648D;
            this.txtbxSellerEmail.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtbxSellerEmail.Name = "txtbxSellerEmail";
            this.txtbxSellerEmail.Padding = new System.Windows.Forms.Padding(5);
            this.txtbxSellerEmail.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.txtbxSellerEmail.Size = new System.Drawing.Size(240, 29);
            this.txtbxSellerEmail.Style = Sunny.UI.UIStyle.Green;
            this.txtbxSellerEmail.TabIndex = 21;
            this.txtbxSellerEmail.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtbxSellerTel
            // 
            this.txtbxSellerTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxSellerTel.FillColor = System.Drawing.Color.White;
            this.txtbxSellerTel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtbxSellerTel.Location = new System.Drawing.Point(173, 125);
            this.txtbxSellerTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxSellerTel.Maximum = 2147483647D;
            this.txtbxSellerTel.Minimum = -2147483648D;
            this.txtbxSellerTel.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtbxSellerTel.Name = "txtbxSellerTel";
            this.txtbxSellerTel.Padding = new System.Windows.Forms.Padding(5);
            this.txtbxSellerTel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.txtbxSellerTel.Size = new System.Drawing.Size(240, 29);
            this.txtbxSellerTel.Style = Sunny.UI.UIStyle.Green;
            this.txtbxSellerTel.TabIndex = 22;
            this.txtbxSellerTel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
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
            // txtbxSellerName
            // 
            this.txtbxSellerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxSellerName.FillColor = System.Drawing.Color.White;
            this.txtbxSellerName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtbxSellerName.Location = new System.Drawing.Point(173, 86);
            this.txtbxSellerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxSellerName.Maximum = 2147483647D;
            this.txtbxSellerName.Minimum = -2147483648D;
            this.txtbxSellerName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtbxSellerName.Name = "txtbxSellerName";
            this.txtbxSellerName.Padding = new System.Windows.Forms.Padding(5);
            this.txtbxSellerName.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.txtbxSellerName.Size = new System.Drawing.Size(240, 29);
            this.txtbxSellerName.Style = Sunny.UI.UIStyle.Green;
            this.txtbxSellerName.TabIndex = 18;
            this.txtbxSellerName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SellerInsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 348);
            this.Controls.Add(this.uiLabelOfficeName);
            this.Controls.Add(this.txtbxSellerOfficeName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.uiLabelJikwi);
            this.Controls.Add(this.uiLabelEmail);
            this.Controls.Add(this.txtbxSellerJikwi);
            this.Controls.Add(this.uiLabelTel);
            this.Controls.Add(this.txtbxSellerEmail);
            this.Controls.Add(this.txtbxSellerTel);
            this.Controls.Add(this.uiLabelName);
            this.Controls.Add(this.txtbxSellerName);
            this.Name = "SellerInsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "판매자 추가 정보";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabelOfficeName;
        private Sunny.UI.UITextBox txtbxSellerOfficeName;
        private CxFlatUI.CxFlatRoundButton btnCancel;
        private CxFlatUI.CxFlatRoundButton btnSubmit;
        private Sunny.UI.UILabel uiLabelJikwi;
        private Sunny.UI.UILabel uiLabelEmail;
        private Sunny.UI.UITextBox txtbxSellerJikwi;
        private Sunny.UI.UILabel uiLabelTel;
        private Sunny.UI.UITextBox txtbxSellerEmail;
        private Sunny.UI.UITextBox txtbxSellerTel;
        private Sunny.UI.UILabel uiLabelName;
        private Sunny.UI.UITextBox txtbxSellerName;
    }
}