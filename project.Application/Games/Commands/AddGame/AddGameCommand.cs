
using project.Application.Interfaces;
using System;

namespace project.Application.Games
{
    public class AddGameCommand : ICommand
    {
        public int FieldId { get; }
        public string GameDateTime { get; }
        public int GameDuration { get; }
        public float Price { get; }
        public string Discipline { get; }
        public int SlotsCount { get; }
        public int AuthorId { get; }


        public AddGameCommand(int fieldId, string gameDateTime, int gameDuration, float price, string discipline, int slotsCount, int authorId)
        {
            FieldId = fieldId;
            GameDateTime = gameDateTime;
            GameDuration = gameDuration;
            Price = price;
            Discipline = discipline;
            SlotsCount = slotsCount;
            AuthorId = authorId;
        }
    }
}
