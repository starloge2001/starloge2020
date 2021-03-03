
namespace addrWin0302
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.addrAdd = new CxFlatUI.CxFlatRoundButton();
            this.addrView = new CxFlatUI.CxFlatRoundButton();
            this.addrAddRand = new CxFlatUI.CxFlatRoundButton();
            this.addrUpdate = new CxFlatUI.CxFlatRoundButton();
            this.addrAllDel = new CxFlatUI.CxFlatRoundButton();
            this.addrDel = new CxFlatUI.CxFlatRoundButton();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.cxFlatPictureBox1 = new CxFlatUI.CxFlatPictureBox();
            this.addrOff = new Sunny.UI.UIImageButton();
            this.addrHelp = new Sunny.UI.UIImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addrOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addrHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // addrAdd
            // 
            this.addrAdd.BackColor = System.Drawing.Color.Transparent;
            this.addrAdd.ButtonType = CxFlatUI.ButtonType.Primary;
            this.addrAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addrAdd.Location = new System.Drawing.Point(240, 122);
            this.addrAdd.Name = "addrAdd";
            this.addrAdd.Size = new System.Drawing.Size(157, 56);
            this.addrAdd.TabIndex = 0;
            this.addrAdd.Text = "주소록 추가";
            this.addrAdd.TextColor = System.Drawing.Color.White;
            this.addrAdd.Click += new System.EventHandler(this.addrAdd_Click);
            // 
            // addrView
            // 
            this.addrView.BackColor = System.Drawing.Color.Transparent;
            this.addrView.ButtonType = CxFlatUI.ButtonType.Primary;
            this.addrView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addrView.Location = new System.Drawing.Point(240, 184);
            this.addrView.Name = "addrView";
            this.addrView.Size = new System.Drawing.Size(157, 56);
            this.addrView.TabIndex = 1;
            this.addrView.Text = "주소록 보기";
            this.addrView.TextColor = System.Drawing.Color.White;
            this.addrView.Click += new System.EventHandler(this.addrView_Click);
            // 
            // addrAddRand
            // 
            this.addrAddRand.BackColor = System.Drawing.Color.Transparent;
            this.addrAddRand.ButtonType = CxFlatUI.ButtonType.Primary;
            this.addrAddRand.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addrAddRand.Location = new System.Drawing.Point(240, 246);
            this.addrAddRand.Name = "addrAddRand";
            this.addrAddRand.Size = new System.Drawing.Size(157, 56);
            this.addrAddRand.TabIndex = 2;
            this.addrAddRand.Text = "랜덤 데이터 추가";
            this.addrAddRand.TextColor = System.Drawing.Color.White;
            this.addrAddRand.Click += new System.EventHandler(this.addrAddRand_Click);
            // 
            // addrUpdate
            // 
            this.addrUpdate.BackColor = System.Drawing.Color.Transparent;
            this.addrUpdate.ButtonType = CxFlatUI.ButtonType.Primary;
            this.addrUpdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addrUpdate.Location = new System.Drawing.Point(415, 246);
            this.addrUpdate.Name = "addrUpdate";
            this.addrUpdate.Size = new System.Drawing.Size(157, 56);
            this.addrUpdate.TabIndex = 3;
            this.addrUpdate.Text = "주소록 수정";
            this.addrUpdate.TextColor = System.Drawing.Color.White;
            this.addrUpdate.Click += new System.EventHandler(this.addrUpdate_Click);
            // 
            // addrAllDel
            // 
            this.addrAllDel.BackColor = System.Drawing.Color.Transparent;
            this.addrAllDel.ButtonType = CxFlatUI.ButtonType.Primary;
            this.addrAllDel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addrAllDel.Location = new System.Drawing.Point(415, 184);
            this.addrAllDel.Name = "addrAllDel";
            this.addrAllDel.Size = new System.Drawing.Size(157, 56);
            this.addrAllDel.TabIndex = 4;
            this.addrAllDel.Text = "주소록 전체 삭제";
            this.addrAllDel.TextColor = System.Drawing.Color.White;
            this.addrAllDel.Click += new System.EventHandler(this.addrAllDel_Click);
            // 
            // addrDel
            // 
            this.addrDel.BackColor = System.Drawing.Color.Transparent;
            this.addrDel.ButtonType = CxFlatUI.ButtonType.Primary;
            this.addrDel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addrDel.Location = new System.Drawing.Point(415, 122);
            this.addrDel.Name = "addrDel";
            this.addrDel.Size = new System.Drawing.Size(157, 56);
            this.addrDel.TabIndex = 5;
            this.addrDel.Text = "주소록 삭제";
            this.addrDel.TextColor = System.Drawing.Color.White;
            this.addrDel.Click += new System.EventHandler(this.addrDel_Click);
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.White;
            this.uiSymbolLabel1.Location = new System.Drawing.Point(12, 6);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(222, 35);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 62141;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.SystemColors.ButtonHighlight;
            this.uiSymbolLabel1.TabIndex = 6;
            this.uiSymbolLabel1.Text = "주소록 관리 프로그램 1.0";
            // 
            // cxFlatPictureBox1
            // 
            this.cxFlatPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("cxFlatPictureBox1.Image")));
            this.cxFlatPictureBox1.Location = new System.Drawing.Point(-1, 64);
            this.cxFlatPictureBox1.Name = "cxFlatPictureBox1";
            this.cxFlatPictureBox1.Size = new System.Drawing.Size(212, 305);
            this.cxFlatPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cxFlatPictureBox1.TabIndex = 7;
            this.cxFlatPictureBox1.TabStop = false;
            // 
            // addrOff
            // 
            this.addrOff.BackColor = System.Drawing.Color.Transparent;
            this.addrOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addrOff.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addrOff.ForeColor = System.Drawing.Color.Red;
            this.addrOff.Image = ((System.Drawing.Image)(resources.GetObject("addrOff.Image")));
            this.addrOff.Location = new System.Drawing.Point(519, 38);
            this.addrOff.Name = "addrOff";
            this.addrOff.Size = new System.Drawing.Size(53, 48);
            this.addrOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.addrOff.TabIndex = 10;
            this.addrOff.TabStop = false;
            this.addrOff.Text = null;
            this.addrOff.Click += new System.EventHandler(this.addrOff_Click);
            // 
            // addrHelp
            // 
            this.addrHelp.BackColor = System.Drawing.Color.Transparent;
            this.addrHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addrHelp.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addrHelp.Image = ((System.Drawing.Image)(resources.GetObject("addrHelp.Image")));
            this.addrHelp.Location = new System.Drawing.Point(464, 38);
            this.addrHelp.Name = "addrHelp";
            this.addrHelp.Size = new System.Drawing.Size(54, 48);
            this.addrHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.addrHelp.TabIndex = 11;
            this.addrHelp.TabStop = false;
            this.addrHelp.Text = null;
            this.addrHelp.Click += new System.EventHandler(this.addrHelp_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(598, 368);
            this.Controls.Add(this.addrHelp);
            this.Controls.Add(this.addrOff);
            this.Controls.Add(this.cxFlatPictureBox1);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.addrDel);
            this.Controls.Add(this.addrAllDel);
            this.Controls.Add(this.addrUpdate);
            this.Controls.Add(this.addrAddRand);
            this.Controls.Add(this.addrView);
            this.Controls.Add(this.addrAdd);
            this.Name = "Mainform";
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addrOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addrHelp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatRoundButton addrAdd;
        private CxFlatUI.CxFlatRoundButton addrView;
        private CxFlatUI.CxFlatRoundButton addrAddRand;
        private CxFlatUI.CxFlatRoundButton addrUpdate;
        private CxFlatUI.CxFlatRoundButton addrAllDel;
        private CxFlatUI.CxFlatRoundButton addrDel;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox1;
        private Sunny.UI.UIImageButton addrOff;
        private Sunny.UI.UIImageButton addrHelp;
    }
}

