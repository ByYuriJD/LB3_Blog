
using System.ComponentModel;
using LB3_Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace LB3_Blog {
	public partial class FormMain : Form {
		//Создаёт экземпляр контекста данных, который будет использоваться
		// для загрузки и отслеживания изменений от пользователях
		private BlogContext? db;
		public FormMain() {
			InitializeComponent();
		}

		// Вызывается при загрузки
		protected override void OnLoad(EventArgs e) {
			base.OnLoad(e);
			this.db = new BlogContext();

			// Загрузка из БД
			this.db.Users.Load();
			this.dataGridViewUsers.DataSource = this.db.Users.Local.ToBindingList();
		}

		protected override void OnClosing(CancelEventArgs e) {
			base.OnClosing(e);

			this.db?.Dispose();
			this.db = null;
		}

		private void dataGridViewUsers_SelectionChanged(object sender, EventArgs e) {
			if (this.db != null) {
				var user = (User)this.dataGridViewUsers.CurrentRow.DataBoundItem;

				if (user != null) {
					this.db.Entry(user).Collection(e => e.Posts).Load();
					this.dataGridViewPosts.DataSource = user.Posts;
				}
			}
		}

		private void button1_Click(object sender, EventArgs e) {
			this.db!.SaveChanges();

			this.dataGridViewUsers.Refresh();
			this.dataGridViewPosts.Refresh();
		}
	}
}
