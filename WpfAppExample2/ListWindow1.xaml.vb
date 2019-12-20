Imports System.Collections.ObjectModel
Imports System.Text.RegularExpressions
Imports WpfAppExample2.Classes

Class MainWindow

    Public Property TaskItemsList() As ObservableCollection(Of TaskItem)

    Public Sub New()
        InitializeComponent()

        Dim taskOperations = New Tasks()
        TaskItemsList = taskOperations.List()

        DataContext = Me
    End Sub
    ''' <summary> 
    ''' Ensure only int values are entered.
    ''' A robust alternate is using Data Annotations  
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NumberValidation(ByVal sender As Object, ByVal e As TextCompositionEventArgs)
        Dim regex = New Regex("[^0-9]+")
        e.Handled = regex.IsMatch(e.Text)
    End Sub
End Class
