namespace ex6
{
     class Tranctation
    {
        public int id;
        public DateTime time;
        public string senderName;
        public string receiveName;
        public string type;

        public Tranctation()
        {

        }

        public Tranctation(int id, DateTime time, string senderName, string receiveName, string type) { 
            this.id = id;
            this.time = time;
            this.senderName = senderName;
            this.receiveName = receiveName;
            this.type = type;
        }
    }
    class Account
    {
        public int id;
        public string name;
        public string email;
        public string password;
        public double balance;
        public List<Tranctation> tranctation = new();
       

        public Account(int id, string name, string email, string password, double balance)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
            this.balance = balance;
        }
        public bool Deposite(double amount)
        {
            
            balance += amount;
            Console.WriteLine(balance);
            Tranctation tr = new Tranctation(1,DateTime.Now,this.name,"Not found","Deposite");
            tranctation.Add(tr);
            return true;
            
        }
        public bool Withdrow(double amount)
        {
            if (amount > balance)
            {
                
                Console.WriteLine("Error");
                return false;
            }
            balance -= amount;
            Console.WriteLine(balance);
            Tranctation tr = new Tranctation(1, DateTime.Now, this.name, "Not found", "Withdraw");
            tranctation.Add(tr);
            return true;

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account client1 = new Account(1, "mohamed", "mr757@gmail", "1224532",500);
            client1.Deposite(300);
            client1.Withdrow(100);
            for (int i = 0; i < client1.tranctation.Count; i++)
            {
                Console.WriteLine(client1.tranctation[i].id);
                Console.WriteLine(client1.tranctation[i].time);
                Console.WriteLine(client1.tranctation[i].senderName);
                Console.WriteLine(client1.tranctation[i].receiveName);
                Console.WriteLine(client1.tranctation[i].type);

            }
            
            

            
        }
    }
}
