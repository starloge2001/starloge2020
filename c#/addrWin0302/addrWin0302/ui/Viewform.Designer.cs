
namespace addrWin0302.ui
{
    partial class Viewform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Viewform));
            this.listView1 = new System.Windows.Forms.ListView();
            this.list_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_addr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gridView1 = new Sunny.UI.UIDataGridView();
            this.grid_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewExit = new Sunny.UI.UIImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewExit)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.list_count,
            this.list_name,
            this.list_tel,
            this.list_addr,
            this.list_email});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 80);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(574, 138);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // list_count
            // 
            this.list_count.Text = "번호";
            this.list_count.Width = 40;
            // 
            // list_name
            // 
            this.list_name.Text = "이 름";
            this.list_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_name.Width = 80;
            // 
            // list_tel
            // 
            this.list_tel.Text = "전화번호";
            this.list_tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_tel.Width = 100;
            // 
            // list_addr
            // 
            this.list_addr.Text = "주 소";
            this.list_addr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_addr.Width = 250;
            // 
            // list_email
            // 
            this.list_email.Text = "email";
            this.list_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_email.Width = 100;
            // 
            // gridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.gridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridView1.BackgroundColor = System.Drawing.Color.White;
            this.gridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridView1.ColumnHeadersHeight = 32;
            this.gridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid_count,
            this.grid_name,
            this.grid_tel,
            this.grid_address,
            this.grid_email});
            this.gridView1.EnableHeadersVisualStyles = false;
            this.gridView1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.gridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.gridView1.Location = new System.Drawing.Point(12, 224);
            this.gridView1.Name = "gridView1";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.gridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridView1.RowTemplate.Height = 29;
            this.gridView1.SelectedIndex = -1;
            this.gridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView1.ShowGridLine = true;
            this.gridView1.Size = new System.Drawing.Size(574, 138);
            this.gridView1.TabIndex = 1;
            // 
            // grid_count
            // 
            this.grid_count.HeaderText = "번 호";
            this.grid_count.Name = "grid_count";
            this.grid_count.Width = 60;
            // 
            // grid_name
            // 
            this.grid_name.HeaderText = "이 름";
            this.grid_name.Name = "grid_name";
            // 
            // grid_tel
            // 
            this.grid_tel.HeaderText = "전화번호";
            this.grid_tel.Name = "grid_tel";
            // 
            // grid_address
            // 
            this.grid_address.HeaderText = "주 소";
            this.grid_address.Name = "grid_address";
            // 
            // grid_email
            // 
            this.grid_email.HeaderText = "email";
            this.grid_email.Name = "grid_email";
            // 
            // viewExit
            // 
            this.viewExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewExit.Image = ((System.Drawing.Image)(resources.GetObject("viewExit.Image")));
            this.viewExit.Location = new System.Drawing.Point(231, 377);
            this.viewExit.Name = "viewExit";
            this.viewExit.Size = new System.Drawing.Size(117, 55);
            this.viewExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.viewExit.TabIndex = 2;
            this.viewExit.TabStop = false;
            this.viewExit.Text = null;
            this.viewExit.Click += new System.EventHandler(this.viewExit_Click);
            // 
            // Viewform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.viewExit);
            this.Controls.Add(this.gridView1);
            this.Controls.Add(this.listView1);
            this.Name = "Viewform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "주소록_보기";
            this.Load += new System.EventHandler(this.Viewform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private Sunny.UI.UIDataGridView gridView1;
        private Sunny.UI.UIImageButton viewExit;
        private System.Windows.Forms.ColumnHeader list_count;
        private System.Windows.Forms.ColumnHeader list_name;
        private System.Windows.Forms.ColumnHeader list_tel;
        private System.Windows.Forms.ColumnHeader list_addr;
        private System.Windows.Forms.ColumnHeader list_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_email;
    }
}