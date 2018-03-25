<script src="~/Scripts/knockout-3.4.2.js"></script>
<script>
    var vm =
    {
        createDescription: ko.observable(),
        createRetail: ko.observable(),
        createSalePrice: ko.observable(),
        createDiscount: ko.observable(),
        imagePath: ko.observable("http://cdn3-www.dogtime.com/assets/uploads/gallery/30-impossibly-cute-puppies/thumbs/thumbs_impossibly-cute-puppy-8.jpg")
    };
    ko.applyBindings(vm);
</script>
