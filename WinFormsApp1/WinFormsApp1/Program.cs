sing System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


3.1
namespace BCS
{
    public partial class ADMINDETAILS : Form
    {
        public ADMINDETAILS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BCS1Entities7 ob = new BCS1Entities7();
                BranchDetail o = new BranchDetail();
                o.BranchId = textBox1.Text;
                o.BranchName = textBox2.Text;
                o.BranchIFSC = textBox3.Text;
                o.BranchLocation = textBox4.Text;
                o.BranchState = textBox5.Text;
                o.Pincode = textBox6.Text;
                ob.BranchDetails.Add(o);
                int numberOfRows = ob.SaveChanges();
                if (numberOfRows > 0)
                    MessageBox.Show("Insertion is successful");
                else
                    MessageBox.Show("Insertion is failed");

            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message);
            }
        }


3.2
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                BCS1Entities10 ob = new BCS1Entities10();
                BankAccountTypeDetail oc = new BankAccountTypeDetail();
                oc.BranchId = textBox7.Text;
                oc.BranchName = textBox8.Text;
                oc.BranchIFSC = textBox9.Text;
                oc.BranchLocation = textBox10.Text;
                oc.BranchState = textBox11.Text;
                oc.Pincode = textBox12.Text;
                oc.salary = textBox26.Text;
                oc.BankAccountType = textBox27.Text;
                ob.BankAccountTypeDetails.Add(oc);
                int numberOfRows = ob.SaveChanges();
                if (numberOfRows > 0)
                    MessageBox.Show("Insertion is successful");
                else
                    MessageBox.Show("Insertion is failed");

            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message);
            }
        }


3.3

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                BCS1Entities4 ab = new BCS1Entities4();
                loan od = new loan();
                od.AccountNO = textBox13.Text;
                od.AccountHolderName = textBox14.Text;
                od.DOB = textBox15.Text;
                od.PhoneNO = textBox16.Text;
                od.Gender = textBox17.Text;
                od.LoanType = textBox18.Text;
                od.MotherName = textBox19.Text;
                od.AadharNo = textBox20.Text;
                od.Address = textBox21.Text;
                od.State = textBox22.Text;
                ab.loans.Add(od);
                int numberOfRows = ab.SaveChanges();
                if (numberOfRows > 0)
                    MessageBox.Show("Insertion is successful");
                else
                    MessageBox.Show("Insertion is failed");

            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message);
            }
        }



3.4
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                BCS1Entities8 ob = new BCS1Entities8();
                loan1 u = new loan1();
                u.AccountNO = textBox23.Text;

                var result = (from t in ob.loan1
                              where t.AccountNO == t.AccountNO
                              select t).FirstOrDefault();
                if (result == null)
                {
                    ob.loan1.Remove(result);
                    int totalrows = ob.SaveChanges();
                    if (totalrows > 0)
                        MessageBox.Show("row is deleted");
                    else
                        MessageBox.Show("not able to delete");

                }
                else
                {
                    MessageBox.Show("record is not found");
                }



            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message);
                throw;
            }
        }

     

3.5
   private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                BCS1Entities7 ob = new BCS1Entities7();
                string BranchDetail = textBox24.Text;
                var result = from o in ob.BranchDetails

                             select o;
                dataGridView1.DataSource = result.ToList();

            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message);
            }
            finally
            {
                MessageBox.Show("Resource is freed");
            }
        }

     

3.6
   private void button6_Click(object sender, EventArgs e)
        {

            try
            {
                BCS1Entities10 ob = new BCS1Entities10();
                string BankAccountTypeDetail = textBox25.Text;
                var result = from o in ob.BankAccountTypeDetails

                             select o;
                dataGridView2.DataSource = result.ToList();

            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message);
            }
            finally
            {
                MessageBox.Show("Resource is freed");
            }
        }

     

3.7
   private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                BCS1Entities4 ob = new BCS1Entities4();
                string loan = textBox28.Text;
                var result = from o in ob.loans
                             where o.AccountNO.Equals(loan)
                             select o;
                dataGridView3.DataSource = result.ToList();

            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message);
            }
            finally
            {
                MessageBox.Show("Resource is freed");
            }
        }
    }

}
3.8
namespace UPDATETRANSACTION
{

}

4.1
namespace FUNDTRANSFER
{
    public partial class FUND: Form
    {
        public ADMINDETAILS()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                BCD1Entities9 obs = new BCD1Entities9();
                AccountDetail a = new AccountDetail();
                a.AccountNo = textBox29.Text;
                a.BranchName = textBox30.Text;
                a.BranchIFSC = textBox31.Text;
                a.AccountHolderName = textBox32.Text;
                a.Amount = textBox33.Text;
                obs.AccountDetail.Add(a);
                int AccountBalance = obs.SaveChanges();
                if (a.Amount <= 0)
                    MessageBox.Show("Amount is low Transaction cannot be completed ");
                else
                    AccountBalance = AccountBalance - a.Amount;
                    MessageBox.Show("Amount Transfered sucessfully");

            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message);
            }
        }
    }
}



4.2
namespace CUSTOMERLOGIN
{
    public partial class CUSTOMERDETAILS : Form
    {
        public CUSTOMERDETAILS()
        {
            InitializeComponent();
        }

        private void OPEN_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerDataBaseEntities2 ob = new CustomerDataBaseEntities2();
                loanDetailsSpecificCustomer od = new loanDetailsSpecificCustomer();
                od.AccountNO = textBox1.Text;
                od.AccountHolderName = textBox2.Text;
                od.DOB = textBox3.Text;
                od.PhoneNO = textBox4.Text;
                od.Gender = textBox5.Text;
                od.LoanType = textBox6.Text;
                od.MotherName = textBox7.Text;
                od.AadharNo = textBox8.Text;
                od.Address = textBox9.Text;
                od.State = textBox10.Text;
                ob.loanDetailsSpecificCustomers.Add(od);
                int numberOfRows = ob.SaveChanges();
                if (numberOfRows > 0)
                    MessageBox.Show("Insertion is successful");
                else
                    MessageBox.Show("Insertion is failed");
            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message);
            }


        }

     
4.4
   private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerDataBaseEntities4 db = new CustomerDataBaseEntities4();
                Customer ob = new Customer();
                ob.name = textBox15.Text;
                ob.Emailid = textBox16.Text;
                ob.Phoneno = textBox17.Text;
                ob.Aadharno = textBox18.Text;
                ob.Address = textBox19.Text;
                ob.City = textBox20.Text;
                ob.State = textBox21.Text;

                int NoOfRows = db.SaveChanges();
                if (NoOfRows > 0)
                    MessageBox.Show("Updated Successfully");
                else
                    MessageBox.Show("Problem in Updating Row");


                else
                {
                    MessageBox.Show("Ticket Number is not available");
                }
            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message);
            }
        }
    }
}