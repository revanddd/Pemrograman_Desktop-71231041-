Imports System.Windows.Forms

Namespace My
    Partial Friend Class MyApplication
        Protected Overrides Function OnInitialize(ByVal commandLineArgs As System.Collections.ObjectModel.ReadOnlyCollection(Of String)) As Boolean
            Return MyBase.OnInitialize(commandLineArgs)
        End Function

        Protected Overrides Sub OnCreateMainForm()
            Me.MainForm = New frmLogin()
        End Sub
    End Class
End Namespace
