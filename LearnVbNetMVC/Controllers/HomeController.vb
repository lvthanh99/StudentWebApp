﻿Public Class HomeController
    Inherits System.Web.Mvc.Controller

    <ActionName("Index")>
    <HttpGet>
    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ViewResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
End Class
