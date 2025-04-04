using System.Text;

namespace Task9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создайте класс BankAccount, который моделирует банковский счет:

            //    Поля:
            //        _balance(текущий баланс, private)
            //Статическое поле:
            //    TotalAccounts(общее количество созданных счетов)
            //Свойства:
            //    AccountNumber(номер счета, readonly)
            //    Balance(public геттер, private сеттер)
            //Конструктор:
            //    Увеличивает TotalAccounts и генерирует AccountNumber(например, случайный 4-значный номер).
            //Методы:
            //    Deposit(decimal amount) – пополняет баланс.
            //    Withdraw(decimal amount) – снимает деньги(если хватает средств, иначе выбрасывает исключение).

            var xBank1 = new BankAccount();
            var xBank2 = new BankAccount();
            var xBank3 = new BankAccount();

            Console.WriteLine($"Номер счета: {xBank1.AccountNumber}");
            Console.WriteLine($"Текущий баланс: {xBank1.Balance}");
            BankAccount.DisplayTotalAccounts();
            xBank1.Deposit(200);
            Console.WriteLine($"Текущий баланс: {xBank1.Balance}");
            try
            {
                xBank1.Withdraw(500);
                Console.WriteLine($"Текущий баланс: {xBank1.Balance}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }

            Console.ReadKey();
        }
    }


    public class BankAccount
    {
        //Поля
        private decimal _balance; //текущий баланс
        public static int TotalAccounts; //общее количество созданных счетов
        private readonly int _accountNumber; //номер счета

        //Свойства
        public decimal Balance
        {
            get => _balance;

            private set
            {
                if (value < 0)
                    throw new ArgumentException("Не хватает средств, пополните баланс");
                _balance = value;
            }
        }
        public int AccountNumber { get; }

        //Конструктор
        public BankAccount()
        {
            Random rnd = new Random();
            string str = "";
            //StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                str += rnd.Next(0, 10);
            }
            _accountNumber = Convert.ToInt32(str);
            AccountNumber = _accountNumber;
            TotalAccounts++;
        }

        //Методы
        public void Deposit(decimal amount) //Пополняет баланс
        {
            Balance += amount;
        }
        public void Withdraw(decimal amount)//снимает деньги(если хватает средств, иначе выбрасывает исключение).
        {
            Balance -= amount;
        }

        public static void DisplayTotalAccounts()
        {
            Console.WriteLine($"Всего создано счетов: {TotalAccounts}");
        }
    }
}
