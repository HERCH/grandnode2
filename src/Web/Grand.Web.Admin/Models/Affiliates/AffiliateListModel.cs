﻿using Grand.Infrastructure.ModelBinding;
using Grand.Infrastructure.Models;
using System.ComponentModel.DataAnnotations;

namespace Grand.Web.Admin.Models.Affiliates;

public class AffiliateListModel : BaseModel
{
    [GrandResourceDisplayName("Admin.Affiliates.List.SearchFirstName")]

    public string SearchFirstName { get; set; }

    [GrandResourceDisplayName("Admin.Affiliates.List.SearchLastName")]

    public string SearchLastName { get; set; }

    [GrandResourceDisplayName("Admin.Affiliates.List.SearchFriendlyUrlName")]

    public string SearchFriendlyUrlName { get; set; }

    [GrandResourceDisplayName("Admin.Affiliates.List.LoadOnlyWithOrders")]
    public bool LoadOnlyWithOrders { get; set; }

    [GrandResourceDisplayName("Admin.Affiliates.List.OrdersCreatedFromUtc")]
    [UIHint("DateNullable")]
    public DateTime? OrdersCreatedFromUtc { get; set; }

    [GrandResourceDisplayName("Admin.Affiliates.List.OrdersCreatedToUtc")]
    [UIHint("DateNullable")]
    public DateTime? OrdersCreatedToUtc { get; set; }
}