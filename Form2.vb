Public Class Form2

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim stFirstName As String
        Dim stLastName As String
        Dim stStreetAddress As String
        Dim stOccupation As String

        stFirstName = txtFirstName.Text
        stLastName = txtLastName.Text
        stStreetAddress = txtStreetAddress.Text

        stOccupation = lstOccupation.SelectedItem

        MsgBox(stFirstName & " " & stLastName & " who lives at " & stStreetAddress & " is a " &
               stOccupation & ".")




    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class