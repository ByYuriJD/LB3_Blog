namespace LB3_Blog {
	partial class FormMain {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			panelTop = new Panel();
			button1 = new Button();
			panelLeft = new Panel();
			dataGridViewUsers = new DataGridView();
			panel1 = new Panel();
			dataGridViewPosts = new DataGridView();
			panelTop.SuspendLayout();
			panelLeft.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridViewPosts).BeginInit();
			SuspendLayout();
			// 
			// panelTop
			// 
			panelTop.Controls.Add(button1);
			panelTop.Dock = DockStyle.Top;
			panelTop.Location = new Point(0, 0);
			panelTop.Name = "panelTop";
			panelTop.Padding = new Padding(10);
			panelTop.Size = new Size(800, 71);
			panelTop.TabIndex = 1;
			// 
			// button1
			// 
			button1.Dock = DockStyle.Left;
			button1.Font = new Font("Segoe UI", 12F);
			button1.Location = new Point(10, 10);
			button1.Name = "button1";
			button1.Padding = new Padding(10);
			button1.Size = new Size(161, 51);
			button1.TabIndex = 0;
			button1.Text = "Сохранить";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// panelLeft
			// 
			panelLeft.Controls.Add(dataGridViewUsers);
			panelLeft.Dock = DockStyle.Left;
			panelLeft.Location = new Point(0, 71);
			panelLeft.Name = "panelLeft";
			panelLeft.Padding = new Padding(10);
			panelLeft.Size = new Size(423, 379);
			panelLeft.TabIndex = 2;
			// 
			// dataGridViewUsers
			// 
			dataGridViewUsers.BackgroundColor = SystemColors.Control;
			dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewUsers.Dock = DockStyle.Fill;
			dataGridViewUsers.Location = new Point(10, 10);
			dataGridViewUsers.Name = "dataGridViewUsers";
			dataGridViewUsers.Size = new Size(403, 359);
			dataGridViewUsers.TabIndex = 0;
			dataGridViewUsers.SelectionChanged += dataGridViewUsers_SelectionChanged;
			// 
			// panel1
			// 
			panel1.Controls.Add(dataGridViewPosts);
			panel1.Dock = DockStyle.Right;
			panel1.Location = new Point(429, 71);
			panel1.Name = "panel1";
			panel1.Padding = new Padding(10);
			panel1.Size = new Size(371, 379);
			panel1.TabIndex = 3;
			// 
			// dataGridViewPosts
			// 
			dataGridViewPosts.BackgroundColor = SystemColors.Control;
			dataGridViewPosts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewPosts.Dock = DockStyle.Fill;
			dataGridViewPosts.Location = new Point(10, 10);
			dataGridViewPosts.Name = "dataGridViewPosts";
			dataGridViewPosts.Size = new Size(351, 359);
			dataGridViewPosts.TabIndex = 0;
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(panel1);
			Controls.Add(panelLeft);
			Controls.Add(panelTop);
			Name = "FormMain";
			Text = "Пользователи";
			panelTop.ResumeLayout(false);
			panelLeft.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridViewPosts).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panelTop;
		private Button button1;
		private Panel panelLeft;
		private DataGridView dataGridViewUsers;
		private Panel panel1;
		private DataGridView dataGridViewPosts;
	}
}
