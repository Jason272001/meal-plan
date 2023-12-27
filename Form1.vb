Imports System.IO
Public Class Form1
    Dim mealideas(10, 12) As String
    Dim mealnames(10) As String
    Dim ingredients(12) As String
    Dim mealcal(10) As Integer
    Dim unicost(12) As Double



    Private cartlist As List(Of String)

    Private Sub cmdorder_Click(sender As Object, e As EventArgs) Handles cmdorder.Click
        Customer_s_Information.Show()
        Me.Hide()
    End Sub


    Private Sub cmdcalo_Click(sender As Object, e As EventArgs) Handles cmdcalo.Click
        Dim inputcalo As Integer

        inputcalo = Txtcalo.Text
        mealnames(0) = ""
        mealnames(1) = "Pasta with mushroom"
        mealnames(2) = "Baked chicken"
        mealnames(3) = "Mushroom jacket potatoes "
        mealnames(4) = "Mushroom and chicken pizza"
        mealnames(5) = "Tomato pasta"
        mealnames(6) = "Egg fried rice"
        mealnames(7) = "Chicken pie"
        mealnames(8) = "Mushroom risotto"
        mealnames(9) = "Mushroom baked eggs"
        mealnames(10) = "Chicken potato salad"
        mealcal(0) = 0
        mealcal(1) = 464
        mealcal(2) = 400
        mealcal(3) = 450
        mealcal(4) = 650
        mealcal(5) = 490
        mealcal(6) = 490
        mealcal(7) = 500
        mealcal(8) = 343
        mealcal(9) = 565
        mealcal(10) = 335
        Do
            inputcalo = InputBox("Please enter maximum calories between 300 and 700")
        Loop While (inputcalo <= 300 And inputcalo > 700)

        lblslip.Text = "You can choose :  " & vbCrLf
        If (inputcalo >= mealcal(1)) Then
            lblslip.Text = lblslip.Text & mealnames(1) & vbCrLf
        End If
        If (inputcalo >= mealcal(2)) Then
            lblslip.Text = lblslip.Text & mealnames(2) & vbCrLf
        End If
        If (inputcalo >= mealcal(3)) Then
            lblslip.Text = lblslip.Text & mealnames(3) & vbCrLf
        End If
        If (inputcalo >= mealcal(4)) Then
            lblslip.Text = lblslip.Text & mealnames(4) & vbCrLf
        End If
        If (inputcalo >= mealcal(5)) Then
            lblslip.Text = lblslip.Text & mealnames(5) & vbCrLf
        End If
        If (inputcalo >= mealcal(6)) Then
            lblslip.Text = lblslip.Text & mealnames(6) & vbCrLf
        End If
        If (inputcalo >= mealcal(7)) Then
            lblslip.Text = lblslip.Text & mealnames(7) & vbCrLf
        End If
        If (inputcalo >= mealcal(8)) Then
            lblslip.Text = lblslip.Text & mealnames(8) & vbCrLf
        End If
        If (inputcalo >= mealcal(9)) Then
            lblslip.Text = lblslip.Text & mealnames(9) & vbCrLf
        End If
        If (inputcalo >= mealcal(10)) Then
            lblslip.Text = lblslip.Text & mealnames(10) & vbCrLf
        End If


        cmdcalo.Enabled = True
        cmding.Enabled = False
        cboing.Enabled = False

    End Sub

    Private Sub cmding_Click(sender As Object, e As EventArgs) Handles cmding.Click
        Dim ingredient As Integer

        mealnames(0) = ""
        mealnames(1) = "Pasta with mushroom"
        mealnames(2) = "Baked chicken"
        mealnames(3) = "Mushroom jacket potatoes "
        mealnames(4) = "Mushroom and chicken pizza"
        mealnames(5) = "Tomato pasta"
        mealnames(6) = "Egg fried rice"
        mealnames(7) = "Chicken pie"
        mealnames(8) = "Mushroom risotto"
        mealnames(9) = "Mushroom baked eggs"
        mealnames(10) = "Chicken potato salad"

        ingredients(0) = ""
        ingredients(1) = "flour"
        ingredients(2) = "chicken"
        ingredients(3) = "spaghetti"
        ingredients(4) = " onions "
        ingredients(5) = "butter"
        ingredients(6) = "mushroom"
        ingredients(7) = "tomato"
        ingredients(8) = "eggs"
        ingredients(9) = "rice"
        ingredients(10) = "potatoes"
        ingredients(11) = "garlic"
        ingredients(12) = "oil"

        ingredient = cboing.SelectedItem
        lblslip.Text = "You have the following recipes ;" & vbCrLf


        cmdcalo.Enabled = False
        cmding.Enabled = True
        Txtcalo.Enabled = False

        While (ingredient < 3)
            ingredient = InputBox("There is no recipies for these ingredient.Please enter the name of ingredient between 3 and and 9")
        End While
        While (ingredient >= 9)
            ingredient = InputBox("There is no recipies for these ingredient.Please enter the name of ingredient between 3 and and 9")

        End While
        If (ingredient = 3) Then
            lblslip.Text = lblslip.Text & mealnames(3) & vbCrLf & mealnames(6) & vbCrLf
        End If
        If (ingredient = 4) Then
            lblslip.Text = lblslip.Text & mealnames(1) & vbCrLf & mealnames(5) & vbCrLf
        End If
        If (ingredient = 5) Then
            lblslip.Text = lblslip.Text & mealnames(2) & vbCrLf & mealnames(4) & vbCrLf
        End If
        If (ingredient = 6) Then
            lblslip.Text = lblslip.Text & mealnames(7) & vbCrLf
        End If
        If (ingredient = 7) Then
            lblslip.Text = lblslip.Text & mealnames(9) & vbCrLf
        End If
        If (ingredient = 8) Then
            lblslip.Text = lblslip.Text & mealnames(10) & vbCrLf
        End If



    End Sub
    Private Sub myfile(meal As String)
        Dim myfile As StreamWriter
        myfile = File.CreateText("mealplans.txt")
        MsgBox("text file was created successfully")
        myfile.WriteLine(cbochoice.SelectedItem)
        myfile.Close()

    End Sub

    Private Sub cmdsave_Click(sender As Object, e As EventArgs) Handles cmdsave.Click
        mealideas(0, 0) = ""
        mealideas(1, 0) = "Pusta with mushroom"
        mealideas(2, 0) = "Baked chicken"
        mealideas(3, 0) = "Mushroom jacket potatoes "
        mealideas(4, 0) = "Mushroom and chicken pizza"
        mealideas(5, 0) = "Tomato pasta "
        mealideas(6, 0) = "Egg fried rice"
        mealideas(7, 0) = "Chicken pie"
        mealideas(8, 0) = "Mushroom risoto"
        mealideas(9, 0) = "Mushroom baked eggs "
        mealideas(10, 0) = "Chicken potato salad "




        mealideas(0, 1) = ""
        mealideas(1, 1) = 0
        mealideas(2, 1) = 0
        mealideas(3, 1) = 0
        mealideas(4, 1) = 200
        mealideas(5, 1) = 0
        mealideas(6, 1) = 0
        mealideas(7, 1) = 20
        mealideas(8, 1) = 0
        mealideas(9, 1) = 0
        mealideas(10, 1) = 0

        mealideas(0, 2) = ""
        mealideas(1, 2) = 0
        mealideas(2, 2) = 400
        mealideas(3, 2) = 0
        mealideas(4, 2) = 200
        mealideas(5, 2) = 0
        mealideas(6, 2) = 0
        mealideas(7, 2) = 200
        mealideas(8, 2) = 0
        mealideas(9, 2) = 0
        mealideas(10, 2) = 60

        mealideas(0, 3) = ""
        mealideas(1, 3) = 60
        mealideas(2, 3) = 0
        mealideas(3, 3) = 0
        mealideas(4, 3) = 0
        mealideas(5, 3) = 60
        mealideas(6, 3) = 0
        mealideas(7, 3) = 0
        mealideas(8, 3) = 0
        mealideas(9, 3) = 0
        mealideas(10, 3) = 0

        mealideas(0, 4) = ""
        mealideas(1, 4) = 200
        mealideas(2, 4) = 0
        mealideas(3, 4) = 0
        mealideas(4, 4) = 200
        mealideas(5, 4) = 0
        mealideas(6, 4) = 0
        mealideas(7, 4) = 300
        mealideas(8, 4) = 400
        mealideas(9, 4) = 200
        mealideas(10, 4) = 300

        mealideas(0, 5) = ""
        mealideas(1, 5) = 10
        mealideas(2, 5) = 15
        mealideas(3, 5) = 8
        mealideas(4, 5) = 0
        mealideas(5, 5) = 5
        mealideas(6, 5) = 0
        mealideas(7, 5) = 0
        mealideas(8, 5) = 0
        mealideas(9, 5) = 10
        mealideas(10, 5) = 10

        mealideas(0, 6) = ""
        mealideas(1, 6) = 80
        mealideas(2, 6) = 0
        mealideas(3, 6) = 70
        mealideas(4, 6) = 40
        mealideas(5, 6) = 0
        mealideas(6, 6) = 0
        mealideas(7, 6) = 0
        mealideas(8, 6) = 80
        mealideas(9, 6) = 90
        mealideas(10, 6) = 50

        mealideas(0, 7) = ""
        mealideas(1, 7) = 0
        mealideas(2, 7) = 300
        mealideas(3, 7) = 0
        mealideas(4, 7) = 200
        mealideas(5, 7) = 40
        mealideas(6, 7) = 0
        mealideas(7, 7) = 0
        mealideas(8, 7) = 0
        mealideas(9, 7) = 60
        mealideas(10, 7) = 0

        mealideas(0, 8) = ""
        mealideas(1, 8) = 0
        mealideas(2, 8) = 0
        mealideas(3, 8) = 0
        mealideas(4, 8) = 0
        mealideas(5, 8) = 0
        mealideas(6, 8) = 140
        mealideas(7, 8) = 60
        mealideas(8, 8) = 0
        mealideas(9, 8) = 140
        mealideas(10, 8) = 0

        mealideas(0, 9) = ""
        mealideas(1, 9) = 0
        mealideas(2, 9) = 0
        mealideas(3, 9) = 0
        mealideas(4, 9) = 0
        mealideas(5, 9) = 0
        mealideas(6, 9) = 75
        mealideas(7, 9) = 0
        mealideas(8, 9) = 80
        mealideas(9, 9) = 0
        mealideas(10, 9) = 40

        mealideas(0, 10) = ""
        mealideas(1, 10) = 0
        mealideas(2, 10) = 0
        mealideas(3, 10) = 400
        mealideas(4, 10) = 0
        mealideas(5, 10) = 0
        mealideas(6, 10) = 0
        mealideas(7, 10) = 0
        mealideas(8, 10) = 0
        mealideas(9, 10) = 0
        mealideas(10, 10) = 80

        mealideas(0, 11) = ""
        mealideas(1, 11) = 0
        mealideas(2, 11) = 5
        mealideas(3, 11) = 0
        mealideas(4, 11) = 0
        mealideas(5, 11) = 8
        mealideas(6, 11) = 0
        mealideas(7, 11) = 7
        mealideas(8, 11) = 0
        mealideas(9, 11) = 3
        mealideas(10, 11) = 8

        mealideas(0, 12) = ""
        mealideas(1, 12) = 0
        mealideas(2, 12) = 10
        mealideas(3, 12) = 0
        mealideas(4, 12) = 0
        mealideas(5, 12) = 0
        mealideas(6, 12) = 15
        mealideas(7, 12) = 15
        mealideas(8, 12) = 5
        mealideas(9, 12) = 5
        mealideas(10, 12) = 5

        If String.IsNullOrEmpty(TextBox2.Text) Then

            TextBox2.Text = TextBox1.Text



        Else
            TextBox2.Text = Val(TextBox2.Text) + Val(TextBox1.Text)

        End If

        cartlist.Add(Label7.Text)
        Label7.Text = ""

        Dim nameStrign As String = ""
        For Each Name As String In cartlist
            nameStrign = nameStrign & "" & Name & vbNewLine


        Next
        Label8.Text = nameStrign





    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cbochoice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbochoice.SelectedIndexChanged
        If (cbochoice.Text = "Pasta with mushroom") Then
            TextBox1.Text = "0.7"
            Dim OLI = "Pasta with mushroom" & vbNewLine & "60g Spaghetti" & vbNewLine & "200g Onions" & vbNewLine & "10g Butter" & vbNewLine & "80g Mushroom"

            Label7.Text = Label7.Text & vbCrLf & OLI
        End If

        If (cbochoice.Text = "Baked chicken") Then
            TextBox1.Text = "3.6"
            Dim OLI = "Baked chicken" & vbNewLine & "400g Chicken" & vbNewLine & "15g Butter" & vbNewLine & "300g Tomato" & vbNewLine & "5g Garlic"
            Label7.Text = Label7.Text & vbCrLf & OLI


        End If
        If (cbochoice.Text = "Mushroom jacket potatoes") Then
            TextBox1.Text = "1.1"
            Dim OLI = "Mushroom jacket potatoes" & vbNewLine & "8g Butter" & vbNewLine & "70g Mushroom" & vbNewLine & "400g Potatoes"
            Label7.Text = Label7.Text & vbCrLf & OLI
        End If
        If (cbochoice.Text = "Mushroom and chicken Pizza") Then
            TextBox1.Text = "2.5"
            Dim OLI = "Mushroom and chicken Pizza" & vbNewLine & "200g Flour" & vbNewLine & "200g Chicken" & vbNewLine & "200g Onions" & vbNewLine & "40g Mushroom" & vbNewLine & "200g Tomato"
            Label7.Text = Label7.Text & vbCrLf & OLI


        End If

        If (cbochoice.Text = "Tomato Pasta") Then
            TextBox1.Text = "0.3"

            Dim OLI = "Tomato Pasta" & vbNewLine & "60g Spaghetti" & vbNewLine & "5g Butter" & vbNewLine & "40g Tomato" & vbNewLine & "8g Garlic"
            Label7.Text = Label7.Text & vbCrLf & OLI
        End If


        If (cbochoice.Text = "Egg fried rice") Then
            TextBox1.Text = "0.7"

            Dim OLI = "Egg fried rice" & vbNewLine & "140g Egg" & vbNewLine & "75g Rice"
            Label7.Text = Label7.Text & vbCrLf & OLI

        End If

        If (cbochoice.Text = "Chicken Pie") Then
            TextBox1.Text = "1"
            Dim OLI = "Chicken Pie" & vbNewLine & "200g Chicken" & vbNewLine & "200g Flour" & vbNewLine & "300g Onions" & vbNewLine & "60g Egg" & vbNewLine & "7g Garlic"
            Label7.Text = Label7.Text & vbCrLf & OLI

        End If


        If (cbochoice.Text = "Mushroom risotto") Then
            TextBox1.Text = "1"
            Dim OLI = "Mushroom risotto" & vbNewLine & "400g Onions" & vbNewLine & "80g Mushroom" & vbNewLine & "80g Rice"
            Label7.Text = Label7.Text & vbCrLf & OLI

        End If


        If (cbochoice.Text = "Mushroom baked eggs") Then
            TextBox1.Text = "1.3"

            Dim OLI = "Mushroom baked eggs" & vbNewLine & "200g Onions" & vbNewLine & "10g Butter" & vbNewLine & "90g Mushroom" & vbNewLine & "140g Egg" & vbNewLine & "3g Garlic" & vbNewLine & "60g Tomato"
            Label7.Text = Label7.Text & vbCrLf & OLI


        End If
        If (cbochoice.Text = "Chicken potato salad") Then
            TextBox1.Text = "1.3"


            Dim OLI = "Chicken potato salad" & vbNewLine & "200g Chicken" & vbNewLine & "300g Onions" & vbNewLine & "50g Mushroom" & vbNewLine & "10g Butter" & vbNewLine & "8g Garlic" & vbNewLine & "80g Potatoes" & vbNewLine & "40g Rice"
            Label7.Text = Label7.Text & vbCrLf & OLI

        End If


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Restart()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cartlist = New List(Of String)
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label8_Click_1(sender As Object, e As EventArgs) 

    End Sub

    Private Sub ListBox1_SelectedIndexChanged_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click_2(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub lblslip_Click(sender As Object, e As EventArgs) Handles lblslip.Click

    End Sub
End Class
