Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        If SessionManager.IsConnect Then Return View()
        Return RedirectToAction("INDEX", "Login")
    End Function

    Function About() As ActionResult
        If SessionManager.IsConnect Then
            If SessionManager.IsManager Then Return View(SessionManager.Users)

        End If
        Return RedirectToAction("INDEX", "Login")
    End Function

    Function Contact() As ActionResult

        If SessionManager.IsConnect() Then Return View(SessionManager.pets)
        Return RedirectToAction("INDEX", "Login")
    End Function
    Function Create() As ActionResult
        If SessionManager.IsConnect() Then Return View()
        Return RedirectToAction("INDEX", "Login")
    End Function

    <HttpPost>
    Function Create(collection As FormCollection) As ActionResult
        Try
            Dim pet = New Pet(collection)
            If SessionManager.IsConnect Then

                Dim pety = SessionManager.Pets.Find(Function(p) p.Id = pet.Id)
                If pety IsNot Nothing Then

                    ViewBag.Error = "the pet alredy exist"

                    Return View()
                End If
            End If
            SessionManager.Pets.Add(pet)
            Return RedirectToAction("contact")
        Catch
            Return View("contact", SessionManager.Pets)
        End Try
    End Function

End Class
