'Alex Wheelock
'RCET 0625
'Spring 2024
'Diner Menu
'https://github.com/AlexWheelock/DinerMenu.git

Option Strict On
Option Explicit On
Public Class DinerMenuForm
    Private Sub DinerNameLabel_Click(sender As Object, e As EventArgs) Handles DinerNameLabel.Click

    End Sub

    Private Sub DisplaySpecialLabel_Click(sender As Object, e As EventArgs) Handles DisplaySpecialLabel.Click

    End Sub

    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        DisplaySpecialLabel.Text = ("Soup" & vbCrLf _
            & vbCrLf _
            & "Chicken Noodle Soup - Better than what your momma used to make you when you were sick." & vbCrLf _
            & "Served with saltine crackers and one side. - $8.00" & vbCrLf _
            & vbCrLf _
            & "Cheesy Potato Bacon Soup - Creamy mashed up potatoes, seasoned and mixed together with cheese" & vbCrLf _
            & "and bacon, basically a runny baked potato. Comes with saltine crackers and one side. - $10.00" & vbCrLf _
            & vbCrLf _
            & "Broccoli Cheddar Soup - This soup is cheesy and delicious, and has broccoli, to make you think that" & vbCrLf _
            & "you're putting something good in your body. Served with saltine crackers and one side. - $8.00")
    End Sub

    Private Sub DinerMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        DisplaySpecialLabel.Text = ("Fish" & vbCrLf _
            & vbCrLf _
            & "Cedar Plank Salmon - Enjoy a fresh, seasoned Atlantic salmon fillet grilled on a" & vbCrLf _
            & "cedar plank, because who doesn't love the taste of burning wood? Served with two sides. - $14.00" & vbCrLf _
            & vbCrLf _
            & "Breaded Halibut - A fresh fillet of halibut that is seasoned, battered, and then deep fried." & vbCrLf _
            & "Served with our homemade pina colada sauce, and two sides. - $16.00" & vbCrLf _
            & vbCrLf _
            & "Fish & Chips - Cutlets of Cod, seasoned, and beer batter deep fried with our delicious french fries!" & vbCrLf _
            & "Served with tartar sauce and two sides. - $12.00")
    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click

    End Sub

    Private Sub SidesButton_Click(sender As Object, e As EventArgs) Handles SidesButton.Click

    End Sub

    Private Sub DessertsButton_Click(sender As Object, e As EventArgs) Handles DessertsButton.Click

    End Sub
End Class
