<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LoyalTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LoyalTheme1
        '
        Me.LoyalTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.LoyalTheme1.Controls.Add(Me.LoyalButton1)
        Me.LoyalTheme1.Controls.Add(Me.Label1)
        Me.LoyalTheme1.Controls.Add(Me.Button1)
        Me.LoyalTheme1.Controls.Add(Me.TextBox2)
        Me.LoyalTheme1.Controls.Add(Me.TextBox1)
        Me.LoyalTheme1.ControlsAlignment = _177FORWARDANTODOWN_XD.LoyalTheme.ControlsAlign.Right
        Me.LoyalTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LoyalTheme1.HeaderColor = System.Drawing.Color.Blue
        Me.LoyalTheme1.HeaderSize = 30
        Me.LoyalTheme1.Location = New System.Drawing.Point(0, 0)
        Me.LoyalTheme1.Name = "LoyalTheme1"
        Me.LoyalTheme1.ShowClose = False
        Me.LoyalTheme1.ShowMaximize = False
        Me.LoyalTheme1.ShowMinimize = False
        Me.LoyalTheme1.Size = New System.Drawing.Size(626, 417)
        Me.LoyalTheme1.TabIndex = 0
        Me.LoyalTheme1.Text = "ChatBot Sample #1"
        Me.LoyalTheme1.TextAlignment = _177FORWARDANTODOWN_XD.LoyalTheme.TextAlign.Center
        '
        'LoyalButton1
        '
        Me.LoyalButton1.ForeColor = System.Drawing.Color.Lime
        Me.LoyalButton1.Location = New System.Drawing.Point(596, 12)
        Me.LoyalButton1.Name = "LoyalButton1"
        Me.LoyalButton1.OutlineColor = System.Drawing.Color.Red
        Me.LoyalButton1.Size = New System.Drawing.Size(21, 14)
        Me.LoyalButton1.TabIndex = 7
        Me.LoyalButton1.Text = "x"
        Me.LoyalButton1.TextAlignment = _177FORWARDANTODOWN_XD.LoyalButton.Alignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Aqua
        Me.Label1.Location = New System.Drawing.Point(12, 386)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(605, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Esta es una muestra de un ChatBot Simple . Esta For ma de Procesamioendo del Bot " & _
            ", es ineficas y A mi parecer desagradable."
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Aqua
        Me.Button1.Location = New System.Drawing.Point(523, 346)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 22)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Send"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(12, 348)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(505, 20)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(12, 45)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(601, 289)
        Me.TextBox1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 417)
        Me.Controls.Add(Me.LoyalTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Chatbot Sample #1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.LoyalTheme1.ResumeLayout(False)
        Me.LoyalTheme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LoyalTheme1 As _177FORWARDANTODOWN_XD.LoyalTheme
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LoyalButton1 As _177FORWARDANTODOWN_XD.LoyalButton

End Class
