<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHangman
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHangman))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.lblWord = New System.Windows.Forms.Label()
        Me.btnGiveUp = New System.Windows.Forms.Button()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.txtGuess = New System.Windows.Forms.TextBox()
        Me.lblGuess = New System.Windows.Forms.Label()
        Me.btnGuess = New System.Windows.Forms.Button()
        Me.pctHangman = New System.Windows.Forms.PictureBox()
        Me.lstCheats = New System.Windows.Forms.ListBox()
        Me.chkCheats = New System.Windows.Forms.CheckBox()
        CType(Me.pctHangman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe Print", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(187, 57)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Hangman"
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Segoe Print", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(263, 12)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(93, 45)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnRestart
        '
        Me.btnRestart.Font = New System.Drawing.Font("Segoe Print", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestart.Location = New System.Drawing.Point(362, 12)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(101, 45)
        Me.btnRestart.TabIndex = 3
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = True
        Me.btnRestart.Visible = False
        '
        'lblWord
        '
        Me.lblWord.AutoSize = True
        Me.lblWord.Font = New System.Drawing.Font("Segoe Print", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWord.Location = New System.Drawing.Point(362, 69)
        Me.lblWord.Name = "lblWord"
        Me.lblWord.Size = New System.Drawing.Size(309, 57)
        Me.lblWord.TabIndex = 4
        Me.lblWord.Text = "_ _ _ _ _ _ _ _ _ _ _"
        Me.lblWord.Visible = False
        '
        'btnGiveUp
        '
        Me.btnGiveUp.Font = New System.Drawing.Font("Segoe Print", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGiveUp.Location = New System.Drawing.Point(469, 12)
        Me.btnGiveUp.Name = "btnGiveUp"
        Me.btnGiveUp.Size = New System.Drawing.Size(101, 45)
        Me.btnGiveUp.TabIndex = 5
        Me.btnGiveUp.Text = "Give up"
        Me.btnGiveUp.UseVisualStyleBackColor = True
        Me.btnGiveUp.Visible = False
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(617, 15)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(118, 42)
        Me.lblScore.TabIndex = 6
        Me.lblScore.Text = "Score: 0"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(365, 326)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(24, 42)
        Me.lblInfo.TabIndex = 7
        Me.lblInfo.Text = "."
        Me.lblInfo.Visible = False
        '
        'txtGuess
        '
        Me.txtGuess.BackColor = System.Drawing.Color.Snow
        Me.txtGuess.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuess.Location = New System.Drawing.Point(372, 232)
        Me.txtGuess.MaxLength = 1
        Me.txtGuess.Name = "txtGuess"
        Me.txtGuess.Size = New System.Drawing.Size(45, 45)
        Me.txtGuess.TabIndex = 8
        Me.txtGuess.Visible = False
        '
        'lblGuess
        '
        Me.lblGuess.AutoSize = True
        Me.lblGuess.Font = New System.Drawing.Font("Segoe Print", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuess.Location = New System.Drawing.Point(366, 194)
        Me.lblGuess.Name = "lblGuess"
        Me.lblGuess.Size = New System.Drawing.Size(153, 35)
        Me.lblGuess.TabIndex = 9
        Me.lblGuess.Text = "Enter a letter"
        Me.lblGuess.Visible = False
        '
        'btnGuess
        '
        Me.btnGuess.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuess.Location = New System.Drawing.Point(423, 232)
        Me.btnGuess.Name = "btnGuess"
        Me.btnGuess.Size = New System.Drawing.Size(96, 45)
        Me.btnGuess.TabIndex = 10
        Me.btnGuess.Text = "Guess"
        Me.btnGuess.UseVisualStyleBackColor = True
        Me.btnGuess.Visible = False
        '
        'pctHangman
        '
        Me.pctHangman.Image = CType(resources.GetObject("pctHangman.Image"), System.Drawing.Image)
        Me.pctHangman.Location = New System.Drawing.Point(12, 69)
        Me.pctHangman.Name = "pctHangman"
        Me.pctHangman.Size = New System.Drawing.Size(344, 369)
        Me.pctHangman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctHangman.TabIndex = 0
        Me.pctHangman.TabStop = False
        '
        'lstCheats
        '
        Me.lstCheats.FormattingEnabled = True
        Me.lstCheats.Location = New System.Drawing.Point(664, 108)
        Me.lstCheats.Name = "lstCheats"
        Me.lstCheats.Size = New System.Drawing.Size(133, 329)
        Me.lstCheats.TabIndex = 11
        Me.lstCheats.Visible = False
        '
        'chkCheats
        '
        Me.chkCheats.AutoSize = True
        Me.chkCheats.Location = New System.Drawing.Point(690, 85)
        Me.chkCheats.Name = "chkCheats"
        Me.chkCheats.Size = New System.Drawing.Size(59, 17)
        Me.chkCheats.TabIndex = 12
        Me.chkCheats.Text = "Cheats"
        Me.chkCheats.UseVisualStyleBackColor = True
        '
        'frmHangman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.chkCheats)
        Me.Controls.Add(Me.lstCheats)
        Me.Controls.Add(Me.btnGuess)
        Me.Controls.Add(Me.lblGuess)
        Me.Controls.Add(Me.txtGuess)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.btnGiveUp)
        Me.Controls.Add(Me.lblWord)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pctHangman)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHangman"
        Me.Text = "Hangman"
        CType(Me.pctHangman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pctHangman As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnRestart As Button
    Friend WithEvents lblWord As Label
    Friend WithEvents btnGiveUp As Button
    Friend WithEvents lblScore As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents txtGuess As TextBox
    Friend WithEvents lblGuess As Label
    Friend WithEvents btnGuess As Button
    Friend WithEvents lstCheats As ListBox
    Friend WithEvents chkCheats As CheckBox
End Class
