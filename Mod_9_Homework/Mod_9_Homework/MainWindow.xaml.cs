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

namespace Mod_9_Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private List<Student> slist=new List<Student>();
        int count=-1;
        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            //slist = new List<Student>();
            
                Student sa = new Student(txtFirstName.Text, txtLastName.Text, txtCity.Text);
                slist.Add(sa);
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtCity.Text = "";
            
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        { 
            if (count <= 0) {
                count = 4;
            }
            count--;
            txtFirstName.Text = slist[count].FirstName;
            txtLastName.Text = slist[count].LastName;
            txtCity.Text = slist[count].City;
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            count++;
            if (count == slist.Count)
            {
                count = 0;
            }
            txtFirstName.Text = slist[count].FirstName;
            txtLastName.Text = slist[count].LastName;
            txtCity.Text = slist[count].City;

        }
    }
}
