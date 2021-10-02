using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_2
{
    enum Menu
    {
        Login = 1, Register //กำหนดลำดับของเมนู
    }
   

    class Program
    {
        static void Main(string[] args)
        {           
            PrintMenuScreen();
        }

        static void PrintMenuScreen()
        {
            Console.Clear();
            PrintHeader();
            PrintListMenu();
            InputMenuFromKeyboard();
        }
        static void PrintHeader()
        {
            Console.WriteLine("Welcome to Digital Library");
            Console.WriteLine("--------------------------");
        }

        static void PrintListMenu() //แสดงเมนูหลัก
        {
            Console.WriteLine("1.Login");
            Console.WriteLine("2.Register");            
        }

        static void InputMenuFromKeyboard() //รับค่าเมนู
        {
            Console.Write("Select Menu :");
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));

            PresentMenu(menu);
        }

        static void PresentMenu(Menu menu) //แยกว่าจะloginหรือregister
        {
            if (menu == Menu.Login)
            {
                ShowInputLogin();
            }
            else if (menu == Menu.Register)
            {
                ShowInputRegister();
            }
        }

        static void ShowInputLogin() //แสดงการloginของนักศึกษาและพนักงาน
        {
            Console.Clear();
            PrintLogin();
            int InputType;
            Console.Write("Input User Type 1 = Student, 2 = Employee : ");
            InputType = int.Parse(Console.ReadLine());
            InputName();
            InputPassword();


            if (InputType == 1)
            {
                StudentManage();
            }
            else if (InputType == 2)
            {
                EmployeeMenu();
            }
        }

        static void ShowInputRegister()
        {
            Console.Clear();
            PrintHeaderRegister();
            
            int InputType;            
            Console.Write("Input User Type 1 = Student, 2 = Employee : ");
            InputType = int.Parse(Console.ReadLine());

            if (InputType == 1)
            {
                CreateNewStudent();
            }
            else if (InputType == 2)
            {
                CreateNewEmployee();
            }

            PrintMenuScreen();

        }

        static void PrintLogin()
        {
            Console.Clear();
            Console.WriteLine("Login Screen");
            Console.WriteLine("-------------------");
        }

        static void PrintHeaderRegister()
        {
            Console.Clear();
            Console.WriteLine("Register new Person");
            Console.WriteLine("-------------------");
        }
        
        static string InputName() //รับค่าชื่อ
        {
            Console.Write("Input name :");
            return Console.ReadLine();
        }

        static string InputPassword() //รับค่ารหัสผ่าน
        {
            Console.Write("Input Password : ");
            return Console.ReadLine();
        }

        static string InputUserType() //รับค่าประเภทบุคคล
        {
            Console.Write("Input User Type 1 = Student, 2 = Employee :");
            return Console.ReadLine();
        }

        static string InputStudentID() //รับค่ารหัสนักศึกษา
        {
            Console.Write("StudentID :");
            return Console.ReadLine();
        }

        static string InputEmployeeID() //รับค่ารหัสพนักงาน
        {
            Console.Write("EmployeeID :");
            return Console.ReadLine();
        }

        static Student CreateNewStudent() //สร้างนักเรียนใหม่
        {
            return new Student(InputName(), InputPassword(), InputUserType(), InputStudentID());
        }

        static Employee CreateNewEmployee() //สร้างพนักงานใหม่
        {
            return new Employee(InputName(), InputPassword(), InputUserType(), InputEmployeeID());
        }

        static void EmployeeMenu()
        {
            Console.Clear();
            Console.WriteLine("Employee Management");
            Console.WriteLine("-------------------");

            InputName();
            InputEmployeeID();
            Console.WriteLine("-------------------");

            GetListBook();
            InputBookListFormKeyboard();
            
        }

        static void GetListBook()
        {
            Console.Clear();
            Console.WriteLine("Get List Book");
            BookList();
            InputBookListFormKeyboard();
            
        }

        static void InputBookListFormKeyboard()
        {
            
            int BookList;
            Console.Write("Input Menu :");
            BookList = int.Parse(Console.ReadLine());

            if (BookList == 1)
            {
                Console.WriteLine("Book ID: 1\nBook name: NOW I UNDERSTAND");
            }
            else if (BookList == 2)
            {
                Console.WriteLine("Book ID: 2\nBook name: REVOLUTIONARY WEALTH");
            }
            else if (BookList == 3)
            {
                Console.WriteLine("Book ID: 3\nBook name: Six Degrees");
            }
            else if (BookList == 4)
            {
                Console.WriteLine("Book ID: 4\nBook name: Les Vacances");
            }
            
        }

        static void PrintBookListEmployee()
        {
            Console.Clear();
            Console.WriteLine("Book List");
            Console.WriteLine("-------------------");
        }

        static void StudentManage()
        {
            Console.Clear();
            Console.WriteLine("Student Management");
            Console.WriteLine("-------------------");

            InputName();
            InputStudentID();
            Console.WriteLine("-------------------");

            BorrowBook();
            InputBorrowBookListFormKeyboard();
            PresentBorrorBook();
        }

        static void BorrowBook()
        {
            Console.Clear();
            Console.WriteLine("1.Borrow Book");

        }

        static void InputBorrowBookListFormKeyboard() //ลำดับหนังสือตามIDต่างๆ
        {
            
            int BorrowBook;
            Console.Write("Input Menu :");
            BorrowBook = int.Parse(Console.ReadLine());

            if (BorrowBook == 1)
            {
                Console.WriteLine("Book ID: 1\nBook name: NOW I UNDERSTAND");
            }
            else if (BorrowBook == 2)
            {
                Console.WriteLine("Book ID: 2\nBook name: REVOLUTIONARY WEALTH");
            }
            else if (BorrowBook == 3)
            {
                Console.WriteLine("Book ID: 3\nBook name: Six Degrees");
            }
            else if (BorrowBook == 4)
            {
                Console.WriteLine("Book ID: 4\nBook name: Les Vacances");
            }
        }

        static void PresentBorrorBook() //กรอกข้อมูลหนังสือที่จะยืม
        {
            Console.Clear();
            PrintBookListEmployee();
            BookList();
            InputBookIDFormKeyboard();

        }

        static void InputBookIDFormKeyboard() //แสดงหนังสือที่เลือก
        {
            
            int bookID;
            Console.Write("Input Book ID :");
            bookID = int.Parse(Console.ReadLine());

            if (bookID == 1)
            {
                Console.WriteLine("Book ID: 1\nBook name: NOW I UNDERSTAND");
            }
            else if (bookID == 2)
            {
                Console.WriteLine("Book ID: 2\nBook name: REVOLUTIONARY WEALTH");
            }
            else if (bookID == 3)
            {
                Console.WriteLine("Book ID: 3\nBook name: Six Degrees");
            }
            else if (bookID == 4)
            {
                Console.WriteLine("Book ID: 4\nBook name: Les Vacances");
            }

            BookList();
            InputExitFromKeyboard();

        }

        static void InputExitFromKeyboard() //inputได้เรื่อยๆจนกว่าจะกรอกexit
        {
            
            string text = "";
            while (text != "exit")
            {                
                Console.Write("Book ID :");                
                text = Console.ReadLine();
                if (text == "1")
                {
                    Console.WriteLine("Book ID: 1\nBook name: NOW I UNDERSTAND");
                }
                else if (text == "2")
                {
                    Console.WriteLine("Book ID: 2\nBook name: REVOLUTIONARY WEALTH");
                }
                else if (text == "3")
                {
                    Console.WriteLine("Book ID: 3\nBook name: Six Degrees");
                }
                else if (text == "4")
                {
                    Console.WriteLine("Book ID: 4\nBook name: Les Vacances");
                }
               

            }

            Console.Clear();
            PrintMenuScreen();
        }

        static void BookList() //แสดงหนังสือทั้งหมด
        {            
            Console.WriteLine("Book ID: 1\nBook name: NOW I UNDERSTAND");                      
            Console.WriteLine("Book ID: 2\nBook name: REVOLUTIONARY WEALTH");            
            Console.WriteLine("Book ID: 3\nBook name: Six Degrees");
            Console.WriteLine("Book ID: 4\nBook name: Les Vacances");
        }

    }

    class Person //กำหนดตัวแปรต่างๆPerson
    {
        protected string name;
        protected string password;
        protected string userType;

        public Person(string name, string password, string userType)
        {
            this.name = name;
            this.password = password;
            this.userType = userType;
        }

        public string GetName()
        {
            return this.name;
        }

        public string GetPassword()
        {
            return this.password;
        }

        public string GetUserType()
        {
            return this.userType;
        }
    }

    class PersonList
    {
        private List<Person> personList;

        public PersonList()
        {
            this.personList = new List<Person>();
        }

        public void AddNewPerson(Person person)
        {
            this.personList.Add(person);
        }

        public void FetchPersonsList()
        {
            foreach (Person person in this.personList)
            {
                if (person is Student)
                {
                    Console.WriteLine("Input Name : {0} \nInput Password : {1}", person.GetName(), person.GetPassword());
                }
                else if (person is Employee)
                {
                    Console.WriteLine("Input Name : {0} \nInput Password : {1}", person.GetName(), person.GetPassword());
                }
            }
        }
    }
    class Student:Person //สืบทอดคลาสPerson
    {
        private string studentID;

        public Student(string name, string password, string userType, string studentID):base(name, password, userType)
        {
            this.studentID = studentID;
        }

    }

    class Employee : Person //สืบทอดคลาสPerson
    {
        private string employeeID;

        public Employee(string name, string password, string userType, string employeeID) : base(name, password, userType)
        {
            this.employeeID = employeeID;
        }        

    }



}
