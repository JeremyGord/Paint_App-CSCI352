using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Paint_APP
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    /// 
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            new NewWindow().Show();
   
            

        }
      private class NewWindow : Window
        {
            private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
            {
                Console.WriteLine("Hello World");
            }
        }
    }
}
