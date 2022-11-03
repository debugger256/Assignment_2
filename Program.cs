using System.Xml.Linq;
using System.Collections;

namespace Assignment_2
{
    public delegate String StudentDetails(String name );
    public delegate int StudentDetail(int Id);
    public class Program
    {

        string address;
        static string getStudentName(String Name)
        {

            return Name;
           // Console.WriteLine("Student name is : "+Name);
          
        }

        static int getStudentId(int Id)
        {
            return Id;
            //Console.WriteLine("Student Id is: "+Id);
        }



        public string StudentAddress
        {
            get { 
                return address; 
            }
            set
            {
                address = value;
            }
        }



        #region Collections 

        

        #endregion
        static void Main(string[] args)
        {
            String name1 = "joel";
            int id = 22;
            String studId = Convert.ToString(id);

            StudentDetails sd = new StudentDetails(getStudentName);
            Console.WriteLine(sd(name1));
         
            StudentDetail sd1 = new StudentDetail(getStudentId);
            Console.WriteLine(sd1(id));

            Program p = new Program();
            p.StudentAddress = "Mutungo";
            Console.WriteLine("The students address is: " + p.StudentAddress);

            Dictionary<String , String> objdictionary = new Dictionary<String, string>();
            objdictionary.Add("Name",name1);
            objdictionary.Add("Student id", studId);
            objdictionary.Add("Address", p.StudentAddress);
            ICollection oc = objdictionary.Keys;

            foreach (String job in oc)
            {
                Console.WriteLine(job +"  "+ objdictionary[job]);
            }

        }
    }
}