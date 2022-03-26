using FacadeDP.App.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDP.App.Concrete
{
    internal class GameFacade
    {
        IDisplayCard _displayCard;
        ICooler _cooler;

        public GameFacade(IDisplayCard displayCard, ICooler cooler)
        {
            _displayCard = displayCard;
            _cooler = cooler;
        }

        public void StartGame(string gameName)
        {
            _displayCard.Start();
            _cooler.Start();
            Console.WriteLine("Oyun Başlatıldı " + gameName);
        }
        public void StopGame(string gameName)
        {
            _displayCard.Stop();
            _cooler.Stop();
            Console.WriteLine("Oyun Kapatıldı " + gameName);
        }
    }
}
