namespace FinancialCRM.WinForm.Models;
public class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    public List<Spending> Spendings { get; set; }
}