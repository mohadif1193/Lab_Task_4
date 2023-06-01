<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btCus = New System.Windows.Forms.Button()
        Me.btRes = New System.Windows.Forms.Button()
        Me.btAbout = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbQTT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbPrice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btATC = New System.Windows.Forms.Button()
        Me.btRemove = New System.Windows.Forms.Button()
        Me.btSearch = New System.Windows.Forms.Button()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btCus)
        Me.Panel1.Controls.Add(Me.btRes)
        Me.Panel1.Controls.Add(Me.btAbout)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(170, 326)
        Me.Panel1.TabIndex = 0
        '
        'btCus
        '
        Me.btCus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btCus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btCus.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btCus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btCus.Location = New System.Drawing.Point(14, 225)
        Me.btCus.Name = "btCus"
        Me.btCus.Size = New System.Drawing.Size(140, 59)
        Me.btCus.TabIndex = 2
        Me.btCus.Text = "Customer"
        Me.btCus.UseVisualStyleBackColor = False
        '
        'btRes
        '
        Me.btRes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btRes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btRes.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btRes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btRes.Location = New System.Drawing.Point(14, 130)
        Me.btRes.Name = "btRes"
        Me.btRes.Size = New System.Drawing.Size(140, 59)
        Me.btRes.TabIndex = 1
        Me.btRes.Text = "Restaurant"
        Me.btRes.UseVisualStyleBackColor = False
        '
        'btAbout
        '
        Me.btAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btAbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btAbout.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btAbout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btAbout.Location = New System.Drawing.Point(14, 36)
        Me.btAbout.Name = "btAbout"
        Me.btAbout.Size = New System.Drawing.Size(140, 59)
        Me.btAbout.TabIndex = 0
        Me.btAbout.Text = "About"
        Me.btAbout.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.tbID)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tbTotal)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbQTT)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbPrice)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(188, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(401, 324)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order Details"
        '
        'tbID
        '
        Me.tbID.Location = New System.Drawing.Point(141, 100)
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(238, 35)
        Me.tbID.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(43, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 28)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Item Id:"
        '
        'tbTotal
        '
        Me.tbTotal.Location = New System.Drawing.Point(141, 264)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.Size = New System.Drawing.Size(238, 35)
        Me.tbTotal.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(64, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 28)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Total:"
        '
        'tbQTT
        '
        Me.tbQTT.Location = New System.Drawing.Point(141, 210)
        Me.tbQTT.Name = "tbQTT"
        Me.tbQTT.Size = New System.Drawing.Size(238, 35)
        Me.tbQTT.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(28, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 28)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Quantity:"
        '
        'tbPrice
        '
        Me.tbPrice.Location = New System.Drawing.Point(141, 154)
        Me.tbPrice.Name = "tbPrice"
        Me.tbPrice.Size = New System.Drawing.Size(238, 35)
        Me.tbPrice.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(62, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 28)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Price:"
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(141, 48)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(238, 35)
        Me.tbName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(6, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Item Name:"
        '
        'btATC
        '
        Me.btATC.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btATC.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btATC.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btATC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btATC.Location = New System.Drawing.Point(595, 49)
        Me.btATC.Name = "btATC"
        Me.btATC.Size = New System.Drawing.Size(157, 59)
        Me.btATC.TabIndex = 2
        Me.btATC.Text = "Add to Cart"
        Me.btATC.UseVisualStyleBackColor = False
        '
        'btRemove
        '
        Me.btRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btRemove.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btRemove.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btRemove.Location = New System.Drawing.Point(595, 125)
        Me.btRemove.Name = "btRemove"
        Me.btRemove.Size = New System.Drawing.Size(157, 59)
        Me.btRemove.TabIndex = 3
        Me.btRemove.Text = "Remove"
        Me.btRemove.UseVisualStyleBackColor = False
        '
        'btSearch
        '
        Me.btSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btSearch.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btSearch.Location = New System.Drawing.Point(188, 12)
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(157, 31)
        Me.btSearch.TabIndex = 4
        Me.btSearch.Text = "Search"
        Me.btSearch.UseVisualStyleBackColor = False
        '
        'tbSearch
        '
        Me.tbSearch.Location = New System.Drawing.Point(351, 12)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(238, 31)
        Me.tbSearch.TabIndex = 5
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(761, 386)
        Me.Controls.Add(Me.tbSearch)
        Me.Controls.Add(Me.btSearch)
        Me.Controls.Add(Me.btRemove)
        Me.Controls.Add(Me.btATC)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btCus As Button
    Friend WithEvents btRes As Button
    Friend WithEvents btAbout As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbQTT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbPrice As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btATC As Button
    Friend WithEvents btRemove As Button
    Friend WithEvents tbID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btSearch As Button
    Friend WithEvents tbSearch As TextBox
End Class
