Public Class Form1

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        MsgBox("hello world")
        MsgBox("how are you")
        MsgBox("I hope you are well")

        MessageBox.Show("this is another Message")



    End Sub

    Private Sub btnVariable_Click(sender As Object, e As EventArgs) Handles btnVariable.Click

        Dim stFirstName As String
        Dim stLastName As String

        stFirstName = "Jacob"
        stLastName = "Dunn"

        MsgBox("Hello and welcome " & stFirstName & " " & stLastName & ", how are you?")

        stFirstName = "Vincent"
        stLastName = "Valentine"

        MsgBox("Hello and welcome " & stFirstName & " " & stLastName & ", how are you?")

    End Sub

    Private Sub btn_DataTypes_Click(sender As Object, e As EventArgs) Handles btn_DataTypes.Click

        Dim stMake As String
        Dim stModel As String
        Dim iDoors As Integer
        Dim stColor As String
        Dim bTaxed As Boolean
        Dim iEngineSize As Integer
        Dim decPrice As Decimal
        Dim dtDateRegistered As Date

        stMake = "BMW"
        stModel = "M340i"
        stColor = "Portamao Blue"
        iDoors = 4
        bTaxed = True
        iEngineSize = 1200
        decPrice = 84000.02
        dtDateRegistered = #01/2/2022#


        MsgBox("the car is " & stMake & vbCrLf & stModel & vbCrLf &
               stColor & " with " & iDoors & " doors and a " &
               iEngineSize & " engine. " & "Priced at " & decPrice & " and registered on " &
               dtDateRegistered & ". "
               )


    End Sub
End Class
