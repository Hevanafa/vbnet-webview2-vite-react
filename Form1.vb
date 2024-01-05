Imports Microsoft.Web.WebView2.Core

''' <summary>
''' Minimum example translated from C# master.
''' </summary>
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitDebugAsync()
        ' InitAsync
    End Sub

    ''' <summary>
    ''' Use this for debugging.
    ''' </summary>
    Async Sub InitDebugAsync()
        Await MainWebView.EnsureCoreWebView2Async()

        AddHandler MainWebView.NavigationStarting, AddressOf MainWebView_NavigationStarting

        'you can change this depending on how you setup the Vite project
        MainWebView.CoreWebView2.Navigate("http://localhost:5173/")
    End Sub

    ''' <summary>
    ''' This requires the distributable version of the React project (built first).
    ''' </summary>
    Async Sub InitAsync()
        Await MainWebView.EnsureCoreWebView2Async()

        AddHandler MainWebView.NavigationStarting, AddressOf MainWebView_NavigationStarting

        MainWebView.CoreWebView2.SetVirtualHostNameToFolderMapping(
            "react_webview",
            "dist",
            CoreWebView2HostResourceAccessKind.Deny)

        MainWebView.CoreWebView2.Navigate("https://react_webview/index.html")
    End Sub

    Private Sub MainWebView_NavigationStarting(sender As Object, e As CoreWebView2NavigationStartingEventArgs)
        Dim nativeClass As New NativeClass()

        ' This will be accessible in React as
        '   const { nativeClass } = window.chrome.webview.hostObjects as CustomHostObjects;
        ' Which Is derived from:
        '   window.chrome.webview.hostObjects.{name}

        MainWebView.CoreWebView2.AddHostObjectToScript("nativeClass", nativeClass)
    End Sub

End Class
