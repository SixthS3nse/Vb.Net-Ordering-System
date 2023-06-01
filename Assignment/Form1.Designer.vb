<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtStandard = New System.Windows.Forms.TextBox()
        Me.txtDeluxe = New System.Windows.Forms.TextBox()
        Me.txtPremium = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.lblTicketTotal = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.chkStandard = New System.Windows.Forms.CheckBox()
        Me.chkDeluxe = New System.Windows.Forms.CheckBox()
        Me.chkPremium = New System.Windows.Forms.CheckBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lstTicket = New System.Windows.Forms.ListBox()
        Me.lstQuantity = New System.Windows.Forms.ListBox()
        Me.lstDiscount = New System.Windows.Forms.ListBox()
        Me.lstPrice = New System.Windows.Forms.ListBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTicketType = New System.Windows.Forms.Label()
        Me.lblQuantityOfTicket = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblPriceAftDis = New System.Windows.Forms.Label()
        Me.lblDate2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblStandard = New System.Windows.Forms.Label()
        Me.lblDeluxe = New System.Windows.Forms.Label()
        Me.lblPremium = New System.Windows.Forms.Label()
        Me.lstReceipt = New System.Windows.Forms.ListBox()
        Me.btnReceipt = New System.Windows.Forms.Button()
        Me.LblName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtStandard
        '
        Me.txtStandard.Enabled = False
        Me.txtStandard.Location = New System.Drawing.Point(198, 68)
        Me.txtStandard.Name = "txtStandard"
        Me.txtStandard.Size = New System.Drawing.Size(81, 20)
        Me.txtStandard.TabIndex = 4
        '
        'txtDeluxe
        '
        Me.txtDeluxe.Enabled = False
        Me.txtDeluxe.Location = New System.Drawing.Point(198, 94)
        Me.txtDeluxe.Name = "txtDeluxe"
        Me.txtDeluxe.Size = New System.Drawing.Size(81, 20)
        Me.txtDeluxe.TabIndex = 5
        '
        'txtPremium
        '
        Me.txtPremium.Enabled = False
        Me.txtPremium.Location = New System.Drawing.Point(198, 120)
        Me.txtPremium.Name = "txtPremium"
        Me.txtPremium.Size = New System.Drawing.Size(81, 20)
        Me.txtPremium.TabIndex = 6
        '
        'btnConfirm
        '
        Me.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirm.Location = New System.Drawing.Point(112, 359)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(100, 35)
        Me.btnConfirm.TabIndex = 7
        Me.btnConfirm.Text = "Confirm Order"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.Location = New System.Drawing.Point(430, 106)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(100, 20)
        Me.lblTotalAmount.TabIndex = 8
        '
        'lblTicketTotal
        '
        Me.lblTicketTotal.AutoSize = True
        Me.lblTicketTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicketTotal.Location = New System.Drawing.Point(426, 77)
        Me.lblTicketTotal.Name = "lblTicketTotal"
        Me.lblTicketTotal.Size = New System.Drawing.Size(104, 20)
        Me.lblTicketTotal.TabIndex = 9
        Me.lblTicketTotal.Text = "Total Amount"
        '
        'btnClear
        '
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Location = New System.Drawing.Point(324, 359)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 35)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "New Order"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Location = New System.Drawing.Point(430, 359)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 35)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'chkStandard
        '
        Me.chkStandard.AutoSize = True
        Me.chkStandard.Location = New System.Drawing.Point(15, 71)
        Me.chkStandard.Name = "chkStandard"
        Me.chkStandard.Size = New System.Drawing.Size(69, 17)
        Me.chkStandard.TabIndex = 1
        Me.chkStandard.Text = "Standard"
        Me.chkStandard.UseVisualStyleBackColor = True
        '
        'chkDeluxe
        '
        Me.chkDeluxe.AutoSize = True
        Me.chkDeluxe.Location = New System.Drawing.Point(15, 97)
        Me.chkDeluxe.Name = "chkDeluxe"
        Me.chkDeluxe.Size = New System.Drawing.Size(59, 17)
        Me.chkDeluxe.TabIndex = 2
        Me.chkDeluxe.Text = "Deluxe"
        Me.chkDeluxe.UseVisualStyleBackColor = True
        '
        'chkPremium
        '
        Me.chkPremium.AutoSize = True
        Me.chkPremium.Location = New System.Drawing.Point(15, 124)
        Me.chkPremium.Name = "chkPremium"
        Me.chkPremium.Size = New System.Drawing.Size(66, 17)
        Me.chkPremium.TabIndex = 3
        Me.chkPremium.Text = "Premium"
        Me.chkPremium.UseVisualStyleBackColor = True
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(198, 45)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(68, 20)
        Me.lblQuantity.TabIndex = 19
        Me.lblQuantity.Text = "Quantity"
        '
        'lstTicket
        '
        Me.lstTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTicket.FormattingEnabled = True
        Me.lstTicket.ItemHeight = 20
        Me.lstTicket.Location = New System.Drawing.Point(12, 184)
        Me.lstTicket.Name = "lstTicket"
        Me.lstTicket.Size = New System.Drawing.Size(125, 164)
        Me.lstTicket.TabIndex = 20
        '
        'lstQuantity
        '
        Me.lstQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstQuantity.FormattingEnabled = True
        Me.lstQuantity.ItemHeight = 20
        Me.lstQuantity.Location = New System.Drawing.Point(143, 184)
        Me.lstQuantity.Name = "lstQuantity"
        Me.lstQuantity.Size = New System.Drawing.Size(125, 164)
        Me.lstQuantity.TabIndex = 21
        '
        'lstDiscount
        '
        Me.lstDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDiscount.FormattingEnabled = True
        Me.lstDiscount.ItemHeight = 20
        Me.lstDiscount.Location = New System.Drawing.Point(274, 184)
        Me.lstDiscount.Name = "lstDiscount"
        Me.lstDiscount.Size = New System.Drawing.Size(125, 164)
        Me.lstDiscount.TabIndex = 22
        '
        'lstPrice
        '
        Me.lstPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPrice.FormattingEnabled = True
        Me.lstPrice.ItemHeight = 20
        Me.lstPrice.Location = New System.Drawing.Point(405, 184)
        Me.lstPrice.Name = "lstPrice"
        Me.lstPrice.Size = New System.Drawing.Size(125, 164)
        Me.lstPrice.TabIndex = 23
        '
        'lblDate
        '
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(430, 8)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(100, 21)
        Me.lblDate.TabIndex = 24
        '
        'lblTicketType
        '
        Me.lblTicketType.AutoSize = True
        Me.lblTicketType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicketType.Location = New System.Drawing.Point(27, 161)
        Me.lblTicketType.Name = "lblTicketType"
        Me.lblTicketType.Size = New System.Drawing.Size(89, 20)
        Me.lblTicketType.TabIndex = 25
        Me.lblTicketType.Text = "Ticket Type"
        '
        'lblQuantityOfTicket
        '
        Me.lblQuantityOfTicket.AutoSize = True
        Me.lblQuantityOfTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantityOfTicket.Location = New System.Drawing.Point(172, 161)
        Me.lblQuantityOfTicket.Name = "lblQuantityOfTicket"
        Me.lblQuantityOfTicket.Size = New System.Drawing.Size(68, 20)
        Me.lblQuantityOfTicket.TabIndex = 26
        Me.lblQuantityOfTicket.Text = "Quantity"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(300, 161)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(72, 20)
        Me.lblDiscount.TabIndex = 27
        Me.lblDiscount.Text = "Discount"
        '
        'lblPriceAftDis
        '
        Me.lblPriceAftDis.AutoSize = True
        Me.lblPriceAftDis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceAftDis.Location = New System.Drawing.Point(435, 161)
        Me.lblPriceAftDis.Name = "lblPriceAftDis"
        Me.lblPriceAftDis.Size = New System.Drawing.Size(73, 20)
        Me.lblPriceAftDis.TabIndex = 28
        Me.lblPriceAftDis.Text = "SubTotal"
        '
        'lblDate2
        '
        Me.lblDate2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDate2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate2.Location = New System.Drawing.Point(430, 29)
        Me.lblDate2.Name = "lblDate2"
        Me.lblDate2.Size = New System.Drawing.Size(100, 21)
        Me.lblDate2.TabIndex = 29
        '
        'Timer1
        '
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(112, 45)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(44, 20)
        Me.lblPrice.TabIndex = 33
        Me.lblPrice.Text = "Price"
        '
        'lblStandard
        '
        Me.lblStandard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStandard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStandard.Location = New System.Drawing.Point(103, 68)
        Me.lblStandard.Name = "lblStandard"
        Me.lblStandard.Size = New System.Drawing.Size(68, 20)
        Me.lblStandard.TabIndex = 34
        Me.lblStandard.Text = "RM50"
        Me.lblStandard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDeluxe
        '
        Me.lblDeluxe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDeluxe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeluxe.Location = New System.Drawing.Point(103, 94)
        Me.lblDeluxe.Name = "lblDeluxe"
        Me.lblDeluxe.Size = New System.Drawing.Size(68, 20)
        Me.lblDeluxe.TabIndex = 35
        Me.lblDeluxe.Text = "RM80"
        Me.lblDeluxe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPremium
        '
        Me.lblPremium.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPremium.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPremium.Location = New System.Drawing.Point(103, 120)
        Me.lblPremium.Name = "lblPremium"
        Me.lblPremium.Size = New System.Drawing.Size(68, 20)
        Me.lblPremium.TabIndex = 36
        Me.lblPremium.Text = "RM100"
        Me.lblPremium.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lstReceipt
        '
        Me.lstReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstReceipt.FormattingEnabled = True
        Me.lstReceipt.Location = New System.Drawing.Point(547, 8)
        Me.lstReceipt.Name = "lstReceipt"
        Me.lstReceipt.Size = New System.Drawing.Size(301, 381)
        Me.lstReceipt.TabIndex = 37
        '
        'btnReceipt
        '
        Me.btnReceipt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReceipt.Location = New System.Drawing.Point(218, 359)
        Me.btnReceipt.Name = "btnReceipt"
        Me.btnReceipt.Size = New System.Drawing.Size(100, 35)
        Me.btnReceipt.TabIndex = 8
        Me.btnReceipt.Text = "Receipt"
        Me.btnReceipt.UseVisualStyleBackColor = True
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.Location = New System.Drawing.Point(27, 8)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(224, 25)
        Me.LblName.TabIndex = 39
        Me.LblName.Text = "Ed Sheeran Concert"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(863, 404)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.btnReceipt)
        Me.Controls.Add(Me.lstReceipt)
        Me.Controls.Add(Me.lblPremium)
        Me.Controls.Add(Me.lblDeluxe)
        Me.Controls.Add(Me.lblStandard)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblDate2)
        Me.Controls.Add(Me.lblPriceAftDis)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblQuantityOfTicket)
        Me.Controls.Add(Me.lblTicketType)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lstPrice)
        Me.Controls.Add(Me.lstDiscount)
        Me.Controls.Add(Me.lstQuantity)
        Me.Controls.Add(Me.lstTicket)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.chkPremium)
        Me.Controls.Add(Me.chkDeluxe)
        Me.Controls.Add(Me.chkStandard)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblTicketTotal)
        Me.Controls.Add(Me.lblTotalAmount)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.txtPremium)
        Me.Controls.Add(Me.txtDeluxe)
        Me.Controls.Add(Me.txtStandard)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Concert Ticketing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtStandard As TextBox
    Friend WithEvents txtDeluxe As TextBox
    Friend WithEvents txtPremium As TextBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents lblTicketTotal As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents chkStandard As CheckBox
    Friend WithEvents chkDeluxe As CheckBox
    Friend WithEvents chkPremium As CheckBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lstTicket As ListBox
    Friend WithEvents lstQuantity As ListBox
    Friend WithEvents lstDiscount As ListBox
    Friend WithEvents lstPrice As ListBox
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTicketType As Label
    Friend WithEvents lblQuantityOfTicket As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblPriceAftDis As Label
    Friend WithEvents lblDate2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblStandard As Label
    Friend WithEvents lblDeluxe As Label
    Friend WithEvents lblPremium As Label
    Friend WithEvents lstReceipt As ListBox
    Friend WithEvents btnReceipt As Button
    Friend WithEvents LblName As Label
End Class
