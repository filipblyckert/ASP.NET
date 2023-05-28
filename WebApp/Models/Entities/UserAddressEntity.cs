﻿using Microsoft.EntityFrameworkCore;
using WebApp.Models.Identity;

namespace WebApp.Models.Entities
{
    [PrimaryKey(nameof(UserId), nameof(AddressId))]    
    public class UserAddressEntity
    {
        public int UserId { get; set; } 
        public AppUser User { get; set; } = null!;
        public int AddressId { get; set; }
        public AddressEntity Address { get; set; } = null!;
    }
}
