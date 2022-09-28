using System;
using Gtrack.Controller;
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
using System.Windows.Shapes;

namespace Gtrack.View
{
    
    
   
        public partial class WindowProfile : Window
        {
            ControllerProfile controller;

            public WindowProfile()
            {
                controller = new ControllerProfile();
                InitializeComponent();
                this.DataContext = controller.GetContext();
            }

            private void ButtonSearch_Click(object sender, RoutedEventArgs e)
            {
                controller.OpenMain();
                this.Close();
            }
        }
        
    
}
