﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Raisins.Client.Web.Models;

namespace Raisins.Client.Web.Migrations
{
    public class BeneficiarySeed : IDbSeeder
    {
        public void Seed(Models.RaisinsDB context)
        {
            if (!context.Beneficiaries.Any(b => b.Name == "MONSTROU"))
            {
                Beneficiary.Add(new Beneficiary()
                {
                    Name = "MONSTROU",
                    Description = "Reservations"
                });
            }
        }
    }
}