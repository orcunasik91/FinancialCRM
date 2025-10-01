using FinancialCRM.WinForm.Models;
using FinancialCRM.WinForm.Models.Context;

namespace FinancialCRM.WinForm;
public partial class FormBilling : Form
{
    private readonly AppDbContext context;
    public FormBilling(AppDbContext _context)
    {
        context = _context;
        InitializeComponent();
    }
    void GetAllBills()
    {
        var result = context.Bills.ToList();
        dataGridView1.DataSource = result;
    }
    private void FormBilling_Load(object sender, EventArgs e)
    {
        GetAllBills();
    }

    private void btnBillList_Click(object sender, EventArgs e)
    {
        GetAllBills();
    }

    private void btnAddBill_Click(object sender, EventArgs e)
    {
        string title = txtBillTitle.Text;
        decimal amount = decimal.Parse(txtBillAmount.Text);
        string period = txtBillPeriod.Text;
        Bill bill = new();
        bill.BillTitle = title;
        bill.BillPeriod = period;
        bill.BillAmount = amount;
        context.Bills.Add(bill);
        context.SaveChanges();
        MessageBox.Show("Yeni Fatura Başarı ile Kaydedildi", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
        GetAllBills();
    }

    private void btnRemoveBill_Click(object sender, EventArgs e)
    {
        int billId = int.Parse(txtBillId.Text);
        Bill bill = context.Bills.Find(billId);
        context.Bills.Remove(bill);
        context.SaveChanges();
        MessageBox.Show("Fatura Başarı ile Silindi", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
        GetAllBills();
    }

    private void btnUpdateBill_Click(object sender, EventArgs e)
    {
        int billId = int.Parse(txtBillId.Text);
        Bill bill = context.Bills.Find(billId);
        bill.BillId = billId;
        bill.BillTitle = txtBillTitle.Text;
        bill.BillAmount = decimal.Parse(txtBillAmount.Text);
        bill.BillPeriod = txtBillPeriod.Text;
        context.Bills.Update(bill);
        context.SaveChanges();
        MessageBox.Show("Fatura Başarı ile Güncellendi", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
        GetAllBills();
    }

    private void btnBanks_Click(object sender, EventArgs e)
    {
        FormBank formBank = new FormBank(context);
        formBank.Show();
        this.Close();
    }

    private void btnBills_Click(object sender, EventArgs e)
    {
        FormBilling_Load(sender,e);
    }
}