namespace BankLoginPage.Models
{
    public interface BankService
    {
        public Bank Login(string username, string password);
    }
}
