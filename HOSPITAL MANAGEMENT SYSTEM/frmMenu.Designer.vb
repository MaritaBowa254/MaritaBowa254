<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdDOCTOR = New System.Windows.Forms.Button()
        Me.cmdADMIT = New System.Windows.Forms.Button()
        Me.cmdDISCHARGE = New System.Windows.Forms.Button()
        Me.cmdBILL = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 19)
        Me.Label2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 19)
        Me.Label3.TabIndex = 2
        '
        'cmdDOCTOR
        '
        Me.cmdDOCTOR.BackColor = System.Drawing.Color.CornflowerBlue
        Me.cmdDOCTOR.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDOCTOR.Location = New System.Drawing.Point(332, 21)
        Me.cmdDOCTOR.Name = "cmdDOCTOR"
        Me.cmdDOCTOR.Size = New System.Drawing.Size(75, 23)
        Me.cmdDOCTOR.TabIndex = 4
        Me.cmdDOCTOR.Text = "DOCTOR"
        Me.cmdDOCTOR.UseVisualStyleBackColor = False
        '
        'cmdADMIT
        '
        Me.cmdADMIT.BackColor = System.Drawing.Color.Crimson
        Me.cmdADMIT.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdADMIT.Location = New System.Drawing.Point(55, 178)
        Me.cmdADMIT.Name = "cmdADMIT"
        Me.cmdADMIT.Size = New System.Drawing.Size(75, 23)
        Me.cmdADMIT.TabIndex = 5
        Me.cmdADMIT.Text = "ADMIT PATIENT"
        Me.cmdADMIT.UseVisualStyleBackColor = False
        '
        'cmdDISCHARGE
        '
        Me.cmdDISCHARGE.BackColor = System.Drawing.Color.DarkKhaki
        Me.cmdDISCHARGE.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDISCHARGE.Location = New System.Drawing.Point(644, 178)
        Me.cmdDISCHARGE.Name = "cmdDISCHARGE"
        Me.cmdDISCHARGE.Size = New System.Drawing.Size(75, 23)
        Me.cmdDISCHARGE.TabIndex = 6
        Me.cmdDISCHARGE.Text = "DISCHARGE PATIENT"
        Me.cmdDISCHARGE.UseVisualStyleBackColor = False
        '
        'cmdBILL
        '
        Me.cmdBILL.BackColor = System.Drawing.Color.Cyan
        Me.cmdBILL.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBILL.Location = New System.Drawing.Point(332, 360)
        Me.cmdBILL.Name = "cmdBILL"
        Me.cmdBILL.Size = New System.Drawing.Size(75, 23)
        Me.cmdBILL.TabIndex = 7
        Me.cmdBILL.Text = "BILL"
        Me.cmdBILL.UseVisualStyleBackColor = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(811, 415)
        Me.Controls.Add(Me.cmdBILL)
        Me.Controls.Add(Me.cmdDISCHARGE)
        Me.Controls.Add(Me.cmdADMIT)
        Me.Controls.Add(Me.cmdDOCTOR)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmMenu"
        Me.Text = "MAIN MENU"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdDOCTOR As System.Windows.Forms.Button
    Friend WithEvents cmdADMIT As System.Windows.Forms.Button
    Friend WithEvents cmdDISCHARGE As System.Windows.Forms.Button
    Friend WithEvents cmdBILL As System.Windows.Forms.Button
End Class
