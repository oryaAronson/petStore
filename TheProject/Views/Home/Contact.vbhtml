@ModelType IEnumerable(Of TheProject.Pet)
@Code
    ViewData("Title") = "Contact"
End Code
    <link href="~/Content/Home/home.css" rel="stylesheet" />


    <style>
        img{
            height: 100px;
        }
    </style>
    <p>
        @Html.ActionLink("Create New", "Create")
    </p>
    <form>
        <div class="form-group">
            <label for="exampleInputEmail1">Email address</label>
            <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp">
            <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
        </div>
        <div class="form-group">
            <label for="exampleInputPassword1">Password</label>
            <input type="password" class="form-control" id="exampleInputPassword1">
        </div>
        <div class="form-group form-check">
            <input type="checkbox" class="form-check-input" id="exampleCheck1">
            <label class="form-check-label" for="exampleCheck1">Check me out</label>
        </div>
        <button type="submit" id="submit" class="btn btn-primary search" >Submit</button>
    </form>
    <table class="table">
        <thead>
            <tr>
                <td></td>
                <td>ID</td>
                <td>Price</td>
                <td>Image</td>
            </tr>
        </thead>
        @For Each item In Model

            @<tr>
                <td>
                    @item.Name
                </td>
                <td>
                    @item.Id
                </td>
                <td>
                    @item.Price
                </td>
                <td>
                    <img src="@item.Image" />
                </td>
                <td>
                    @Html.ActionLink("Edit", "Edit", New With {.id = item.Id}) |
                    @Html.ActionLink("Delete", "Delete", New With {.id = item.Id})
                </td>
            </tr>

        Next
    </table>