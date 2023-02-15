﻿namespace PettyNails.Data
{
    public enum RoleType { User, Admin }
    public class User : IdentityUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public RoleType Role { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
