<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarInventory
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbMake = New System.Windows.Forms.ComboBox()
        Me.cbYear = New System.Windows.Forms.ComboBox()
        Me.tbModel = New System.Windows.Forms.TextBox()
        Me.tbPrice = New System.Windows.Forms.TextBox()
        Me.ckNewStatus = New System.Windows.Forms.CheckBox()
        Me.lvCarList = New System.Windows.Forms.ListView()
        Me.colNewStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tbOutput = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Make"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Model:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "&Year"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "&Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "&New"
        '
        'cbMake
        '
        Me.cbMake.FormattingEnabled = True
        Me.cbMake.Items.AddRange(New Object() {"Hyundai", "Volkswagen", "Honda"})
        Me.cbMake.Location = New System.Drawing.Point(123, 9)
        Me.cbMake.Name = "cbMake"
        Me.cbMake.Size = New System.Drawing.Size(121, 24)
        Me.cbMake.TabIndex = 1
        '
        'cbYear
        '
        Me.cbYear.FormattingEnabled = True
        Me.cbYear.Items.AddRange(New Object() {"2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "", ""})
        Me.cbYear.Location = New System.Drawing.Point(123, 65)
        Me.cbYear.Name = "cbYear"
        Me.cbYear.Size = New System.Drawing.Size(121, 24)
        Me.cbYear.TabIndex = 2
        '
        'tbModel
        '
        Me.tbModel.Location = New System.Drawing.Point(123, 37)
        Me.tbModel.Name = "tbModel"
        Me.tbModel.Size = New System.Drawing.Size(121, 22)
        Me.tbModel.TabIndex = 3
        '
        'tbPrice
        '
        Me.tbPrice.Location = New System.Drawing.Point(123, 93)
        Me.tbPrice.Name = "tbPrice"
        Me.tbPrice.Size = New System.Drawing.Size(121, 22)
        Me.tbPrice.TabIndex = 4
        '
        'ckNewStatus
        '
        Me.ckNewStatus.AutoSize = True
        Me.ckNewStatus.Location = New System.Drawing.Point(123, 122)
        Me.ckNewStatus.Name = "ckNewStatus"
        Me.ckNewStatus.Size = New System.Drawing.Size(18, 17)
        Me.ckNewStatus.TabIndex = 5
        Me.ckNewStatus.UseVisualStyleBackColor = True
        '
        'lvCarList
        '
        Me.lvCarList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNewStatus, Me.colMake, Me.colModel, Me.colYear, Me.colPrice})
        Me.lvCarList.HideSelection = False
        Me.lvCarList.Location = New System.Drawing.Point(15, 152)
        Me.lvCarList.MultiSelect = False
        Me.lvCarList.Name = "lvCarList"
        Me.lvCarList.Size = New System.Drawing.Size(601, 228)
        Me.lvCarList.TabIndex = 6
        Me.lvCarList.UseCompatibleStateImageBehavior = False
        Me.lvCarList.View = System.Windows.Forms.View.Details
        '
        'colNewStatus
        '
        Me.colNewStatus.Text = "New"
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        '
        'colModel
        '
        Me.colModel.DisplayIndex = 4
        Me.colModel.Text = "Model"
        '
        'colYear
        '
        Me.colYear.DisplayIndex = 2
        Me.colYear.Text = "Year"
        '
        'colPrice
        '
        Me.colPrice.DisplayIndex = 3
        Me.colPrice.Text = "Price"
        '
        'tbOutput
        '
        Me.tbOutput.Location = New System.Drawing.Point(271, 9)
        Me.tbOutput.Multiline = True
        Me.tbOutput.Name = "tbOutput"
        Me.tbOutput.Size = New System.Drawing.Size(345, 106)
        Me.tbOutput.TabIndex = 7
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(363, 395)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 37)
        Me.btnEnter.TabIndex = 8
        Me.btnEnter.Text = "&Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(445, 395)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 37)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(527, 395)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 37)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'CarInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.tbOutput)
        Me.Controls.Add(Me.lvCarList)
        Me.Controls.Add(Me.ckNewStatus)
        Me.Controls.Add(Me.tbPrice)
        Me.Controls.Add(Me.tbModel)
        Me.Controls.Add(Me.cbYear)
        Me.Controls.Add(Me.cbMake)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CarInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbMake As ComboBox
    Friend WithEvents cbYear As ComboBox
    Friend WithEvents tbModel As TextBox
    Friend WithEvents tbPrice As TextBox
    Friend WithEvents ckNewStatus As CheckBox
    Friend WithEvents lvCarList As ListView
    Friend WithEvents colNewStatus As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents colPrice As ColumnHeader
    Friend WithEvents tbOutput As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
End Class
