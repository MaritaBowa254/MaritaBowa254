Public Class frmDoctor

    Private Sub DoctorsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.DoctorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HmDataSet)

    End Sub

    Private Sub frmDoctor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HmDataSet.Doctors' table. You can move, or remove it, as needed.


    End Sub

    Private Sub NameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NameTextBox.TextChanged

    End Sub

    Private Sub DoctorsBindingSource1BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.DoctorsBindingSource1.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.HmDataSet1)

    End Sub

    Private Sub frmDoctor_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HmDataSet1.Doctors' table. You can move, or remove it, as needed.
        Me.DoctorsTableAdapter1.Fill(Me.HmDataSet1.Doctors)

    End Sub

    Private Sub BtnBACK_Click(sender As Object, e As EventArgs) Handles BtnBACK.Click
        frmMenu.Show()
        Me.Hide()

    End Sub
End Class