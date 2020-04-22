@ModelType AdventureWorks.ViewModelLayer.ProductViewModel
@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
    ViewBag.Title = "Products"
End Code

    <div class="row">
        <div class="col-sm-3">Product ID</div>
        <div class="col-sm-9">@Model.Entity.ProductID</div>
    </div>
<div class="row">
    <div class="col-sm-3">Product Number</div>
     <div class="col-sm-9">@Model.Entity.ProductNumber</div>
</div>