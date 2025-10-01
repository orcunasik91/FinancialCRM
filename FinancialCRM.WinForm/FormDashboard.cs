using FinancialCRM.WinForm.Models.Context;
using System.Windows.Forms.DataVisualization.Charting;

namespace FinancialCRM.WinForm;
public partial class FormDashboard : Form
{
    private readonly AppDbContext context;
    public FormDashboard(AppDbContext _context)
    {
        context = _context;
        InitializeComponent();
    }
    int billCount = 0;
    private void FormDashboard_Load(object sender, EventArgs e)
    {
        #region Total Balance
        string totalBalance = context.Banks.Sum(b => b.Balance).ToString("0.00 ₺");
        lblTotalBalance.Text = totalBalance;
        #endregion
        #region Gelen Son Havale
        decimal lastBankProcessAmount = context.BankProcesses.OrderByDescending(bp => bp.BankProcessId).Select(bp => bp.Amount).FirstOrDefault();
        lblLastBankProcessAmount.Text = lastBankProcessAmount.ToString("0.00 ₺");
        #endregion
        #region Chart1
        var bankData = context.Banks.Select(b => new
        {
            b.BankTitle,
            b.Balance
        }).ToList();
        chart1.Series.Clear();
        foreach (var item in bankData)
        {
            var series1 = chart1.Series.Add(item.BankTitle);
            series1.ChartType = SeriesChartType.Column;
            series1.Points.AddY(item.Balance);
            series1.IsValueShownAsLabel = true;
        }
        #endregion
        #region Chart2
        var billData = context.Bills.Select(b => new
        {
            b.BillTitle,
            b.BillAmount
        }).ToList();
        chart2.Series.Clear();
        foreach (var item in billData)
        {
            var series2 = chart2.Series.Add(item.BillTitle);
            series2.ChartType = SeriesChartType.Column;
            series2.Points.AddY(item.BillAmount);
            series2.IsValueShownAsLabel = true;
        }
        #endregion
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        billCount++;
        if(billCount % 4 == 1)
        {
            decimal billAmount = context.Bills.Where(b => b.BillTitle == "Elektrik faturası").Select(b => b.BillAmount).FirstOrDefault();
            lblBillTitle.Text = "Elektrik Faturası";
            lblBillAmount.Text = billAmount.ToString("0.00 ₺");
        }
        if (billCount % 4 == 2)
        {
            decimal billAmount = context.Bills.Where(b => b.BillTitle == "Doğalgaz faturası").Select(b => b.BillAmount).FirstOrDefault();
            lblBillTitle.Text = "Doğalgaz Faturası";
            lblBillAmount.Text = billAmount.ToString("0.00 ₺");
        }
        if (billCount % 4 == 3)
        {
            decimal billAmount1 = context.Bills.Where(b => b.BillTitle == "Su faturası").Select(b => b.BillAmount).FirstOrDefault();
            lblBillTitle.Text = "Su Faturası";
            lblBillAmount.Text = billAmount1.ToString("0.00 ₺");
        }
        if (billCount % 4 == 0)
        {
            decimal billAmount1 = context.Bills.Where(b => b.BillTitle == "İnternet faturası").Select(b => b.BillAmount).FirstOrDefault();
            lblBillTitle.Text = "İnternet Faturası";
            lblBillAmount.Text = billAmount1.ToString("0.00 ₺");
        }
    }
}
