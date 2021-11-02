Imports System.Web.Mvc

Namespace Controllers
    Public Class StudentController
        Inherits Controller
        Private db As StudentDBEntities = New StudentDBEntities()


        ' GET: Student
        Function Index() As ActionResult
            Return View(db.Students.OrderBy(Function(s) s.studentName).ToList())
        End Function

        Function Edit(ByVal id As Integer) As ActionResult
            Dim std = db.Students.Where(Function(s) s.studentID = id).FirstOrDefault()

            Return View(std)
        End Function


        <HttpPost>
        Function Edit(ByVal std As Student) As ActionResult

            'Edit data
            Dim student = db.Students.Where(Function(s) s.studentID = std.studentID).First()
            student.studentID = std.studentID
            student.studentName = std.studentName
            student.age = std.age
            student.standardID = std.standardID
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

    End Class
End Namespace