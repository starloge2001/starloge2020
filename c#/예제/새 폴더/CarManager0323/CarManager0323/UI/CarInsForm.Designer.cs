
namespace CarManager0323.UI
{
    partial class CarInsForm
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
            this.uiLabelCompany = new Sunny.UI.UILabel();
            this.uiLabelColor = new Sunny.UI.UILabel();
            this.txtbxCarCompany = new Sunny.UI.UITextBox();
            this.uiLabelPrice = new Sunny.UI.UILabel();
            this.txtbxCarColor = new Sunny.UI.UITextBox();
            this.txtbxCarPrice = new Sunny.UI.UITextBox();
            this.uiLabelModel = new Sunny.UI.UILabel();
            this.txtbxCarModel = new Sunny.UI.UITextBox();
            this.uiLabelYear = new Sunny.UI.UILabel();
            this.txtbxCarYear = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.ButtonType = CxFlatUI.ButtonType.Danger;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancel.Location = new System.Drawing.Point(305, 287);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 49);
            this.btnCancel.TabIndex = 15;
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
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "제출";
            this.btnSubmit.TextColor = System.Drawing.Color.White;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // uiLabelCompany
            // 
            this.uiLabelCompany.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabelCompany.Location = new System.Drawing.Point(38, 203);
            this.uiLabelCompany.Name = "uiLabelCompany";
            this.uiLabelCompany.Size = new System.Drawing.Size(100, 29);
            this.uiLabelCompany.TabIndex = 11;
            this.uiLabelCompany.Text = "제조";
            this.uiLabelCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabelColor
            // 
            this.uiLabelColor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabelColor.Location = new System.Drawing.Point(38, 164);
            this.uiLabelColor.Name = "uiLabelColor";
            this.uiLabelColor.Size = new System.Drawing.Size(100, 29);
            this.uiLabelColor.TabIndex = 12;
            this.uiLabelColor.Text = "색상";
            this.uiLabelColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbxCarCompany
            // 
            this.txtbxCarCompany.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxCarCompany.FillColor = System.Drawing.Color.White;
            this.txtbxCarCompany.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtbxCarCompany.Location = new System.Drawing.Point(173, 203);
            this.txtbxCarCompany.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxCarCompany.Maximum = 2147483647D;
            this.txtbxCarCompany.Minimum = -2147483648D;
            this.txtbxCarCompany.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtbxCarCompany.Name = "txtbxCarCompany";
            this.txtbxCarCompany.Padding = new System.Windows.Forms.Padding(5);
            this.txtbxCarCompany.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.txtbxCarCompany.Size = new System.Drawing.Size(240, 29);
            this.txtbxCarCompany.Style = Sunny.UI.UIStyle.Green;
            this.txtbxCarCompany.TabIndex = 8;
            this.txtbxCarCompany.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabelPrice
            // 
            this.uiLabelPrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabelPrice.Location = new System.Drawing.Point(38, 125);
            this.uiLabelPrice.Name = "uiLabelPrice";
            this.uiLabelPrice.Size = new System.Drawing.Size(100, 29);
            this.uiLabelPrice.TabIndex = 13;
            this.uiLabelPrice.Text = "가격";
            this.uiLabelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbxCarColor
            // 
            this.txtbxCarColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxCarColor.FillColor = System.Drawing.Color.White;
            this.txtbxCarColor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtbxCarColor.Location = new System.Drawing.Point(173, 164);
            this.txtbxCarColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxCarColor.Maximum = 2147483647D;
            this.txtbxCarColor.Minimum = -2147483648D;
            this.txtbxCarColor.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtbxCarColor.Name = "txtbxCarColor";
            this.txtbxCarColor.Padding = new System.Windows.Forms.Padding(5);
            this.txtbxCarColor.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.txtbxCarColor.Size = new System.Drawing.Size(240, 29);
            this.txtbxCarColor.Style = Sunny.UI.UIStyle.Green;
            this.txtbxCarColor.TabIndex = 9;
            this.txtbxCarColor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtbxCarPrice
            // 
            this.txtbxCarPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxCarPrice.FillColor = System.Drawing.Color.White;
            this.txtbxCarPrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtbxCarPrice.Location = new System.Drawing.Point(173, 125);
            this.txtbxCarPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxCarPrice.Maximum = 2147483647D;
            this.txtbxCarPrice.Minimum = -2147483648D;
            this.txtbxCarPrice.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtbxCarPrice.Name = "txtbxCarPrice";
            this.txtbxCarPrice.Padding = new System.Windows.Forms.Padding(5);
            this.txtbxCarPrice.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.txtbxCarPrice.Size = new System.Drawing.Size(240, 29);
            this.txtbxCarPrice.Style = Sunny.UI.UIStyle.Green;
            this.txtbxCarPrice.TabIndex = 10;
            this.txtbxCarPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabelModel
            // 
            this.uiLabelModel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabelModel.Location = new System.Drawing.Point(38, 86);
            this.uiLabelModel.Name = "uiLabelModel";
            this.uiLabelModel.Size = new System.Drawing.Size(100, 29);
            this.uiLabelModel.TabIndex = 7;
            this.uiLabelModel.Text = "모델";
            this.uiLabelModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbxCarModel
            // 
            this.txtbxCarModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxCarModel.FillColor = System.Drawing.Color.White;
            this.txtbxCarModel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtbxCarModel.Location = new System.Drawing.Point(173, 86);
            this.txtbxCarModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxCarModel.Maximum = 2147483647D;
            this.txtbxCarModel.Minimum = -2147483648D;
            this.txtbxCarModel.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtbxCarModel.Name = "txtbxCarModel";
            this.txtbxCarModel.Padding = new System.Windows.Forms.Padding(5);
            this.txtbxCarModel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.txtbxCarModel.Size = new System.Drawing.Size(240, 29);
            this.txtbxCarModel.Style = Sunny.UI.UIStyle.Green;
            this.txtbxCarModel.TabIndex = 6;
            this.txtbxCarModel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabelYear
            // 
            this.uiLabelYear.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabelYear.Location = new System.Drawing.Point(38, 243);
            this.uiLabelYear.Name = "uiLabelYear";
            this.uiLabelYear.Size = new System.Drawing.Size(100, 29);
            this.uiLabelYear.TabIndex = 17;
            this.uiLabelYear.Text = "연식";
            this.uiLabelYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbxCarYear
            // 
            this.txtbxCarYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxCarYear.FillColor = System.Drawing.Color.White;
            this.txtbxCarYear.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtbxCarYear.Location = new System.Drawing.Point(173, 243);
            this.txtbxCarYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxCarYear.Maximum = 2147483647D;
            this.txtbxCarYear.Minimum = -2147483648D;
            this.txtbxCarYear.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtbxCarYear.Name = "txtbxCarYear";
            this.txtbxCarYear.Padding = new System.Windows.Forms.Padding(5);
            this.txtbxCarYear.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.txtbxCarYear.Size = new System.Drawing.Size(240, 29);
            this.txtbxCarYear.Style = Sunny.UI.UIStyle.Green;
            this.txtbxCarYear.TabIndex = 16;
            this.txtbxCarYear.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CarInsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 348);
            this.Controls.Add(this.uiLabelYear);
            this.Controls.Add(this.txtbxCarYear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.uiLabelCompany);
            this.Controls.Add(this.uiLabelColor);
            this.Controls.Add(this.txtbxCarCompany);
            this.Controls.Add(this.uiLabelPrice);
            this.Controls.Add(this.txtbxCarColor);
            this.Controls.Add(this.txtbxCarPrice);
            this.Controls.Add(this.uiLabelModel);
            this.Controls.Add(this.txtbxCarModel);
            this.Name = "CarInsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "차량 정보 추가";
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatRoundButton btnCancel;
        private CxFlatUI.CxFlatRoundButton btnSubmit;
        private Sunny.UI.UILabel uiLabelCompany;
        private Sunny.UI.UILabel uiLabelColor;
        private Sunny.UI.UITextBox txtbxCarCompany;
        private Sunny.UI.UILabel uiLabelPrice;
        private Sunny.UI.UITextBox txtbxCarColor;
        private Sunny.UI.UITextBox txtbxCarPrice;
        private Sunny.UI.UILabel uiLabelModel;
        private Sunny.UI.UITextBox txtbxCarModel;
        private Sunny.UI.UILabel uiLabelYear;
        private Sunny.UI.UITextBox txtbxCarYear;
    }
}