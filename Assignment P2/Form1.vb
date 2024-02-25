Imports System.Runtime.CompilerServices

'Jaden Torres
'Assignment P4 for GUI
'Professor: Bruce Montgomery
'Class Name: Payroll Calculator
'This program allows an input gross pay. The program then calculates your FICA, Federal Tax, State Tax, and total Net Pay when processed.'
'Sources: https://learn.microsoft.com/en-us/dotnet/visual-basic/misc/bc30311?f1url=%3FappId%3Droslyn%26k%3Dk(BC30311), https://learn.microsoft.com/en-us/windows/apps/design/controls/number-box, and https://learn.microsoft.com/en-us/office/vba/language/reference/user-interface-help/msgbox-function'

Public Class Form1

    Dim strIncome As String 'input required variable to be captured'
    Dim decIncome As Decimal 'input required variable to be captured'
    Dim decFica As Decimal 'calculated decimal used as output FICA'
    Dim decFed As Decimal 'calculated decimal used as output Federal'
    Dim decState As Decimal 'calculated decimal used as output State'
    Dim decNet As Decimal 'calculated decimal used as output NetPay'
    Dim cdecFica As Decimal = 0.0765 'number used to multiply'
    Dim cdecFed As Decimal = 0.22 'number used to multiply'
    Dim cdecState As Decimal = 0.04 'number used to multiply'


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Compute(netpay As Decimal) 'I have made a compute sub class for the calculations in this program.'
        decState = Math.Round(netpay * cdecState, 2) 'Used math.round to round to nearest tenth'
        decFica = Math.Round(netpay * cdecFica, 2) 'Used math.round to round to nearest tenth'
        decFed = Math.Round(netpay * cdecFed, 2) 'Used math.round to round to nearest tenth'
        decNet = netpay - (decFica + decState + decFed) 'Following formula is used to calculate net pay'
    End Sub


    Public Sub ComputeBttn_Click(sender As Object, e As EventArgs) Handles ComputeBttn.Click 'This is what happens when the compute button is pressed'
        strIncome = Input.Text
        If Decimal.TryParse(strIncome, decIncome) = False Then 'Error handling in the mix'
            MsgBox("Error: Please input a whole number or decimal.") 'Pop up error window'
            Answer.ResetText() 'resetting box'
            FICA.ResetText() 'resetting box'
            FEDERAL.ResetText() 'resetting box'
            STATE.ResetText() 'resetting box'
            Exit Sub
        End If
        Compute(decIncome) 'Calling Compute'
        Stat_Output() 'Calling State_Output'

    End Sub

    Private Sub Stat_Output() 'Made a seperate sub class to send all computed numbers into a output window.'
        FICA.Text = decFica.ToString()
        FEDERAL.Text = decFed.ToString()
        STATE.Text = decState.ToString()
        Answer.Text = "$" + decNet.ToString()

    End Sub

    Private Sub ExitBttn_Click(sender As Object, e As EventArgs) Handles ExitBttn.Click 'This button when pressed closes the window'
        Close() 'Closes the program'
    End Sub

    Private Sub ClearBttn_Click(sender As Object, e As EventArgs) Handles ClearBttn.Click 'This button when pressed resets all calculations.' 
        Input.ResetText()
        Answer.ResetText()
        FICA.ResetText()
        FEDERAL.ResetText()
        STATE.ResetText()
    End Sub

    Private Sub FICA_Click(sender As Object, e As EventArgs) Handles FICALBL.Click

    End Sub
End Class
