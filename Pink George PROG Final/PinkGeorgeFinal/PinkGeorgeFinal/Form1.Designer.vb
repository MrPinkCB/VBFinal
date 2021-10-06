<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.LBoxKms = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbKm = New System.Windows.Forms.TextBox()
        Me.BtnAddKms = New System.Windows.Forms.Button()
        Me.BtnInitialize = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LblTotalKmTravel = New System.Windows.Forms.Label()
        Me.LblTotalDays = New System.Windows.Forms.Label()
        Me.LblTotalReimburseAmount = New System.Windows.Forms.Label()
        Me.LblTotalFlatRateKms = New System.Windows.Forms.Label()
        Me.LblTotalFlatRateDays = New System.Windows.Forms.Label()
        Me.LblTotalFlatRateAmount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter KM's Traveled"
        '
        'LBoxKms
        '
        Me.LBoxKms.FormattingEnabled = True
        Me.LBoxKms.Location = New System.Drawing.Point(36, 83)
        Me.LBoxKms.Name = "LBoxKms"
        Me.LBoxKms.Size = New System.Drawing.Size(120, 173)
        Me.LBoxKms.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 285)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "KM"
        '
        'TbKm
        '
        Me.TbKm.Location = New System.Drawing.Point(36, 313)
        Me.TbKm.Name = "TbKm"
        Me.TbKm.Size = New System.Drawing.Size(64, 20)
        Me.TbKm.TabIndex = 3
        '
        'BtnAddKms
        '
        Me.BtnAddKms.Location = New System.Drawing.Point(39, 388)
        Me.BtnAddKms.Name = "BtnAddKms"
        Me.BtnAddKms.Size = New System.Drawing.Size(97, 23)
        Me.BtnAddKms.TabIndex = 4
        Me.BtnAddKms.Text = "Add Daily KM"
        Me.BtnAddKms.UseVisualStyleBackColor = True
        '
        'BtnInitialize
        '
        Me.BtnInitialize.Location = New System.Drawing.Point(39, 452)
        Me.BtnInitialize.Name = "BtnInitialize"
        Me.BtnInitialize.Size = New System.Drawing.Size(97, 23)
        Me.BtnInitialize.TabIndex = 5
        Me.BtnInitialize.Text = "Initialize"
        Me.BtnInitialize.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(233, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total KM's Travelled"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(233, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Total Days"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(233, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(191, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Total Reimbursement Amount ($)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(233, 273)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(180, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Total Flat Rate KM's Travelled"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(233, 331)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Total Flat Rate Days"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(233, 388)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(157, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Total Flat Rate Amount ($)"
        '
        'LblTotalKmTravel
        '
        Me.LblTotalKmTravel.AutoSize = True
        Me.LblTotalKmTravel.Location = New System.Drawing.Point(236, 111)
        Me.LblTotalKmTravel.Name = "LblTotalKmTravel"
        Me.LblTotalKmTravel.Size = New System.Drawing.Size(39, 13)
        Me.LblTotalKmTravel.TabIndex = 12
        Me.LblTotalKmTravel.Text = "Label9"
        '
        'LblTotalDays
        '
        Me.LblTotalDays.AutoSize = True
        Me.LblTotalDays.Location = New System.Drawing.Point(239, 176)
        Me.LblTotalDays.Name = "LblTotalDays"
        Me.LblTotalDays.Size = New System.Drawing.Size(45, 13)
        Me.LblTotalDays.TabIndex = 13
        Me.LblTotalDays.Text = "Label10"
        '
        'LblTotalReimburseAmount
        '
        Me.LblTotalReimburseAmount.AutoSize = True
        Me.LblTotalReimburseAmount.Location = New System.Drawing.Point(242, 242)
        Me.LblTotalReimburseAmount.Name = "LblTotalReimburseAmount"
        Me.LblTotalReimburseAmount.Size = New System.Drawing.Size(45, 13)
        Me.LblTotalReimburseAmount.TabIndex = 14
        Me.LblTotalReimburseAmount.Text = "Label11"
        '
        'LblTotalFlatRateKms
        '
        Me.LblTotalFlatRateKms.AutoSize = True
        Me.LblTotalFlatRateKms.Location = New System.Drawing.Point(245, 300)
        Me.LblTotalFlatRateKms.Name = "LblTotalFlatRateKms"
        Me.LblTotalFlatRateKms.Size = New System.Drawing.Size(45, 13)
        Me.LblTotalFlatRateKms.TabIndex = 15
        Me.LblTotalFlatRateKms.Text = "Label12"
        '
        'LblTotalFlatRateDays
        '
        Me.LblTotalFlatRateDays.AutoSize = True
        Me.LblTotalFlatRateDays.Location = New System.Drawing.Point(248, 359)
        Me.LblTotalFlatRateDays.Name = "LblTotalFlatRateDays"
        Me.LblTotalFlatRateDays.Size = New System.Drawing.Size(45, 13)
        Me.LblTotalFlatRateDays.TabIndex = 16
        Me.LblTotalFlatRateDays.Text = "Label13"
        '
        'LblTotalFlatRateAmount
        '
        Me.LblTotalFlatRateAmount.AutoSize = True
        Me.LblTotalFlatRateAmount.Location = New System.Drawing.Point(248, 414)
        Me.LblTotalFlatRateAmount.Name = "LblTotalFlatRateAmount"
        Me.LblTotalFlatRateAmount.Size = New System.Drawing.Size(45, 13)
        Me.LblTotalFlatRateAmount.TabIndex = 17
        Me.LblTotalFlatRateAmount.Text = "Label14"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 531)
        Me.Controls.Add(Me.LblTotalFlatRateAmount)
        Me.Controls.Add(Me.LblTotalFlatRateDays)
        Me.Controls.Add(Me.LblTotalFlatRateKms)
        Me.Controls.Add(Me.LblTotalReimburseAmount)
        Me.Controls.Add(Me.LblTotalDays)
        Me.Controls.Add(Me.LblTotalKmTravel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnInitialize)
        Me.Controls.Add(Me.BtnAddKms)
        Me.Controls.Add(Me.TbKm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LBoxKms)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LBoxKms As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TbKm As TextBox
    Friend WithEvents BtnAddKms As Button
    Friend WithEvents BtnInitialize As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LblTotalKmTravel As Label
    Friend WithEvents LblTotalDays As Label
    Friend WithEvents LblTotalReimburseAmount As Label
    Friend WithEvents LblTotalFlatRateKms As Label
    Friend WithEvents LblTotalFlatRateDays As Label
    Friend WithEvents LblTotalFlatRateAmount As Label
End Class
