@ModelType IEnumerable(Of lastlogin.user)

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    <p>
        @Html.ActionLink("Create New", "Create")
    </p>
    <table class="table">
        <tr>
            <th>
                @Html.DisplayNameFor(Function(model) model.username)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.password)
            </th>
            <th></th>
        </tr>
    
    @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.username)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.password)
            </td>
            <td>
                @Html.ActionLink("Edit", "Edit", New With {.id = item.userid }) |
                @Html.ActionLink("Details", "Details", New With {.id = item.userid }) |
                @Html.ActionLink("Delete", "Delete", New With {.id = item.userid })
            </td>
        </tr>
    Next
    
    </table>
</body>
</html>
