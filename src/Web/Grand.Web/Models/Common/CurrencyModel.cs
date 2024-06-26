﻿using Grand.Infrastructure.Models;

namespace Grand.Web.Models.Common;

public class CurrencyModel : BaseEntityModel
{
    public string Name { get; set; }

    public string CurrencySymbol { get; set; }
    public string CurrencyCode { get; set; }
}