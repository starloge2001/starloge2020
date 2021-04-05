
namespace CarManager0323.UI
{
    partial class DealInsForm
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
            this.uiLabelSeller = new Sunny.UI.UILabel();
            this.uiLabelCar = new Sunny.UI.UILabel();
            this.uiLabelCustomer = new Sunny.UI.UILabel();
            this.comboBoxCustomer = new Sunny.UI.UIComboBox();
            this.comboBoxCar = new Sunny.UI.UIComboBox();
            this.comboBoxSeller = new Sunny.UI.UIComboBox();
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
            // uiLabelSeller
            // 
            this.uiLabelSeller.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabelSeller.Location = new System.Drawing.Point(38, 164);
            this.uiLabelSeller.Name = "uiLabelSeller";
            this.uiLabelSeller.Size = new System.Drawing.Size(100, 29);
            this.uiLabelSeller.TabIndex = 24;
            this.uiLabelSeller.Text = "판매자";
            this.uiLabelSeller.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabelCar
            // 
            this.uiLabelCar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabelCar.Location = new System.Drawing.Point(38, 125);
            this.uiLabelCar.Name = "uiLabelCar";
            this.uiLabelCar.Size = new System.Drawing.Size(100, 29);
            this.uiLabelCar.TabIndex = 25;
            this.uiLabelCar.Text = "차량";
            this.uiLabelCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabelCustomer
            // 
            this.uiLabelCustomer.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiLabelCustomer.Location = new System.Drawing.Point(38, 86);
            this.uiLabelCustomer.Name = "uiLabelCustomer";
            this.uiLabelCustomer.Size = new System.Drawing.Size(100, 29);
            this.uiLabelCustomer.TabIndex = 19;
            this.uiLabelCustomer.Text = "고객";
            this.uiLabelCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.FillColor = System.Drawing.Color.White;
            this.comboBoxCustomer.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.comboBoxCustomer.Location = new System.Drawing.Point(173, 86);
            this.comboBoxCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxCustomer.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboBoxCustomer.Size = new System.Drawing.Size(240, 29);
            this.comboBoxCustomer.TabIndex = 28;
            this.comboBoxCustomer.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxCar
            // 
            this.comboBoxCar.FillColor = System.Drawing.Color.White;
            this.comboBoxCar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.comboBoxCar.Location = new System.Drawing.Point(173, 125);
            this.comboBoxCar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxCar.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboBoxCar.Name = "comboBoxCar";
            this.comboBoxCar.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboBoxCar.Size = new System.Drawing.Size(240, 29);
            this.comboBoxCar.TabIndex = 29;
            this.comboBoxCar.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxSeller
            // 
            this.comboBoxSeller.FillColor = System.Drawing.Color.White;
            this.comboBoxSeller.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.comboBoxSeller.Location = new System.Drawing.Point(173, 164);
            this.comboBoxSeller.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSeller.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboBoxSeller.Name = "comboBoxSeller";
            this.comboBoxSeller.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboBoxSeller.Size = new System.Drawing.Size(240, 29);
            this.comboBoxSeller.TabIndex = 29;
            this.comboBoxSeller.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DealInsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 348);
            this.Controls.Add(this.comboBoxSeller);
            this.Controls.Add(this.comboBoxCar);
            this.Controls.Add(this.comboBoxCustomer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.uiLabelSeller);
            this.Controls.Add(this.uiLabelCar);
            this.Controls.Add(this.uiLabelCustomer);
            this.Name = "DealInsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "거래 추가 정보";
            this.ResumeLayout(false);

        }

        #endregion
        private CxFlatUI.CxFlatRoundButton btnCancel;
        private CxFlatUI.CxFlatRoundButton btnSubmit;
        private Sunny.UI.UILabel uiLabelSeller;
        private Sunny.UI.UILabel uiLabelCar;
        private Sunny.UI.UILabel uiLabelCustomer;
        private Sunny.UI.UIComboBox comboBoxCustomer;
        private Sunny.UI.UIComboBox comboBoxCar;
        private Sunny.UI.UIComboBox comboBoxSeller;
    }
}