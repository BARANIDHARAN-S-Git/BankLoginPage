using BankLoginPage.Models;

namespace BankLoginPage.Service
{
    public class BankServiceImpl : BankService
    {
        private List<Bank> _accounts;

        public BankServiceImpl()
        {
            _accounts = new List<Bank>
            {
                new Bank
                {
                    UserName="Buttler",
                    Password="abc",
                    FullName="JosButtler"
                },
                 new Bank
                {
                    UserName="Samson",
                    Password="def",
                    FullName="SanjuSamson"
                },
                 new Bank
                {
                    UserName="Dhoni",
                    Password="ghi",
                    FullName="MahendraSinghDhoni"
                }
            };

        }
        public Bank Login(string username, string password)
        {
            return _accounts.SingleOrDefault(a => a.UserName == username && a.Password == password);
        }
    }
}
