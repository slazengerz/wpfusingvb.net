Imports CommonLibrary
Imports AdventureWorks.EntityLayer
Imports System.Collections.ObjectModel
Imports System.Linq
Imports AdventureWorks.DataLayer
Public Class ProductViewModel
    Inherits CommonBase

    Public Property Entity As Product
    Public Property Products As ObservableCollection(Of Product)
    Sub New()
        LoadProducts()
    End Sub
    Sub LoadProducts()
        LoadProducts(Nothing)
    End Sub

    Function LoadProducts(ByVal startingFilePath As String) As ObservableCollection(Of Product)
        Try
            Dim prodMgr = New ProductManager
            Products = prodMgr.LoadProducts(startingFilePath)
        Catch e As Exception
            System.Diagnostics.Debug.WriteLine(e.ToString())
        End Try
        Return Products
    End Function

    Function LoadProduct(ByVal productId As Integer) As Product
        Return LoadProduct(productId, Nothing)
    End Function

    Public Function LoadProduct(ByVal productId As Integer, ByVal startingFilePath As String) As Product
        Dim prodMgr = New ProductManager
        Products = prodMgr.LoadProducts(startingFilePath)
        Entity = Products.ToList().FirstOrDefault(Function(p) p.ProductID = productId)
        RaisePropertyChanged("Entity")
        Return Entity
    End Function
End Class
