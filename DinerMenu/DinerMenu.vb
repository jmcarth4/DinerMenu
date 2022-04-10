'Jessica McArthur
'RCET0265   
'Spring 2020
'Diner Menu Program
'https://github.com/jmcarth4/DinerMenu.git
Public Class DinerMenu
    'selecting a button displays the item offered for that label.
    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        DisplaySpecialLabel.Text = StrDup(20, " ") & "Soup du jour" & vbNewLine & StrDup(15, " ") & "Garlic Cream Soup" & vbNewLine & " Garlic with more garlic in a cream potato base"
    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        DisplaySpecialLabel.Text = StrDup(52, " ") & "La Salad" & vbNewLine & StrDup(45, " ") & "Kale Garlic Delight" & vbNewLine & " Kale drowned in a garlic vingrette. Cranberries and sunflower seeds for good meausre"
    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        DisplaySpecialLabel.Text = StrDup(25, " ") & "Possion" & vbNewLine & StrDup(15, " ") & "Garlic Roasted Salmon " & vbNewLine & " Topped with fresh garlic and chives"
    End Sub

    'exits the program
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
