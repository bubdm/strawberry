namespace strawberry
{
	partial class FormMain
	{
		/// <summary>
		/// 必要なデザイナ変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナで生成されたコード

		/// <summary>
		/// デザイナ サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディタで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.編集ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.参照ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.新しいフォルダToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.削除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.名前の変更ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.textBox1 = new System.Windows.Forms.ToolStripTextBox();
			this.refresh_button = new System.Windows.Forms.ToolStripButton();
			this.search_textBox = new System.Windows.Forms.ToolStripTextBox();
			this.keySearch_button = new System.Windows.Forms.ToolStripButton();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(4, 52);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(167, 337);
			this.treeView1.TabIndex = 0;
			this.treeView1.Click += new System.EventHandler(this.treeView1_Click);
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
			this.listView1.FullRowSelect = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(177, 52);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(555, 337);
			this.listView1.TabIndex = 1;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "名前";
			this.columnHeader1.Width = 90;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "ユーザ";
			this.columnHeader2.Width = 65;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "状態";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "リビジョン";
			this.columnHeader4.Width = 83;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "更新日時";
			this.columnHeader5.Width = 120;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "サイズ(KB)";
			this.columnHeader6.Width = 90;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.編集ToolStripMenuItem,
            this.参照ToolStripMenuItem,
            this.新しいフォルダToolStripMenuItem,
            this.削除ToolStripMenuItem,
            this.設定ToolStripMenuItem,
            this.名前の変更ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(4, 23);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(460, 26);
			this.menuStrip1.TabIndex = 8;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 編集ToolStripMenuItem
			// 
			this.編集ToolStripMenuItem.Name = "編集ToolStripMenuItem";
			this.編集ToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
			this.編集ToolStripMenuItem.Text = "編集";
			// 
			// 参照ToolStripMenuItem
			// 
			this.参照ToolStripMenuItem.Name = "参照ToolStripMenuItem";
			this.参照ToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
			this.参照ToolStripMenuItem.Text = "参照";
			// 
			// 新しいフォルダToolStripMenuItem
			// 
			this.新しいフォルダToolStripMenuItem.Name = "新しいフォルダToolStripMenuItem";
			this.新しいフォルダToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
			this.新しいフォルダToolStripMenuItem.Text = "新しいフォルダ";
			// 
			// 削除ToolStripMenuItem
			// 
			this.削除ToolStripMenuItem.Name = "削除ToolStripMenuItem";
			this.削除ToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
			this.削除ToolStripMenuItem.Text = "削除";
			this.削除ToolStripMenuItem.Click += new System.EventHandler(this.削除ToolStripMenuItem_Click);
			// 
			// 設定ToolStripMenuItem
			// 
			this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
			this.設定ToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
			this.設定ToolStripMenuItem.Text = "設定";
			// 
			// 名前の変更ToolStripMenuItem
			// 
			this.名前の変更ToolStripMenuItem.Name = "名前の変更ToolStripMenuItem";
			this.名前の変更ToolStripMenuItem.Size = new System.Drawing.Size(80, 22);
			this.名前の変更ToolStripMenuItem.Text = "名前の変更";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.textBox1,
            this.refresh_button,
            this.search_textBox,
            this.keySearch_button});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(735, 25);
			this.toolStrip1.TabIndex = 9;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "toolStripButton1";
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton2.Text = "toolStripButton2";
			// 
			// textBox1
			// 
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(412, 25);
			this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
			// 
			// refresh_button
			// 
			this.refresh_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.refresh_button.Image = ((System.Drawing.Image)(resources.GetObject("refresh_button.Image")));
			this.refresh_button.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.refresh_button.Name = "refresh_button";
			this.refresh_button.Size = new System.Drawing.Size(23, 22);
			this.refresh_button.Text = "toolStripButton3";
			this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
			// 
			// search_textBox
			// 
			this.search_textBox.Name = "search_textBox";
			this.search_textBox.Size = new System.Drawing.Size(200, 25);
			this.search_textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.search_textBox_KeyUp);
			// 
			// keySearch_button
			// 
			this.keySearch_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.keySearch_button.Image = ((System.Drawing.Image)(resources.GetObject("keySearch_button.Image")));
			this.keySearch_button.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.keySearch_button.Name = "keySearch_button";
			this.keySearch_button.Size = new System.Drawing.Size(23, 22);
			this.keySearch_button.Text = "toolStripButton4";
			this.keySearch_button.Click += new System.EventHandler(this.keySearch_button_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(735, 429);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.treeView1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormMain";
			this.Text = "FormMain";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 編集ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 参照ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 新しいフォルダToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 削除ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 名前の変更ToolStripMenuItem;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripTextBox textBox1;
		private System.Windows.Forms.ToolStripButton refresh_button;
		private System.Windows.Forms.ToolStripTextBox search_textBox;
		private System.Windows.Forms.ToolStripButton keySearch_button;
	}
}

