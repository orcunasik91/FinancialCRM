namespace FinancialCRM.WinForm.Models;
public class Spending
{
    public int SpendingId { get; set; }
    public string Title { get; set; }
    public decimal Amount { get; set; }
    public DateTime SpendingDate { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}