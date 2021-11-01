@ModelType IEnumerable(Of LearnVbNetMVC.Student)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.StudentName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Age)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.StudentId}) |
            @Html.ActionLink("Details", "Details", New With {.id = item.StudentId}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.StudentId})
        </td>
</tr>
Next

</table>
