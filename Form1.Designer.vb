﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MainWebView = New Microsoft.Web.WebView2.WinForms.WebView2()
        CType(Me.MainWebView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainWebView
        '
        Me.MainWebView.AllowExternalDrop = True
        Me.MainWebView.CreationProperties = Nothing
        Me.MainWebView.DefaultBackgroundColor = System.Drawing.Color.White
        Me.MainWebView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainWebView.Location = New System.Drawing.Point(0, 0)
        Me.MainWebView.Name = "MainWebView"
        Me.MainWebView.Size = New System.Drawing.Size(624, 441)
        Me.MainWebView.TabIndex = 0
        Me.MainWebView.ZoomFactor = 1.0R
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.MainWebView)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.MainWebView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainWebView As Microsoft.Web.WebView2.WinForms.WebView2
End Class
