<img id="item-image" data-bind="attr:{src: imagePath}" src="@Html.DisplayFor(model => model.ImageUrL)"style="max-height:100%; max-width:100%" />

<div>
@Html.EditorFor(model => model.ImageUrL, new { htmlAttributes = new { @class = "form-control", data_bind = "textInput: imagePath" } })
</div>


<span class="item-retail-price" data-bind="text: createRetail">@Html.DisplayFor(model => model.RetailPrice)</span>

<div>
@Html.EditorFor(model => model.RetailPrice, new { htmlAttributes = new { @class = "form-control", data_bind = "textInput: createRetail" } })
</div>

<div>
@Html.EditorFor(model => model.SalePrice, new { htmlAttributes = new { @class = "form-control", data_bind = "textInput: createSalePrice" } })
</div>

@Html.EditorFor(model => model.SalePrice, new { htmlAttributes = new { @class = "form-control", data_bind = "textInput: createSalePrice" } })
