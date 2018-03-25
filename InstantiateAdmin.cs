            //Check to see if there exists a default "admin" already
            
            if (!context.Users.Any(o => o.UserName == "admin"))
            {
                //Instantiate a default admin user, add it to role Admin
                
                var user = new ApplicationUser { UserName = "admin", JoinDate = DateTime.Today };
                userManager.Create(user);
                userManager.AddToRole(user.Id, "Admin");
            }
