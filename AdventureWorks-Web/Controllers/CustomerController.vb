Imports System.Web.Mvc
Imports AdventureWorks.ViewModelLayer

Namespace Controllers
    Public Class CustomerController
        Inherits Controller

        ' GET: Customer
        Function CustomerList() As ActionResult
            Dim vm As New CustomerViewModel
            vm.LoadCustomers(Server.MapPath("/"))
            Return View(vm)
        End Function

        Function CustomerDetail(ByVal id As Integer) As ActionResult
            Dim vm As New CustomerViewModel
            vm.LoadCustomer(id, Server.MapPath("/"))
            Return View(vm)
        End Function
    End Class
End Namespace