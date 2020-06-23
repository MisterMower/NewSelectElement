<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCurrentSelection
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
        Me.components = New System.ComponentModel.Container()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxObjectName = New System.Windows.Forms.TextBox()
        Me.TextBoxObjectType = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SelectionTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ButtonClose
        '
        Me.ButtonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClose.Location = New System.Drawing.Point(270, 116)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(100, 25)
        Me.ButtonClose.TabIndex = 0
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Object Name"
        '
        'TextBoxObjectName
        '
        Me.TextBoxObjectName.Location = New System.Drawing.Point(12, 29)
        Me.TextBoxObjectName.Name = "TextBoxObjectName"
        Me.TextBoxObjectName.ReadOnly = True
        Me.TextBoxObjectName.Size = New System.Drawing.Size(358, 22)
        Me.TextBoxObjectName.TabIndex = 2
        '
        'TextBoxObjectType
        '
        Me.TextBoxObjectType.Location = New System.Drawing.Point(12, 74)
        Me.TextBoxObjectType.Name = "TextBoxObjectType"
        Me.TextBoxObjectType.ReadOnly = True
        Me.TextBoxObjectType.Size = New System.Drawing.Size(358, 22)
        Me.TextBoxObjectType.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Object Type"
        '
        'SelectionTimer
        '
        '
        'FormCurrentSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 153)
        Me.Controls.Add(Me.TextBoxObjectType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxObjectName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonClose)
        Me.Name = "FormCurrentSelection"
        Me.Text = "Current Selection"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxObjectName As TextBox
    Friend WithEvents TextBoxObjectType As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents SelectionTimer As Timer
End Class
