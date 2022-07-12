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
using System.Windows.Shapes;

namespace ToDo.Views
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            if (this.WindowState == WindowState.Maximized)
            {
                MaxBtn.Content = "\xe675";
            }
            else if (this.WindowState == WindowState.Normal)
            {
                MaxBtn.Content = "\xe674";
            }

            CloseBtn.Click += (s, e) => 
            {
                this.Close();
            };

            MinBtn.Click += (s, e) =>
            {
                this.WindowState = WindowState.Minimized;
            };

            MaxBtn.Click += (s, e) =>
            {
                if (this.WindowState == WindowState.Maximized)
                {
                    this.WindowState = WindowState.Normal;
                    MaxBtn.Content = "\xe674";
                }
                else if (this.WindowState == WindowState.Normal)
                {
                    this.WindowState = WindowState.Maximized;
                    MaxBtn.Content = "\xe675";
                }
            };

            StateBar.MouseMove += (s, e) =>
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                    this.DragMove();
            };

            StateBar.MouseDoubleClick += (s, e) =>
            {
                if (e.LeftButton  == MouseButtonState.Pressed)
                {
                    if (this.WindowState == WindowState.Maximized)
                    {
                        this.WindowState = WindowState.Normal;
                        MaxBtn.Content = "\xe674";
                    }
                    else if (this.WindowState == WindowState.Normal)
                    {
                        this.WindowState = WindowState.Maximized;
                        MaxBtn.Content = "\xe675";
                    }
                }
            };
        }

    }
}
