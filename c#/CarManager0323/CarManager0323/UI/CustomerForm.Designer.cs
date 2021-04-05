
namespace CarManager0323.UI
{
    partial class CustomerForm
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
            this.custCancel = new Sunny.UI.UISymbolButton();
            this.custOK = new Sunny.UI.UISymbolButton();
            this.custTel = new Sunny.UI.UITextBox();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.custEmail = new Sunny.UI.UITextBox();
            this.custAddr = new Sunny.UI.UITextBox();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.custName = new Sunny.UI.UITextBox();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.SuspendLayout();
            // 
            // custCancel
            // 
            this.custCancel.BackColor = System.Drawing.Color.Transparent;
            this.custCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custCancel.FillColor = System.Drawing.Color.Red;
            this.custCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custCancel.IsCircle = true;
            this.custCancel.Location = new System.Drawing.Point(279, 369);
            this.custCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.custCancel.Name = "custCancel";
            this.custCancel.RectColor = System.Drawing.Color.Red;
            this.custCancel.Size = new System.Drawing.Size(50, 50);
            this.custCancel.Style = Sunny.UI.UIStyle.Custom;
            this.custCancel.Symbol = 61453;
            this.custCancel.SymbolSize = 30;
            this.custCancel.TabIndex = 28;
            this.custCancel.Click += new System.EventHandler(this.custCancel_Click);
            // 
            // custOK
            // 
            this.custOK.BackColor = System.Drawing.Color.Transparent;
            this.custOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.custOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custOK.IsCircle = true;
            this.custOK.Location = new System.Drawing.Point(170, 369);
            this.custOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.custOK.Name = "custOK";
            this.custOK.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.custOK.Size = new System.Drawing.Size(50, 50);
            this.custOK.Style = Sunny.UI.UIStyle.Custom;
            this.custOK.SymbolSize = 30;
            this.custOK.TabIndex = 27;
            this.custOK.Click += new System.EventHandler(this.custOK_Click);
            // 
            // custTel
            // 
            this.custTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.custTel.FillColor = System.Drawing.Color.White;
            this.custTel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custTel.Location = new System.Drawing.Point(239, 145);
            this.custTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custTel.Maximum = 2147483647D;
            this.custTel.Minimum = -2147483648D;
            this.custTel.MinimumSize = new System.Drawing.Size(1, 1);
            this.custTel.Name = "custTel";
            this.custTel.Padding = new System.Windows.Forms.Padding(5);
            this.custTel.Size = new System.Drawing.Size(182, 29);
            this.custTel.TabIndex = 24;
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel3.Location = new System.Drawing.Point(62, 145);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(170, 29);
            this.uiSymbolLabel3.Symbol = 57488;
            this.uiSymbolLabel3.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel3.TabIndex = 30;
            this.uiSymbolLabel3.Text = "전 화";
            // 
            // custEmail
            // 
            this.custEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.custEmail.FillColor = System.Drawing.Color.White;
            this.custEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custEmail.Location = new System.Drawing.Point(239, 271);
            this.custEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custEmail.Maximum = 2147483647D;
            this.custEmail.Minimum = -2147483648D;
            this.custEmail.MinimumSize = new System.Drawing.Size(1, 1);
            this.custEmail.Name = "custEmail";
            this.custEmail.Padding = new System.Windows.Forms.Padding(5);
            this.custEmail.Size = new System.Drawing.Size(182, 29);
            this.custEmail.TabIndex = 26;
            // 
            // custAddr
            // 
            this.custAddr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.custAddr.FillColor = System.Drawing.Color.White;
            this.custAddr.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custAddr.Location = new System.Drawing.Point(239, 206);
            this.custAddr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custAddr.Maximum = 2147483647D;
            this.custAddr.Minimum = -2147483648D;
            this.custAddr.MinimumSize = new System.Drawing.Size(1, 1);
            this.custAddr.Name = "custAddr";
            this.custAddr.Padding = new System.Windows.Forms.Padding(5);
            this.custAddr.Size = new System.Drawing.Size(182, 29);
            this.custAddr.TabIndex = 25;
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel4.Location = new System.Drawing.Point(62, 271);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(170, 29);
            this.uiSymbolLabel4.Symbol = 61946;
            this.uiSymbolLabel4.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel4.TabIndex = 31;
            this.uiSymbolLabel4.Text = "이메일";
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(62, 206);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(170, 29);
            this.uiSymbolLabel2.Symbol = 61649;
            this.uiSymbolLabel2.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel2.TabIndex = 32;
            this.uiSymbolLabel2.Text = "주 소";
            // 
            // custName
            // 
            this.custName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.custName.FillColor = System.Drawing.Color.White;
            this.custName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custName.Location = new System.Drawing.Point(239, 84);
            this.custName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custName.Maximum = 2147483647D;
            this.custName.Minimum = -2147483648D;
            this.custName.MinimumSize = new System.Drawing.Size(1, 1);
            this.custName.Name = "custName";
            this.custName.Padding = new System.Windows.Forms.Padding(5);
            this.custName.Size = new System.Drawing.Size(182, 29);
            this.custName.TabIndex = 23;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(62, 84);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(170, 29);
            this.uiSymbolLabel1.Symbol = 62144;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel1.TabIndex = 29;
            this.uiSymbolLabel1.Text = "이 름";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 434);
            this.Controls.Add(this.custCancel);
            this.Controls.Add(this.custOK);
            this.Controls.Add(this.custTel);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.custEmail);
            this.Controls.Add(this.custAddr);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.custName);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "customerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton custCancel;
        private Sunny.UI.UISymbolButton custOK;
        private Sunny.UI.UITextBox custTel;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UITextBox custEmail;
        private Sunny.UI.UITextBox custAddr;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UITextBox custName;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
    }
}