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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ShowHiddenBtn = New System.Windows.Forms.Button()
        Me.AlphabetBox1 = New System.Windows.Forms.GroupBox()
        Me.Alphabet1 = New System.Windows.Forms.Label()
        Me.RandomBtn = New System.Windows.Forms.Button()
        Me.CustomBtn = New System.Windows.Forms.Button()
        Me.AlphabetBox2 = New System.Windows.Forms.GroupBox()
        Me.Alphabet2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AlphabetBox1.SuspendLayout()
        Me.AlphabetBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ShowHiddenBtn
        '
        Me.ShowHiddenBtn.Font = New System.Drawing.Font("Mali", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ShowHiddenBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ShowHiddenBtn.Location = New System.Drawing.Point(12, 115)
        Me.ShowHiddenBtn.Name = "ShowHiddenBtn"
        Me.ShowHiddenBtn.Size = New System.Drawing.Size(230, 98)
        Me.ShowHiddenBtn.TabIndex = 9
        Me.ShowHiddenBtn.Text = "Show Romaji"
        Me.ShowHiddenBtn.UseVisualStyleBackColor = True
        '
        'AlphabetBox1
        '
        Me.AlphabetBox1.Controls.Add(Me.Alphabet1)
        Me.AlphabetBox1.Font = New System.Drawing.Font("Mali", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AlphabetBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AlphabetBox1.Location = New System.Drawing.Point(257, 12)
        Me.AlphabetBox1.Name = "AlphabetBox1"
        Me.AlphabetBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AlphabetBox1.Size = New System.Drawing.Size(300, 300)
        Me.AlphabetBox1.TabIndex = 8
        Me.AlphabetBox1.TabStop = False
        Me.AlphabetBox1.Text = "Japanese Alphabet"
        '
        'Alphabet1
        '
        Me.Alphabet1.Font = New System.Drawing.Font("TakaoGothic", 84.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Alphabet1.Location = New System.Drawing.Point(6, 90)
        Me.Alphabet1.Name = "Alphabet1"
        Me.Alphabet1.Size = New System.Drawing.Size(291, 129)
        Me.Alphabet1.TabIndex = 0
        Me.Alphabet1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RandomBtn
        '
        Me.RandomBtn.Font = New System.Drawing.Font("Mali", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RandomBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RandomBtn.Location = New System.Drawing.Point(12, 12)
        Me.RandomBtn.Name = "RandomBtn"
        Me.RandomBtn.Size = New System.Drawing.Size(230, 98)
        Me.RandomBtn.TabIndex = 7
        Me.RandomBtn.Text = "Random"
        Me.RandomBtn.UseVisualStyleBackColor = True
        '
        'CustomBtn
        '
        Me.CustomBtn.Font = New System.Drawing.Font("Mali", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CustomBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CustomBtn.Location = New System.Drawing.Point(129, 219)
        Me.CustomBtn.Name = "CustomBtn"
        Me.CustomBtn.Size = New System.Drawing.Size(113, 98)
        Me.CustomBtn.TabIndex = 6
        Me.CustomBtn.Text = "Custom"
        Me.CustomBtn.UseVisualStyleBackColor = True
        '
        'AlphabetBox2
        '
        Me.AlphabetBox2.Controls.Add(Me.Alphabet2)
        Me.AlphabetBox2.Font = New System.Drawing.Font("Mali", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AlphabetBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AlphabetBox2.Location = New System.Drawing.Point(575, 12)
        Me.AlphabetBox2.Name = "AlphabetBox2"
        Me.AlphabetBox2.Size = New System.Drawing.Size(300, 300)
        Me.AlphabetBox2.TabIndex = 10
        Me.AlphabetBox2.TabStop = False
        Me.AlphabetBox2.Text = "Romaji Alphabet"
        '
        'Alphabet2
        '
        Me.Alphabet2.Font = New System.Drawing.Font("TakaoGothic", 84.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Alphabet2.Location = New System.Drawing.Point(6, 90)
        Me.Alphabet2.Name = "Alphabet2"
        Me.Alphabet2.Size = New System.Drawing.Size(291, 129)
        Me.Alphabet2.TabIndex = 1
        Me.Alphabet2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Mali", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(12, 219)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 98)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(887, 359)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ShowHiddenBtn)
        Me.Controls.Add(Me.AlphabetBox1)
        Me.Controls.Add(Me.RandomBtn)
        Me.Controls.Add(Me.CustomBtn)
        Me.Controls.Add(Me.AlphabetBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Kana"
        Me.AlphabetBox1.ResumeLayout(False)
        Me.AlphabetBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ShowHiddenBtn As Button
    Friend WithEvents AlphabetBox1 As GroupBox
    Friend WithEvents Alphabet1 As Label
    Friend WithEvents RandomBtn As Button
    Friend WithEvents CustomBtn As Button
    Friend WithEvents AlphabetBox2 As GroupBox
    Friend WithEvents Alphabet2 As Label
    Friend WithEvents Button1 As Button
End Class
