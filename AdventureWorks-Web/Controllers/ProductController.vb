Imports System.Web.Mvc
Imports AdventureWorks.ViewModelLayer

Namespace Controllers
    Public Class ProductController
        Inherits Controller

        ' GET: Product
        Function ProductList() As ActionResult
            Dim vm As New ProductViewModel
            vm.LoadProducts(Server.MapPath("/"))
            Return View(vm)
        End Function

        Function ProductDetail(ByVal id As Integer) As ActionResult
            Dim vm As New ProductViewModel
            vm.LoadProduct(id, Server.MapPath("/"))
            Return View(vm)
        End Function
    End Class
End Namespace