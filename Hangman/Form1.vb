Public Class frmHangman

    Dim words() As String = {"school", "survive", "bowl", "plate", "fork", "knife", "butter", "spoon", "potato", "word", "wrong", "right", "left", "up", "down", "on", "in", "of", "can", "tin", "aluminium", "frost", "frog", "top", "jellyfish", "heat", "pen", "snow", "playground", "car", "trousers", "ear", "treatment", "nest", "cave", "meeting", "fear", "number", "spade", "turkey", "force", "kick", "sand", "whole", "wrist", "jail", "guide", "money", "mask", "account", "cake", "shirt", "theory", "cheese", "cemetery", "letters", "cushion", "dinosaurs", "boot", "trail", "duck", "ship", "pineapple", "computer", "lion", "games", "radio", "light", "shelf", "boat", "water", "remote", "field", "tree", "dog", "wallpaper", "country", "city", "keys", "scissors", "square", "finger", "history", "scarecrow", "pipe", "channel", "toothbrush", "cloth", "camera", "rings", "calendar", "egg", "pocket", "limousine", "shed", "netflix", "taxi", "bike", "electricity", "waves", "triangles", "police", "bank", "revision", "wheelchair", "rubber", "television", "earphones", "telephones", "baguette", "jumper", "shoes", "slippers", "class", "pencil", "ruler", "student", "lunch", "breakfast", "dinner", "watch", "witch", "trolley", "tablet", "slide", "sea", "pea", "playground", "van", "lamp", "moth", "soup", "pot", "hamburger", "chicken", "cow", "pig", "world", "space", "sun", "pool", "float", "party", "baloons", "fabric", "writer", "promotion", "brain", "package", "hospital", "combination", "degree", "film", "counter", "entry", "pizza", "husband", "earth", "designer", "register", "daughter", "medicine", "chance", "bridge", "hat", "blank", "aspect", "garbage", "respect", "upstairs", "garden", "ice", "sock", "south", "trouble", "oven", "security", "tie", "kettle", "research", "reward", "concert", "shower", "net", "border", "harbour", "tower", "house", "plane", "president", "ash", "doctor", "court", "prison"}
    Dim word As String = ""
    Dim guesses As String = ""
    Dim score As Integer = 0
    Dim r As New Random
    Dim hasStarted As Boolean = False
    Dim stage As Integer = 1



    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        If Not hasStarted Then

            hasStarted = True
            btnStart.Visible = False
            restart()

        End If

    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click

        Dim max As Integer = 0

        restart()

    End Sub

    Private Sub btnGiveUp_Click(sender As Object, e As EventArgs) Handles btnGiveUp.Click
        giveUp()
    End Sub

    Private Sub btnGuess_Click(sender As Object, e As EventArgs) Handles btnGuess.Click
        If Not txtGuess.Text.Equals("") Then
            submitGuess(txtGuess.Text)
        End If
    End Sub

    Private Sub chkCheats_CheckedChanged(sender As Object, e As EventArgs) Handles chkCheats.CheckedChanged
        lstCheats.Visible = chkCheats.Checked
    End Sub








    Private Sub updateScore()
        lblScore.Text = "Score: " + Str(score)
    End Sub

    Private Sub newWord()

        word = words(r.Next(0, words.Length))
        guesses = ""

    End Sub

    Private Sub Info(msg As String)
        lblInfo.Text = msg
    End Sub

    Private Sub updateStage()

        Select Case stage
            Case 1
                pctHangman.Image = My.Resources.stage7
            Case 2
                pctHangman.Image = My.Resources.stage6
            Case 3
                pctHangman.Image = My.Resources.stage5
            Case 4
                pctHangman.Image = My.Resources.stage4
            Case 5
                pctHangman.Image = My.Resources.stage3
            Case 6
                pctHangman.Image = My.Resources.stage2
            Case 7
                pctHangman.Image = My.Resources.stage1
        End Select

    End Sub

    Private Sub updateDisplayedWord()

        lblWord.Text = ""

        For Each c As String In word
            If guesses.Contains(c) Then
                lblWord.Text += c + " "
            Else
                lblWord.Text += "_ "
            End If
        Next

        lstCheats.Items.Clear()

        If guesses.Length = 0 Then

            For Each w As String In words
                If w.Length = word.Length Then
                    lstCheats.Items.Add(w)
                End If
            Next

        Else

            For Each w As String In words
                Dim contains As Integer = 0
                For Each g As String In guesses
                    If w.Contains(g.ToLower()) Then
                        contains += 1
                    End If
                Next
                If contains = guesses.Length And w.Length = word.Length Then
                    lstCheats.Items.Add(w)
                Else
                    'lstCheats.Items.Add("#" + w)
                End If
            Next

        End If


    End Sub

    Private Sub checkForWinOrDeath()

        If Not lblWord.Text.Contains("_") Then

            Info("Congrats, you have won!")
            score += 1
            updateScore()
            endGame()

        ElseIf stage >= 7 Then

            Info("Unlucky, you have lost.")
            guesses = word
            updateDisplayedWord()
            endGame()

        End If

    End Sub

    Private Sub giveUp()
        Info("You gave up.")
        guesses = word
        updateDisplayedWord()
        endGame()
    End Sub

    Private Sub showGame(visible As Boolean)
        btnGiveUp.Visible = visible
        txtGuess.Visible = visible
        lblGuess.Visible = visible
        lblWord.Visible = visible
        lblInfo.Visible = visible
        btnRestart.Visible = visible
        btnGuess.Visible = visible
    End Sub

    Private Sub endGame()
        btnGiveUp.Visible = False
        btnGuess.Visible = False
        lblGuess.Visible = False
        txtGuess.Visible = False
    End Sub

    Private Sub submitGuess(c As String)

        If Not guesses.Contains(c) Then
            If Char.IsLetter(c) Then

                txtGuess.Text = ""

                guesses += c

                If word.Contains(c) Then
                    Info("Correct!")
                    updateDisplayedWord()
                Else
                    Info("Incorrect.")
                    stage += 1
                    updateStage()
                End If

                checkForWinOrDeath()

            Else
                txtGuess.Text = ""
                Info("That is not a letter!")
            End If
        Else
            txtGuess.Text = ""
            Info("You have already guessed that!")
        End If

    End Sub

    Private Sub restart()

        stage = 1
        updateStage()

        Info("")

        showGame(True)

        newWord()

        updateDisplayedWord()

    End Sub
End Class
