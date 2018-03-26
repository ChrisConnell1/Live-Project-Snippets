        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BuyerId,FirstName,LastName,PhoneNumber,Email")] Buyer buyer)
        {
            buyer.JoinDate = DateTime.Now.ToLocalTime();
            try
            {
                if (ModelState.IsValid)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again and if the problem continues, contact your System Administrator.");
              
              ....
              
              return View(buyer);
