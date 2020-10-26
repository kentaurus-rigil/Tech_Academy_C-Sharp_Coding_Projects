Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        String Text = "Hello"
        System.IO.File.WriteAllText(@"C:\Users\guesttta\Documents\GitHub\Tech_Academy_C-Sharp_Coding_Projects\Mvc.txt", Text);
        Return View()

    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
End Class
