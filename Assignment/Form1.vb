Option Strict On


Public Class Form1
    Dim Standard As Integer
    Dim Deluxe As Integer
    Dim Premium As Integer
    Dim discount1, discount2, discount3 As Single
    Dim count1, count2, count3 As Integer
    Dim Value2, Value3, Value4 As Integer
    Dim sum As Single

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Randomize()
        GetNumber()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Shows Current Date and Time
        lblDate.Text = Date.Now.ToString("dd-MM-yyyy")
        lblDate2.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub chkStandard_CheckedChanged(sender As Object, e As EventArgs) Handles chkStandard.CheckedChanged
        If chkStandard.Checked Then
            txtStandard.Enabled = True
        Else
            txtStandard.Enabled = False
        End If
    End Sub

    Private Sub chkDeluxe_CheckedChanged(sender As Object, e As EventArgs) Handles chkDeluxe.CheckedChanged
        If chkDeluxe.Checked Then
            txtDeluxe.Enabled = True
        Else
            txtDeluxe.Enabled = False
        End If
    End Sub

    Private Sub chkPremium_CheckedChanged(sender As Object, e As EventArgs) Handles chkPremium.CheckedChanged
        If chkPremium.Checked Then
            txtPremium.Enabled = True
        Else
            txtPremium.Enabled = False
        End If
    End Sub

    Private Sub txtStandard_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStandard.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            'Accept the character if it's a number
            e.Handled = False
        Else
            'Reject the character if it's not a number
            e.Handled = True
        End If


    End Sub

    Private Sub txtDeluxe_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDeluxe.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            'Accept the character if it's a number
            e.Handled = False
        Else
            'Reject the character if it's not a number
            e.Handled = True
        End If
    End Sub

    Private Sub txtPremium_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPremium.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            'Accept the character if it's a number
            e.Handled = False
        Else
            'Reject the character if it's not a number
            e.Handled = True
        End If
    End Sub



    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        'When quantity = 0
        If (txtStandard.Text = "") And (txtDeluxe.Text = "") And (txtPremium.Text = "") Then
            MessageBox.Show("Please enter the quantity of ticket", "Transaction Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'The value that customer going to purchase
        ElseIf chkStandard.Checked And chkDeluxe.Checked = False And chkPremium.Checked = False Then
            count1 = CInt(txtStandard.Text)
            count2 = 0
            count3 = 0

        ElseIf chkDeluxe.Checked And chkStandard.Checked = False And chkPremium.Checked = False Then
            count1 = 0
            count2 = CInt(txtDeluxe.Text)
            count3 = 0

        ElseIf chkPremium.Checked And chkStandard.Checked = False And chkDeluxe.Checked = False Then
            count1 = 0
            count2 = 0
            count3 = CInt(txtPremium.Text)

        ElseIf chkStandard.Checked And chkDeluxe.Checked And chkPremium.Checked = False Then
            count1 = CInt(txtStandard.Text)
            count2 = CInt(txtDeluxe.Text)
            count3 = 0

        ElseIf chkStandard.Checked And chkDeluxe.Checked = False And chkPremium.Checked Then
            count1 = CInt(txtStandard.Text)
            count2 = 0
            count3 = CInt(txtPremium.Text)

        ElseIf chkStandard.Checked = False And chkDeluxe.Checked And chkPremium.Checked Then
            count1 = 0
            count2 = CInt(txtDeluxe.Text)
            count3 = CInt(txtPremium.Text)

        ElseIf chkStandard.Checked And chkDeluxe.Checked And chkPremium.Checked Then
            count1 = CInt(txtStandard.Text)
            count2 = CInt(txtDeluxe.Text)
            count3 = CInt(txtPremium.Text)
        End If


        'Ticket Pricing Calculation
        Standard = count1 * 50
        Deluxe = count2 * 80
        Premium = count3 * 100
        '----------------------------------------------------------------------------------------------
        'Button Color
        If (txtStandard.Text = "") And (txtDeluxe.Text = "") And (txtPremium.Text = "") Then
            btnConfirm.BackColor = Color.Red
        Else
            btnConfirm.BackColor = Color.Green
        End If

        '-----------------------------------------------------------------------------------------------

        'Calculate Tickets Discounts for each types

        'DISCOUNT CALCULATION FOR STANDARD TICKETS
        'Ticket Amount 2~4, Discount = 10%
        If count1 >= 2 And count1 <= 4 Then
            discount1 = CSng(Standard * 0.1)

            'Ticket Amount 5~8, Discount = 15%
        ElseIf count1 >= 5 And count1 <= 8 Then
            discount1 = CSng(Standard * 0.15)

            'Ticket Amount 9~12, Discount = 20%
        ElseIf count1 >= 9 And count1 <= 12 Then
            discount1 = CSng(Standard * 0.2)

            'Ticket Amount 12~15, Discount = 25%
        ElseIf count1 >= 12 And count1 <= 15 Then
            discount1 = CSng(Standard * 0.25)
        End If

        'Calculate Price After Discount
        Value2 = CInt(Standard - discount1)
        '-------------------------------------------------------------------------------------------------

        'DISCOUNT CALCULATION FOR DELUXE TICKETS
        'Ticket Amount 2~4, Discount = 10%
        If count2 >= 2 And count2 <= 4 Then
            discount2 = CSng(Deluxe * 0.1)

            'Ticket Amount 5~8, Discount = 15%
        ElseIf count2 >= 5 And count2 <= 8 Then
            discount2 = CSng(Deluxe * 0.15)

            'Ticket Amount 9~12, Discount = 20%
        ElseIf count2 >= 9 And count2 <= 12 Then
            discount2 = CSng(Deluxe * 0.2)

            'Ticket Amount 12~15, Discount = 25%
        ElseIf count2 >= 12 And count2 <= 15 Then
            discount2 = CSng(Deluxe * 0.25)
        End If

        'Calculate Price After Discount
        Value3 = CInt(Deluxe - discount2)
        '----------------------------------------------------------------------------------------------------

        'DISCOUNT CALCULATION FOR PREMIUM TICKETS
        'Ticket Amount 2~4, Discount = 10%
        If count3 >= 2 And count3 <= 4 Then
            discount3 = CSng(Premium * 0.1)

            'Ticket Amount 5~8, Discount = 15%
        ElseIf count3 >= 5 And count3 <= 8 Then
            discount3 = CSng(Premium * 0.15)

            'Ticket Amount 9~12, Discount = 20%
        ElseIf count3 >= 9 And count3 <= 12 Then
            discount3 = CSng(Premium * 0.2)

            'Ticket Amount 12~15, Discount = 25%
        ElseIf count3 >= 12 And count3 <= 15 Then
            discount3 = CSng(Premium * 0.25)
        End If

        'Calculate Price After Discount
        Value4 = CInt(Premium - discount3)
        '---------------------------------------------------------------------------------------------

        'Calculate Total Price
        sum = Value2 + Value3 + Value4
        '---------------------------------------------------------------------------------------------
        'Listbox Coding Part

        'Ticket Type Listbox
        If (chkStandard.Checked = False) Or (chkStandard.Checked) And (txtStandard.Text = "") Then
            lstTicket.Items.Add("")
        Else
            lstTicket.Items.Add(chkStandard.Text)
        End If

        If (chkDeluxe.Checked = False) Or (chkDeluxe.Checked) And (txtDeluxe.Text = "") Then
            lstTicket.Items.Add("")
        Else
            lstTicket.Items.Add(chkDeluxe.Text)
        End If

        If (chkPremium.Checked = False) Or (chkPremium.Checked) And (txtPremium.Text = "") Then
            lstTicket.Items.Add("")
        Else
            lstTicket.Items.Add(chkPremium.Text)
        End If

        'Quantity Listbox
        If (chkStandard.Checked = False) Or (chkStandard.Checked) And (txtStandard.Text = "") Then
            lstQuantity.Items.Add("")
        Else
            lstQuantity.Items.Add(txtStandard.Text)
        End If

        If (chkDeluxe.Checked = False) Or (chkDeluxe.Checked) And (txtDeluxe.Text = "") Then
            lstQuantity.Items.Add("")
        Else
            lstQuantity.Items.Add(txtDeluxe.Text)
        End If
        If (chkPremium.Checked = False) Or (chkPremium.Checked) And (txtPremium.Text = "") Then
            lstQuantity.Items.Add("")
        Else
            lstQuantity.Items.Add(txtPremium.Text)
        End If

        'Discount Listbox
        If (chkStandard.Checked = False) Or (chkStandard.Checked) And (txtStandard.Text = "") Then
            lstDiscount.Items.Add("")
        Else
            lstDiscount.Items.Add(discount1.ToString("c"))
        End If

        If (chkDeluxe.Checked = False) Or (chkDeluxe.Checked) And (txtDeluxe.Text = "") Then
            lstDiscount.Items.Add("")
        Else
            lstDiscount.Items.Add(discount2.ToString("c"))
        End If

        If (chkPremium.Checked = False) Or (chkPremium.Checked) And (txtPremium.Text = "") Then
            lstDiscount.Items.Add("")
        Else
            lstDiscount.Items.Add(discount3.ToString("c"))
        End If

        'Sub Total Listbox
        If (chkStandard.Checked = False) Or (chkStandard.Checked) And (txtStandard.Text = "") Then
            lstPrice.Items.Add("")
        Else
            lstPrice.Items.Add(Value2.ToString("c"))
        End If

        If (chkDeluxe.Checked = False) Or (chkDeluxe.Checked) And (txtDeluxe.Text = "") Then
            lstPrice.Items.Add("")
        Else
            lstPrice.Items.Add(Value3.ToString("c"))
        End If

        If (chkPremium.Checked = False) Or (chkPremium.Checked) And (txtPremium.Text = "") Then
            lstPrice.Items.Add("")
        Else
            lstPrice.Items.Add(Value4.ToString("c"))
        End If

        'Calculation for Total Amount
        lblTotalAmount.Text = sum.ToString("c")

    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        btnConfirm.BackColor = DefaultBackColor
        btnReceipt.BackColor = DefaultBackColor
        lstTicket.Items.Clear()
        lstQuantity.Items.Clear()
        lstDiscount.Items.Clear()
        lstPrice.Items.Clear()
        lstReceipt.Items.Clear()
        txtStandard.Clear()
        txtDeluxe.Clear()
        txtPremium.Clear()
        lblTotalAmount.Text = ""
        chkStandard.Checked = False
        chkDeluxe.Checked = False
        chkPremium.Checked = False

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim Reply As DialogResult
        Reply = MessageBox.Show("Do you want to exit the application", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Reply = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Dim Num As Integer
    Private Sub GetNumber()
        Num = CInt(Math.Ceiling(Rnd() * 80001139))
    End Sub

    Private Sub btnReceipt_Click(sender As Object, e As EventArgs) Handles btnReceipt.Click
        If (btnConfirm.BackColor = Color.Green) Then
            btnReceipt.BackColor = Color.Green
        Else
            btnReceipt.BackColor = Color.Red
        End If

        'Receipt 
        lstReceipt.Items.Add("Serial Number: " & Num & vbTab & vbTab & Date.Now.ToShortDateString)
        lstReceipt.Items.Add(vbTab & vbTab & vbTab & vbTab & Date.Now.ToLongTimeString)
        lstReceipt.Items.Add("")
        lstReceipt.Items.Add("Ticket Type" & vbTab & "Quantity" & vbTab & "Discount" & vbTab & "   " & "Price")

        If (chkStandard.Checked = False) Or (chkStandard.Checked) And (txtStandard.Text = "") Then
            lstReceipt.Items.Add("")
        Else
            lstReceipt.Items.Add(chkStandard.Text & vbTab & vbTab & txtStandard.Text & vbTab & discount1.ToString("c") & vbTab & "   " & Value2.ToString("c"))
        End If

        If (chkDeluxe.Checked = False) Or (chkDeluxe.Checked) And (txtDeluxe.Text = "") Then
            lstReceipt.Items.Add("")
        Else
            lstReceipt.Items.Add(chkDeluxe.Text & vbTab & vbTab & txtDeluxe.Text & vbTab & discount2.ToString("c") & vbTab & "   " & Value3.ToString("c"))
        End If

        If (chkPremium.Checked = False) Or (chkPremium.Checked) And (txtPremium.Text = "") Then
            lstReceipt.Items.Add("")
        Else
            lstReceipt.Items.Add(chkPremium.Text & vbTab & vbTab & txtPremium.Text & vbTab & discount3.ToString("c") & "   " & Value4.ToString("c"))
        End If
        lstReceipt.Items.Add("--------------------------------------------------------------------------------------")
        lstReceipt.Items.Add("Total Price" & vbTab & vbTab & vbTab & "   " & sum.ToString("c"))
        lstReceipt.Items.Add("--------------------------------------------------------------------------------------")


        'Calculation for Total Amount
        lblTotalAmount.Text = sum.ToString("c")
    End Sub
End Class



