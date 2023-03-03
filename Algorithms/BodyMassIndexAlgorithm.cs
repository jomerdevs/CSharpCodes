using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCodes.Algorithms
{
    internal class BodyMassIndexAlgorithm
    {
        public static void calculateBMI(double height, double weight)
        {
            // la medida en height en este caso debe ser en metros, si la queremos en pies solo multiplicar por 3.28084

            double weightKg = weight * 0.453592; // convertimos el peso de libras a kilogramos
            double bmi = weightKg / Math.Pow(height, 2);

            if (bmi < 18.5)
                Console.WriteLine($"Tu índice de masa corporal es {bmi}, estás muy bajo de peso");
            else if (bmi >= 18.5 && bmi < 24.9)
                Console.WriteLine($"Tu índice de masa corporal es {bmi}, estás saludable y en peso ideal");
            else if (bmi >= 24.9 && bmi < 30)
                Console.WriteLine($"Tu índice de masa corporal es {bmi}, estás en sobrepeso");
            else if (bmi > 30)
                Console.WriteLine($"Tu índice de masa corporal es {bmi}, sufres de obesidad");

        }
    }
}
