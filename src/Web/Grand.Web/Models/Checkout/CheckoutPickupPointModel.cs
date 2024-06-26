﻿using Grand.Domain.Common;
using Grand.Infrastructure.Models;

namespace Grand.Web.Models.Checkout;

public class CheckoutPickupPointModel : BaseModel
{
    public string Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public Address Address { get; set; }

    public string PickupFee { get; set; }
}