<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtCantidadcontactos = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnempezar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.dtpFechanacimiento = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'txtCantidadcontactos
        '
        Me.txtCantidadcontactos.Location = New System.Drawing.Point(366, 38)
        Me.txtCantidadcontactos.Name = "txtCantidadcontactos"
        Me.txtCantidadcontactos.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidadcontactos.TabIndex = 0
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(366, 79)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(100, 20)
        Me.txtnombre.TabIndex = 1
        Me.txtnombre.Visible = False
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(366, 160)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(100, 20)
        Me.txttelefono.TabIndex = 3
        Me.txttelefono.Visible = False
        '
        'txtcorreo
        '
        Me.txtcorreo.Location = New System.Drawing.Point(366, 198)
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(100, 20)
        Me.txtcorreo.TabIndex = 4
        Me.txtcorreo.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(154, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Numero de contactos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(154, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(154, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Fecha de nacimiento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(154, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Telefono"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(154, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Correo"
        '
        'btnempezar
        '
        Me.btnempezar.Location = New System.Drawing.Point(501, 35)
        Me.btnempezar.Name = "btnempezar"
        Me.btnempezar.Size = New System.Drawing.Size(75, 23)
        Me.btnempezar.TabIndex = 10
        Me.btnempezar.Text = "Empezar"
        Me.btnempezar.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(601, 154)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 11
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'dtpFechanacimiento
        '
        Me.dtpFechanacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechanacimiento.Location = New System.Drawing.Point(366, 119)
        Me.dtpFechanacimiento.Name = "dtpFechanacimiento"
        Me.dtpFechanacimiento.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechanacimiento.TabIndex = 12
        Me.dtpFechanacimiento.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dtpFechanacimiento)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnempezar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtcorreo)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtCantidadcontactos)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCantidadcontactos As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnempezar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents dtpFechanacimiento As DateTimePicker
End Class
