Public Class Form1
    Dim playerHP As Integer = 3
    Dim enemyHP1, enemyHP2, enemyHP3, enemyHP4 As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enemyHP1 = 5
        enemyHP2 = 5
        enemyHP3 = 5
        enemyHP4 = 5

        UpdateUIHP()
        UpdateUI1()
        UpdateUI2()
        UpdateUI3()
    End Sub

    Private Sub lblAnswer1_1_Click(sender As Object, e As EventArgs) Handles lblAnswer1_1.Click
        If enemyHP1 = 5 Then
            enemyHP1 -= 1
        Else
            playerHP -= 1
        End If
        UpdateUIHP()
        UpdateUI1()
    End Sub

    Private Sub lblAnswer2_1_Click(sender As Object, e As EventArgs) Handles lblAnswer2_1.Click
        If enemyHP1 = 4 Then
            enemyHP1 -= 1
        Else
            playerHP -= 1
        End If
        UpdateUIHP()
        UpdateUI1()
    End Sub

    Private Sub lblAnswer3_1_Click(sender As Object, e As EventArgs) Handles lblAnswer3_1.Click
        If enemyHP1 = 3 Or enemyHP1 = 1 Then
            enemyHP1 -= 1
        Else
            playerHP -= 1
        End If
        UpdateUIHP()
        UpdateUI1()
    End Sub

    Private Sub lblAnswer4_1_Click(sender As Object, e As EventArgs) Handles lblAnswer4_1.Click
        If enemyHP1 = 2 Then
            enemyHP1 -= 1
        Else
            playerHP -= 1
        End If
        UpdateUIHP()
        UpdateUI1()
    End Sub

    Private Sub lblAnswer1_2_Click(sender As Object, e As EventArgs) Handles lblAnswer1_2.Click
        If enemyHP2 = 4 Or enemyHP2 = 1 Then
            enemyHP2 -= 1
        Else
            playerHP -= 1
        End If
        UpdateUIHP()
        UpdateUI2()
    End Sub

    Private Sub lblAnswer2_2_Click(sender As Object, e As EventArgs) Handles lblAnswer2_2.Click
        If enemyHP2 = 5 Then
            enemyHP2 -= 1
        Else
            playerHP -= 1
        End If
        UpdateUIHP()
        UpdateUI2()
    End Sub

    Private Sub lblAnswer3_2_Click(sender As Object, e As EventArgs) Handles lblAnswer3_2.Click
        If enemyHP2 = 3 Then
            enemyHP2 -= 1
        Else
            playerHP -= 1
        End If
        UpdateUIHP()
        UpdateUI2()
    End Sub

    Private Sub lblAnswer4_2_Click(sender As Object, e As EventArgs) Handles lblAnswer4_2.Click
        If enemyHP2 = 2 Then
            enemyHP2 -= 1
        Else
            playerHP -= 1
        End If
        UpdateUIHP()
        UpdateUI2()
    End Sub

    Private Sub lblAnswer1_3_Click(sender As Object, e As EventArgs) Handles lblAnswer1_3.Click
        If enemyHP3 = 4 Then
            enemyHP3 -= 1
        Else
            playerHP -= 1
        End If
        UpdateUIHP()
        UpdateUI3()
    End Sub

    Private Sub lblAnswer2_3_Click(sender As Object, e As EventArgs) Handles lblAnswer2_3.Click
        If enemyHP3 = 3 Then
            enemyHP3 -= 1
        Else
            playerHP -= 1
        End If
        UpdateUIHP()
        UpdateUI3()
    End Sub

    Private Sub lblAnswer3_3_Click(sender As Object, e As EventArgs) Handles lblAnswer3_3.Click
        If enemyHP3 = 5 Or enemyHP3 = 2 Then
            enemyHP3 -= 1
        Else
            playerHP -= 1
        End If
        UpdateUIHP()
        UpdateUI3()
    End Sub

    Private Sub lblAnswer4_3_Click(sender As Object, e As EventArgs) Handles lblAnswer4_3.Click
        If enemyHP3 = 1 Then
            enemyHP3 -= 1
        Else
            playerHP -= 1
        End If
        UpdateUIHP()
        UpdateUI3()
    End Sub

    Private Sub lblAnswer1_4_Click(sender As Object, e As EventArgs) Handles lblAnswer1_4.Click

    End Sub

    Private Sub lblAnswer2_4_Click(sender As Object, e As EventArgs) Handles lblAnswer2_4.Click

    End Sub

    Private Sub lblAnswer3_4_Click(sender As Object, e As EventArgs) Handles lblAnswer3_4.Click

    End Sub

    Private Sub lblAnswer4_4_Click(sender As Object, e As EventArgs) Handles lblAnswer4_4.Click

    End Sub
    Private Sub UpdateUIHP()
        lblHP1.Text = playerHP.ToString()
        lblHP2.Text = playerHP.ToString()
        lblHP3.Text = playerHP.ToString()
        lblHP4.Text = playerHP.ToString()

        If playerHP <= 0 Then
            MessageBox.Show("Game Over! You failed to defeat the demon lord.", "Game Over")
        ElseIf enemyHP1 And enemyHP2 AndAlso enemyHP3 AndAlso enemyHP4 <= 0 Then
            MessageBox.Show("Congratulations! You have defeated the demon lord!", "Victory!")
        End If
    End Sub
    Private Sub UpdateUI1()
        If enemyHP1 = 5 Then
            lblQuestion1.Text = "Solve the problem: " + vbCrLf + "If x - 5 = 0, what is x?"
            lblAnswer1_1.Text = "5"
            lblAnswer2_1.Text = "-5"
            lblAnswer3_1.Text = "0"
            lblAnswer4_1.Text = "10"
        ElseIf enemyHP1 = 4 Then
            lblQuestion1.Text = "Solve the problem: " + vbCrLf + "If 2x - 36 = 0, what is x?"
            lblAnswer1_1.Text = "20"
            lblAnswer2_1.Text = "18"
            lblAnswer3_1.Text = "16"
            lblAnswer4_1.Text = "22"
        ElseIf enemyHP1 = 3 Then
            lblQuestion1.Text = "Solve the problem: " + vbCrLf + "If 2x = 11 - 3, what is x?"
            lblAnswer1_1.Text = "8"
            lblAnswer2_1.Text = "12"
            lblAnswer3_1.Text = "4"
            lblAnswer4_1.Text = "6"
        ElseIf enemyHP1 = 2 Then
            lblQuestion1.Text = "Solve the problem: " + vbCrLf + "If 2x - 3 = -7, what is x?"
            lblAnswer1_1.Text = "4"
            lblAnswer2_1.Text = "2"
            lblAnswer3_1.Text = "-4"
            lblAnswer4_1.Text = "-2"
        ElseIf enemyHP1 = 1 Then
            lblQuestion1.Text = "Solve the problem: " + vbCrLf + "If 4x - 15 = 5, what is x?"
            lblAnswer1_1.Text = "10"
            lblAnswer2_1.Text = "-5"
            lblAnswer3_1.Text = "5"
            lblAnswer4_1.Text = "-10"
        ElseIf enemyHP1 = 0 Then
            TabControl1.SelectedIndex += 1
        End If
    End Sub
    Private Sub UpdateUI2()
        If enemyHP2 = 5 Then
            lblQuestion2.Text = "What is x^2 called?"
            lblAnswer1_2.Text = "x raised to the power of 2"
            lblAnswer2_2.Text = "x squared"
            lblAnswer3_2.Text = "x to 2"
            lblAnswer4_2.Text = "x 2"
        ElseIf enemyHP2 = 4 Then
            lblQuestion2.Text = "What is x^4 called?"
            lblAnswer1_2.Text = "x raised to the power of 4"
            lblAnswer2_2.Text = "x quad"
            lblAnswer3_2.Text = "x 4"
            lblAnswer4_2.Text = "x to 2"
        ElseIf enemyHP2 = 3 Then
            lblQuestion2.Text = "Solve the problem: " + vbCrLf + "4^2 = ?"
            lblAnswer1_2.Text = "8"
            lblAnswer2_2.Text = "12"
            lblAnswer3_2.Text = "16"
            lblAnswer4_2.Text = "6"
        ElseIf enemyHP2 = 2 Then
            lblQuestion2.Text = "Solve the problem: " + vbCrLf + "2^3 = ?"
            lblAnswer1_2.Text = "9"
            lblAnswer2_2.Text = "5"
            lblAnswer3_2.Text = "6"
            lblAnswer4_2.Text = "8"
        ElseIf enemyHP2 = 1 Then
            lblQuestion2.Text = "Solve the problem: " + vbCrLf + "3^3 + 5^2 = ?"
            lblAnswer1_2.Text = "52"
            lblAnswer2_2.Text = "48"
            lblAnswer3_2.Text = "54"
            lblAnswer4_2.Text = "50"
        ElseIf enemyHP2 = 0 Then
            TabControl1.SelectedIndex += 1
        End If
    End Sub
    Private Sub UpdateUI3()
        If enemyHP3 = 5 Then
            lblQuestion3.Text = "Solve the problem:" + vbCrLf + "(4 x 6) - 8 = ?"
            lblAnswer1_3.Text = "14"
            lblAnswer2_3.Text = "20"
            lblAnswer3_3.Text = "16"
            lblAnswer4_3.Text = "12"
        ElseIf enemyHP3 = 4 Then
            lblQuestion3.Text = "Solve the problem:" + vbCrLf + "2 + 7 x (7 x 9) / 3 = ?"
            lblAnswer1_3.Text = "149"
            lblAnswer2_3.Text = "152"
            lblAnswer3_3.Text = "138"
            lblAnswer4_3.Text = "144"
        ElseIf enemyHP3 = 3 Then
            lblQuestion3.Text = "Solve the problem:" + vbCrLf + "9 / 3 + 7 - 9 + 7 = ?"
            lblAnswer1_3.Text = "6"
            lblAnswer2_3.Text = "8"
            lblAnswer3_3.Text = "10"
            lblAnswer4_3.Text = "12"
        ElseIf enemyHP3 = 2 Then
            lblQuestion3.Text = "Solve the problem:" + vbCrLf + "5 - (9 - 3) + 6 = ?"
            lblAnswer1_3.Text = "10"
            lblAnswer2_3.Text = "7"
            lblAnswer3_3.Text = "5"
            lblAnswer4_3.Text = "8"
        ElseIf enemyHP3 = 1 Then
            lblQuestion3.Text = "Solve the problem:" + vbCrLf + "12 / (1 + 3) − 9 × 6 = ?"
            lblAnswer1_3.Text = "55"
            lblAnswer2_3.Text = "52"
            lblAnswer3_3.Text = "-47"
            lblAnswer4_3.Text = "-51"
        ElseIf enemyHP3 = 0 Then
            TabControl1.SelectedIndex += 1
        End If
    End Sub
End Class
