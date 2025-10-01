namespace FinancialCRM.WinForm.Models;
public class Bill
{
    public int BillId { get; set; }
    public string BillTitle { get; set; }
    public decimal BillAmount { get; set; }
    public string BillPeriod { get; set; }
}