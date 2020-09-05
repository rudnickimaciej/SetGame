using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace project.Application.Interfaces
{
   public interface IDbService
    {
        DbSet<Player> Players { get; set; }
        DbSet<Game> Games { get; set; }
        void Save();
    }
}
