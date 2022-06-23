Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim i As Integer = 0
        Dim price As Double
        Do
            price = lstPrice.Items(i).ToString
            lstPrice.Items(i) = Format(price, "#.00")
            i = i + 1
        Loop Until i > 9
        gbLstProds.BackColor = Color.FromArgb(125, Color.DarkCyan)
        gbCart.BackColor = Color.FromArgb(125, Color.DarkCyan)
    End Sub

    Private Sub lstProdName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProdName.SelectedIndexChanged
        Dim items As Integer = lstProdName.Items.Count
        Dim i As Integer = 0
        While i < items
            If lstProdName.GetSelected(i) = True Then
                lstPrice.SetSelected(i, True)
            End If
            i = i + 1
        End While
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim items As Integer = lstProdName.Items.Count
        Dim i As Integer = 0
        Dim qty

        For i = 0 To items - 1
            If lstProdName.GetSelected(i) = True Then
                lstCartProd.Items.Add(lstProdName.Items(i))
                lstCartPrice.Items.Add(lstPrice.Items(i))
getQty:
                qty = InputBox("Enter the quantity for " & lstProdName.Items(i) & ":", "input")
                If Not IsNumeric(qty) Or qty = "" Or qty = "0" Then
                    GoTo getQty
                End If

                lstCartQuanti.Items.Add(qty)
                Dim price As Double = lstPrice.Items(i)
                lstCartAmount.Items.Add(Format(price * qty, "#.00"))
                lstProdName.SetSelected(i, False)
                lstPrice.SetSelected(i, False)
            End If
        Next
    End Sub

    Private Sub btnCLear_Click(sender As Object, e As EventArgs) Handles btnCLear.Click
        Dim i As Integer = lstCartProd.Items.Count - 1
        Do While i >= 0
            lstCartProd.Items.RemoveAt(i)
            lstCartPrice.Items.RemoveAt(i)
            lstCartQuanti.Items.RemoveAt(i)
            lstCartAmount.Items.RemoveAt(i)
            i = i - 1
        Loop
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim i As Integer = lstCartProd.Items.Count - 1

        If lstCartProd.SelectedIndex > -1 Then
            Do Until i <= -1
                If lstCartProd.GetSelected(i) = True Then
                    lstCartProd.Items.RemoveAt(i)
                    lstCartPrice.Items.RemoveAt(i)
                    lstCartQuanti.Items.RemoveAt(i)
                    lstCartAmount.Items.RemoveAt(i)
                End If
                i = i - 1
            Loop
        Else
            MsgBox("No item to delete", vbOKOnly, "DELETE")
        End If
    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        Dim i As Integer = lstCartProd.Items.Count - 1
        Dim receipt As String = ""
        Dim total As Double = 0
        Dim amt As Double

        Do
            receipt = receipt & lstCartQuanti.Items(i) & lstCartProd.Items(i) _
                & " @ " & lstCartPrice.Items(i) & " = " _
                & lstCartAmount.Items(i) & vbNewLine
            amt = lstCartAmount.Items(i)
            total = total + amt
            i = i - 1
        Loop While i >= 0
        MsgBox(receipt & vbNewLine & "Total: " & Format(total, "#.00"), vbOKOnly + vbInformation, "RECEIPT")
        btnCLear_Click(sender, e)
    End Sub

    Private Sub lstCartProd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCartProd.SelectedIndexChanged
        Dim items As Integer = lstCartProd.Items.Count
        Dim i As Integer = 0
        While i < items
            If lstCartProd.GetSelected(i) = True Then
                lstCartPrice.SetSelected(i, True)
                lstCartQuanti.SetSelected(i, True)
                lstCartAmount.SetSelected(i, True)
            End If
            i = i + 1
        End While
    End Sub
End Class
