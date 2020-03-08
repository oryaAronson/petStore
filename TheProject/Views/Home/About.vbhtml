@Code
    ViewData("Title") = "About"
End Code

<style>
    img {
        height: 100px;
    }
</style>
<table class="table">
    <thead>
        <tr>
            <td</td>
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
                @item.Email
            </td>
            <td>
                @item.Age
            </td>
        </tr>

    Next
</table>