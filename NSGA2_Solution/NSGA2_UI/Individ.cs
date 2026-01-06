using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSGA2_UI
{
    public class Individ
    {
        public double putere_motor;   // CP
        public double capacitate_rezervor; // litri
        public double dimensiune_roti; // inch
        public double acceleratie; // secunde
        public double autonomie_range;    // km
        public int rank; // rangul in populatie
        public double crowding_distance; // distanta de aglomerare
        public int domination_count; // numarul de dominari
        public List<Individ> dominates; // solutii dominate

        public Individ()
        {
            putere_motor = 0;
            capacitate_rezervor = 0;
            dimensiune_roti = 0;
            acceleratie = 0;
            autonomie_range = 0;
            rank = 0;
            crowding_distance = 0;
            domination_count = 0;
            dominates = new List<Individ>();
        }
        public Individ(double motor, double rezervor, double roti, double acc, double range)
        {
            putere_motor = motor;
            capacitate_rezervor = rezervor;
            dimensiune_roti = roti;
            acceleratie = acc;
            autonomie_range = range;
            rank = 0;
            crowding_distance = 0;
            domination_count = 0;
            dominates = new List<Individ>();
        }

        public static Individ TournamentSelection(Individ[] population)
        {
            int index1 = new Random().Next(population.Length);
            int index2 = new Random().Next(population.Length);

            if (population[index1].rank > population[index2].rank)
            {
                return population[index1];
            }
            else if (population[index1].rank < population[index2].rank)
            {
                return population[index2];
            }
            else
            {
                if (population[index1].crowding_distance > population[index2].crowding_distance)
                {
                    return population[index1];
                }
                else
                {
                    return population[index2];
                }
            }
        }
        public static Individ[] Crossover(Individ parent1, Individ parent2)
        {
            double _rate = new Random().NextDouble();

            Individ[] children = new Individ[2];
            children[0] = new Individ();
            children[1] = new Individ();
            children[0].putere_motor = _rate * parent1.putere_motor + (1 - _rate) * parent2.putere_motor;
            children[0].capacitate_rezervor = _rate * parent1.capacitate_rezervor + (1 - _rate) * parent2.capacitate_rezervor;
            children[0].dimensiune_roti = _rate * parent1.dimensiune_roti + (1 - _rate) * parent2.dimensiune_roti;

            children[1].putere_motor = (1 - _rate) * parent1.putere_motor + _rate * parent2.putere_motor;
            children[1].capacitate_rezervor = (1 - _rate) * parent1.capacitate_rezervor + _rate * parent2.capacitate_rezervor;
            children[1].dimensiune_roti = (1 - _rate) * parent1.dimensiune_roti + _rate * parent2.dimensiune_roti;

            return children;
        }
        public static void Mutation(Individ child, double mutationRate)
        {
            mutationRate = mutationRate / 100.0;
            Random rand = new Random();
            if (rand.NextDouble() < mutationRate)
            {
                // Mutatie pe putere motor
                double mutationValue = rand.NextDouble() * 100 - 50; // mutatie intre -50 si +50
                child.putere_motor += mutationValue;
            }
            if (rand.NextDouble() < mutationRate)
            {
                // Mutatie pe capacitate rezervor
                double mutationValue = rand.NextDouble() * 20 - 10; // mutatie intre -10 si +10
                child.capacitate_rezervor += mutationValue;
            }
            if (rand.NextDouble() < mutationRate)
            {
                // Mutatie pe dimensiune roti
                double mutationValue = rand.NextDouble() * 4 - 2; // mutatie intre -2 si +2
                child.dimensiune_roti += mutationValue;
            }
        }
        public static List<Individ> buildFront(List<Individ> lastFront, Individ[] population)
        {
            List<Individ> F = new List<Individ>();
            for (int i = 0; i < population.Length; i++)
            {
                for (int j = 0; j < lastFront.Count; j++)
                {
                    if (lastFront[j].dominates.Contains(population[i]))
                    {
                        population[i].domination_count--;
                        if (population[i].domination_count == 0)
                        {
                            population[i].rank = 12;
                            F.Add(population[i]);
                        }
                    }
                }
            }
            return F;
        }
    }

}
