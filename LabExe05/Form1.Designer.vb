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
        Me.gbLstProds = New System.Windows.Forms.GroupBox()
        Me.imgAddTC = New System.Windows.Forms.PictureBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.LblPrice = New System.Windows.Forms.Label()
        Me.LblProdName = New System.Windows.Forms.Label()
        Me.lstPrice = New System.Windows.Forms.ListBox()
        Me.lstProdName = New System.Windows.Forms.ListBox()
        Me.gbCart = New System.Windows.Forms.GroupBox()
        Me.imgDelete = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.imgClear = New System.Windows.Forms.PictureBox()
        Me.btnCheckOut = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblCartAmount = New System.Windows.Forms.Label()
        Me.lstCartAmount = New System.Windows.Forms.ListBox()
        Me.lblCartQuant = New System.Windows.Forms.Label()
        Me.lstCartQuanti = New System.Windows.Forms.ListBox()
        Me.btnCLear = New System.Windows.Forms.Button()
        Me.lblCartPrice = New System.Windows.Forms.Label()
        Me.lblCardProd = New System.Windows.Forms.Label()
        Me.lstCartPrice = New System.Windows.Forms.ListBox()
        Me.lstCartProd = New System.Windows.Forms.ListBox()
        Me.gbLstProds.SuspendLayout()
        CType(Me.imgAddTC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCart.SuspendLayout()
        CType(Me.imgDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgClear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbLstProds
        '
        Me.gbLstProds.BackColor = System.Drawing.Color.DarkCyan
        Me.gbLstProds.Controls.Add(Me.imgAddTC)
        Me.gbLstProds.Controls.Add(Me.btnAdd)
        Me.gbLstProds.Controls.Add(Me.LblPrice)
        Me.gbLstProds.Controls.Add(Me.LblProdName)
        Me.gbLstProds.Controls.Add(Me.lstPrice)
        Me.gbLstProds.Controls.Add(Me.lstProdName)
        Me.gbLstProds.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbLstProds.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.gbLstProds.ForeColor = System.Drawing.Color.White
        Me.gbLstProds.Location = New System.Drawing.Point(12, 12)
        Me.gbLstProds.Name = "gbLstProds"
        Me.gbLstProds.Size = New System.Drawing.Size(320, 350)
        Me.gbLstProds.TabIndex = 0
        Me.gbLstProds.TabStop = False
        Me.gbLstProds.Text = "List of Products"
        '
        'imgAddTC
        '
        Me.imgAddTC.BackColor = System.Drawing.Color.DarkCyan
        Me.imgAddTC.Image = Global.LabExe05.My.Resources.Resources.imgAddTC
        Me.imgAddTC.Location = New System.Drawing.Point(260, 292)
        Me.imgAddTC.Name = "imgAddTC"
        Me.imgAddTC.Size = New System.Drawing.Size(35, 35)
        Me.imgAddTC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgAddTC.TabIndex = 6
        Me.imgAddTC.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.DarkCyan
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(158, 286)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(145, 47)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add to Cart"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'LblPrice
        '
        Me.LblPrice.AutoSize = True
        Me.LblPrice.BackColor = System.Drawing.Color.Transparent
        Me.LblPrice.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblPrice.Location = New System.Drawing.Point(182, 31)
        Me.LblPrice.Name = "LblPrice"
        Me.LblPrice.Size = New System.Drawing.Size(47, 21)
        Me.LblPrice.TabIndex = 4
        Me.LblPrice.Text = "Price"
        '
        'LblProdName
        '
        Me.LblProdName.AutoSize = True
        Me.LblProdName.BackColor = System.Drawing.Color.Transparent
        Me.LblProdName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblProdName.Location = New System.Drawing.Point(12, 31)
        Me.LblProdName.Name = "LblProdName"
        Me.LblProdName.Size = New System.Drawing.Size(124, 21)
        Me.LblProdName.TabIndex = 3
        Me.LblProdName.Text = "Product Name"
        '
        'lstPrice
        '
        Me.lstPrice.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lstPrice.ForeColor = System.Drawing.Color.DarkCyan
        Me.lstPrice.FormattingEnabled = True
        Me.lstPrice.ItemHeight = 21
        Me.lstPrice.Items.AddRange(New Object() {"8 ", "15", "40", "35", "18", "10", "20", "25", "11", "200"})
        Me.lstPrice.Location = New System.Drawing.Point(186, 55)
        Me.lstPrice.Name = "lstPrice"
        Me.lstPrice.Size = New System.Drawing.Size(117, 214)
        Me.lstPrice.TabIndex = 2
        '
        'lstProdName
        '
        Me.lstProdName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lstProdName.ForeColor = System.Drawing.Color.DarkCyan
        Me.lstProdName.FormattingEnabled = True
        Me.lstProdName.ItemHeight = 21
        Me.lstProdName.Items.AddRange(New Object() {"PENCIL", "BALLPEN", "NOTEBOOK", "PAPER", "GLUE", "ERASER", "SCISSORS", "RULER", "SHARPENER", "BAG"})
        Me.lstProdName.Location = New System.Drawing.Point(16, 55)
        Me.lstProdName.Name = "lstProdName"
        Me.lstProdName.Size = New System.Drawing.Size(153, 214)
        Me.lstProdName.TabIndex = 1
        '
        'gbCart
        '
        Me.gbCart.BackColor = System.Drawing.Color.DarkCyan
        Me.gbCart.Controls.Add(Me.imgDelete)
        Me.gbCart.Controls.Add(Me.PictureBox2)
        Me.gbCart.Controls.Add(Me.imgClear)
        Me.gbCart.Controls.Add(Me.btnCheckOut)
        Me.gbCart.Controls.Add(Me.btnDelete)
        Me.gbCart.Controls.Add(Me.lblCartAmount)
        Me.gbCart.Controls.Add(Me.lstCartAmount)
        Me.gbCart.Controls.Add(Me.lblCartQuant)
        Me.gbCart.Controls.Add(Me.lstCartQuanti)
        Me.gbCart.Controls.Add(Me.btnCLear)
        Me.gbCart.Controls.Add(Me.lblCartPrice)
        Me.gbCart.Controls.Add(Me.lblCardProd)
        Me.gbCart.Controls.Add(Me.lstCartPrice)
        Me.gbCart.Controls.Add(Me.lstCartProd)
        Me.gbCart.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.gbCart.ForeColor = System.Drawing.Color.White
        Me.gbCart.Location = New System.Drawing.Point(336, 12)
        Me.gbCart.Name = "gbCart"
        Me.gbCart.Size = New System.Drawing.Size(503, 350)
        Me.gbCart.TabIndex = 6
        Me.gbCart.TabStop = False
        Me.gbCart.Text = "Cart"
        '
        'imgDelete
        '
        Me.imgDelete.BackColor = System.Drawing.Color.DarkCyan
        Me.imgDelete.Image = Global.LabExe05.My.Resources.Resources.imgDelete
        Me.imgDelete.Location = New System.Drawing.Point(244, 292)
        Me.imgDelete.Name = "imgDelete"
        Me.imgDelete.Size = New System.Drawing.Size(35, 35)
        Me.imgDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgDelete.TabIndex = 13
        Me.imgDelete.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.DarkCyan
        Me.PictureBox2.Image = Global.LabExe05.My.Resources.Resources.imgCO
        Me.PictureBox2.Location = New System.Drawing.Point(440, 292)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'imgClear
        '
        Me.imgClear.BackColor = System.Drawing.Color.DarkCyan
        Me.imgClear.Image = Global.LabExe05.My.Resources.Resources.imgClear
        Me.imgClear.Location = New System.Drawing.Point(72, 292)
        Me.imgClear.Name = "imgClear"
        Me.imgClear.Size = New System.Drawing.Size(35, 35)
        Me.imgClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgClear.TabIndex = 7
        Me.imgClear.TabStop = False
        '
        'btnCheckOut
        '
        Me.btnCheckOut.BackColor = System.Drawing.Color.DarkCyan
        Me.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckOut.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCheckOut.ForeColor = System.Drawing.Color.White
        Me.btnCheckOut.Location = New System.Drawing.Point(344, 286)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Size = New System.Drawing.Size(140, 47)
        Me.btnCheckOut.TabIndex = 11
        Me.btnCheckOut.Text = "Check Out"
        Me.btnCheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCheckOut.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.DarkCyan
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(182, 286)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(105, 47)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'lblCartAmount
        '
        Me.lblCartAmount.AutoSize = True
        Me.lblCartAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblCartAmount.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCartAmount.Location = New System.Drawing.Point(380, 31)
        Me.lblCartAmount.Name = "lblCartAmount"
        Me.lblCartAmount.Size = New System.Drawing.Size(75, 21)
        Me.lblCartAmount.TabIndex = 9
        Me.lblCartAmount.Text = "Amount"
        '
        'lstCartAmount
        '
        Me.lstCartAmount.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lstCartAmount.ForeColor = System.Drawing.Color.DarkCyan
        Me.lstCartAmount.FormattingEnabled = True
        Me.lstCartAmount.ItemHeight = 21
        Me.lstCartAmount.Location = New System.Drawing.Point(382, 55)
        Me.lstCartAmount.Name = "lstCartAmount"
        Me.lstCartAmount.Size = New System.Drawing.Size(102, 214)
        Me.lstCartAmount.TabIndex = 8
        '
        'lblCartQuant
        '
        Me.lblCartQuant.AutoSize = True
        Me.lblCartQuant.BackColor = System.Drawing.Color.Transparent
        Me.lblCartQuant.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCartQuant.Location = New System.Drawing.Point(274, 31)
        Me.lblCartQuant.Name = "lblCartQuant"
        Me.lblCartQuant.Size = New System.Drawing.Size(80, 21)
        Me.lblCartQuant.TabIndex = 7
        Me.lblCartQuant.Text = "Quantity"
        '
        'lstCartQuanti
        '
        Me.lstCartQuanti.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lstCartQuanti.ForeColor = System.Drawing.Color.DarkCyan
        Me.lstCartQuanti.FormattingEnabled = True
        Me.lstCartQuanti.ItemHeight = 21
        Me.lstCartQuanti.Location = New System.Drawing.Point(276, 55)
        Me.lstCartQuanti.Name = "lstCartQuanti"
        Me.lstCartQuanti.Size = New System.Drawing.Size(88, 214)
        Me.lstCartQuanti.TabIndex = 6
        '
        'btnCLear
        '
        Me.btnCLear.BackColor = System.Drawing.Color.DarkCyan
        Me.btnCLear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCLear.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCLear.ForeColor = System.Drawing.Color.White
        Me.btnCLear.Location = New System.Drawing.Point(16, 286)
        Me.btnCLear.Name = "btnCLear"
        Me.btnCLear.Size = New System.Drawing.Size(99, 47)
        Me.btnCLear.TabIndex = 5
        Me.btnCLear.Text = "Clear"
        Me.btnCLear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCLear.UseVisualStyleBackColor = False
        '
        'lblCartPrice
        '
        Me.lblCartPrice.AutoSize = True
        Me.lblCartPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblCartPrice.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCartPrice.Location = New System.Drawing.Point(155, 31)
        Me.lblCartPrice.Name = "lblCartPrice"
        Me.lblCartPrice.Size = New System.Drawing.Size(47, 21)
        Me.lblCartPrice.TabIndex = 4
        Me.lblCartPrice.Text = "Price"
        '
        'lblCardProd
        '
        Me.lblCardProd.AutoSize = True
        Me.lblCardProd.BackColor = System.Drawing.Color.Transparent
        Me.lblCardProd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCardProd.Location = New System.Drawing.Point(12, 31)
        Me.lblCardProd.Name = "lblCardProd"
        Me.lblCardProd.Size = New System.Drawing.Size(124, 21)
        Me.lblCardProd.TabIndex = 3
        Me.lblCardProd.Text = "Product Name"
        '
        'lstCartPrice
        '
        Me.lstCartPrice.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lstCartPrice.ForeColor = System.Drawing.Color.DarkCyan
        Me.lstCartPrice.FormattingEnabled = True
        Me.lstCartPrice.ItemHeight = 21
        Me.lstCartPrice.Location = New System.Drawing.Point(157, 55)
        Me.lstCartPrice.Name = "lstCartPrice"
        Me.lstCartPrice.Size = New System.Drawing.Size(102, 214)
        Me.lstCartPrice.TabIndex = 2
        '
        'lstCartProd
        '
        Me.lstCartProd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lstCartProd.ForeColor = System.Drawing.Color.DarkCyan
        Me.lstCartProd.FormattingEnabled = True
        Me.lstCartProd.ItemHeight = 21
        Me.lstCartProd.Location = New System.Drawing.Point(16, 55)
        Me.lstCartProd.Name = "lstCartProd"
        Me.lstCartProd.Size = New System.Drawing.Size(124, 214)
        Me.lstCartProd.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkTurquoise
        Me.BackgroundImage = Global.LabExe05.My.Resources.Resources.imgBG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(849, 374)
        Me.Controls.Add(Me.gbCart)
        Me.Controls.Add(Me.gbLstProds)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "HARVY JONES PONTILLAS (DICT22)"
        Me.gbLstProds.ResumeLayout(False)
        Me.gbLstProds.PerformLayout()
        CType(Me.imgAddTC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCart.ResumeLayout(False)
        Me.gbCart.PerformLayout()
        CType(Me.imgDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgClear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbLstProds As GroupBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents LblPrice As Label
    Friend WithEvents LblProdName As Label
    Friend WithEvents lstPrice As ListBox
    Friend WithEvents lstProdName As ListBox
    Friend WithEvents gbCart As GroupBox
    Friend WithEvents btnCheckOut As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblCartAmount As Label
    Friend WithEvents lstCartAmount As ListBox
    Friend WithEvents lblCartQuant As Label
    Friend WithEvents lstCartQuanti As ListBox
    Friend WithEvents btnCLear As Button
    Friend WithEvents lblCartPrice As Label
    Friend WithEvents lblCardProd As Label
    Friend WithEvents lstCartPrice As ListBox
    Friend WithEvents lstCartProd As ListBox
    Friend WithEvents imgAddTC As PictureBox
    Friend WithEvents imgDelete As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents imgClear As PictureBox
End Class
