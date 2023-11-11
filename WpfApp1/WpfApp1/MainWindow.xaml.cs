using System;
using System.Data;
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

namespace WpfApp1
{

    public partial class MainWindow : Window
    {
        private List<string> history = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            foreach(UIElement el in MainRoot.Children)
            {
                if(el is Button)
                {
                    ((Button)el).Click += Button_Click;
                }
            }

   
        }
      
        public void Button_Click(object sender, RoutedEventArgs e)
        {   
            string str = (string)((Button)e.OriginalSource).Content;
         
            if(str=="C")
                TBone.Text = "";
            else if (str == "=")
            {
                
                string value=new DataTable().Compute(TBone.Text, null).ToString();
                TBone.Text = value;
                
            }
            else
            
            TBone.Text += str;
        }

         public void SaveHistory_Click(object sender, RoutedEventArgs e)
        {
          
         
        }


    }
  
}
