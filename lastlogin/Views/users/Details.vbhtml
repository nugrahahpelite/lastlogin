@ModelType lastlogin.user

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Details</title>
</head>
<body>
    <div>
        <h4>user</h4>
        <hr />
        <dl class="dl-horizontal">
            <dt>
                @Html.DisplayNameFor(Function(model) model.username)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.username)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.password)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.password)
            </dd>
    
        </dl>
    </div>
    <p>
        @Html.ActionLink("Edit", "Edit", New With { .id = Model.userid }) |
        @Html.ActionLink("Back to List", "Index")
    </p>
</body>
</html>
