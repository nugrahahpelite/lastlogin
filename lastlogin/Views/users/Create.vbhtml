﻿@ModelType lastlogin.user

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Create</title>
</head>
<body>
    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/jqueryval")
    @Using (Html.BeginForm()) 
        @Html.AntiForgeryToken()
        
        @<div class="form-horizontal">
            <h4>user</h4>
            <hr />
            @Html.ValidationSummary(True, "", New With { .class = "text-danger" })
            <div class="form-group">
                @Html.LabelFor(Function(model) model.username, htmlAttributes:= New With { .class = "control-label col-md-2" })
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.username, New With { .htmlAttributes = New With { .class = "form-control" } })
                    @Html.ValidationMessageFor(Function(model) model.username, "", New With { .class = "text-danger" })
                </div>
            </div>
    
            <div class="form-group">
                @Html.LabelFor(Function(model) model.password, htmlAttributes:= New With { .class = "control-label col-md-2" })
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.password, New With { .htmlAttributes = New With { .class = "form-control" } })
                    @Html.ValidationMessageFor(Function(model) model.password, "", New With { .class = "text-danger" })
                </div>
            </div>
    
            <div class="form-group">
                <div class="col-md-offset-2 col-md-10">
                    <input type="submit" value="Create" class="btn btn-default" />
                </div>
            </div>
        </div>
    End Using
    
    <div>
        @Html.ActionLink("Back to List", "Index")
    </div>
</body>
</html>
