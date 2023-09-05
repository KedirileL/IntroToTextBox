Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim stName As String
        Dim stSurname As String
        Dim stGender As String

        stName = txtName.Text
        stSurname = txtSurname.Text
        stGender = txtGender.Text

        MsgBox(" Hi " & stName & " " & stSurname & ". Its good to know you are " & stGender)
    End Sub
End Class
