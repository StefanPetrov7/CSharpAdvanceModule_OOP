﻿using EasterRaces.Core.Contracts;
using EasterRaces.IO;
using EasterRaces.IO.Contracts;
using EasterRaces.Core.Entities;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Cars;

namespace EasterRaces
{
    public class StartUp
    {
        public static void Main()
        {

            IChampionshipController controller = new ChampionshipController();
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            IEngine enigne = new Engine(controller, reader, writer);
            enigne.Run();
        }
    }
}
