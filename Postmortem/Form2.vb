Public Class frmLogon
    Private AdminPasscode As String = "QWERTYUIOP" 'admin password
    Private Sub btnSubmit_Click() Handles btnSubmit.Click
        If txtPassword.Text = AdminPasscode Then 'if statement
            Me.Hide() 'hides form 2
            frmHashDatabase.Show() 'shows the Postmortem form
        Else
            MsgBox("Incorrect credentials - Exiting program") 'msg box
            Me.Close() 'closes the application
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then 'If enter key is pressed instead of clicking with mouse button
            btnSubmit_Click() 'execute click function
        End If
    End Sub

    Private Sub frmLogon_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class