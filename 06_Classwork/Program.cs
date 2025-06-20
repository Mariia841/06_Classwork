namespace _06_Classwork
{
    class creditcard
    {
        private string cardNumber;
        public string CardNumber
        {
            get { return cardNumber; }
            set
            {
                if (value.Length != 16 || !long.TryParse(value, out _))
                {
                    throw new ArgumentException("Card number must be a 16-digit number.");
                }
                cardNumber = value;
            }
        }

        private string ownerName;
        public string OwnerName
        {
            get { return ownerName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Owner name cannot be empty.");
                }
                ownerName = value;
            }
        }

        private string cvc;
        public string Cvc
        {
            get { return cvc; }
            set 
            {
                if (value.Length != 3 || !int.TryParse(value, out _))
                {
                    throw new ArgumentException("CVC must be a 3-digit number.");
                }
                cvc = value;
            }

        }
        
        private DateTime expirationDate;
        public DateTime ExpirationDate
        {
            get { return expirationDate; }
            set
            {
                if (value < DateTime.Now)
                {
                    throw new ArgumentException("Expiration date must be in the future.");
                }
                expirationDate = value;
            }
        }
        public creditcard(string cardNumber, string ownerName, string cvc, DateTime expirationDate)
        {
            CardNumber = cardNumber;
            OwnerName = ownerName;
            Cvc = cvc;
            ExpirationDate = expirationDate;
        }
        public void Print()
        {
            Console.WriteLine($"Card Number: {CardNumber}");
            Console.WriteLine($"Owner Name: {OwnerName}");
            Console.WriteLine($"CVC: {Cvc}");
            Console.WriteLine($"Expiration Date: {ExpirationDate.ToShortDateString()}");
        }
        public override string ToString()
        {
            return $"Card Number: {CardNumber}, Owner: {OwnerName}, CVC: {Cvc}, Expiration Date: {ExpirationDate.ToShortDateString()}";
        }





    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //Завдання 2
            //Створіть клас «Кредитна картка». Вам необхідно зберіга -
            //ти інформацію про номер картки, ПІБ власника, CVC, дату
            //завершення роботи картки і т.д.Передбачити механізми
            //ініціалізації полів класу.Якщо значення для ініціалізації
            //неправильне, генеруйте виняток.
            //try
            //{
            //    creditcard card = new creditcard("1234567890123456", "John Doe", "123", DateTime.Now.AddYears(1));
            //    card.Print();
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            //}


            //Завдання 1
            //Користувач вводить до рядка з клавіатури набір сим-
            //волів від 0 - 9.Необхідно перетворити рядок на число ціло -
            //го типу.Передбачити випадок виходу за межі діапазону,
            //який визначається типом int.Використовуйте механізм
            //виключень.

            //Console.WriteLine("Enter a string of numbers from 0 to 9:");
            //string input = Console.ReadLine();
            //Console.WriteLine(input);
            //try
            //{
            //    int number = Convert.ToInt32(input);
            //    Console.WriteLine($"Converted number: {number}");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Invalid format. Please enter a valid integer.");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("The number is too large or too small for an Int32.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            //}


        }
    }
}
