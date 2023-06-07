Public Class frmAdmitPatient

    Private Sub AdmitBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.AdmitBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HmDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HmDataSet.Admit' table. You can move, or remove it, as needed.
        Me.AdmitTableAdapter.Fill(Me.HmDataSet.Admit)

    End Sub

    Private Sub BtnBACK_Click(sender As Object, e As EventArgs) Handles BtnBACK.Click
        frmMenu.Show()
        Me.Hide()

    End Sub
End Class