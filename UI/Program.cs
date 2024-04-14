using UserAccountBusiness;

namespace UserDataUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter UserName: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Enter UserID: ");
            string userID = Console.ReadLine();


            AccountService userData = new AccountService();

            
            if (true)
            {

                Console.WriteLine("Welcome User!");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}