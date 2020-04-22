@ModelType AdventureWorks.ViewModelLayer.CustomerViewModel
@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
    ViewBag.Title = "Customer Detail"
End Code

<div class="row">
    <div class="col-sm-3">FirstName</div>
    <div class="col-sm-9">@Model.Entity.FirstName</div>
</div>
<div class="row">
    <div class="col-sm-3">LastName</div>
    <div class="col-sm-9">@Model.Entity.LastName</div>
</div>