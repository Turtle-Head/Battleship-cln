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
        Ex1 = New Button()
        Fire = New Button()
        Output1 = New RichTextBox()
        Xv = New TextBox()
        Yv = New TextBox()
        SuspendLayout()
        ' 
        ' Ex1
        ' 
        Ex1.BackColor = Color.MidnightBlue
        Ex1.ForeColor = Color.Gold
        Ex1.Location = New Point(33, 12)
        Ex1.Name = "Ex1"
        Ex1.Size = New Size(125, 23)
        Ex1.TabIndex = 0
        Ex1.Text = "Initialize"
        Ex1.UseVisualStyleBackColor = False
        ' 
        ' Fire
        ' 
        Fire.BackColor = Color.DarkBlue
        Fire.ForeColor = Color.Gold
        Fire.Location = New Point(33, 163)
        Fire.Name = "Fire"
        Fire.Size = New Size(124, 23)
        Fire.TabIndex = 3
        Fire.Text = "Fire"
        Fire.UseVisualStyleBackColor = False
        ' 
        ' Output1
        ' 
        Output1.BackColor = SystemColors.ControlText
        Output1.Cursor = Cursors.Hand
        Output1.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Output1.ForeColor = Color.Gold
        Output1.Location = New Point(51, 51)
        Output1.Name = "Output1"
        Output1.ReadOnly = True
        Output1.ScrollBars = RichTextBoxScrollBars.None
        Output1.Size = New Size(68, 96)
        Output1.TabIndex = 2
        Output1.TabStop = False
        Output1.Text = ""' 
        ' Xv
        ' 
        Xv.BackColor = Color.Navy
        Xv.ForeColor = Color.Gold
        Xv.Location = New Point(132, 52)
        Xv.Name = "Xv"
        Xv.PlaceholderText = "X"
        Xv.Size = New Size(14, 23)
        Xv.TabIndex = 1
        ' 
        ' Yv
        ' 
        Yv.BackColor = Color.Navy
        Yv.ForeColor = Color.Gold
        Yv.Location = New Point(132, 124)
        Yv.Name = "Yv"
        Yv.PlaceholderText = "Y"
        Yv.Size = New Size(14, 23)
        Yv.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MidnightBlue
        BackgroundImage = My.Resources.Resources.abstract_7430672_640
        ClientSize = New Size(192, 217)
        Controls.Add(Yv)
        Controls.Add(Xv)
        Controls.Add(Output1)
        Controls.Add(Fire)
        Controls.Add(Ex1)
        Name = "Form1"
        ShowIcon = False
        Text = "Battleship"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Ex1 As Button
    Friend WithEvents Fire As Button
    Friend WithEvents Output1 As RichTextBox
    Friend WithEvents Xv As TextBox
    Friend WithEvents Yv As TextBox
End Class
