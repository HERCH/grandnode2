﻿using Grand.Infrastructure.Models;

namespace Grand.Web.Models.Customer;

public class SubAccountSimpleModel : BaseEntityModel
{
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public bool Active { get; set; }
}