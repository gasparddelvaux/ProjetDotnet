using Microsoft.AspNetCore.Identity;
using System.Diagnostics;

namespace ProjetDotnet.Domain.Users;

public class User : IdentityUser
{
    public List<Task>? Tasks { get; set; }
}