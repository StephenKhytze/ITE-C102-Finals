﻿
Public Class Form1
    Dim playerHP As Integer = 3
    Dim enemyHP1, enemyHP2, enemyHP3, enemyHP4 As Integer
    Dim battleTimer As Integer = 30

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enemyHP1 = 5
        enemyHP2 = 5
        enemyHP3 = 5
        enemyHP4 = 5

        UpdateTimerLabel()
        UpdateUIHP()
        UpdateUI1()
        UpdateUI2()
        UpdateUI3()
        UpdateUI4()
    End Sub

    Private Sub lblAnswer1_1_Click(sender As Object, e As EventArgs) Handles lblAnswer1_1.Click
        tmrAnimation.Start()
        tmrBattle.Start()

        If enemyHP1 = 5 Then
            imgCharSprite1.Image = My.Resources.charGIrlSpriteAttack
            enemyHP1 -= 1
        Else
            imgCharSprite1.Image = My.Resources.charGirlHurtSprite
            playerHP -= 1
        End If
    End Sub

    Private Sub lblAnswer2_1_Click(sender As Object, e As EventArgs) Handles lblAnswer2_1.Click
        tmrAnimation.Start()
        If enemyHP1 = 4 Then
            imgCharSprite1.Image = My.Resources.charGIrlSpriteAttack
            enemyHP1 -= 1
        Else
            imgCharSprite1.Image = My.Resources.charGirlHurtSprite
            playerHP -= 1
        End If
    End Sub

    Private Sub lblAnswer3_1_Click(sender As Object, e As EventArgs) Handles lblAnswer3_1.Click
        tmrAnimation.Start()
        If enemyHP1 = 3 Or enemyHP1 = 1 Then
            imgCharSprite1.Image = My.Resources.charGIrlSpriteAttack
            enemyHP1 -= 1
        Else
            imgCharSprite1.Image = My.Resources.charGirlHurtSprite
            playerHP -= 1
        End If
    End Sub

    Private Sub lblAnswer4_1_Click(sender As Object, e As EventArgs) Handles lblAnswer4_1.Click
        tmrAnimation.Start()
        If enemyHP1 = 2 Then
            imgCharSprite1.Image = My.Resources.charGIrlSpriteAttack
            enemyHP1 -= 1
        Else
            imgCharSprite1.Image = My.Resources.charGirlHurtSprite
            playerHP -= 1
        End If
    End Sub

    Private Sub lblAnswer1_2_Click(sender As Object, e As EventArgs) Handles lblAnswer1_2.Click
        tmrAnimation.Start()
        If enemyHP2 = 4 Or enemyHP2 = 1 Then
            imgCharSprite2.Image = My.Resources.charGirlSpriteAttack2
            enemyHP2 -= 1
        Else
            imgCharSprite2.Image = My.Resources.charGirlHurtSprite2
            playerHP -= 1
        End If
    End Sub

    Private Sub lblAnswer2_2_Click(sender As Object, e As EventArgs) Handles lblAnswer2_2.Click
        tmrAnimation.Start()
        If enemyHP2 = 5 Then
            imgCharSprite2.Image = My.Resources.charGirlSpriteAttack2
            enemyHP2 -= 1
        Else
            imgCharSprite2.Image = My.Resources.charGirlHurtSprite2
            playerHP -= 1
        End If
    End Sub

    Private Sub lblAnswer3_2_Click(sender As Object, e As EventArgs) Handles lblAnswer3_2.Click
        tmrAnimation.Start()
        If enemyHP2 = 3 Then
            imgCharSprite2.Image = My.Resources.charGirlSpriteAttack2
            enemyHP2 -= 1
        Else
            imgCharSprite2.Image = My.Resources.charGirlHurtSprite2
            playerHP -= 1
        End If
    End Sub

    Private Sub lblAnswer4_2_Click(sender As Object, e As EventArgs) Handles lblAnswer4_2.Click
        tmrAnimation.Start()
        If enemyHP2 = 2 Then
            imgCharSprite2.Image = My.Resources.charGirlSpriteAttack2
            enemyHP2 -= 1
        Else
            imgCharSprite2.Image = My.Resources.charGirlHurtSprite2
            playerHP -= 1
        End If
    End Sub

    Private Sub lblAnswer1_3_Click(sender As Object, e As EventArgs) Handles lblAnswer1_3.Click
        tmrAnimation.Start()
        If enemyHP3 = 4 Then
            imgCharSprite3.Image = My.Resources.charGIrlSpriteAttack
            enemyHP3 -= 1
        Else
            imgCharSprite3.Image = My.Resources.charGirlHurtSprite
            playerHP -= 1
        End If
    End Sub

    Private Sub lblAnswer2_3_Click(sender As Object, e As EventArgs) Handles lblAnswer2_3.Click
        tmrAnimation.Start()
        If enemyHP3 = 3 Then
            imgCharSprite3.Image = My.Resources.charGIrlSpriteAttack
            enemyHP3 -= 1
        Else
            imgCharSprite3.Image = My.Resources.charGirlHurtSprite
            playerHP -= 1
        End If
    End Sub

    Private Sub lblAnswer3_3_Click(sender As Object, e As EventArgs) Handles lblAnswer3_3.Click
        tmrAnimation.Start()
        If enemyHP3 = 5 Or enemyHP3 = 2 Then
            imgCharSprite3.Image = My.Resources.charGIrlSpriteAttack
            enemyHP3 -= 1
        Else
            imgCharSprite3.Image = My.Resources.charGirlHurtSprite
            playerHP -= 1
        End If
    End Sub

    Private Sub lblAnswer4_3_Click(sender As Object, e As EventArgs) Handles lblAnswer4_3.Click
        tmrAnimation.Start()
        If enemyHP3 = 1 Then
            imgCharSprite3.Image = My.Resources.charGIrlSpriteAttack
            enemyHP3 -= 1
        Else
            imgCharSprite3.Image = My.Resources.charGirlHurtSprite
            playerHP -= 1
        End If
    End Sub

    Private Sub lblAnswer1_4_Click(sender As Object, e As EventArgs) Handles lblAnswer1_4.Click
        tmrAnimation.Start()
        If enemyHP4 = 2 Then
            imgCharSprite4.Image = My.Resources.charGIrlSpriteAttack
            enemyHP4 -= 1
        Else
            imgCharSprite4.Image = My.Resources.charGirlHurtSprite
            playerHP -= 1
        End If
    End Sub

    Private Sub lblAnswer2_4_Click(sender As Object, e As EventArgs) Handles lblAnswer2_4.Click
        tmrAnimation.Start()
        If enemyHP4 = 1 Then
            imgCharSprite4.Image = My.Resources.charGIrlSpriteAttack
            enemyHP4 -= 1
        Else
            imgCharSprite4.Image = My.Resources.charGirlHurtSprite
            playerHP -= 1
        End If
    End Sub

    Private Sub lblAnswer3_4_Click(sender As Object, e As EventArgs) Handles lblAnswer3_4.Click
        tmrAnimation.Start()
        If enemyHP4 = 5 Or enemyHP4 = 3 Then
            imgCharSprite4.Image = My.Resources.charGIrlSpriteAttack
            enemyHP4 -= 1
        Else
            imgCharSprite4.Image = My.Resources.charGirlHurtSprite
            playerHP -= 1
        End If
    End Sub

    Private Sub lblAnswer4_4_Click(sender As Object, e As EventArgs) Handles lblAnswer4_4.Click
        tmrAnimation.Start()
        If enemyHP4 = 4 Then
            imgCharSprite4.Image = My.Resources.charGIrlSpriteAttack
            enemyHP4 -= 1
        Else
            imgCharSprite4.Image = My.Resources.charGirlHurtSprite
            playerHP -= 1
        End If
    End Sub
    Private Sub UpdateUIHP()
        lblHP1.Text = playerHP.ToString()
        lblHP2.Text = playerHP.ToString()
        lblHP3.Text = playerHP.ToString()
        lblHP4.Text = playerHP.ToString()

        If playerHP <= 0 Then
            TabControl1.SelectedTab = MenuTab
            ResetUI()
        ElseIf enemyHP1 And enemyHP2 AndAlso enemyHP3 AndAlso enemyHP4 <= 0 Then
            MessageBox.Show("Congratulations! You have defeated the demon lord!", "Victory!")
        End If
    End Sub
    Private Sub UpdateUI1()
        If enemyHP1 = 5 Then
            lblQuestion1.Text = "Solve the problem: " + vbCrLf + vbCrLf + "If x - 5 = 0, what is x?"
            lblAnswer1_1.Text = "5"
            lblAnswer2_1.Text = "-5"
            lblAnswer3_1.Text = "0"
            lblAnswer4_1.Text = "10"
        ElseIf enemyHP1 = 4 Then
            lblQuestion1.Text = "Solve the problem: " + vbCrLf + vbCrLf + "If 2x - 36 = 0, what is x?"
            lblAnswer1_1.Text = "20"
            lblAnswer2_1.Text = "18"
            lblAnswer3_1.Text = "16"
            lblAnswer4_1.Text = "22"
        ElseIf enemyHP1 = 3 Then
            lblQuestion1.Text = "Solve the problem: " + vbCrLf + vbCrLf + "If 2x = 11 - 3, what is x?"
            lblAnswer1_1.Text = "8"
            lblAnswer2_1.Text = "12"
            lblAnswer3_1.Text = "4"
            lblAnswer4_1.Text = "6"
        ElseIf enemyHP1 = 2 Then
            lblQuestion1.Text = "Solve the problem: " + vbCrLf + vbCrLf + "If 2x - 3 = -7, what is x?"
            lblAnswer1_1.Text = "4"
            lblAnswer2_1.Text = "2"
            lblAnswer3_1.Text = "-4"
            lblAnswer4_1.Text = "-2"
        ElseIf enemyHP1 = 1 Then
            lblQuestion1.Text = "Solve the problem: " + vbCrLf + vbCrLf + "If 4x - 15 = 5, what is x?"
            lblAnswer1_1.Text = "10"
            lblAnswer2_1.Text = "-5"
            lblAnswer3_1.Text = "5"
            lblAnswer4_1.Text = "-10"
        ElseIf enemyHP1 = 0 Then
            battleTimer = 30
            tmrBattle.Stop()
            TabControl1.SelectedIndex += 1
            enemyHP1 -= 1
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
            lblQuestion2.Text = "Solve the problem: " + vbCrLf + vbCrLf + "4^2 = ?"
            lblAnswer1_2.Text = "8"
            lblAnswer2_2.Text = "12"
            lblAnswer3_2.Text = "16"
            lblAnswer4_2.Text = "6"
        ElseIf enemyHP2 = 2 Then
            lblQuestion2.Text = "Solve the problem: " + vbCrLf + vbCrLf + "2^3 = ?"
            lblAnswer1_2.Text = "9"
            lblAnswer2_2.Text = "5"
            lblAnswer3_2.Text = "6"
            lblAnswer4_2.Text = "8"
        ElseIf enemyHP2 = 1 Then
            lblQuestion2.Text = "Solve the problem: " + vbCrLf + vbCrLf + "3^3 + 5^2 = ?"
            lblAnswer1_2.Text = "52"
            lblAnswer2_2.Text = "48"
            lblAnswer3_2.Text = "54"
            lblAnswer4_2.Text = "50"
        ElseIf enemyHP2 = 0 Then
            battleTimer = 30
            tmrBattle.Stop()
            TabControl1.SelectedIndex += 1
            enemyHP2 -= 1
        End If
    End Sub
    Private Sub UpdateUI3()
        If enemyHP3 = 5 Then
            lblQuestion3.Text = "Solve the problem:" + vbCrLf + vbCrLf + "(4 x 6) - 8 = ?"
            lblAnswer1_3.Text = "14"
            lblAnswer2_3.Text = "20"
            lblAnswer3_3.Text = "16"
            lblAnswer4_3.Text = "12"
        ElseIf enemyHP3 = 4 Then
            lblQuestion3.Text = "Solve the problem:" + vbCrLf + vbCrLf + "2 + 7 x (7 x 9) / 3 = ?"
            lblAnswer1_3.Text = "149"
            lblAnswer2_3.Text = "152"
            lblAnswer3_3.Text = "138"
            lblAnswer4_3.Text = "144"
        ElseIf enemyHP3 = 3 Then
            lblQuestion3.Text = "Solve the problem:" + vbCrLf + vbCrLf + "9 / 3 + 7 - 9 + 7 = ?"
            lblAnswer1_3.Text = "6"
            lblAnswer2_3.Text = "8"
            lblAnswer3_3.Text = "10"
            lblAnswer4_3.Text = "12"
        ElseIf enemyHP3 = 2 Then
            lblQuestion3.Text = "Solve the problem:" + vbCrLf + vbCrLf + "5 - (9 - 3) + 6 = ?"
            lblAnswer1_3.Text = "10"
            lblAnswer2_3.Text = "7"
            lblAnswer3_3.Text = "5"
            lblAnswer4_3.Text = "8"
        ElseIf enemyHP3 = 1 Then
            lblQuestion3.Text = "Solve the problem:" + vbCrLf + vbCrLf + "12 / (1 + 3) − 9 × 6 = ?"
            lblAnswer1_3.Text = "55"
            lblAnswer2_3.Text = "52"
            lblAnswer3_3.Text = "-47"
            lblAnswer4_3.Text = "-51"
        ElseIf enemyHP3 = 0 Then
            battleTimer = 30
            tmrBattle.Stop()
            TabControl1.SelectedIndex += 1
            enemyHP3 -= 1
        End If
    End Sub
    Private Sub UpdateUI4()
        If enemyHP4 = 5 Then
            lblQuestion4.Text = "Solve for 'x':" + vbCrLf + vbCrLf + "x = -5^2"
            lblAnswer1_4.Text = "-25"
            lblAnswer2_4.Text = "20"
            lblAnswer3_4.Text = "25"
            lblAnswer4_4.Text = "-20"
        ElseIf enemyHP4 = 4 Then
            lblQuestion4.Text = "Solve the problem:" + vbCrLf + vbCrLf + "(9 - 3^2)(5) = ?"
            lblAnswer1_4.Text = "90"
            lblAnswer2_4.Text = "45"
            lblAnswer3_4.Text = "35"
            lblAnswer4_4.Text = "0"
        ElseIf enemyHP4 = 3 Then
            lblQuestion4.Text = "Solve for 'x':" + vbCrLf + vbCrLf + "12x = 6^2"
            lblAnswer1_4.Text = "6"
            lblAnswer2_4.Text = "36"
            lblAnswer3_4.Text = "3"
            lblAnswer4_4.Text = "9"
        ElseIf enemyHP4 = 2 Then
            lblQuestion4.Text = "Solve for 'x':" + vbCrLf + vbCrLf + "5x - 20 = 15"
            lblAnswer1_4.Text = "7"
            lblAnswer2_4.Text = "35"
            lblAnswer3_4.Text = "-7"
            lblAnswer4_4.Text = "27"
        ElseIf enemyHP4 = 1 Then
            lblQuestion4.Text = "Solve the problem:" + vbCrLf + vbCrLf + "[5(4 - 1) + 20] / 7 + 3^2 = ?"
            lblAnswer1_4.Text = "18"
            lblAnswer2_4.Text = "14"
            lblAnswer3_4.Text = "15"
            lblAnswer4_4.Text = "-18"
        ElseIf enemyHP4 = 0 Then
            battleTimer = 30
            tmrBattle.Stop()
            TabControl1.SelectedIndex += 1
            enemyHP4 -= 1
        End If
    End Sub
    Private Sub tmrAnimation_Tick(sender As Object, e As EventArgs) Handles tmrAnimation.Tick
        tmrAnimation.Stop()
        UpdateAnimation1()
        UpdateAnimation2()
        UpdateAnimation3()
        UpdateAnimation4()
        UpdateTimerLabel()
        battleTimer = 30
    End Sub
    Private Sub UpdateAnimation1()
        imgCharSprite1.Image = My.Resources.charGirlSpriteIdle
        UpdateUIHP()
        UpdateUI1()
    End Sub
    Private Sub UpdateAnimation2()
        imgCharSprite2.Image = My.Resources.charGirlSpriteIdle2
        UpdateUIHP()
        UpdateUI2()
    End Sub
    Private Sub UpdateAnimation3()
        imgCharSprite3.Image = My.Resources.charGirlSpriteIdle
        UpdateUIHP()
        UpdateUI3()
    End Sub
    Private Sub UpdateAnimation4()
        imgCharSprite4.Image = My.Resources.charGirlSpriteIdle
        UpdateUIHP()
        UpdateUI4()
    End Sub
    Private Sub ResetUI()
        enemyHP1 = 5
        enemyHP2 = 5
        enemyHP3 = 5
        enemyHP4 = 5
        playerHP = 3
    End Sub

    Private Sub tmrBattle_Tick(sender As Object, e As EventArgs) Handles tmrBattle.Tick
        UpdateTimerLabel()

        If battleTimer <= 0 Then
            tmrAnimation.Stop()
            imgCharSprite1.Image = My.Resources.charGirlHurtSprite
            imgCharSprite2.Image = My.Resources.charGirlHurtSprite2
            imgCharSprite3.Image = My.Resources.charGirlHurtSprite
            imgCharSprite4.Image = My.Resources.charGirlHurtSprite '
            tmrAnimation.Start()
            battleTimer = 30
            playerHP -= 1
            UpdateUIHP()

        Else
            battleTimer -= 1
        End If
    End Sub

    Private Sub UpdateTimerLabel()
        lblTimer1.Text = Str(battleTimer)
        lblTimer2.Text = Str(battleTimer)
        lblTimer3.Text = Str(battleTimer)
        lblTimer4.Text = Str(battleTimer)
    End Sub
End Class