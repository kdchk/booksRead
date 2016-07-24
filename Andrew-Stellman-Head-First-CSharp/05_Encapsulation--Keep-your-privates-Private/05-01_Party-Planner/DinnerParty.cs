using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_01_Party_Planner
{
    class DinnerParty
    {
        const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations) { }

        private decimal CalculateCostOfDecorations()
        {
            decimal CostOfDecorations;
            if (FancyDecorations)
            {
                CostOfDecorations = (NumberOfPeople * 15M) + 50M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.5M) + 30M;
            }
            return CostOfDecorations;
        }

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal CostOfBeveragesPerPerson;
            if (HealthyOption)
            {
                CostOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.00M;
            }
            return CostOfBeveragesPerPerson;
        }

        public decimal Cost
        {
            get
            {
                decimal totalCost;
                totalCost = CalculateCostOfDecorations();
                totalCost += ((CalculateCostOfBeveragesPerPerson() + CostOfFoodPerPerson) * NumberOfPeople);
                if (HealthyOption)
                {
                    totalCost *= 0.95M;
                }
                return totalCost;
            }
        }
    }
}
