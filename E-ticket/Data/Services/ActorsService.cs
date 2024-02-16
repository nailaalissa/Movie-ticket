using System.Collections.Generic;
using E_ticket.Data;
using E_ticket.Data.Base;
using E_ticket.Models;
using Microsoft.EntityFrameworkCore;

namespace E_ticket.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>,IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }
    }
}
