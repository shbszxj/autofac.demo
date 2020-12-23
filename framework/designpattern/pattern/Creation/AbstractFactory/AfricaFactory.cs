﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Creation.AbstractFactory
{
    class AfricaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Zebra();
        }
    }
}
