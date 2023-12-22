'Program Name: Rock, Paper, Scissors
'Author: Tabitha Champeau
'Date: December 15, 2023
'Purpose: The program simulates the game rock, paper, scissors between a challenger and the computer.
'Challenger will pick either rock, paper, or scissors and compare their choice against the computer's randomly 
'generated choice.  A message box will appear declaring the winner according to the traditional game ruels.
'Match history will be recorded in a list box while the Challenger's stats are tracked in real time.


Imports System.Random

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set all radio buttons to unchecked.
        radPaper.Checked = False
        radRock.Checked = False
        radScissors.Checked = False

        'Hold the splash screen for 3 sec

        Threading.Thread.Sleep(3000)

    End Sub


    Private Sub btnShoot_Click(sender As Object, e As EventArgs) Handles btnShoot.Click

        'Error Message is no radio buttons checked and nestled in is the game code
        If radPaper.Checked = False AndAlso radRock.Checked = False AndAlso radScissors.Checked = False Then
            MessageBox.Show("Don't go to a fight empty handed!  Please choose either rock, paper, or scissors for defense.")
        Else
            'Random Number generator for 1-3 to stand for computer choice
            '1 = Rock
            '2 = Paper
            '3 = Scissors
            Dim intComputerChoice As Integer = CInt(Int((3 * Rnd()) + 1))

            lblChallengerPicks.Visible = True
            lblComputerPicks.Visible = True

            'Rock, Paper, Scissors bit 
            If radRock.Checked = True Then
                If intComputerChoice = 1 Then
                    MessageBox.Show("It's a tie!")
                    lstHistory.Items.Add("Tie")
                    lblChallengerPicks.Text = "Challenger Picked Rock!"
                    lblComputerPicks.Text = "Computer Picked Rock!"
                    pbxChoice.BackgroundImage = Final_Project.My.Resources.Resources.RockPic
                ElseIf intComputerChoice = 2 Then
                    MessageBox.Show("Computer Wins! Paper beats Rock. Don't worry, you'll beat them next time.")
                    lstHistory.Items.Add("Lose")
                    lblChallengerPicks.Text = "Challenger Picked Rock!"
                    lblComputerPicks.Text = "Computer Picked Paper!"
                    pbxChoice.BackgroundImage = Final_Project.My.Resources.Resources.PaperPic
                ElseIf intComputerChoice = 3 Then
                    MessageBox.Show("Challenger Wins! Rock beats Scissors. Think you can do it again?")
                    lstHistory.Items.Add("Win")
                    lblChallengerPicks.Text = "Challenger Picked Rock!"
                    lblComputerPicks.Text = "Computer Picked Scissors!"
                    pbxChoice.BackgroundImage = Final_Project.My.Resources.Resources.ScissorsPic
                End If
            ElseIf radPaper.Checked = True Then
                If intComputerChoice = 2 Then
                    MessageBox.Show("It's a tie!")
                    lstHistory.Items.Add("Tie")
                    lblChallengerPicks.Text = "Challenger Picked Paper!"
                    lblComputerPicks.Text = "Computer Picked Paper!"
                    pbxChoice.BackgroundImage = Final_Project.My.Resources.Resources.PaperPic
                ElseIf intComputerChoice = 3 Then
                    MessageBox.Show("Computer Wins! Scissors beats Paper. Don't worry, you'll get them next time.")
                    lstHistory.Items.Add("Lose")
                    lblChallengerPicks.Text = "Challenger Picked Paper!"
                    lblComputerPicks.Text = "Computer Picked Scissors!"
                    pbxChoice.BackgroundImage = Final_Project.My.Resources.Resources.ScissorsPic
                ElseIf intComputerChoice = 1 Then
                    MessageBox.Show("Challenger Wins! Paper beats Rock. Care to try again?")
                    lstHistory.Items.Add("Win")
                    lblChallengerPicks.Text = "Challenger Picked Paper!"
                    lblComputerPicks.Text = "Computer Picked Rock!"
                    pbxChoice.BackgroundImage = Final_Project.My.Resources.Resources.RockPic
                End If
            ElseIf radScissors.Checked = True Then
                If intComputerChoice = 3 Then
                    MessageBox.Show("It's a tie!")
                    lstHistory.Items.Add("Tie")
                    lblChallengerPicks.Text = "Challenger Picked Scissors!"
                    lblComputerPicks.Text = "Computer Picked Scissors!"
                    pbxChoice.BackgroundImage = Final_Project.My.Resources.Resources.ScissorsPic
                ElseIf intComputerChoice = 1 Then
                    MessageBox.Show("Computer Wins! Rock beats Scissors. Don't give up, there's always next time.")
                    lstHistory.Items.Add("Lose")
                    lblChallengerPicks.Text = "Challenger Picked Scissors!"
                    lblComputerPicks.Text = "Computer Picked Rock!"
                    pbxChoice.BackgroundImage = Final_Project.My.Resources.Resources.RockPic
                ElseIf intComputerChoice = 2 Then
                    MessageBox.Show("Challenger Wins! Scissors beats paper. Wanna go another round?")
                    lstHistory.Items.Add("Win")
                    lblChallengerPicks.Text = "Challenger Picked Scissors!"
                    lblComputerPicks.Text = "Computer Picked Paper!"
                    pbxChoice.BackgroundImage = Final_Project.My.Resources.Resources.PaperPic
                End If
            End If
        End If
        'Limiting number of lstbox items to 10 
        If lstHistory.Items.Count <= 9 Then
            btnShoot.Enabled = True
        Else
            btnShoot.Enabled = False
            MessageBox.Show("Match History can only track up to 10 matches.  Please Clear Match History before trying again")
        End If

        'Looping through the lstbox to update statistics
        If radPaper.Checked = False AndAlso radRock.Checked = False AndAlso radScissors.Checked = False Then

        Else
            Dim intWins As Integer = 0
            Dim intLose As Integer = 0
            Dim intTie As Integer = 0

            For Each i As String In lstHistory.Items
                If i.StartsWith("Win") Then
                    intWins += 1
                    lblNumWin.Text = "Number of Wins: " & intWins
                ElseIf i.StartsWith("Lose") Then
                    intLose += 1
                    lblNumLose.Text = "Number of Loses: " & intLose
                ElseIf i.StartsWith("Tie") Then
                    intTie += 1
                    lblNumTie.Text = "Number of Ties: " & intTie
                Else
                    MessageBox.Show("Sorry something went wrong, try again")
                End If
            Next

            Dim intAverage As Integer
            intAverage = (intWins / lstHistory.Items.Count) * 100
            lblWinAverage.Text = "Win Average: " & intAverage & "%"

        End If
        'Resets radio buttons after button is clicked in preperation for the next round.
        radPaper.Checked = False
        radRock.Checked = False
        radScissors.Checked = False


    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        'The mnuClear click event clears the Listbox object of Match History,
        'resets picturebox to questionmark pic, enables shoot button, hides lbls showing who picked what,
        'and unchecks all radio buttons, and resets the statistics.

        lstHistory.Items.Clear()

        radPaper.Checked = False
        radRock.Checked = False
        radScissors.Checked = False

        lblChallengerPicks.Visible = False
        lblComputerPicks.Visible = False
        pbxChoice.BackgroundImage = Final_Project.My.Resources.Resources.QuestionPic
        btnShoot.Enabled = True

        lblNumWin.Text = "Number of Wins:"
        lblNumTie.Text = "Number of Ties:"
        lblNumLose.Text = "Number of Losses:"
        lblWinAverage.Text = "Win Average:"

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'This mnu click event closes the window and exits the application

        Close()
    End Sub



End Class


