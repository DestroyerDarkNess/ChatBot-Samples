<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LoyalTheme1 = New _177FORWARDANTODOWN_XD.LoyalTheme()
        Me.LoyalButton1 = New _177FORWARDANTODOWN_XD.LoyalButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LoyalTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LoyalTheme1
        '
        Me.LoyalTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.LoyalTheme1.Controls.Add(Me.LoyalButton1)
        Me.LoyalTheme1.Controls.Add(Me.Label4)
        Me.LoyalTheme1.Controls.Add(Me.Label3)
        Me.LoyalTheme1.Controls.Add(Me.Label2)
        Me.LoyalTheme1.Controls.Add(Me.Label1)
        Me.LoyalTheme1.ControlsAlignment = _177FORWARDANTODOWN_XD.LoyalTheme.ControlsAlign.Right
        Me.LoyalTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LoyalTheme1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LoyalTheme1.HeaderSize = 30
        Me.LoyalTheme1.Location = New System.Drawing.Point(0, 0)
        Me.LoyalTheme1.Name = "LoyalTheme1"
        Me.LoyalTheme1.ShowClose = False
        Me.LoyalTheme1.ShowMaximize = False
        Me.LoyalTheme1.ShowMinimize = False
        Me.LoyalTheme1.Size = New System.Drawing.Size(220, 137)
        Me.LoyalTheme1.TabIndex = 0
        Me.LoyalTheme1.Text = "Sample #3 I.A"
        Me.LoyalTheme1.TextAlignment = _177FORWARDANTODOWN_XD.LoyalTheme.TextAlign.Center
        '
        'LoyalButton1
        '
        Me.LoyalButton1.ForeColor = System.Drawing.Color.Lime
        Me.LoyalButton1.Location = New System.Drawing.Point(188, 13)
        Me.LoyalButton1.Name = "LoyalButton1"
        Me.LoyalButton1.OutlineColor = System.Drawing.Color.Red
        Me.LoyalButton1.Size = New System.Drawing.Size(21, 14)
        Me.LoyalButton1.TabIndex = 4
        Me.LoyalButton1.Text = "x"
        Me.LoyalButton1.TextAlignment = _177FORWARDANTODOWN_XD.LoyalButton.Alignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Aqua
        Me.Label4.Location = New System.Drawing.Point(55, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "* Chat_Dictionary.dll"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(20, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "No Se Comparte el codigo fuente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Aqua
        Me.Label2.Location = New System.Drawing.Point(28, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "* IA_Neuronal_Module.vb"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(12, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Actualmente en desarrollo Usando:"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(220, 137)
        Me.Controls.Add(Me.LoyalTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.LoyalTheme1.ResumeLayout(False)
        Me.LoyalTheme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LoyalTheme1 As _177FORWARDANTODOWN_XD.LoyalTheme
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LoyalButton1 As _177FORWARDANTODOWN_XD.LoyalButton
End Class
