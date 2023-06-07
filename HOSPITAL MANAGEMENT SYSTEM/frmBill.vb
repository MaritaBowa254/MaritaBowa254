Public Class frmBill

    Private Sub frmBill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HmDataSet.Bill' table. You can move, or remove it, as needed.
        
    End Sub

    Private Sub BillBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.BillBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.HmDataSet)

    End Sub

    Private Sub BillBindingSource1BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.BillBindingSource1.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.HmDataSet1)

    End Sub

    Private Sub frmBill_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HmDataSet1.Bill' table. You can move, or remove it, as needed.
        Me.BillTableAdapter1.Fill(Me.HmDataSet1.Bill)

    End Sub

    Private Sub BtnBACK_Click(sender As Object, e As EventArgs) Handles BtnBACK.Click
        frmMenu.Show()
        Me.Hide()

    End Sub
End Class