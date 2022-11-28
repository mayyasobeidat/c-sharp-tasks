using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _27November
{

    class personal
    {
        private int age;
        private string gender;
        private string name;
        private string email;
        private string id;
        private string phone;

        public personal( int myAge , string myGender , string myName , string myEmail , string myId , string myPhone) {

            if (myAge <= 18 || myAge >= 60)
            {
                Console.WriteLine("Your age is outside the allowed range");
                string m = Convert.ToString(age);
                m = "error";

            }

            else
            {
                age = myAge;
            }

            gender = myGender;
            name = myName;  
            email = myEmail;
            id = myId;
            phone = myPhone;    


            string keyNum = myPhone.Substring(0, 3);
            if (keyNum == "077" || keyNum == "078" || keyNum == "079")
            {
                phone = myPhone;

            }
            else 
            {
                Console.WriteLine("The phone number is wrong");
                phone = "error";
            }
        }

        public void PersonalInfo()
        {
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Gender : " + gender);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Email : " + email);
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Phone : " + phone);
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            personal myInfo = new personal(2, "Male", "Mayyas", "mayyasobeidat@gmail.com", "000000000" , "0797383346");
            myInfo.PersonalInfo();
        }
    }
}
