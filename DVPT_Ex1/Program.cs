using System.Diagnostics;

namespace DVPT_Ex1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            double valeurFinale = 0;
            Console.WriteLine(traitement(3000000,1000000000000000000, out valeurFinale));
            Console.WriteLine(valeurFinale);

        }

        static bool traitement(int nbIteration, double valeurDepart, out double valeurFinale)
        {
            try
            {
                for (int i = 0; i < nbIteration; i++)
                {
                    valeurDepart *= 2;
                }

                valeurFinale = valeurDepart;

                // check if valeurFinale is a number
                return (!double.IsNaN(valeurFinale) && !double.IsInfinity(valeurFinale));

            }
            catch (OverflowException e)
            {
                EventLog.WriteEntry("Application", e.Message, EventLogEntryType.Error);
                valeurFinale = 0;
                return false;
            }
        }

    }

}