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

namespace YoutTube_Desktop_Viewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Video VideoOne { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            // setup scroll bar

            // only show scroll bars if necessary
            myScrollViewer.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;
            myScrollViewer.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;

            // populate some videos for testing
            VideoOne = new Video()
            {
                title = "Video Title Here",
                channelName = "Hat Films"
                //thumbnailLink = ""
            };

            this.DataContext = this;
        }
    }
}
