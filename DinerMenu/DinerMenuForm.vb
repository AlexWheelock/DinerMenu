'Alex Wheelock
'RCET 0625
'Spring 2024
'Diner Menu
'https://github.com/AlexWheelock/DinerMenu.git

Option Strict On
Option Explicit On
Public Class DinerMenuForm

    'when ran, it will load the default settings for the display label
    Private Sub DinerMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DefaultSettings()
    End Sub

    'sub that sets the display to the soup of the day, and the displays position.
    Sub DefaultSettings()
        DisplaySpecialLabel.Text = ("Soup of the Day:" & vbCrLf _
                    & vbCrLf _
                    & "Cheesy Potato Bacon Soup")
        DisplaySpecialLabel.Location = New Point(250, 140)
    End Sub

    'when the soup button is clicked, it will display the soup menu, changing the display text and position
    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        DisplaySpecialLabel.Location = New Point(12, 58)
        DisplaySpecialLabel.Text = ("Soup" & vbCrLf _
            & vbCrLf _
            & "Chicken Noodle Soup - Better than what your momma used to make you when you were sick." & vbCrLf _
            & "Served with saltine crackers and one side. - $8.00" & vbCrLf _
            & vbCrLf _
            & "Cheesy Potato Bacon Soup - Creamy mashed up potatoes, seasoned and mixed together with" & vbCrLf _
            & "cheese and bacon. Served with saltine crackers and one side. - $10.00" & vbCrLf _
            & vbCrLf _
            & "Broccoli Cheddar Soup - This soup is cheesy and delicious, and has broccoli, to make you think" & vbCrLf _
            & "that you're eating something healthy. Served with saltine crackers and one side. - $8.00")
    End Sub

    'when the fish button is clicked, it will display the soup menu, changing the display text and position
    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        DisplaySpecialLabel.Location = New Point(6, 58)
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

    'when the salad button is clicked, it will display the soup menu, changing the display text and position
    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        DisplaySpecialLabel.Location = New Point(29, 58)
        DisplaySpecialLabel.Text = ("Salad" & vbCrLf _
            & vbCrLf _
            & "Caesar Salad - Fresh romaine lettuce with a creamy caesar dressing and parmesan cheese," & vbCrLf _
            & "with seasoned croutons. - $10.00 (Add chicken for an additional $2.00)" & vbCrLf _
            & vbCrLf _
            & "House Salad - A fresh house salad with iceberg lettuce, onion, cheese, ham, a sliced egg," & vbCrLf _
            & "and diced tomato. Served with a dressing of your choice. - $9.00" & vbCrLf _
            & vbCrLf _
            & "Italian Salad - Fresh romaine lettuce, radicchio, sliced onion, sliced tomato, black olives," & vbCrLf _
            & "with croutons, parmesan cheese, served with our homemade italian dressing. - $12.00")
    End Sub

    'when the sides button is clicked, it will display the soup menu, changing the display text and position
    Private Sub SidesButton_Click(sender As Object, e As EventArgs) Handles SidesButton.Click
        DisplaySpecialLabel.Location = New Point(250, 58)
        DisplaySpecialLabel.Text = ("Sides" & vbCrLf _
            & vbCrLf _
            & "Side salad of your choice" & vbCrLf _
            & vbCrLf _
            & "Side soup of your choice" & vbCrLf _
            & vbCrLf _
            & "Chili" & vbCrLf _
            & vbCrLf _
            & "Fruit" & vbCrLf _
            & vbCrLf _
            & "Vegetables")
    End Sub

    'when the desserts button is clicked, it will display the soup menu, changing the display text and position
    Private Sub DessertsButton_Click(sender As Object, e As EventArgs) Handles DessertsButton.Click
        DisplaySpecialLabel.Location = New Point(22, 58)
        DisplaySpecialLabel.Text = ("Desserts" & vbCrLf _
            & vbCrLf _
            & "Chocolate Cake - Slice of homemade multi-layered chocolate cake and frosting. - $8.00" & vbCrLf _
            & vbCrLf _
            & "Cherry Pie - Slice of homemade cherry filling and homemade flaky crust - $6.00" & vbCrLf _
            & vbCrLf _
            & "Banana Creme Pie - Slice of homemade banana creme filling and homemade crust - $6.00" & vbCrLf _
            & vbCrLf _
            & "Cheese Cake - Slice of rich cheese cake on graham cracker crust with fruit of choice. - $10.00" & vbCrLf _
            & vbCrLf _
            & "Tiramisu - Slice of our world famous homemade tiramisu - $10.00")
    End Sub

    'when the exit button, "e", or "esc" are pressed, it will close the form.
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    'label that displays the name of the diner
    Private Sub DinerNameLabel_Click(sender As Object, e As EventArgs) Handles DinerNameLabel.Click

    End Sub

    'label that displays the menu items
    Private Sub DisplaySpecialLabel_Click(sender As Object, e As EventArgs) Handles DisplaySpecialLabel.Click

    End Sub
End Class
