using MagicVilla.Models;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla.Controllers;

[ApiController]
public class VillaAPIController : Controller
{
    public IEnumerable<Villa> GetVillas()
    {
        return new List<Villa>
        {
            new Villa { Id = 1, Name = "Pool View" },
            new Villa { Id = 2, Name = "Beach view" }
        };
    }
}