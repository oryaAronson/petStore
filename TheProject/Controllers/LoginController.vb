Imports System.Web.Mvc

Namespace Controllers
    Public Class LoginController
        Inherits Controller

        ' GET: Login
        Function Index() As ActionResult
            Return View()
        End Function

        <HttpPost>
        Function Index(collection As FormCollection) As ActionResult
            Try
                Dim user = New UserVM(collection)
                Dim tempUser = SessionManager.Users.Find(Function(u) u.Email = user.Email)
                SessionManager.User = tempUser
                If SessionManager.IsConnect Then
                    Return RedirectToAction("Index", "Home")

                End If
                ViewBag.Error = "Email or Password is incurrect"
                Return View("Index")
            Catch
                Return View("Index")
            End Try
        End Function
    End Class

    

End Namespace