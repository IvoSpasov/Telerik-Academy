namespace Infestation
{
    using System;

    using Infestation.Supplements;

    public class HoldingPenExtension : HoldingPen
    {
        protected override void ExecuteAddSupplementCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "AggressionCatalyst":
                    this.GetUnit(commandWords[2]).AddSupplement(new AggressionCatalyst());
                    break;
                case "HealthCatalyst":
                    this.GetUnit(commandWords[2]).AddSupplement(new HealthCatalyst());
                    break;
                case "PowerCatalyst":
                    this.GetUnit(commandWords[2]).AddSupplement(new PowerCatalyst());
                    break;
                default:
                    throw new ArgumentException("there is no such supplement");
            }
        }

        protected override void ExecuteInsertUnitCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "Tank":
                    var tank = new Tank(commandWords[2]);
                    this.InsertUnit(tank);
                    break;
                case "Marine":
                    var marine = new Marine(commandWords[2]);
                    this.InsertUnit(marine);
                    break;
                default:
                    base.ExecuteInsertUnitCommand(commandWords);
                    break;
            }
        }
    }
}
