Imports AdventureWorks.ViewModelLayer

Public Class CustomerControl

    Public _viewModel As CustomerViewModel

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ' Here we assign view model to the instance of already loaded
        ' CustomerViewModel class so that we can get the data from already
        ' loaded customers collection
        _viewModel = DirectCast(Me.Resources("viewModel"), CustomerViewModel)

    End Sub

    Private Sub UserControl_Loaded(sender As Object, e As RoutedEventArgs)
        _viewModel.LoadCustomer(1)
    End Sub
End Class
