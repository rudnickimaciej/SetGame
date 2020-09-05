using Domain.Models;
using Microsoft.EntityFrameworkCore;
using project.Application.Interfaces;
using project.Persistance;
using System;
using System.Linq;

namespace TestingConsole
{

    //_context.Players.Find(3) - jeśli chcesz wyszukać obiekt po Id to jest do tego oddzielna,specjalnie zoptymalizowana
    // do wsyzukiwania po kluczu id metoda - Find(int). Jeśli obiekt o tym id jest już w cachu to jego zwrócenie będzie natychmaistowe

    class Program
    {
        static void Main(string[] args)
        {
          
            //IDatabaseService _context = new DatabaseService();
            //var players = _context.Players.FirstOrDefault(p => EF.Functions.Like(p.Name, "%Piotrek%"));


            int i = 0;

        }
    }
}
