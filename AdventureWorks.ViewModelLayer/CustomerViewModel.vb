Imports System.Collections.ObjectModel
Imports AdventureWorks.DataLayer
Imports AdventureWorks.EntityLayer
Imports CommonLibrary

Public Class CustomerViewModel
    Inherits CommonBase

    Public Property Entity As Customer
    Public Property Customers As ObservableCollection(Of Customer)

    Sub New()
        LoadCustomers(Nothing)
    End Sub

    Function LoadCustomers(ByVal filePath As String) As ObservableCollection(Of Customer)
        Try
            Dim custMgr = New CustomerManager
            Customers = custMgr.LoadCustomers(filePath)
        Catch e As Exception
            System.Diagnostics.Debug.WriteLine(e.ToString())
        End Try
        Return Customers
    End Function

    Function LoadCustomer(ByVal custID As Integer) As Customer
        Return LoadCustomer(custID, Nothing)
    End Function

    Function LoadCustomer(ByVal custID As Integer, ByVal startingFilePath As String) As Customer
        Dim custMgr = New CustomerManager
        Customers = custMgr.LoadCustomers(startingFilePath)
        Entity = Customers.ToList().FirstOrDefault(Function(c) c.CustomerID = custID)
        RaisePropertyChanged("Entity")
        Return Entity
    End Function
End Class
