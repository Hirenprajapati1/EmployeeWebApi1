using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using EmployeeWebApi.Models;
using Microsoft.Data.SqlClient;

namespace EmployeeWebApi.Repository
{
    public class EmployeeRepository
    {
        //public bool AddEmployeeData(EmployeeModel st)


        public int AddEmployeeData(EmployeeModel st)
        {
            try
            {
                SqlConnection sc = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = database1; Integrated Security = True; Connect Timeout = 300; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

                SqlCommand cd = new SqlCommand("AddEmployee1", sc);
                cd.CommandType = System.Data.CommandType.StoredProcedure;
                cd.Parameters.AddWithValue("@Name", st.Name);
                cd.Parameters.AddWithValue("@Email", st.Email);
                cd.Parameters.AddWithValue("@EmployeeCode", st.EmployeeCode);
                cd.Parameters.AddWithValue("@Gender", st.Gender);

                cd.Parameters.AddWithValue("@Designation", st.Designation);
                cd.Parameters.AddWithValue("@Department", st.Department);
                cd.Parameters.AddWithValue("@DOB", st.DOB);
                cd.Parameters.AddWithValue("@Salary", st.Salary);
                sc.Open();
                cd.ExecuteNonQuery();
                //bool isExecute = Convert.ToBoolean(cd.ExecuteNonQuery());
                sc.Close();
                //return isExecute;
                return 1;
            }
            catch
            {
                throw;
            }
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //return true;
        }



        public List<EmployeeModel> GetEmployees()
        {
            SqlConnection sc = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = database1; Integrated Security = True; Connect Timeout = 300; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            List<EmployeeModel> s2 = new List<EmployeeModel>();

            SqlDataAdapter sa = new SqlDataAdapter("GetEmployee2", sc);
            DataTable dt = new DataTable();
            sa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sc.Open();
            sa.Fill(dt);
            sc.Close();
            foreach (DataRow dr in dt.Rows)
            {
                s2.Add(
                    new EmployeeModel
                    {
                        ID = Convert.ToInt32(dr["ID"]),
                        Name = Convert.ToString(dr["Name"]),
                        Email = Convert.ToString(dr["Email"]),
                        EmployeeCode = Convert.ToString(dr["EmployeeCode"]),
                        Gender = Convert.ToString(dr["Gender"]),
                        Designation = Convert.ToInt32(dr["Designation"]),
                        DesignationName = Convert.ToString(dr["DesignationName"]),
                        Department = Convert.ToInt32(dr["Department"]),
                        DepartmentName = Convert.ToString(dr["DepartmentName"]),
                        DOB = Convert.ToString(dr["DOB"]),
                        Salary = Convert.ToInt32(dr["Salary"])
                    }
                    );
            }
            return s2;
        }


        public int UpdateEmployeeData(EmployeeModel st)
        {
            try
            {
                SqlConnection sc = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = database1; Integrated Security = True; Connect Timeout = 300; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
                SqlCommand cd = new SqlCommand("UpdateEmployee3", sc);
                cd.CommandType = System.Data.CommandType.StoredProcedure;
                cd.Parameters.AddWithValue("@ID", st.ID);
                cd.Parameters.AddWithValue("@Name", st.Name);
                cd.Parameters.AddWithValue("@Email", st.Email);
                cd.Parameters.AddWithValue("@EmployeeCode", st.EmployeeCode);
                cd.Parameters.AddWithValue("@Gender", st.Gender);
                cd.Parameters.AddWithValue("@Designation", st.Designation);
                cd.Parameters.AddWithValue("@Department", st.Department);
                cd.Parameters.AddWithValue("@DOB", st.DOB);
                cd.Parameters.AddWithValue("@Salary", st.Salary);
                sc.Open();
                //bool isExecute = Convert.ToBoolean(cd.ExecuteNonQuery());
                cd.ExecuteNonQuery();
                sc.Close();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 1;
            //return true;
        }


        public int DeleteEmployeeData(int ID)
        {
            try
            {

                SqlConnection sc = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = database1; Integrated Security = True; Connect Timeout = 300; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
                SqlCommand cd = new SqlCommand("DeleteEmployee", sc);
                cd.CommandType = CommandType.StoredProcedure;
                cd.Parameters.AddWithValue("@id", ID);
                sc.Open();

                //int isExecute = cd.ExecuteNonQuery();
                cd.ExecuteNonQuery();
                sc.Close();
                //if (isExecute > 0)
                //{

                //    return true;
                //}
                //else
                //{
                //    return false;
                //}
            }

            catch (Exception)
            {

                throw;
            }
            return 1;
        }


    }
}
