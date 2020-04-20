﻿Class MainWindow
    Private Sub CustomerDetail_Click(sender As Object, e As RoutedEventArgs)
        contentArea.Children.Clear()
        contentArea.Children.Add(New CustomerControl())
    End Sub

    Private Sub ProductDetail_Click(sender As Object, e As RoutedEventArgs)
        contentArea.Children.Clear()
        contentArea.Children.Add(New ProductControl())

    End Sub

    Private Sub Exit_Click(sender As Object, e As RoutedEventArgs)
        Me.Close()
    End Sub

    Private Sub CustomerList_Click(sender As Object, e As RoutedEventArgs)
        contentArea.Children.Clear()
        contentArea.Children.Add(New CustomerListControl())
    End Sub

    Private Sub ProductList_Click(sender As Object, e As RoutedEventArgs)
        contentArea.Children.Clear()
        contentArea.Children.Add(New ProductListControl())
    End Sub
End Class
