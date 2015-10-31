// Task 01 -> Create a ChaoticParticle class, which is a Particle, randomly changing its movement (Speed).
// You are not allowed to edit any existing class.

namespace ParticleSystem
{
    using System;
    using System.Collections.Generic;

    public class ChaoticParticle : Particle
    {
        private const int MinSpeed = -3;
        private const int MaxSpeed = 3;
        private Random randomGen;

        public ChaoticParticle(MatrixCoords position, MatrixCoords speed, Random randomGenerator)
            : base(position, speed)
        {
            this.randomGen = randomGenerator;
        }

        public override IEnumerable<Particle> Update()
        {
            int randomCol = randomGen.Next(MinSpeed, MaxSpeed);
            int randomRow = randomGen.Next(MinSpeed, MaxSpeed);
            base.Speed = new MatrixCoords(randomCol, randomRow);

            return base.Update();
        }
    }
}
