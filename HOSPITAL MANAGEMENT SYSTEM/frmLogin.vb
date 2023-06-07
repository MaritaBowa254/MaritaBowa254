Public Class FrmLOGIN

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPASSWORD.TextChanged

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\joken\Documents\inventorydb.accdb")
    End Sub

    Private Sub CmdLOGIN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdLOGIN.Click
        If TxtUSERNAME.Text = "CENTRAL" And
            TxtPASSWORD.Text = "JOSE44" Then
            MsgBox("LOGIN SUCCESSFUL!", MsgBoxStyle.OkOnly, "LOG IN FORM")
            frmMenu.Show()
            Me.Hide()
        Else
            MsgBox("SORRY, INCORRECT USERNAME AND/OR PASSWORD.PLEASE TRY AGAIN!", MsgBoxStyle.OkOnly, "INVALID")

        End If
    End Sub
End Class
