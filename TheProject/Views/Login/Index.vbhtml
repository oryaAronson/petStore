﻿@ModelType TheProject.UserVM

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
        <h4>UserVM</h4>
    <h1>@ViewBag.Error</h1>
        <hr />
        @Html.ValidationSummary(True, "", New With { .class = "text-danger" })
        @Html.HiddenFor(Function(model) model.ID)

     <div class="form-group">
         @Html.LabelFor(Function(model) model.Name, htmlAttributes:=New With {.class = "control-label col-md-2"})
         <div class="col-md-10">
             @Html.EditorFor(Function(model) model.Name, New With {.htmlAttributes = New With {.class = "form-control"}})
             @Html.ValidationMessageFor(Function(model) model.Name, "", New With {.class = "text-danger"})
         </div>

         @Html.LabelFor(Function(model) model.Age, htmlAttributes:=New With {.class = "control-label col-md-2"})
         <div class="col-md-10">
             @Html.EditorFor(Function(model) model.Age, New With {.htmlAttributes = New With {.class = "form-control"}})
             @Html.ValidationMessageFor(Function(model) model.Age, "", New With {.class = "text-danger"})
         </div>

         @Html.LabelFor(Function(model) model.Email, htmlAttributes:=New With {.class = "control-label col-md-2"})
         <div class="col-md-10">
             @Html.EditorFor(Function(model) model.Email, New With {.htmlAttributes = New With {.class = "form-control"}})
             @Html.ValidationMessageFor(Function(model) model.Email, "", New With {.class = "text-danger"})
         </div>

     </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Save" class="btn btn-default" />
            </div>
        </div>
    </div>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>
