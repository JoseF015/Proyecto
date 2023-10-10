<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Unidad_IV
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Mostrar = New System.Windows.Forms.TextBox()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Siguiente = New System.Windows.Forms.Button()
        Me.Anterior = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(537, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "%"
        '
        'Mostrar
        '
        Me.Mostrar.Location = New System.Drawing.Point(486, 86)
        Me.Mostrar.Name = "Mostrar"
        Me.Mostrar.Size = New System.Drawing.Size(45, 20)
        Me.Mostrar.TabIndex = 18
        '
        'Salir
        '
        Me.Salir.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Salir.Location = New System.Drawing.Point(18, 37)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(93, 32)
        Me.Salir.TabIndex = 17
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = False
        '
        'Siguiente
        '
        Me.Siguiente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Siguiente.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Siguiente.Location = New System.Drawing.Point(610, 594)
        Me.Siguiente.Name = "Siguiente"
        Me.Siguiente.Size = New System.Drawing.Size(112, 32)
        Me.Siguiente.TabIndex = 16
        Me.Siguiente.Text = "Siguiente"
        Me.Siguiente.UseVisualStyleBackColor = False
        '
        'Anterior
        '
        Me.Anterior.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Anterior.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Anterior.Location = New System.Drawing.Point(18, 594)
        Me.Anterior.Name = "Anterior"
        Me.Anterior.Size = New System.Drawing.Size(114, 31)
        Me.Anterior.TabIndex = 15
        Me.Anterior.Text = "Regresar"
        Me.Anterior.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(120, 86)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(360, 14)
        Me.ProgressBar1.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.MyProyect.My.Resources.Resources.Img1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 112)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(704, 445)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Unidad_IV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(734, 638)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Mostrar)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Siguiente)
        Me.Controls.Add(Me.Anterior)
        Me.Controls.Add(Me.ProgressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Unidad_IV"
        Me.Text = "Unidad_IV"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Mostrar As TextBox
    Friend WithEvents Salir As Button
    Friend WithEvents Siguiente As Button
    Friend WithEvents Anterior As Button
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
