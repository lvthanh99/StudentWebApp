Imports System.Web.Mvc

Namespace Controllers
    Public Class StudentController
        Inherits Controller


        ' GET: Student
        Function Index() As ActionResult
            Return View(studentList.OrderBy(Function(s) s.StudentName).ToList())
        End Function

        Function Edit(ByVal id As Integer) As ActionResult
            Dim std = studentList.Where(Function(item) item.StudentId = id).FirstOrDefault()

            Return View(std)
        End Function


        <HttpPost>
        Function Edit(ByVal std As Student) As ActionResult

            'Edit data
            Dim student = studentList.Where(Function(item) item.StudentId = std.StudentId).FirstOrDefault()
            studentList.Remove(student)
            studentList.Add(std)

            Return RedirectToAction("Index")
        End Function
        Private studentList As IList(Of Student) = New List(Of Student)() From {
            New Student() With {.StudentId = 1, .StudentName = "Thanh", .Age = 15},
            New Student() With {.StudentId = 2, .StudentName = "Hoang", .Age = 15},
            New Student() With {.StudentId = 3, .StudentName = "Trang", .Age = 15},
            New Student() With {.StudentId = 4, .StudentName = "Phong", .Age = 15},
            New Student() With {.StudentId = 5, .StudentName = "Hoa", .Age = 15}
            }
    End Class
End Namespace