<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GenHash
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GenHash))
        Me.MD5 = New System.Windows.Forms.Label()
        Me.tboriginal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.md5tbresultado = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.sha5tbresultado = New System.Windows.Forms.TextBox()
        Me.SHA5 = New System.Windows.Forms.Label()
        Me.sha1tbresultado = New System.Windows.Forms.TextBox()
        Me.SHA1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MD5
        '
        Me.MD5.AutoSize = True
        Me.MD5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MD5.ForeColor = System.Drawing.Color.White
        Me.MD5.Location = New System.Drawing.Point(3, 65)
        Me.MD5.Name = "MD5"
        Me.MD5.Size = New System.Drawing.Size(43, 20)
        Me.MD5.TabIndex = 0
        Me.MD5.Text = "MD5"
        '
        'tboriginal
        '
        Me.tboriginal.Location = New System.Drawing.Point(7, 33)
        Me.tboriginal.Name = "tboriginal"
        Me.tboriginal.Size = New System.Drawing.Size(526, 20)
        Me.tboriginal.TabIndex = 1
        Me.tboriginal.Text = "Hamza Akiour"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(210, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ORIGINAL"
        '
        'md5tbresultado
        '
        Me.md5tbresultado.Location = New System.Drawing.Point(7, 88)
        Me.md5tbresultado.Name = "md5tbresultado"
        Me.md5tbresultado.ReadOnly = True
        Me.md5tbresultado.Size = New System.Drawing.Size(526, 20)
        Me.md5tbresultado.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.sha5tbresultado)
        Me.Panel1.Controls.Add(Me.SHA5)
        Me.Panel1.Controls.Add(Me.sha1tbresultado)
        Me.Panel1.Controls.Add(Me.SHA1)
        Me.Panel1.Controls.Add(Me.MD5)
        Me.Panel1.Controls.Add(Me.md5tbresultado)
        Me.Panel1.Controls.Add(Me.tboriginal)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(540, 206)
        Me.Panel1.TabIndex = 5
        '
        'sha5tbresultado
        '
        Me.sha5tbresultado.Location = New System.Drawing.Point(8, 180)
        Me.sha5tbresultado.Name = "sha5tbresultado"
        Me.sha5tbresultado.ReadOnly = True
        Me.sha5tbresultado.Size = New System.Drawing.Size(526, 20)
        Me.sha5tbresultado.TabIndex = 4
        '
        'SHA5
        '
        Me.SHA5.AutoSize = True
        Me.SHA5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SHA5.ForeColor = System.Drawing.Color.White
        Me.SHA5.Location = New System.Drawing.Point(3, 157)
        Me.SHA5.Name = "SHA5"
        Me.SHA5.Size = New System.Drawing.Size(52, 20)
        Me.SHA5.TabIndex = 0
        Me.SHA5.Text = "SHA5"
        '
        'sha1tbresultado
        '
        Me.sha1tbresultado.Location = New System.Drawing.Point(8, 134)
        Me.sha1tbresultado.Name = "sha1tbresultado"
        Me.sha1tbresultado.ReadOnly = True
        Me.sha1tbresultado.Size = New System.Drawing.Size(526, 20)
        Me.sha1tbresultado.TabIndex = 4
        '
        'SHA1
        '
        Me.SHA1.AutoSize = True
        Me.SHA1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SHA1.ForeColor = System.Drawing.Color.White
        Me.SHA1.Location = New System.Drawing.Point(3, 111)
        Me.SHA1.Name = "SHA1"
        Me.SHA1.Size = New System.Drawing.Size(52, 20)
        Me.SHA1.TabIndex = 0
        Me.SHA1.Text = "SHA1"
        '
        'GenHash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Firebrick
        Me.ClientSize = New System.Drawing.Size(550, 215)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GenHash"
        Me.Text = "GenHash"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MD5 As Label
    Friend WithEvents tboriginal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents md5tbresultado As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SHA1 As Label
    Friend WithEvents sha1tbresultado As TextBox
    Friend WithEvents SHA5 As Label
    Friend WithEvents sha5tbresultado As TextBox
End Class
