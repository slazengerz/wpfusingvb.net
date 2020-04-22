Imports System.Collections.ObjectModel
Imports System.Configuration
Imports AdventureWorks.EntityLayer

Public Class CustomerManager
    Inherits DataManagerBase

    Function LoadCustomers() As ObservableCollection(Of Customer)

        Return LoadCustomers(Nothing)
    End Function


    Function LoadCustomers(ByVal CustomerFilePath As String) As ObservableCollection(Of Customer)

        Dim doc = MyBase.LoadXElement(ConfigurationManager.AppSettings("CustomerFile"), CustomerFilePath)

        Dim customer = From cust In doc.<Customer>
                       Select New Customer With {
                           .CustomerID = Convert.ToInt32(cust.Element("CustomerID").Value),
                            .FirstName = cust.Element("FirstName").Value,
                            .LastName = cust.Element("LastName").Value,
                            .CompanyName = cust.Element("CompanyName").Value
                           }
        Return New ObservableCollection(Of Customer)(customer.toList())
    End Function

End Class
