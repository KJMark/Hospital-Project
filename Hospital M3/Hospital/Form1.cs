using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nurse_button1_Click(object sender, EventArgs e)
        {
            string x;
            int ids = Convert.ToInt32(id_textBox1.Text);                          //convert from text box into string
            int ages = Convert.ToInt32(age_textBox4.Text);                            //convert from text box into int
            double phones = Convert.ToDouble(phone_textBox7.Text);                   //convert from text box into double
            double mobiles = Convert.ToDouble(mobile_textBox8.Text);
            int emp_IDs = Convert.ToInt32(empID_textBox9.Text);
            double salarys = Convert.ToDouble(salaryy_textBox6.Text);
            double empTaxPer = Convert.ToDouble(taxPercent_textBox1.Text);
            int exHrs = Convert.ToInt32(extraHrrs_textBox6.Text);
            int nurNumDys = Convert.ToInt32(nurNumDys_textBox25.Text);
            int nurNumHrs = Convert.ToInt32(nurNumHrs_textBox26.Text);
            if(day_radioButton1.Checked){ x = day_radioButton1.Text; }                      //if day sheft radio button is checked it will return its text
            else if(night_radioButton1.Checked){ x = night_radioButton1.Text; }          //else if night sheft radio button is checked it will return its text "night"
            else { x = "Error!!"; }                                                          //else will return error if there is no employee working sheft
            int exHrSals = Convert.ToInt32(exHrSal_textBox1.Text);
            Nurse inp1 = new Nurse(ids, ages, name_textBox2.Text, address_textBox5.Text, gender_comboBox1.Text, phones, mobiles, emp_IDs, salarys, workHrs_textBox5.Text, workDays_textBox2.Text, empTaxPer, exHrs, x, nurDep_textBox23.Text, nurNumDys, nurNumHrs, exHrSals);
            MessageBox.Show(inp1.ToString());                                              //show all data in a message box
        }

        private void doctor_button2_Click(object sender, EventArgs e)
        {
            int ids = Convert.ToInt32(id_textBox1.Text); 
            int ages = Convert.ToInt32(age_textBox4.Text);                                      //convert from text box into int
            double phones = Convert.ToDouble(phone_textBox7.Text);                          //convert from text box into double 
            double mobiles = Convert.ToDouble(mobile_textBox8.Text);
            int emp_IDs = Convert.ToInt32(empID_textBox9.Text);
            double salarys = Convert.ToDouble(salaryy_textBox6.Text);
            double empTaxPer = Convert.ToDouble(taxPercent_textBox1.Text);
            int opFees = Convert.ToInt32(DocOpCost_textBox6.Text);                        
            int opNum = Convert.ToInt32(DocOpNum_textBox9.Text);
            int newPafees = Convert.ToInt32(newPa_textBox7.Text);
            int followPafees = Convert.ToInt32(followPa_textBox3.Text);
            double docOpPers = Convert.ToDouble(docPerOfOp_textBox1.Text);
            Doctors inp2 = new Doctors(ids, ages, name_textBox2.Text, address_textBox5.Text, gender_comboBox1.Text, phones, mobiles, emp_IDs, salarys, workHrs_textBox5.Text, workDays_textBox2.Text, empTaxPer, docSpec_textBox24.Text, opNum, opFees, newPafees, followPafees, docOpPers);
            MessageBox.Show(inp2.ToString());                            //show all data in a message box
        }

        private void manger_button3_Click(object sender, EventArgs e)
        {
            int ids = Convert.ToInt32(id_textBox1.Text); 
            int ages = Convert.ToInt32(age_textBox4.Text);                                    //convert from text box into int
            double phones = Convert.ToDouble(phone_textBox7.Text);                               //convert from text box into double 
            double mobiles = Convert.ToDouble(mobile_textBox8.Text);
            int emp_IDs = Convert.ToInt32(empID_textBox9.Text);
            double salarys = Convert.ToDouble(salaryy_textBox6.Text);
            double empTaxPer = Convert.ToDouble(taxPercent_textBox1.Text);
            Manger inp3 = new Manger(ids, ages, name_textBox2.Text, address_textBox5.Text, gender_comboBox1.Text, phones, mobiles, emp_IDs, salarys, workHrs_textBox5.Text, workDays_textBox2.Text, empTaxPer, manOf_textBox1.Text);
            MessageBox.Show(inp3.ToString());                                                                 //show all data in a message box
        }

        private void patiant_button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void patient_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=MARK\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
            {
                SqlCommand com1 = new SqlCommand("Insert into Person(age, name, gender, address, phone, mobile) values(@age, @name, @gender, @address, @phone, @mobile) ", con);
                SqlCommand com2 = new SqlCommand("Insert into Patient(code, entryDate, bloodType, sufferingFrom, Person_name) values(@code, @entryDate, @bloodType, @sufferingFrom, @Person_name) ", con);

                com1.Parameters.AddWithValue("@age", age_textBox4.Text);
                com1.Parameters.AddWithValue("@name", name_textBox2.Text);
                com1.Parameters.AddWithValue("@gender", gender_comboBox1.Text);
                com1.Parameters.AddWithValue("@address", address_textBox5.Text);
                com1.Parameters.AddWithValue("@phone", phone_textBox7.Text);
                com1.Parameters.AddWithValue("@mobile", mobile_textBox8.Text);

                com2.Parameters.AddWithValue("@code", paCode_textBox4.Text);
                com2.Parameters.AddWithValue("@entryDate", paEntry_dateTimePicker1.Value.ToShortDateString());
                com2.Parameters.AddWithValue("@bloodType", bloodType_textBox10.Text);
                com2.Parameters.AddWithValue("@sufferingFrom", sufferFrom_textBox22.Text);
                com2.Parameters.AddWithValue("@Person_name", name_textBox2.Text);

                con.Open();
                com1.ExecuteNonQuery();
                com2.ExecuteNonQuery();             
                con.Close();
            }
            
            int ids = Convert.ToInt32(id_textBox1.Text);
            int ages = Convert.ToInt32(age_textBox4.Text);                                           //convert from text box into int
            double phones = Convert.ToDouble(phone_textBox7.Text);                            //convert from text box into double 
            double mobiles = Convert.ToDouble(mobile_textBox8.Text);
            double paCodes = Convert.ToDouble(paCode_textBox4.Text);
            string entryDate = paEntry_dateTimePicker1.Value.ToShortDateString();                  //convert from date time picker into string 
            patient inp4 = new patient(ids, ages, name_textBox2.Text, address_textBox5.Text, gender_comboBox1.Text, phones, mobiles, paCodes, entryDate, bloodType_textBox10.Text, sufferFrom_textBox22.Text);
            MessageBox.Show(inp4.ToString());               //show all data in a message box

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void newPa_textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void nurNumDys_textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void manOf_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void examin_button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void operations_button4_Click(object sender, EventArgs e)
        {
            
        }

        private void followUp_button5_Click(object sender, EventArgs e)
        {
            
        }

        private void checkOutt_button1_Click(object sender, EventArgs e)
        {
            double mdslsts = Convert.ToDouble(midCost_textBox12.Text);                    //convert from text box into double 
            double ex_cost = Convert.ToDouble(examCost_textBox3.Text);
            double tstrycst = Convert.ToDouble(testRayCost_textBox4.Text);
            double tstanacst = Convert.ToDouble(testAnaCost_textBox2.Text);
            double opcsts = Convert.ToDouble(OperationCost_textBox1.Text);
            double flwupcost = Convert.ToDouble(followupCost_textBox18.Text);
            Medical_examination exa = new Medical_examination(examDoc_textBox4.Text, examType_textBox11.Text, examResult_textBox19.Text, ex_cost);
            Test tst = new Test(testRayType_textBox14.Text, testAnaType_textBox15.Text, tstrycst, tstanacst);
            Medicines mdcns = new Medicines(midLst_textBox13.Text, mdslsts);
            Operations oprs = new Operations(operationType_textBox20.Text, operationDocname_textBox21.Text, opcsts);
            Medical_follow_up mdcflwp = new Medical_follow_up(followupDoc_textBox17.Text, followupResult_textBox16.Text, flwupcost);
            Check_out bell = new Check_out(exa, mdcns, tst, oprs, mdcflwp);
            MessageBox.Show(bell.ToString());                                                      //show all data in a message box
        }

        private void bloodType_textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void phone_textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataShow_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=MARK\\SQLEXPRESS;Initial Catalog=Hospital;Integrated Security=True");
            SqlCommand com3 = new SqlCommand("select * from Person", con);
            SqlCommand com4 = new SqlCommand("select * from Patient", con);
            try
            {
                SqlDataAdapter ada = new SqlDataAdapter();
                SqlDataAdapter ada2 = new SqlDataAdapter();
                ada.SelectCommand = com3;
                ada2.SelectCommand = com4;
                DataTable dtb = new DataTable();
                DataTable dtb2 = new DataTable();
                ada.Fill(dtb);
                ada2.Fill(dtb2);
                dataGridView1.DataSource = dtb;
                dataGridView2.DataSource = dtb2;
                ada.Update(dtb);
                ada2.Update(dtb2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }
    }
}
