using System;

namespace mission2Assignment
{
    class RollDice
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome! How many times woud you like to roll the dice?");
            int numRolls = Convert.ToInt32(Console.ReadLine());

            int[] totals = new int[0];


            for (int i = 0; i < numRolls; i++)
            {
                Random rand = new Random();
                int roll1 = rand.Next(1, 7);
                int roll2 = rand.Next(1, 7);
                int total = roll1 + roll2;
                Array.Resize(ref totals, totals.Length + 1);
                totals[totals.Length - 1] = total;
               // Console.WriteLine("You rolled a " + roll1 + " and a " + roll2 + " for a total of " + total);
            }

            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;
            int counter5 = 0;
            int counter6 = 0;
            int counter7 = 0;
            int counter8 = 0;
            int counter9 = 0;
            int counter10 = 0;
            int counter11 = 0;
            int counter12 = 0;


            for (int i = 0; i < totals.Length; i++)
            {
                int currentNum = (totals[i]);
                if(currentNum == 2)
                {
                    counter2 = counter2 + 1;
                }
                if (currentNum == 3)
                {
                    counter3 = counter3 + 1;
                }
                if (currentNum == 4)
                {
                    counter4 = counter4 + 1;
                }
                if (currentNum == 5)
                {
                    counter5 = counter5 + 1;
                }
                if (currentNum == 6)
                {
                    counter6 = counter6 + 1;
                }
                if (currentNum == 7)
                {
                    counter7 = counter7 + 1;
                }
                if (currentNum == 8)
                {
                    counter8 = counter8 + 1;
                }
                if (currentNum == 9)
                {
                    counter9 = counter9 + 1;
                }
                if (currentNum == 10)
                {
                    counter10 = counter10 + 1;
                }
                if (currentNum == 11)
                {
                    counter11 = counter11 + 1;
                }
                if (currentNum == 12)
                {
                    counter12 = counter12 + 1;
                }
            }

            //calculate percentages of total rolls
            double proportion2 = Convert.ToDouble(counter2) / numRolls;
            double proportion3 =  Convert.ToDouble(counter3) / numRolls;
            double proportion4 =  Convert.ToDouble(counter4) / numRolls;
            double proportion5 =  Convert.ToDouble(counter5) / numRolls;
            double proportion6 =  Convert.ToDouble(counter6) / numRolls;
            double proportion7 =  Convert.ToDouble(counter7) / numRolls;
            double proportion8 =  Convert.ToDouble(counter8) / numRolls;
            double proportion9 =  Convert.ToDouble(counter9) / numRolls;
            double proportion10 = Convert.ToDouble(counter10) / numRolls;
            double proportion11 = Convert.ToDouble(counter11) / numRolls;
            double proportion12 = Convert.ToDouble(counter12) / numRolls;

            int roundedProportion2 = (int)Math.Round(proportion2 * 100);
            int roundedProportion3 = (int)Math.Round(proportion3 * 100);
            int roundedProportion4 = (int)Math.Round(proportion4 * 100);
            int roundedProportion5 = (int)Math.Round(proportion5 * 100);
            int roundedProportion6 = (int)Math.Round(proportion6 * 100);
            int roundedProportion7 = (int)Math.Round(proportion7 * 100);
            int roundedProportion8 = (int)Math.Round(proportion8 * 100);
            int roundedProportion9 = (int)Math.Round(proportion9 * 100);
            int roundedProportion10 = (int)Math.Round(proportion10 * 100);
            int roundedProportion11 = (int)Math.Round(proportion11 * 100);
            int roundedProportion12 = (int)Math.Round(proportion12 * 100);

            string asterisk2 = new string('*', roundedProportion2);
            string asterisk3 = new string('*', roundedProportion3);
            string asterisk4 = new string('*', roundedProportion4);
            string asterisk5 = new string('*', roundedProportion5);
            string asterisk6 = new string('*', roundedProportion6);
            string asterisk7 = new string('*', roundedProportion7);
            string asterisk8 = new string('*', roundedProportion8);
            string asterisk9 = new string('*', roundedProportion9);
            string asterisk10 = new string('*', roundedProportion10);
            string asterisk11 = new string('*', roundedProportion11);
            string asterisk12 = new string('*', roundedProportion12);


            Console.WriteLine("Here is a breakdown of your rolls. Each * represents 1% of the total rolls.");

            Console.WriteLine("2: " + asterisk2);
            Console.WriteLine("3: " +  asterisk3) ;
            Console.WriteLine("4: " +  asterisk4) ;
            Console.WriteLine("5: " +  asterisk5) ;
            Console.WriteLine("6: " +  asterisk6) ;
            Console.WriteLine("7: " +  asterisk7) ;
            Console.WriteLine("8: " +  asterisk8) ;
            Console.WriteLine("9: " +  asterisk9) ;
            Console.WriteLine("10: " + asterisk10);
            Console.WriteLine("11: " + asterisk11);
            Console.WriteLine("12: " + asterisk12);


            Console.WriteLine("Thank you! Bye.");
        }



    }
}
