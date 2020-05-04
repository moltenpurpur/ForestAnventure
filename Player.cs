﻿﻿using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace ConsoleApp1
{
    public class Player
    {
        public Point Location;
        public List<Creature> DreamTeam;

        public Player()
        {
            Location = new Point {X = 0, Y = 0};
            DreamTeam = new List<Creature>
            {
                (new Creature(CreatureOwner.Human, CreatureName.Elf, 350, 50, 15, 75)),
                (new Creature(CreatureOwner.Human, CreatureName.LittleCat, 666, 0, 50, 0)),
                (new Creature(CreatureOwner.Human, CreatureName.Raccoon, 100, 100, 0, 100)),
                (new Creature(CreatureOwner.Human, CreatureName.Rabbit, 450, 40, 35, 50))
            };
        }
    }

}