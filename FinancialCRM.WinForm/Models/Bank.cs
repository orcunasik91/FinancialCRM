namespace FinancialCRM.WinForm.Models;
public class Bank
{
    public int BankId { get; set; }
    public string AccountNumber { get; set; }
    public string BankTitle { get; set; }
    public decimal Balance { get; set; }
    public List<BankProcess> BankProcesses { get; set; }
}