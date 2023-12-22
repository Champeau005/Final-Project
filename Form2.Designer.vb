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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.gboSelection = New System.Windows.Forms.GroupBox()
        Me.radScissors = New System.Windows.Forms.RadioButton()
        Me.radPaper = New System.Windows.Forms.RadioButton()
        Me.radRock = New System.Windows.Forms.RadioButton()
        Me.pbxChoice = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblHeading2 = New System.Windows.Forms.Label()
        Me.btnShoot = New System.Windows.Forms.Button()
        Me.lblChallengerPicks = New System.Windows.Forms.Label()
        Me.lblComputerPicks = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblWinAverage = New System.Windows.Forms.Label()
        Me.lblNumLose = New System.Windows.Forms.Label()
        Me.lblNumTie = New System.Windows.Forms.Label()
        Me.lblNumWin = New System.Windows.Forms.Label()
        Me.lstHistory = New System.Windows.Forms.ListBox()
        Me.lblHistory = New System.Windows.Forms.Label()
        Me.lblStats = New System.Windows.Forms.Label()
        Me.gboSelection.SuspendLayout()
        CType(Me.pbxChoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(124, 37)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(552, 31)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Challenger              vs                Computer"
        '
        'gboSelection
        '
        Me.gboSelection.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.gboSelection.Controls.Add(Me.radScissors)
        Me.gboSelection.Controls.Add(Me.radPaper)
        Me.gboSelection.Controls.Add(Me.radRock)
        Me.gboSelection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboSelection.ForeColor = System.Drawing.Color.White
        Me.gboSelection.Location = New System.Drawing.Point(108, 100)
        Me.gboSelection.Name = "gboSelection"
        Me.gboSelection.Size = New System.Drawing.Size(174, 100)
        Me.gboSelection.TabIndex = 1
        Me.gboSelection.TabStop = False
        Me.gboSelection.Text = "Choose Your Destiny"
        '
        'radScissors
        '
        Me.radScissors.AutoSize = True
        Me.radScissors.Location = New System.Drawing.Point(22, 70)
        Me.radScissors.Name = "radScissors"
        Me.radScissors.Size = New System.Drawing.Size(87, 24)
        Me.radScissors.TabIndex = 2
        Me.radScissors.Text = "Scissors"
        Me.radScissors.UseVisualStyleBackColor = True
        '
        'radPaper
        '
        Me.radPaper.AutoSize = True
        Me.radPaper.Location = New System.Drawing.Point(22, 45)
        Me.radPaper.Name = "radPaper"
        Me.radPaper.Size = New System.Drawing.Size(69, 24)
        Me.radPaper.TabIndex = 1
        Me.radPaper.Text = "Paper"
        Me.radPaper.UseVisualStyleBackColor = True
        '
        'radRock
        '
        Me.radRock.AutoSize = True
        Me.radRock.Location = New System.Drawing.Point(22, 20)
        Me.radRock.Name = "radRock"
        Me.radRock.Size = New System.Drawing.Size(64, 24)
        Me.radRock.TabIndex = 0
        Me.radRock.Text = "Rock"
        Me.radRock.UseVisualStyleBackColor = True
        '
        'pbxChoice
        '
        Me.pbxChoice.BackgroundImage = Global.Final_Project.My.Resources.Resources.QuestionPic
        Me.pbxChoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxChoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxChoice.Location = New System.Drawing.Point(558, 100)
        Me.pbxChoice.Name = "pbxChoice"
        Me.pbxChoice.Size = New System.Drawing.Size(100, 100)
        Me.pbxChoice.TabIndex = 2
        Me.pbxChoice.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuMenu
        '
        Me.mnuMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear, Me.mnuExit})
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Size = New System.Drawing.Size(50, 20)
        Me.mnuMenu.Text = "Menu"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(101, 22)
        Me.mnuClear.Text = "Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(101, 22)
        Me.mnuExit.Text = "Exit"
        '
        'lblHeading2
        '
        Me.lblHeading2.AutoSize = True
        Me.lblHeading2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading2.Location = New System.Drawing.Point(275, 254)
        Me.lblHeading2.Name = "lblHeading2"
        Me.lblHeading2.Size = New System.Drawing.Size(176, 20)
        Me.lblHeading2.TabIndex = 4
        Me.lblHeading2.Text = "Rock, Paper, Scissors..."
        '
        'btnShoot
        '
        Me.btnShoot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShoot.Location = New System.Drawing.Point(447, 249)
        Me.btnShoot.Name = "btnShoot"
        Me.btnShoot.Size = New System.Drawing.Size(78, 31)
        Me.btnShoot.TabIndex = 5
        Me.btnShoot.Text = "Shoot"
        Me.btnShoot.UseVisualStyleBackColor = True
        '
        'lblChallengerPicks
        '
        Me.lblChallengerPicks.AutoSize = True
        Me.lblChallengerPicks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChallengerPicks.Location = New System.Drawing.Point(106, 214)
        Me.lblChallengerPicks.Name = "lblChallengerPicks"
        Me.lblChallengerPicks.Size = New System.Drawing.Size(138, 20)
        Me.lblChallengerPicks.TabIndex = 6
        Me.lblChallengerPicks.Text = "Challenger Picks..."
        Me.lblChallengerPicks.Visible = False
        '
        'lblComputerPicks
        '
        Me.lblComputerPicks.AutoSize = True
        Me.lblComputerPicks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComputerPicks.Location = New System.Drawing.Point(520, 214)
        Me.lblComputerPicks.Name = "lblComputerPicks"
        Me.lblComputerPicks.Size = New System.Drawing.Size(132, 20)
        Me.lblComputerPicks.TabIndex = 7
        Me.lblComputerPicks.Text = "Computer Picks..."
        Me.lblComputerPicks.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel1.Controls.Add(Me.lblWinAverage)
        Me.Panel1.Controls.Add(Me.lblNumLose)
        Me.Panel1.Controls.Add(Me.lblNumTie)
        Me.Panel1.Controls.Add(Me.lblNumWin)
        Me.Panel1.Controls.Add(Me.lstHistory)
        Me.Panel1.Location = New System.Drawing.Point(0, 320)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 163)
        Me.Panel1.TabIndex = 8
        '
        'lblWinAverage
        '
        Me.lblWinAverage.AutoSize = True
        Me.lblWinAverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinAverage.ForeColor = System.Drawing.Color.White
        Me.lblWinAverage.Location = New System.Drawing.Point(410, 128)
        Me.lblWinAverage.Name = "lblWinAverage"
        Me.lblWinAverage.Size = New System.Drawing.Size(115, 20)
        Me.lblWinAverage.TabIndex = 14
        Me.lblWinAverage.Text = "Win Average:"
        '
        'lblNumLose
        '
        Me.lblNumLose.AutoSize = True
        Me.lblNumLose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumLose.ForeColor = System.Drawing.Color.White
        Me.lblNumLose.Location = New System.Drawing.Point(410, 90)
        Me.lblNumLose.Name = "lblNumLose"
        Me.lblNumLose.Size = New System.Drawing.Size(159, 20)
        Me.lblNumLose.TabIndex = 13
        Me.lblNumLose.Text = "Number of Losses:"
        '
        'lblNumTie
        '
        Me.lblNumTie.AutoSize = True
        Me.lblNumTie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumTie.ForeColor = System.Drawing.Color.White
        Me.lblNumTie.Location = New System.Drawing.Point(410, 52)
        Me.lblNumTie.Name = "lblNumTie"
        Me.lblNumTie.Size = New System.Drawing.Size(135, 20)
        Me.lblNumTie.TabIndex = 12
        Me.lblNumTie.Text = "Number of Ties:"
        '
        'lblNumWin
        '
        Me.lblNumWin.AutoSize = True
        Me.lblNumWin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumWin.ForeColor = System.Drawing.Color.White
        Me.lblNumWin.Location = New System.Drawing.Point(410, 14)
        Me.lblNumWin.Name = "lblNumWin"
        Me.lblNumWin.Size = New System.Drawing.Size(141, 20)
        Me.lblNumWin.TabIndex = 11
        Me.lblNumWin.Text = "Number of Wins:"
        '
        'lstHistory
        '
        Me.lstHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstHistory.FormattingEnabled = True
        Me.lstHistory.ItemHeight = 20
        Me.lstHistory.Location = New System.Drawing.Point(0, -1)
        Me.lstHistory.Name = "lstHistory"
        Me.lstHistory.Size = New System.Drawing.Size(399, 164)
        Me.lstHistory.TabIndex = 0
        '
        'lblHistory
        '
        Me.lblHistory.AutoSize = True
        Me.lblHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHistory.Location = New System.Drawing.Point(4, 297)
        Me.lblHistory.Name = "lblHistory"
        Me.lblHistory.Size = New System.Drawing.Size(283, 20)
        Me.lblHistory.TabIndex = 9
        Me.lblHistory.Text = "Match History (Up to 10 Matches):"
        '
        'lblStats
        '
        Me.lblStats.AutoSize = True
        Me.lblStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStats.Location = New System.Drawing.Point(410, 297)
        Me.lblStats.Name = "lblStats"
        Me.lblStats.Size = New System.Drawing.Size(148, 20)
        Me.lblStats.TabIndex = 10
        Me.lblStats.Text = "Challenger Stats:"
        '
        'Form2
        '
        Me.AcceptButton = Me.btnShoot
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(800, 479)
        Me.Controls.Add(Me.lblStats)
        Me.Controls.Add(Me.lblHistory)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblComputerPicks)
        Me.Controls.Add(Me.lblChallengerPicks)
        Me.Controls.Add(Me.btnShoot)
        Me.Controls.Add(Me.lblHeading2)
        Me.Controls.Add(Me.pbxChoice)
        Me.Controls.Add(Me.gboSelection)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "Rock, Paper, Scissors"
        Me.gboSelection.ResumeLayout(False)
        Me.gboSelection.PerformLayout()
        CType(Me.pbxChoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents gboSelection As GroupBox
    Friend WithEvents radScissors As RadioButton
    Friend WithEvents radPaper As RadioButton
    Friend WithEvents radRock As RadioButton
    Friend WithEvents pbxChoice As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuMenu As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lblHeading2 As Label
    Friend WithEvents btnShoot As Button
    Friend WithEvents lblChallengerPicks As Label
    Friend WithEvents lblComputerPicks As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lstHistory As ListBox
    Friend WithEvents lblHistory As Label
    Friend WithEvents lblNumWin As Label
    Friend WithEvents lblStats As Label
    Friend WithEvents lblWinAverage As Label
    Friend WithEvents lblNumLose As Label
    Friend WithEvents lblNumTie As Label
End Class
