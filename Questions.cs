using System;

namespace UnitCalculator
{
    public class Questions
    {
        double unitFirstValue { get; set; }
        double unitSecondValue { get; set; }
        double unitValue { get; set; }
        int numberValue { get; set; }
        string unitStringValue { get; set; }

        public void Conversation()
        {
            try
            {
                Console.WriteLine("Cześć");
                AskForUnitType();
                Console.WriteLine($"Czy chesz Przeliczyć coś jeszcze, jeśli tak wpisz 'Tak'");
                string isOver = Console.ReadLine();
                if (isOver is "tak" || isOver is "Tak")
                {
                    AskForUnitType();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            catch (Exception ex)
            {

                IfError();
            }

        }

        public void AskForUnitType()
        {
            Console.WriteLine("na jakie jednostki chcesz przeliczyć");
            Console.WriteLine("Odległość, Pojemność, czy Waga?");
            string userInput = Console.ReadLine();

            if (userInput is "Odległość")
            {
                AskToSpecifiedASpecificUnitForLenght();
            }
            else if (userInput == "Pojemność")
            {
                AskToSpecifiedASpecificUnitForCapacity();
            }
            else if (userInput == "Waga")
            {
                AskToSpecifiedASpecificUnitForWeight();
            }
            else
            {
                Console.WriteLine("Nie zrozumiałem, może jeszcze raz?");
                Conversation();
            }

        }

        public void AskToSpecifiedASpecificUnitForLenght()
        {
            Processor processor = new Processor();

            Console.WriteLine("Najpierw podaj twoją liczbę i jednostkę po spacji, (nie przyjmuję liczb po przecinku), np, 100 m");
            Console.WriteLine("może tez być mm, cm, lub km?");
            string userSpecificInputforLenght = Console.ReadLine();
            string unitStringValue = GetStringFromInputLenght(userSpecificInputforLenght);
            unitFirstValue = CheckForLenghtTypeOfLenghtUnit(unitStringValue);
            Console.WriteLine("Teraz podaj na jakie jednostki chcesz przeliczyć ta liczbę?");
            string expectedUnit = Console.ReadLine();
            unitSecondValue = CheckForLenghtTypeOfLenghtUnit(expectedUnit);
            numberValue = processor.GetNumberFormString(userSpecificInputforLenght);
            Console.WriteLine("Twój wynik to!");
            Console.WriteLine($"{processor.Calculate(unitSecondValue, unitFirstValue, numberValue)} {expectedUnit}");


        }
        public void AskToSpecifiedASpecificUnitForCapacity()
        {
            Processor processor = new Processor();

            Console.WriteLine("Najpierw podaj twoją liczbę i jednostkę po spacji, (nie przyjmuję liczb po przecinku), np, 100 l");
            Console.WriteLine("może tez być ml, cl, lub hl?");
            string userSpecificInputforLenght = Console.ReadLine();
            string unitStringValue = GetStringFromInputCapacit(userSpecificInputforLenght);
            unitFirstValue = CheckForLenghtTypeOfCapacityUnit(unitStringValue);
            Console.WriteLine("Teraz podaj na jakie jednostki chcesz przeliczyć ta liczbę?");
            string expectedUnit = Console.ReadLine();
            unitSecondValue = CheckForLenghtTypeOfCapacityUnit(expectedUnit);
            numberValue = processor.GetNumberFormString(userSpecificInputforLenght);
            Console.WriteLine($"{processor.Calculate(unitSecondValue, unitFirstValue, numberValue)} {expectedUnit}");


        }
        public void AskToSpecifiedASpecificUnitForWeight()
        {
            Processor processor = new Processor();

            Console.WriteLine("Najpierw podaj twoją liczbę i jednostkę po spacji, (nie przyjmuję liczb po przecinku), np, 100 kg");
            Console.WriteLine("może tez być g, dag, lub t?");
            string userSpecificInputforLenght = Console.ReadLine();
            string unitStringValue = GetStringFromInputWeight(userSpecificInputforLenght);
            unitFirstValue = CheckForLenghtTypeOfWeightUnit(unitStringValue);
            Console.WriteLine("Teraz podaj na jakie jednostki chcesz przeliczyć ta liczbę?");
            string expectedUnit = Console.ReadLine();
            unitSecondValue = CheckForLenghtTypeOfWeightUnit(expectedUnit);
            numberValue = processor.GetNumberFormString(userSpecificInputforLenght);
            Console.WriteLine($"{processor.Calculate(unitSecondValue, unitFirstValue, numberValue)} {expectedUnit}");


        }
        public double CheckForLenghtTypeOfLenghtUnit(string inputUnitValue)
        {
            switch (inputUnitValue)
            {
                case "m":
                    unitValue = 1000;
                    break;
                case "mm":
                    unitValue = 1;
                    break;
                case "cm":
                    unitValue = 10;
                    break;
                case "km":
                    unitValue = 1000000;
                    break;
                default:
                    break;
            }
            return unitValue;
        }
        public double CheckForLenghtTypeOfCapacityUnit(string inputUnitValue)
        {
            switch (inputUnitValue)
            {
                case "l":
                    unitValue = 1000;
                    break;
                case "ml":
                    unitValue = 1;
                    break;
                case "cl":
                    unitValue = 100;
                    break;
                case "hl":
                    unitValue = 100000;
                    break;
                default:
                    break;
            }
            return unitValue;
        }
        public double CheckForLenghtTypeOfWeightUnit(string inputUnitValue)
        {
            switch (inputUnitValue)
            {
                case "kg":
                    unitValue = 1000;
                    break;
                case "g":
                    unitValue = 1;
                    break;
                case "dag":
                    unitValue = 10;
                    break;
                case "t":
                    unitValue = 1000000;
                    break;
                default:
                    break;
            }
            return unitValue;
        }

        string GetStringFromInputLenght(string userSpecificInputforLenght)
        {

            if (userSpecificInputforLenght.Contains("m"))
            {
                unitStringValue = "m";
            }
            else if (userSpecificInputforLenght.Contains("mm"))
            {
                unitStringValue = "mm";
            }
            else if (userSpecificInputforLenght.Contains("km"))
            {
                unitStringValue = "km";
            }
            else if (userSpecificInputforLenght.Contains("cm"))
            {
                unitStringValue = "cm";
            }
            else
            {
                IfError();
            }
            return unitStringValue;
        }

        string GetStringFromInputWeight(string userSpecificInputforLenght)
        {
            if (userSpecificInputforLenght.Contains("g"))
            {
                unitStringValue = "g";
            }
            else if (userSpecificInputforLenght.Contains("kg"))
            {
                unitStringValue = "kg";
            }
            else if (userSpecificInputforLenght.Contains("dag"))
            {
                unitStringValue = "dag";
            }
            else if (userSpecificInputforLenght.Contains("t"))
            {
                unitStringValue = "t";
            }
            else
            {
                IfError();
            }
            return unitStringValue;
        }

        string GetStringFromInputCapacit(string userSpecificInputforLenght)
        {
            if (userSpecificInputforLenght.Contains("l"))
            {
                unitStringValue = "l";
            }
            else if (userSpecificInputforLenght.Contains("ml"))
            {
                unitStringValue = "ml";
            }
            else if (userSpecificInputforLenght.Contains("cl"))
            {
                unitStringValue = "cl";
            }
            else if (userSpecificInputforLenght.Contains("hl"))
            {
                unitStringValue = "hl";
            }
            else
            {
                IfError();
            }
            return unitStringValue;
        }
        void IfError()
        {
            Console.WriteLine("Coś poszło nie tak, chyba nie rozozumiem, spróbujmy od początku");
            Conversation();
        }

    }
}
