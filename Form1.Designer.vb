<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnVariable = New System.Windows.Forms.Button()
        Me.btn_DataTypes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(307, 174)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(172, 87)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Press Here"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnVariable
        '
        Me.btnVariable.Location = New System.Drawing.Point(502, 174)
        Me.btnVariable.Name = "btnVariable"
        Me.btnVariable.Size = New System.Drawing.Size(173, 87)
        Me.btnVariable.TabIndex = 1
        Me.btnVariable.Text = "Variable Click Here"
        Me.btnVariable.UseVisualStyleBackColor = True
        '
        'btn_DataTypes
        '
        Me.btn_DataTypes.Location = New System.Drawing.Point(101, 174)
        Me.btn_DataTypes.Name = "btn_DataTypes"
        Me.btn_DataTypes.Size = New System.Drawing.Size(180, 87)
        Me.btn_DataTypes.TabIndex = 2
        Me.btn_DataTypes.Text = "Data Types"
        Me.btn_DataTypes.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_DataTypes)
        Me.Controls.Add(Me.btnVariable)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents btnVariable As Button
    Friend WithEvents btn_DataTypes As Button
End Class
