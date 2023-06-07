<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLOGIN
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
        Me.CmdLOGIN = New System.Windows.Forms.Button()
        Me.LblUSERNAME = New System.Windows.Forms.Label()
        Me.LblPASSWORD = New System.Windows.Forms.Label()
        Me.TxtUSERNAME = New System.Windows.Forms.TextBox()
        Me.TxtPASSWORD = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CmdLOGIN
        '
        Me.CmdLOGIN.BackColor = System.Drawing.Color.DeepPink
        Me.CmdLOGIN.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdLOGIN.Location = New System.Drawing.Point(239, 265)
        Me.CmdLOGIN.Name = "CmdLOGIN"
        Me.CmdLOGIN.Size = New System.Drawing.Size(75, 23)
        Me.CmdLOGIN.TabIndex = 0
        Me.CmdLOGIN.Text = "LOG IN"
        Me.CmdLOGIN.UseVisualStyleBackColor = False
        '
        'LblUSERNAME
        '
        Me.LblUSERNAME.AutoSize = True
        Me.LblUSERNAME.BackColor = System.Drawing.Color.Cyan
        Me.LblUSERNAME.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUSERNAME.Location = New System.Drawing.Point(92, 38)
        Me.LblUSERNAME.Name = "LblUSERNAME"
        Me.LblUSERNAME.Size = New System.Drawing.Size(77, 19)
        Me.LblUSERNAME.TabIndex = 1
        Me.LblUSERNAME.Text = "USERNAME"
        '
        'LblPASSWORD
        '
        Me.LblPASSWORD.AutoSize = True
        Me.LblPASSWORD.BackColor = System.Drawing.Color.Cyan
        Me.LblPASSWORD.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPASSWORD.Location = New System.Drawing.Point(92, 127)
        Me.LblPASSWORD.Name = "LblPASSWORD"
        Me.LblPASSWORD.Size = New System.Drawing.Size(77, 19)
        Me.LblPASSWORD.TabIndex = 2
        Me.LblPASSWORD.Text = "PASSWORD"
        '
        'TxtUSERNAME
        '
        Me.TxtUSERNAME.BackColor = System.Drawing.Color.White
        Me.TxtUSERNAME.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUSERNAME.Location = New System.Drawing.Point(350, 31)
        Me.TxtUSERNAME.Name = "TxtUSERNAME"
        Me.TxtUSERNAME.Size = New System.Drawing.Size(100, 27)
        Me.TxtUSERNAME.TabIndex = 3
        '
        'TxtPASSWORD
        '
        Me.TxtPASSWORD.BackColor = System.Drawing.Color.White
        Me.TxtPASSWORD.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPASSWORD.Location = New System.Drawing.Point(350, 120)
        Me.TxtPASSWORD.Name = "TxtPASSWORD"
        Me.TxtPASSWORD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPASSWORD.Size = New System.Drawing.Size(100, 27)
        Me.TxtPASSWORD.TabIndex = 4
        '
        'FrmLOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(846, 341)
        Me.Controls.Add(Me.TxtPASSWORD)
        Me.Controls.Add(Me.TxtUSERNAME)
        Me.Controls.Add(Me.LblPASSWORD)
        Me.Controls.Add(Me.LblUSERNAME)
        Me.Controls.Add(Me.CmdLOGIN)
        Me.Name = "FrmLOGIN"
        Me.Text = "LOG IN FORM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmdLOGIN As System.Windows.Forms.Button
    Friend WithEvents LblUSERNAME As System.Windows.Forms.Label
    Friend WithEvents LblPASSWORD As System.Windows.Forms.Label
    Friend WithEvents TxtUSERNAME As System.Windows.Forms.TextBox
    Friend WithEvents TxtPASSWORD As System.Windows.Forms.TextBox

End Class
