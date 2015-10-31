// Task 03 -> Create a ChickenParticle class. The ChickenParticle class moves like a ChaoticParticle, but randomly stops at
// different positions for several simulation ticks and, for each of those stops, creates (lays) a new ChickenParticle. 
// You are not allowed to edit any existing class.

using System;
using System.Collections.Generic;

namespace ParticleSystem
{
    public class ChickenParticle : ChaoticParticle
    {
        private const int tickDelay = 5;
        private int countingTicks = 0;
        private IList<Particle> listOfParticles;

         public ChickenParticle(MatrixCoords position, MatrixCoords speed, Random randomGenerator)
            : base(position, speed, randomGenerator)
        {
            this.listOfParticles = new List<Particle>();
        }

         public override IEnumerable<Particle> Update()
         {

             if (this.countingTicks == 0)
             {
                 Random randomGen = new Random();
                 listOfParticles.Add(new ChickenParticle(base.Position, base.Speed, randomGen));
                 this.countingTicks = tickDelay;
                 base.Update();

                 return listOfParticles;
             }
             else
             {
                 this.countingTicks--;
                 return new List<Particle>();
             }
         }

         public override char[,] GetImage()
         {
             return new char[,] { { '^' } };
         }
    }
}
