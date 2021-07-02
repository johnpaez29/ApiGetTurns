using Microsoft.EntityFrameworkCore;
using ProcessTurnLogic.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ProcessTurnLogic.DataAccess
{
    public class ControlTurnContext : DbContext
    {
        public ControlTurnContext(DbContextOptions<ControlTurnContext> options)
        : base(options)
        {
        }
        public DbSet<Turno> Turnos { get; set; }

    }
}
