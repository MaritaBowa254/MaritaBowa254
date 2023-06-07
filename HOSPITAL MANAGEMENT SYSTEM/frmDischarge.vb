Public Class frmDischarge

    Private Sub DischargeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.DischargeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HmDataSet)

    End Sub

    Private Sub frmDischarge_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HmDataSet.discharge' table. You can move, or remove it, as needed.
        
    End Sub

    Private Sub AddressTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddressTextBox.TextChanged

    End Sub

    Private Sub frmDischarge_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HmDataSet1.discharge' table. You can move, or remove it, as needed.
        Me.DischargeTableAdapter1.Fill(Me.HmDataSet1.discharge)

    End Sub

    Private Sub DischargeBindingSource1BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.DischargeBindingSource1.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.HmDataSet1)

    End Sub

    Private Sub DischargedateDateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DischargedateDateTimePicker1.ValueChanged

    End Sub

    Private Sub DischargedateLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RemarksLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DoctorLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BloodgroupLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DiseaseLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AdmitdatetimeLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnBACK_Click(sender As Object, e As EventArgs) Handles BtnBACK.Click
        frmMenu.Show()
        Me.Hide()

    End Sub
End Class