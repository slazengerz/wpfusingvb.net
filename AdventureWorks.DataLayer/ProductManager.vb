Imports System.Collections.ObjectModel
Imports AdventureWorks.EntityLayer
Imports System.Configuration


Public Class ProductManager
    Inherits DataManagerBase

    Public Function LoadProducts(ByVal startingFilePath As String) As ObservableCollection(Of Product)

        Dim doc = MyBase.LoadXElement(ConfigurationManager.AppSettings("ProductsFile"), startingFilePath)

        Dim Products = From prod In doc.<Product>
                       Select New Product With {
                       .ProductID = Convert.ToInt32(prod.Element("ProductID").Value),
                       .Name = prod.Element("Name").Value,
                       .ProductNumber = prod.Element("ProductNumber").Value,
                       .Color = prod.Element("Color").Value,
                       .Size = prod.Element("Size").Value,
                       .Weight = Convert.ToDecimal(prod.Element("Weight").Value),
                       .StandardCost = Convert.ToDecimal(prod.Element("StandardCost").Value),
                       .ListPrice = Convert.ToDecimal(prod.Element("ListPrice").Value),
                       .SellStartDate = Convert.ToDateTime(prod.Element("SellStartDate").Value),
                       .SellEndDate = Convert.ToDateTime(prod.Element("SellEndDate").Value)
                       }


        Return New ObservableCollection(Of Product)(Products.ToList())
    End Function
End Class
