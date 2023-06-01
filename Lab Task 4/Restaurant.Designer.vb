<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Restaurant
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btCus = New System.Windows.Forms.Button()
        Me.btAbout = New System.Windows.Forms.Button()
        Me.btHome = New System.Windows.Forms.Button()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.btReserve = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.resTime = New System.Windows.Forms.TextBox()
        Me.resDate = New System.Windows.Forms.DateTimePicker()
        Me.lastName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.phoneNo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.firstName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbRating = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbLocation = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.btSearch = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btCus)
        Me.Panel1.Controls.Add(Me.btAbout)
        Me.Panel1.Controls.Add(Me.btHome)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(170, 326)
        Me.Panel1.TabIndex = 1
        '
        'btCus
        '
        Me.btCus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
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
        'btAbout
        '
        Me.btAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btAbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btAbout.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btAbout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btAbout.Location = New System.Drawing.Point(14, 130)
        Me.btAbout.Name = "btAbout"
        Me.btAbout.Size = New System.Drawing.Size(140, 59)
        Me.btAbout.TabIndex = 1
        Me.btAbout.Text = "About"
        Me.btAbout.UseVisualStyleBackColor = False
        '
        'btHome
        '
        Me.btHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btHome.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btHome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btHome.Location = New System.Drawing.Point(14, 36)
        Me.btHome.Name = "btHome"
        Me.btHome.Size = New System.Drawing.Size(140, 59)
        Me.btHome.TabIndex = 0
        Me.btHome.Text = "Home"
        Me.btHome.UseVisualStyleBackColor = False
        '
        'btCancel
        '
        Me.btCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btCancel.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btCancel.Location = New System.Drawing.Point(204, 576)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(144, 38)
        Me.btCancel.TabIndex = 6
        Me.btCancel.Text = "Cancell"
        Me.btCancel.UseVisualStyleBackColor = False
        '
        'btReserve
        '
        Me.btReserve.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btReserve.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btReserve.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btReserve.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btReserve.Location = New System.Drawing.Point(378, 576)
        Me.btReserve.Name = "btReserve"
        Me.btReserve.Size = New System.Drawing.Size(144, 38)
        Me.btReserve.TabIndex = 5
        Me.btReserve.Text = "Reserve"
        Me.btReserve.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btCancel)
        Me.GroupBox1.Controls.Add(Me.tbRating)
        Me.GroupBox1.Controls.Add(Me.btReserve)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbLocation)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(194, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(528, 625)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resevation"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.resTime)
        Me.GroupBox2.Controls.Add(Me.resDate)
        Me.GroupBox2.Controls.Add(Me.lastName)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.phoneNo)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.firstName)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 267)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(511, 303)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer Details"
        '
        'resTime
        '
        Me.resTime.Location = New System.Drawing.Point(199, 243)
        Me.resTime.Name = "resTime"
        Me.resTime.Size = New System.Drawing.Size(270, 35)
        Me.resTime.TabIndex = 21
        '
        'resDate
        '
        Me.resDate.Location = New System.Drawing.Point(199, 189)
        Me.resDate.Name = "resDate"
        Me.resDate.Size = New System.Drawing.Size(270, 35)
        Me.resDate.TabIndex = 20
        '
        'lastName
        '
        Me.lastName.Location = New System.Drawing.Point(199, 86)
        Me.lastName.Name = "lastName"
        Me.lastName.Size = New System.Drawing.Size(270, 35)
        Me.lastName.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(66, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 28)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Last Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(123, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 28)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Time:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(126, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 28)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Date:"
        '
        'phoneNo
        '
        Me.phoneNo.Location = New System.Drawing.Point(199, 139)
        Me.phoneNo.Name = "phoneNo"
        Me.phoneNo.Size = New System.Drawing.Size(270, 35)
        Me.phoneNo.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(74, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 28)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Phone No:"
        '
        'firstName
        '
        Me.firstName.Location = New System.Drawing.Point(199, 34)
        Me.firstName.Name = "firstName"
        Me.firstName.Size = New System.Drawing.Size(270, 35)
        Me.firstName.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(61, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 28)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "First Name:"
        '
        'tbRating
        '
        Me.tbRating.Location = New System.Drawing.Point(210, 200)
        Me.tbRating.Name = "tbRating"
        Me.tbRating.Size = New System.Drawing.Size(270, 35)
        Me.tbRating.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(117, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 28)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Rating:"
        '
        'tbLocation
        '
        Me.tbLocation.Location = New System.Drawing.Point(210, 148)
        Me.tbLocation.Name = "tbLocation"
        Me.tbLocation.Size = New System.Drawing.Size(270, 35)
        Me.tbLocation.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(95, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 28)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Location:"
        '
        'tbID
        '
        Me.tbID.Location = New System.Drawing.Point(210, 96)
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(270, 35)
        Me.tbID.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(43, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 28)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Restaurant ID:"
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(210, 48)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(270, 35)
        Me.tbName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(11, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Restaurant Name:"
        '
        'tbSearch
        '
        Me.tbSearch.Location = New System.Drawing.Point(357, 12)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(365, 35)
        Me.tbSearch.TabIndex = 7
        '
        'btSearch
        '
        Me.btSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btSearch.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btSearch.Location = New System.Drawing.Point(194, 12)
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(157, 35)
        Me.btSearch.TabIndex = 6
        Me.btSearch.Text = "Search"
        Me.btSearch.UseVisualStyleBackColor = False
        '
        'Restaurant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(734, 689)
        Me.Controls.Add(Me.tbSearch)
        Me.Controls.Add(Me.btSearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Restaurant"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restaurant"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btCus As Button
    Friend WithEvents btAbout As Button
    Friend WithEvents btHome As Button
    Friend WithEvents btCancel As Button
    Friend WithEvents btReserve As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbRating As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbLocation As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents resTime As TextBox
    Friend WithEvents resDate As DateTimePicker
    Friend WithEvents lastName As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents phoneNo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents firstName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbSearch As TextBox
    Friend WithEvents btSearch As Button
End Class
