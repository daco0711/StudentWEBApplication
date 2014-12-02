using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationStudent
{
    public partial class _Default : System.Web.UI.Page
    {
       
        
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

        protected void updateStudent(Object sender, EventArgs e)
        {
            String studentName = txtUpdIme.Text;
            String indexNumber = txtUpdIndexNumber.Text;
            String city = txtUpdCity.Text;
            String address = txtUpdAddress.Text;
            String jmbg = txtUpdJMBG.Text;
            String sex = txtUpdsex.Text;
            String datumRodj = txtUpdDatum.Text;
            String studentID = txtUpdID.Text;


            DateTime datumRodje = DateTime.Now;
            if (datumRodj != "" && studentID != "")
            {
                try
                {
                    datumRodje = Convert.ToDateTime(datumRodj);
                    Int32 studeID = Convert.ToInt32(studentID);
                    client.updateStudent(studeID, studentName, indexNumber, city, address, jmbg, sex, datumRodje);
                }
                catch (Exception exc)
                {
                    statusLbl.Text = exc.Message;
                }
            }
            }
        
        protected void addStudent(Object sender, EventArgs e)
        {

            String studentName = txtDodajIme.Text;
            String indexNumber = txtBrIndexa.Text;
            String city = txtCity.Text;
            String address = txtDodajAdresu.Text;
            String jmbg = txtJmbg.Text;
            String sex = txtDodajSex.Text;
            String datum = txtDatum.Text;

            txtDodajIme.Text = "";
            txtBrIndexa.Text = "";
            txtCity.Text = "";
            txtDodajAdresu.Text = "";
            txtJmbg.Text = "";
            txtDodajSex.Text = "";
            txtDatum.Text = "";

            DateTime datumRodj = DateTime.Now;
            if (datum != "")
            {
                 datumRodj = Convert.ToDateTime(datum);
            }
            

            try
            {
                client.addStudent(studentName, indexNumber, city, address, jmbg, sex,datumRodj);

            }
            catch (Exception ex)
            {
                statusLbl.Text = ex.Message;
                return;
            }
            statusLbl.Text = studentName;
        }
        
            protected void getStudentById(object sender,EventArgs e)
            {
                String studentID = txtSearch.Text;
                txtSearch.Text = "";

                    if(!studentID.Equals("")){
                        try{
                            Int32 stID = Convert.ToInt32(studentID);
                            ServiceReference1.Student student = client.getStudentById(stID);
                            if (student !=null)
                               
                            {
                                IDTabele.Rows.Clear();
                                TableRow row = createRowInTable(student);
                                IDTabele.Rows.Add(row);
                            }
                        }catch (FormatException fe){
                        }
                    }
            }

            protected void delStudents(object sender, EventArgs e)
            {

                String studID = txtDel.Text;
                txtDel.Text = "";
                if (!studID.Equals(""))
                {
                    Int32 stID = Convert.ToInt32(studID);
                    client.deleteStudent(stID);
                }
            }


        

        private static TableRow createRowInTable(ServiceReference1.Student student)
        {
            TableRow row = new TableRow();
            TableCell cellName = new TableCell();
            TableCell cellJMBG = new TableCell();
            TableCell cellId = new TableCell();
            TableCell cellIndexNumber = new TableCell();
            TableCell cellCity = new TableCell();
            TableCell cellAddress = new TableCell();
            TableCell cellSex = new TableCell();
            TableCell cellDatum = new TableCell();

            cellName.Text = student.StudentName;
            cellJMBG.Text = student.Jmbg;
            cellId.Text = student.StudentId.ToString();
            cellIndexNumber.Text = student.IndexNumber;
            cellCity.Text = student.City;
            cellAddress.Text = student.Address;
            cellSex.Text = student.Sex;
            cellDatum.Text = student.BirthDate.ToString();

            row.Cells.Add(cellName);
            row.Cells.Add(cellJMBG);
            row.Cells.Add(cellId);
            row.Cells.Add(cellIndexNumber);
            row.Cells.Add(cellCity);
            row.Cells.Add(cellAddress);
            row.Cells.Add(cellSex);
            row.Cells.Add(cellDatum);

            return row;

        }
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference1.Student[] students = client.getStudents();
            List<ServiceReference1.Student> studentList = new List<ServiceReference1.Student>(students);
            int studentCount = studentList.Capacity;
            LblCount.Text = studentCount.ToString();

            foreach (ServiceReference1.Student student in studentList)
            {
                TableRow row = new TableRow();
                TableCell cellName = new TableCell();
                TableCell cellJMBG = new TableCell();
                TableCell cellId = new TableCell();
                TableCell cellIndexNumber = new TableCell();
                TableCell cellCity = new TableCell();
                TableCell cellAddress = new TableCell();
                TableCell cellSex = new TableCell();
                TableCell cellDatum = new TableCell();

                cellName.Text = student.StudentName;
                cellJMBG.Text = student.Jmbg;
                cellId.Text = student.StudentId.ToString();
                cellIndexNumber.Text = student.IndexNumber;
                cellCity.Text = student.City;
                cellAddress.Text = student.Address;
                cellSex.Text = student.Sex;
                cellDatum.Text = student.BirthDate.ToString();

                row.Controls.Add(cellName);
                row.Controls.Add(cellJMBG);
                row.Controls.Add(cellId);
                row.Controls.Add(cellIndexNumber);
                row.Controls.Add(cellCity);
                row.Controls.Add(cellAddress);
                row.Controls.Add(cellSex);
                row.Controls.Add(cellDatum);

                IDTabele.Rows.Add(row);

            }




        }
    }
}
