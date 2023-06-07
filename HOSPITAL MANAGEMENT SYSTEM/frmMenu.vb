Public Class frmMenu

    Private Sub cmdDISCHARGE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDISCHARGE.Click
        Me.Hide()
        frmDischarge.Show()

    End Sub

    Private Sub cmdDOCTOR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDOCTOR.Click
        Me.Hide()
        frmDoctor.Show()

    End Sub

    Private Sub cmdADMIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdADMIT.Click
        Me.Hide()
        frmAdmitPatient.Show()

    End Sub

    Private Sub cmdBILL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBILL.Click
        Me.Hide()
        frmBill.Show()

    End Sub
End Class