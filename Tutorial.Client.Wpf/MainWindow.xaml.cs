using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Tutorial.Domain;
using Tutorial.BLL;

namespace Tutorial.Client.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IForumService forumService = new ServiceAdapter.ForumServiceAdapter();
            forumService.SaveForumAsync(
                new Forum
                {
                    Name = "Hello World 2",
                    Creator = "zsp"
                })
                .ContinueWith(
                    (task) =>
                    {
                        if (task.Exception == null)
                        {
                            System.Windows.MessageBox.Show("success");
                        }
                    });
        }
    }
}
