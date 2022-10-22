<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtStreetAddress = New System.Windows.Forms.TextBox()
        Me.lblStreetAddress = New System.Windows.Forms.Label()
        Me.lstOccupation = New System.Windows.Forms.ListBox()
        Me.lblOccupation = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(235, 284)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(331, 104)
        Me.btnSubmit.TabIndex = 0
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(312, 77)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(254, 23)
        Me.txtFirstName.TabIndex = 1
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(242, 80)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(64, 15)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.Text = "First Name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(312, 137)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(254, 23)
        Me.txtLastName.TabIndex = 3
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(243, 140)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(63, 15)
        Me.lblLastName.TabIndex = 4
        Me.lblLastName.Text = "Last Name"
        '
        'txtStreetAddress
        '
        Me.txtStreetAddress.Location = New System.Drawing.Point(312, 185)
        Me.txtStreetAddress.Name = "txtStreetAddress"
        Me.txtStreetAddress.Size = New System.Drawing.Size(254, 23)
        Me.txtStreetAddress.TabIndex = 5
        '
        'lblStreetAddress
        '
        Me.lblStreetAddress.AutoSize = True
        Me.lblStreetAddress.Location = New System.Drawing.Point(224, 188)
        Me.lblStreetAddress.Name = "lblStreetAddress"
        Me.lblStreetAddress.Size = New System.Drawing.Size(82, 15)
        Me.lblStreetAddress.TabIndex = 6
        Me.lblStreetAddress.Text = "Street Address"
        '
        'lstOccupation
        '
        Me.lstOccupation.FormattingEnabled = True
        Me.lstOccupation.ItemHeight = 15
        Me.lstOccupation.Items.AddRange(New Object() {"Programmer", "Doctor", "Soldier", "Student", "Tailor", "Tinkerer", "Apothocary"})
        Me.lstOccupation.Location = New System.Drawing.Point(603, 73)
        Me.lstOccupation.Name = "lstOccupation"
        Me.lstOccupation.Size = New System.Drawing.Size(130, 214)
        Me.lstOccupation.TabIndex = 7
        '
        'lblOccupation
        '
        Me.lblOccupation.AutoSize = True
        Me.lblOccupation.Location = New System.Drawing.Point(605, 47)
        Me.lblOccupation.Name = "lblOccupation"
        Me.lblOccupation.Size = New System.Drawing.Size(69, 15)
        Me.lblOccupation.TabIndex = 8
        Me.lblOccupation.Text = "Occupation"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblOccupation)
        Me.Controls.Add(Me.lstOccupation)
        Me.Controls.Add(Me.lblStreetAddress)
        Me.Controls.Add(Me.txtStreetAddress)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.btnSubmit)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtStreetAddress As TextBox
    Friend WithEvents lblStreetAddress As Label
    Friend WithEvents lstOccupation As ListBox
    Friend WithEvents lblOccupation As Label
End Class
