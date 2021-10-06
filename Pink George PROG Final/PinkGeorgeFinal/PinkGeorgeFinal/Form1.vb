'----------------------------------------------------------------------------
'Program Info
'----------------------------------------------------------------------------
'Program:KM Reimbursement
'Date:2020-12-09
'Author:George Pink
'Operation: This program allows employee to enter kms they travel for business trips to record how much will be reimbursed to the employee. The initilaize button is clearing data and upon boot it is cleared,
'           The Add button add's the trip as well as beings tabulation on all of the 6 fields it displays. We use modular programming which contains, many functions, and sub procedures to make code clean 
'           and efficent for not only this version, but future versions as well.  
'-----------------------------------------------------------------------------
'Change Log
'-----------------------------------------------------------------------------
'Date                           Programmer                              Change
'2020-12-08                     George Pink                        Program Created
'2020-12-09                     George Pink                        Adding code comments
'2020-12-09                     George Pink                        Added Clear/Focus to TbKm textbox property for user functionality.
'-----------------------------------------------------------------------------
Public Class Form1
    'Variables defined. 1 constant variable, with the global array with assigned strings.
    Dim ErrorCode() As String = {"Please enter a valid number", "Driving backwards does not reduce km's sadly, please enter a positive number", "There is no km's to add, please enter at least one number"}
    Const KmCost As Decimal = 0.55

    'Add Button calling on Error Check Function to add data. If input is true then we add data here. Calls all functions and calculates accordingly.
    Private Sub BtnAddKms_Click(sender As Object, e As EventArgs) Handles BtnAddKms.Click
        If errorcheck() = True Then
            LBoxKms.Items.Add(TbKm.Text)
            TbKm.Clear()
            TbKm.Focus()
            'Our label calculation values called from their appropriate functions
            LblTotalKmTravel.Text = CalculateTotalKmsTravelled()
            LblTotalDays.Text = CalculateTotalDays()
            LblTotalReimburseAmount.Text = "$" & CalculateTotalReimburseAmount()
            LblTotalFlatRateKms.Text = CalculateTotalFlatRateKmTravelled()
            LblTotalFlatRateDays.Text = CalculateTotalFlatRateDays()
            LblTotalFlatRateAmount.Text = "$" & CalculateTotalFlatRateAmount()
        End If
    End Sub
    'Function calculates Total Flat Rate Amount utilizing For Loop to count everytime a value is greater than 300KM and increasing by 150 dollars per counter
    Private Function CalculateTotalFlatRateAmount() As Decimal
        Dim TotalFlatRateAmount As Decimal
        For counter = 0 To LBoxKms.Items.Count - 1
            If LBoxKms.Items(counter) > 300 Then
                TotalFlatRateAmount += 150
            End If
        Next
        Return TotalFlatRateAmount
    End Function
    'Function calculates Total Flat Rate Days utilizing For Loop to count everytime a value is greater than 300KM and increasing by 1 per counter
    Private Function CalculateTotalFlatRateDays() As Integer
        Dim TotalFlatRateDays As Integer
        For counter = 0 To LBoxKms.Items.Count - 1
            If LBoxKms.Items(counter) > 300 Then
                TotalFlatRateDays += 1
            End If
        Next
        Return TotalFlatRateDays
    End Function
    'Function calculates Total Flat Rate KM Travelled utilizing For Loop to count everytime any value in list box is greater than 300 it will be counted and added in the appropriate label.
    Private Function CalculateTotalFlatRateKmTravelled() As Integer
        Dim SumFlatKms As Integer = 0
        For counter = 0 To LBoxKms.Items.Count - 1
            If LBoxKms.Items(counter) > 300 Then
                SumFlatKms += LBoxKms.Items(counter)
            End If
        Next
        Return SumFlatKms
    End Function
    'Function calculates Total Reimbursement Amount utilizing For Loop to give a grand total of all KM's. If statement adjusts values over 300 to flat rate of 150 while other values are calculated by KMCost.
    Private Function CalculateTotalReimburseAmount() As Decimal
        Dim GrandTotal As Decimal = 0
        For counter = 0 To LBoxKms.Items.Count - 1
            If LBoxKms.Items(counter) > 300 Then
                GrandTotal += 150
            Else
                GrandTotal += (LBoxKms.Items(counter) * KmCost)
            End If
        Next
        Return GrandTotal
    End Function
    'Function calculates Total Days by simply returning the count in the listbox. 
    Private Function CalculateTotalDays() As Integer
        Return LBoxKms.Items.Count
    End Function
    'Function calculates Total KM Travelled utilzing a For Loop. Each item entered into listbox is counted and assigned via SUMKM and equal to the toal of items in listbox.
    Private Function CalculateTotalKmsTravelled() As Integer
        Dim SumKM As Integer = 0
        For counter = 0 To LBoxKms.Items.Count - 1
            SumKM += LBoxKms.Items(counter)
        Next
        Return SumKM
    End Function

    'Clear button 
    Private Sub BtnInitialize_Click(sender As Object, e As EventArgs) Handles BtnInitialize.Click
        Call ClearState()
    End Sub

    'Sub Procedure that is utilized for the error check function to call upon to display the proper error message.
    Sub ShowErrorInMsgBox(ErrorId As Integer)
        MsgBox(ErrorCode(ErrorId))
    End Sub

    'Function performing 3 error checks and displaying message as it is called from the sub procedure.
    Function errorcheck() As Boolean
        'Checking the textbox for no input at all.
        If TbKm.Text = "" Then
            ShowErrorInMsgBox(2)
            Return False

            'Checking for our textbox input is a number
        ElseIf Not IsNumeric(TbKm.Text) Then
            ShowErrorInMsgBox(0)
            Return False

            'Checking to see if the number entered is 0 or less.
        ElseIf TbKm.Text <= 0 Then
            ShowErrorInMsgBox(1)
            Return False
        Else
            'If all checks pass, errorcheck becomes true which is called on the Add sub where we then add the value to the listbox.
            Return True
        End If
    End Function

    'Sub procedure that ensure that on load it calls our initialize sub procedure to clear all fields.
    Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearState()
    End Sub

    'Sub clears all input fields within application.
    Sub ClearState()
        TbKm.Text = ""
        LBoxKms.Items.Clear()
        LblTotalKmTravel.Text = ""
        LblTotalDays.Text = ""
        LblTotalReimburseAmount.Text = ""
        LblTotalFlatRateKms.Text = ""
        LblTotalFlatRateDays.Text = ""
        LblTotalFlatRateAmount.Text = ""
    End Sub
End Class