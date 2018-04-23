' Developer Express Code Central Example:
' How to customize PDF Viewer Ribbon
' 
' The following example shows how to customize PDF Viewer Ribbon.
' To accomplish
' this task, it is necessary to override the default PdfViewerControl's
' RibbonTemplate and add the required bar items to the newly defined
' RibbonControl.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E5091

Imports System
Imports System.IO
Imports System.Linq
Imports System.Windows
Imports DevExpress.Utils
Imports System.Reflection
Imports DevExpress.Xpf.Core
Imports System.Windows.Input
Imports DevExpress.Xpf.PdfViewer
Imports DevExpress.Xpf.WindowsUI
Imports System.Collections.Generic

Namespace DXSample
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits DXWindow

        Public Sub New()
            InitializeComponent()
            Dim pdfStream As New FileStream("Demo.pdf", FileMode.Open)
            Viewer.DocumentSource = pdfStream
        End Sub

        Private Sub bCustomItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            Dim w As New WinUIDialogWindow()
            w.Content = "Hello world!"
            w.ShowDialogWindow(MessageBoxButton.YesNo)
        End Sub
    End Class
End Namespace
