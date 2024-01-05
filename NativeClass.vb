Imports System.Runtime.InteropServices
Imports System.Text.Json

<ComVisible(True)>
Public Class NativeClass
    Public Sub Show()
        MessageBox.Show("Hello from .NET!")
    End Sub

    Public Function Add%(a%, b%)
        Add = a + b
    End Function

    Public Function AddByObject%(json_obj As String)
        Dim example = JsonSerializer.Deserialize(Of ExampleAdd)(json_obj)
        AddByObject = example.a + example.b
    End Function
End Class

Class ExampleAdd
    Public Property a%
    Public Property b%
End Class
