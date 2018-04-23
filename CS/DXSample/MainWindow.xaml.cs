using System;
using System.IO;
using System.Linq;
using System.Windows;
using DevExpress.Utils;
using System.Reflection;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Mvvm;
using System.Windows.Input;
using DevExpress.Xpf.PdfViewer;
using DevExpress.Xpf.WindowsUI;
using System.Collections.Generic;

namespace DXSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DXWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            FileStream pdfStream = new FileStream("Demo.pdf", FileMode.Open);
            Viewer.DocumentSource = pdfStream;
        }

        private void bCustomItem_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
            WinUIDialogWindow w = new WinUIDialogWindow();
            w.Content = "Hello world!";
            w.ShowDialogWindow(MessageBoxButton.YesNo);
        }
    }
}
