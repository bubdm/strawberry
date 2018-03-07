namespace strawberry.ui
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.編集ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.参照RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.削除ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.名前の変更NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.コピーCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.貼り付けVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.フォルダの新規作成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.txtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.microsoftVisioDrawingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.フォルダToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.属性PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.編集ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.参照ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.新しいフォルダToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.削除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.名前の変更ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.模式切换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.详细模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.图标模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.textBox1 = new System.Windows.Forms.ToolStripTextBox();
			this.refresh_button = new System.Windows.Forms.ToolStripButton();
			this.search_textBox = new System.Windows.Forms.ToolStripTextBox();
			this.keySearch_button = new System.Windows.Forms.ToolStripButton();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
			this.contextMenuStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.treeView1.ImageIndex = 0;
			this.treeView1.ImageList = this.imageList1;
			this.treeView1.LabelEdit = true;
			this.treeView1.Location = new System.Drawing.Point(0, 0);
			this.treeView1.Name = "treeView1";
			this.treeView1.SelectedImageIndex = 0;
			this.treeView1.Size = new System.Drawing.Size(204, 334);
			this.treeView1.TabIndex = 0;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "icon1.png");
			// 
			// listView1
			// 
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
			this.listView1.ContextMenuStrip = this.contextMenuStrip1;
			this.listView1.FullRowSelect = true;
			this.listView1.HideSelection = false;
			this.listView1.LabelEdit = true;
			this.listView1.Location = new System.Drawing.Point(0, 0);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(518, 334);
			this.listView1.TabIndex = 1;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView1_AfterLabelEdit);
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listViewItem_Selected);
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
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.編集ToolStripMenuItem1,
            this.参照RToolStripMenuItem,
            this.削除ToolStripMenuItem1,
            this.名前の変更NToolStripMenuItem,
            this.コピーCToolStripMenuItem,
            this.貼り付けVToolStripMenuItem,
            this.フォルダの新規作成ToolStripMenuItem,
            this.属性PToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(185, 202);
			// 
			// 編集ToolStripMenuItem1
			// 
			this.編集ToolStripMenuItem1.Name = "編集ToolStripMenuItem1";
			this.編集ToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
			this.編集ToolStripMenuItem1.Text = "編集(E)";
			this.編集ToolStripMenuItem1.Click += new System.EventHandler(this.編集ToolStripMenuItem1_Click);
			// 
			// 参照RToolStripMenuItem
			// 
			this.参照RToolStripMenuItem.Name = "参照RToolStripMenuItem";
			this.参照RToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
			this.参照RToolStripMenuItem.Text = "参照(R)";
			// 
			// 削除ToolStripMenuItem1
			// 
			this.削除ToolStripMenuItem1.Name = "削除ToolStripMenuItem1";
			this.削除ToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
			this.削除ToolStripMenuItem1.Text = "削除(D)";
			this.削除ToolStripMenuItem1.Click += new System.EventHandler(this.削除ToolStripMenuItem1_Click);
			// 
			// 名前の変更NToolStripMenuItem
			// 
			this.名前の変更NToolStripMenuItem.Name = "名前の変更NToolStripMenuItem";
			this.名前の変更NToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
			this.名前の変更NToolStripMenuItem.Text = "名前の変更(N)";
			this.名前の変更NToolStripMenuItem.Click += new System.EventHandler(this.名前の変更NToolStripMenuItem_Click);
			// 
			// コピーCToolStripMenuItem
			// 
			this.コピーCToolStripMenuItem.Name = "コピーCToolStripMenuItem";
			this.コピーCToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
			this.コピーCToolStripMenuItem.Text = "コピー(C)";
			this.コピーCToolStripMenuItem.Click += new System.EventHandler(this.コピーCToolStripMenuItem_Click);
			// 
			// 貼り付けVToolStripMenuItem
			// 
			this.貼り付けVToolStripMenuItem.Name = "貼り付けVToolStripMenuItem";
			this.貼り付けVToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
			this.貼り付けVToolStripMenuItem.Text = "貼り付け(V)";
			this.貼り付けVToolStripMenuItem.Click += new System.EventHandler(this.貼り付けVToolStripMenuItem_Click);
			// 
			// フォルダの新規作成ToolStripMenuItem
			// 
			this.フォルダの新規作成ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtToolStripMenuItem,
            this.exToolStripMenuItem,
            this.microsoftVisioDrawingToolStripMenuItem,
            this.フォルダToolStripMenuItem});
			this.フォルダの新規作成ToolStripMenuItem.Name = "フォルダの新規作成ToolStripMenuItem";
			this.フォルダの新規作成ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
			this.フォルダの新規作成ToolStripMenuItem.Text = "フォルダの新規作成";
			//this.フォルダの新規作成ToolStripMenuItem.Click += new System.EventHandler(this.フォルダの新規作成ToolStripMenuItem_Click);
			// 
			// txtToolStripMenuItem
			// 
			this.txtToolStripMenuItem.Name = "txtToolStripMenuItem";
			this.txtToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
			this.txtToolStripMenuItem.Text = "txt";
			this.txtToolStripMenuItem.Click += new System.EventHandler(this.txtToolStripMenuItem_Click);
			// 
			// exToolStripMenuItem
			// 
			this.exToolStripMenuItem.Name = "exToolStripMenuItem";
			this.exToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
			this.exToolStripMenuItem.Text = "excle";
			this.exToolStripMenuItem.Click += new System.EventHandler(this.exToolStripMenuItem_Click);
			// 
			// microsoftVisioDrawingToolStripMenuItem
			// 
			this.microsoftVisioDrawingToolStripMenuItem.Name = "microsoftVisioDrawingToolStripMenuItem";
			this.microsoftVisioDrawingToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
			this.microsoftVisioDrawingToolStripMenuItem.Text = "Microsoft Visio Drawing";
			this.microsoftVisioDrawingToolStripMenuItem.Click += new System.EventHandler(this.microsoftVisioDrawingToolStripMenuItem_Click);
			// 
			// フォルダToolStripMenuItem
			// 
			this.フォルダToolStripMenuItem.Name = "フォルダToolStripMenuItem";
			this.フォルダToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
			this.フォルダToolStripMenuItem.Text = "フォルダ";
			this.フォルダToolStripMenuItem.Click += new System.EventHandler(this.フォルダToolStripMenuItem_Click);
			// 
			// 属性PToolStripMenuItem
			// 
			this.属性PToolStripMenuItem.Name = "属性PToolStripMenuItem";
			this.属性PToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
			this.属性PToolStripMenuItem.Text = "属性(P)";
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
            this.名前の変更ToolStripMenuItem,
            this.模式切换ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(4, 23);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(436, 26);
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
			this.新しいフォルダToolStripMenuItem.Click += new System.EventHandler(this.新しいフォルダToolStripMenuItem_Click);
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
			this.名前の変更ToolStripMenuItem.Click += new System.EventHandler(this.名前の変更ToolStripMenuItem_Click);
			// 
			// 模式切换ToolStripMenuItem
			// 
			this.模式切换ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.详细模式ToolStripMenuItem,
            this.图标模式ToolStripMenuItem});
			this.模式切换ToolStripMenuItem.Name = "模式切换ToolStripMenuItem";
			this.模式切换ToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
			this.模式切换ToolStripMenuItem.Text = "模式切换";
			// 
			// 详细模式ToolStripMenuItem
			// 
			this.详细模式ToolStripMenuItem.Name = "详细模式ToolStripMenuItem";
			this.详细模式ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.详细模式ToolStripMenuItem.Text = "详细模式";
			this.详细模式ToolStripMenuItem.Click += new System.EventHandler(this.详细模式ToolStripMenuItem_Click);
			// 
			// 图标模式ToolStripMenuItem
			// 
			this.图标模式ToolStripMenuItem.Name = "图标模式ToolStripMenuItem";
			this.图标模式ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.图标模式ToolStripMenuItem.Text = "图标模式";
			this.图标模式ToolStripMenuItem.Click += new System.EventHandler(this.图标模式ToolStripMenuItem_Click);
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
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton2.Text = "toolStripButton2";
			this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
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
			// splitContainer1
			// 
			this.splitContainer1.Location = new System.Drawing.Point(4, 52);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.treeView1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.listView1);
			this.splitContainer1.Size = new System.Drawing.Size(728, 334);
			this.splitContainer1.SplitterDistance = 206;
			this.splitContainer1.TabIndex = 10;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6});
			this.statusStrip1.Location = new System.Drawing.Point(0, 390);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(735, 23);
			this.statusStrip1.TabIndex = 11;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(134, 18);
			this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(134, 18);
			this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new System.Drawing.Size(134, 18);
			this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
			// 
			// toolStripStatusLabel4
			// 
			this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
			this.toolStripStatusLabel4.Size = new System.Drawing.Size(134, 18);
			this.toolStripStatusLabel4.Text = "toolStripStatusLabel4";
			// 
			// toolStripStatusLabel5
			// 
			this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
			this.toolStripStatusLabel5.Size = new System.Drawing.Size(134, 18);
			this.toolStripStatusLabel5.Text = "toolStripStatusLabel5";
			// 
			// toolStripStatusLabel6
			// 
			this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
			this.toolStripStatusLabel6.Size = new System.Drawing.Size(134, 18);
			this.toolStripStatusLabel6.Text = "toolStripStatusLabel6";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(735, 413);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.splitContainer1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormMain";
			this.Text = "FormMain";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.contextMenuStrip1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
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
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ToolStripMenuItem 模式切换ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 详细模式ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 图标模式ToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 編集ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem 参照RToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 削除ToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem 名前の変更NToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem コピーCToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 貼り付けVToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem フォルダの新規作成ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 属性PToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem txtToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem microsoftVisioDrawingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem フォルダToolStripMenuItem;
	}
}

