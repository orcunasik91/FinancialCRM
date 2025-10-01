using FinancialCRM.WinForm.Models.Context;

namespace FinancialCRM.WinForm;
public partial class FormBank : Form
{
    private readonly AppDbContext context;
    public FormBank(AppDbContext _context)
    {
        InitializeComponent();
        context = _context;
    }

    private void FormBank_Load(object sender, EventArgs e)
    {
        #region Banka Bakiyeleri
        decimal ziraatBalance = context.Banks.Where(b => b.BankTitle == "Ziraat Bankası").Select(b => b.Balance).FirstOrDefault();
        lblZiraatBalance.Text = ziraatBalance.ToString("0.00 ₺");
        decimal vakifBalance = context.Banks.Where(b => b.BankTitle == "Vakıfbank").Select(b => b.Balance).FirstOrDefault();
        lblVakifBalance.Text = vakifBalance.ToString("0.00 ₺");
        decimal isbankBalance = context.Banks.Where(b => b.BankTitle == "İş Bankası").Select(b => b.Balance).FirstOrDefault();
        lblIsBankBalance.Text = isbankBalance.ToString("0.00 ₺");
        #endregion
        #region Son 5 Banka Hareketleri
        var bankProcess1 = context.BankProcesses.OrderByDescending(bp => bp.BankProcessId).Take(1).FirstOrDefault();
        lblProcess1.Font = new Font("Consolas", 10, FontStyle.Bold);
        lblProcess1.Text = $"{bankProcess1.Description,-30} {bankProcess1.ProcessType,-25} {bankProcess1.ProcessDate,-20:dd.MM.yyyy} {bankProcess1.Amount,10:0.00 ₺}";
        var bankProcess2 = context.BankProcesses.OrderByDescending(bp => bp.BankProcessId).Take(2).Last();
        lblProcess2.Font = new Font("Consolas", 10, FontStyle.Bold);
        lblProcess2.Text = $"{bankProcess2.Description,-30} {bankProcess2.ProcessType,-25} {bankProcess2.ProcessDate,-20:dd.MM.yyyy} {bankProcess2.Amount,10:0.00 ₺}";
        var bankProcess3 = context.BankProcesses.OrderByDescending(bp => bp.BankProcessId).Take(3).Last();
        lblProcess3.Font = new Font("Consolas", 10, FontStyle.Bold);
        lblProcess3.Text = $"{bankProcess3.Description,-30} {bankProcess3.ProcessType,-25} {bankProcess3.ProcessDate,-20:dd.MM.yyyy} {bankProcess3.Amount,10:0.00 ₺}";
        var bankProcess4 = context.BankProcesses.OrderByDescending(bp => bp.BankProcessId).Take(4).Last();
        lblProcess4.Font = new Font("Consolas", 10, FontStyle.Bold);
        lblProcess4.Text = $"{bankProcess4.Description,-30} {bankProcess4.ProcessType,-25} {bankProcess4.ProcessDate,-20:dd.MM.yyyy} {bankProcess4.Amount,10:0.00 ₺}";
        var bankProcess5 = context.BankProcesses.OrderByDescending(bp => bp.BankProcessId).Take(5).Last();
        lblProcess5.Font = new Font("Consolas", 10, FontStyle.Bold);
        lblProcess5.Text = $"{bankProcess5.Description,-30} {bankProcess5.ProcessType,-25} {bankProcess5.ProcessDate,-20:dd.MM.yyyy} {bankProcess5.Amount,10:0.00 ₺}";
        #endregion
    }

    private void btnBills_Click(object sender, EventArgs e)
    {
        FormBilling formBilling = new FormBilling(context);
        formBilling.Show();
        this.Hide();
    }

    private void FormBank_FormClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }
}