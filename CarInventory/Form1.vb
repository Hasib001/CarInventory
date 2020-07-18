Option Strict On

Public Class CarInventory
#Region "Variable & constant"

    Dim cars As New List(Of Car)
    Dim editMode As Boolean = False
    Dim updatingData As Boolean = False
    Dim currentlySelectedIndex As Integer = -1




#End Region

#Region "event handlers"
    ''' <summary>
    ''' executes when user presses exit button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()

    End Sub

    ''' <summary>
    ''' executes when user presses reset button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click


        ResetForm()

    End Sub
    ''' <summary>
    ''' executes when user presses enter button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim inputMake As String = cbMake.Text
        Dim inputModel As String = tbModel.Text
        Dim inputYear As String = cbYear.Text
        Dim inputPrice As String = tbPrice.Text
        Dim inputNewStatus As Boolean = ckNewStatus.Checked

        Dim errors = ValidateInputs(inputMake, inputModel, inputYear, inputPrice)
        Dim car As Car

        If (String.IsNullOrEmpty(errors)) Then
            If (editMode) Then
                cars(currentlySelectedIndex).CarMake = inputMake
                cars(currentlySelectedIndex).CarModel = inputModel
                cars(currentlySelectedIndex).CarYear = Convert.ToInt32(inputYear)
                cars(currentlySelectedIndex).CarPrice = Convert.ToDecimal(inputPrice)
                cars(currentlySelectedIndex).CarNewStatus = inputNewStatus
                UpdateCarList()
                ResetForm()
                tbOutput.Text = "Reset Form"

            Else
                car = New Car(inputMake, inputModel, inputYear, inputPrice, inputNewStatus)
                cars.Add(car)
                ResetForm()
                tbOutput.Text = "Added new student"
                UpdateCarList()

            End If
        End If



    End Sub





#End Region

#Region "Subs and Function"
    Function ValidateInputs(make As String, model As String, year As String, price As String) As String
        Dim errorMessage As String = String.Empty

        Dim decimalPrice As Decimal

        If (String.IsNullOrEmpty(make)) Then
            errorMessage += "Please  select a valid make " & Environment.NewLine
        End If
        If (String.IsNullOrEmpty(model)) Then
            errorMessage += "Please Enter a valid model" & Environment.NewLine
        End If
        If (String.IsNullOrEmpty(year)) Then
            errorMessage += "Please select a valid year" & Environment.NewLine
        End If
        If (Decimal.TryParse(year, decimalPrice)) Then
            errorMessage += "Please Enter a valid price " & Environment.NewLine
        End If

        Return errorMessage



    End Function


    Private Sub UpdateCarList()
        Dim carListItem As ListViewItem
        updatingData = True
        lvCarList.Items.Clear()

        For Each car As Car In cars
            carListItem = New ListViewItem()

            carListItem.Checked = car.CarNewStatus
            carListItem.SubItems.Add(car.CarMake)
            carListItem.SubItems.Add(car.CarModel)
            carListItem.SubItems.Add(car.CarYear.ToString)
            carListItem.SubItems.Add(car.CarPrice.ToString)

            lvCarList.Items.Add(carListItem)



        Next
        updatingData = False

    End Sub

    Private Sub ResetForm()
        lvCarList.SelectedIndices.Clear()
        cbMake.SelectedIndex = -1
        tbModel.Text = String.Empty
        cbMake.SelectedIndex = -1
        ckNewStatus.Checked = False
        editMode = False
        tbOutput.Text = "Reset Form"


    End Sub

#End Region



End Class
