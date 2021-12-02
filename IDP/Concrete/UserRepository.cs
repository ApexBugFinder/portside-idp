using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IDP.Models;
using IDP.Data;
using IDP.Abstract;
using Microsoft.EntityFrameworkCore;

namespace IDP.Concrete
{
  public class UserRepository : IUserRepository
  {
    private readonly ApplicationDbContext _context;

    public UserRepository(ApplicationDbContext context)
    {
      _context = context;
    }
  }
}
