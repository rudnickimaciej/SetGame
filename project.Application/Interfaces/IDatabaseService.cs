using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace project.Application.Interfaces
{
    public interface IDatabaseService
    {
        DbSet<Player> Players { get; set; }
        DbSet<Game> Games { get; set; }
        void Save();
    }
}