using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace DataGridDashboard
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			var converter = new BrushConverter();
			ObservableCollection<Member> members = new ObservableCollection<Member>();

			// Create Datagrif items info
			members.Add(new Member { Number = "1", Character = "P", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "John Doe", Position = "Administrator", Phone = "123-536-242", Email = "John@gmail.com" });
			members.Add(new Member { Number = "2", Character = "K", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Jim Miggel", Position = "Manager", Phone = "524-242-127", Email = "Miggel@gmail.com" });
			members.Add(new Member { Number = "3", Character = "A", BgColor = (Brush)converter.ConvertFromString("#ff8f00"), Name = "Katy perry", Position = "Coach", Phone = "425-613-416", Email = "katyperry@gmail.com" });
			members.Add(new Member { Number = "1", Character = "P", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "John Doe", Position = "Administrator", Phone = "123-536-242", Email = "John@gmail.com" });
			members.Add(new Member { Number = "2", Character = "K", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Jim Miggel", Position = "Manager", Phone = "524-242-127", Email = "Miggel@gmail.com" });
			members.Add(new Member { Number = "3", Character = "A", BgColor = (Brush)converter.ConvertFromString("#ff8f00"), Name = "Katy perry", Position = "Coach", Phone = "425-613-416", Email = "katyperry@gmail.com" });
			members.Add(new Member { Number = "1", Character = "P", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "John Doe", Position = "Administrator", Phone = "123-536-242", Email = "John@gmail.com" });
			members.Add(new Member { Number = "2", Character = "K", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Jim Miggel", Position = "Manager", Phone = "524-242-127", Email = "Miggel@gmail.com" });
			members.Add(new Member { Number = "3", Character = "A", BgColor = (Brush)converter.ConvertFromString("#ff8f00"), Name = "Katy perry", Position = "Coach", Phone = "425-613-416", Email = "katyperry@gmail.com" });
			members.Add(new Member { Number = "1", Character = "P", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "John Doe", Position = "Administrator", Phone = "123-536-242", Email = "John@gmail.com" });
			members.Add(new Member { Number = "2", Character = "K", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Jim Miggel", Position = "Manager", Phone = "524-242-127", Email = "Miggel@gmail.com" });
			members.Add(new Member { Number = "3", Character = "A", BgColor = (Brush)converter.ConvertFromString("#ff8f00"), Name = "Katy perry", Position = "Coach", Phone = "425-613-416", Email = "katyperry@gmail.com" });
			members.Add(new Member { Number = "1", Character = "P", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "John Doe", Position = "Administrator", Phone = "123-536-242", Email = "John@gmail.com" });
			members.Add(new Member { Number = "2", Character = "K", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Jim Miggel", Position = "Manager", Phone = "524-242-127", Email = "Miggel@gmail.com" });
			members.Add(new Member { Number = "3", Character = "A", BgColor = (Brush)converter.ConvertFromString("#ff8f00"), Name = "Katy perry", Position = "Coach", Phone = "425-613-416", Email = "katyperry@gmail.com" });
			members.Add(new Member { Number = "1", Character = "P", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "John Doe", Position = "Administrator", Phone = "123-536-242", Email = "John@gmail.com" });
			members.Add(new Member { Number = "2", Character = "K", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Jim Miggel", Position = "Manager", Phone = "524-242-127", Email = "Miggel@gmail.com" });
			members.Add(new Member { Number = "3", Character = "A", BgColor = (Brush)converter.ConvertFromString("#ff8f00"), Name = "Katy perry", Position = "Coach", Phone = "425-613-416", Email = "katyperry@gmail.com" });
			members.Add(new Member { Number = "1", Character = "P", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "John Doe", Position = "Administrator", Phone = "123-536-242", Email = "John@gmail.com" });
			members.Add(new Member { Number = "2", Character = "K", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Jim Miggel", Position = "Manager", Phone = "524-242-127", Email = "Miggel@gmail.com" });
			members.Add(new Member { Number = "3", Character = "A", BgColor = (Brush)converter.ConvertFromString("#ff8f00"), Name = "Katy perry", Position = "Coach", Phone = "425-613-416", Email = "katyperry@gmail.com" });
			members.Add(new Member { Number = "1", Character = "P", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "John Doe", Position = "Administrator", Phone = "123-536-242", Email = "John@gmail.com" });
			members.Add(new Member { Number = "2", Character = "K", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Jim Miggel", Position = "Manager", Phone = "524-242-127", Email = "Miggel@gmail.com" });
			members.Add(new Member { Number = "3", Character = "A", BgColor = (Brush)converter.ConvertFromString("#ff8f00"), Name = "Katy perry", Position = "Coach", Phone = "425-613-416", Email = "katyperry@gmail.com" });
			members.Add(new Member { Number = "1", Character = "P", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "John Doe", Position = "Administrator", Phone = "123-536-242", Email = "John@gmail.com" });
			members.Add(new Member { Number = "2", Character = "K", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Jim Miggel", Position = "Manager", Phone = "524-242-127", Email = "Miggel@gmail.com" });
			members.Add(new Member { Number = "3", Character = "A", BgColor = (Brush)converter.ConvertFromString("#ff8f00"), Name = "Katy perry", Position = "Coach", Phone = "425-613-416", Email = "katyperry@gmail.com" });
			members.Add(new Member { Number = "1", Character = "P", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "John Doe", Position = "Administrator", Phone = "123-536-242", Email = "John@gmail.com" });
			members.Add(new Member { Number = "2", Character = "K", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Jim Miggel", Position = "Manager", Phone = "524-242-127", Email = "Miggel@gmail.com" });
			members.Add(new Member { Number = "3", Character = "A", BgColor = (Brush)converter.ConvertFromString("#ff8f00"), Name = "Katy perry", Position = "Coach", Phone = "425-613-416", Email = "katyperry@gmail.com" });
			members.Add(new Member { Number = "1", Character = "P", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "John Doe", Position = "Administrator", Phone = "123-536-242", Email = "John@gmail.com" });
			members.Add(new Member { Number = "2", Character = "K", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Jim Miggel", Position = "Manager", Phone = "524-242-127", Email = "Miggel@gmail.com" });
			members.Add(new Member { Number = "3", Character = "A", BgColor = (Brush)converter.ConvertFromString("#ff8f00"), Name = "Katy perry", Position = "Coach", Phone = "425-613-416", Email = "katyperry@gmail.com" });
			members.Add(new Member { Number = "1", Character = "P", BgColor = (Brush)converter.ConvertFromString("#1098ad"), Name = "John Doe", Position = "Administrator", Phone = "123-536-242", Email = "John@gmail.com" });
			members.Add(new Member { Number = "2", Character = "K", BgColor = (Brush)converter.ConvertFromString("#1e88e5"), Name = "Jim Miggel", Position = "Manager", Phone = "524-242-127", Email = "Miggel@gmail.com" });
			members.Add(new Member { Number = "3", Character = "A", BgColor = (Brush)converter.ConvertFromString("#ff8f00"), Name = "Katy perry", Position = "Coach", Phone = "425-613-416", Email = "katyperry@gmail.com" });


			memberDataGrid.ItemsSource = members;
		}

		private void Border_Mousedown(object sender, MouseButtonEventArgs e)
		{
			if (e.ChangedButton == MouseButton.Left)
			{
				this.DragMove();
			}
		}
		private bool isMaximized = false;
		private void Border_MouseLeftButtondown(object sender, MouseButtonEventArgs e)
		{
			if(e.ClickCount== 2) 
			{ 
				if(isMaximized)
				{
					this.WindowState= WindowState.Normal;
					this.Width = 1080;
					this.Height = 720;

					isMaximized = false;
				}
				else
				{
					this.WindowState = WindowState.Maximized;
					isMaximized = true;
				}
			}
		}

	}

	public class Member
	{
		public string Character { get; set; }
		public string Number { get; set; }
		public string Name { get; set; }
		public string Position { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public Brush BgColor { get; set; }

	}

}
