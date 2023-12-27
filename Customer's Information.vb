Public Class Customer_s_Information



    Public Property StringPass As String
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Customer_s_Information_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtcardnumber_TextChanged(sender As Object, e As EventArgs) Handles txtcardnumber.TextChanged

    End Sub

    Private Sub lblinformation_Click(sender As Object, e As EventArgs) Handles lblinformation.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(txtname.Text) Then

            MessageBox.Show(String.Format("To Complete the order Please fill the pyament information!"))




        ElseIf String.IsNullOrEmpty(txthome.Text) Then

            MessageBox.Show(String.Format("To Complete the order Please fill the pyament information!"))
        ElseIf String.IsNullOrEmpty(txtstreet.Text) Then

            MessageBox.Show(String.Format("To Complete the order Please fill the pyament information!"))

        ElseIf String.IsNullOrEmpty(txttown.Text) Then

            MessageBox.Show(String.Format("To Complete the order Please fill the pyament information!"))

        ElseIf String.IsNullOrEmpty(txtpost.Text) Then

            MessageBox.Show(String.Format("To Complete the order Please fill the pyament information!"))


        ElseIf String.IsNullOrEmpty(txtemail.Text) Then

            MessageBox.Show(String.Format("To Complete the order Please fill the pyament information!"))


        ElseIf String.IsNullOrEmpty(txtcardnumber.Text) Then

            MessageBox.Show(String.Format("To Complete the order Please fill the pyament information!"))




        Else
            If txtcardnumber.Text.Length < 16 Or txtcardnumber.Text.Length > 16 Then
                MessageBox.Show(String.Format("Wrong Number!Card Number must be 16 Characters"))

            Else

                lblinformation.Text = lblinformation.Text & vbCrLf & "Name :" & txtname.Text & vbNewLine & "Home No :" & txtname.Text & vbNewLine & "Street :" & txtstreet.Text & vbNewLine & "Town/City :" & txttown.Text & vbNewLine & "Post Code :" & txtpost.Text & vbNewLine & "Email Address :" & txtemail.Text & vbNewLine



                MessageBox.Show(String.Format("Order Successful! Thank You."))

            End If






        End If

    End Sub

    Private Sub txtname_TextChanged(sender As Object, e As EventArgs) Handles txtname.TextChanged

    End Sub

    Private Sub txthome_TextChanged(sender As Object, e As EventArgs) Handles txthome.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtstreet_TextChanged(sender As Object, e As EventArgs) Handles txtstreet.TextChanged

    End Sub

    Private Sub txttown_TextChanged(sender As Object, e As EventArgs) Handles txttown.TextChanged

    End Sub

    Private Sub txtpost_TextChanged(sender As Object, e As EventArgs) Handles txtpost.TextChanged

    End Sub

    Private Sub txtemail_TextChanged(sender As Object, e As EventArgs) Handles txtemail.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class