using System;
using System.ComponentModel;
using System.Globalization;

namespace VP_mid_paper
{



    abstract class Society
    {
        static public void printwithDelay(string text, int delay = 10)
        {

            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine("\n");
        }
        public Society(string n, string cont)
        {
            list_activities = new List<string>();
            name = n;
            contact = cont;
        }

        public virtual void add_funds(int funds) { }







        public List<string> list_activities = new List<string>();
        public string? name { get; set; }
        public string? contact { get; set; }
        public void add_activity(string val)
        {
            list_activities.Add(val);
        }
        //void register_event()
        //{

        //    printwithDelay(""
        //}



        public void list_events()
        {
            printwithDelay("Printing all events of society ...\n");
            foreach (var activity in list_activities)
            {

                printwithDelay(activity);



            }


        }



        public virtual void display()
        {
            printwithDelay("Displaying All Society Details!\n");
            Console.WriteLine("Society Name: ", name);
            Console.WriteLine("Society Contact: ", contact);
            printwithDelay("Printing all events of Society \n");
            list_events();

        }










    }
    class FundedSociety : Society
    {

        //public FundedSociety():base() {

        //}

        private double fundingAmount;
        public override void add_funds(int funds)
        {
            fundingAmount = funds;
        }
        double get_amount()
        {
            return fundingAmount;
        }
        void set_fund(double d)
        {
            fundingAmount = d;
        }

        public FundedSociety(string n, string c) : base(n, c)
        {
            fundingAmount = 0;
        }

        public override void display()
        {
            printwithDelay("Displaying All Society Details!\n");
            Console.WriteLine("Society Name: ", name);
            Console.WriteLine("Society Contact: ", contact);
            Console.WriteLine("Society Funds: ", fundingAmount);
            printwithDelay("Printing all events of Society \n");
            list_events();

        }




    }
    class NonFundedSociety : Society
    {

        public NonFundedSociety(string n, string c) : base(n, c)
        {
        }


        public override void display()
        {
            printwithDelay("Displaying All Society Details!\n");
            Console.WriteLine("Society Name: ", name);
            Console.WriteLine("Society Contact: ", contact);
            printwithDelay("Printing all events of Society \n");
            list_events();

        }



    }
    enum Roles
    {
        president,
        vicePresident,
        generalSecretary,
        financeSecretary,
    }
    class ClubRole
    {
        private string name;
        private string role;
        private string contactInfo;
        static public void printwithDelay(string text, int delay = 10)
        {

            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.Write("\n");
        }


        public string get_name()
        {
            return name;
        }
        public void set_name(string val)
        {
            name = val;
        }
        public string get_role()
        {
            return role;
        }
        public void set_role(string val)
        {
            role = val;
        }
        public string get_contactinfo()
        {
            return contactInfo;
        }
        public void set_contactinfo(string val)
        {
            contactInfo = val;
        }

        public void Get_values()
        {
            printwithDelay("<====Enter Details===> ");
            printwithDelay("Enter Name: ");
            string? buffer = Console.ReadLine();
            if (buffer == null)
            {
                Get_values();
            }
            else
            {
                name = buffer;
                Console.Write("Enter Contact: ");
                buffer = Console.ReadLine();
                contactInfo = buffer;
                //printwithDelay("Enter Role:  \n");
                //buffer = Console.ReadLine();
                //if (buffer == null)
                //{
                //    printwithDelay("Role cannot be null! \n Enter All values again! \n");
                //    Get_values();
                //}
                //else
                //{
                //    role = buffer;
                //    if (role == null || role != "President"  || role != "Vice President" || role != "General Secretary" || role != "Finance Secretary")
                //    { 
                //        printwithDelay("Entered Role Do not match available one \nEnter Values again!\n");
                //        Get_values();
                //        }
                //    else
                //    {
                //        role = buffer;
                //    }

                //}





            }

        }








    }

    class StudentClub
    {
        private double budget { get; set; }
        private ClubRole? president;
        private ClubRole? vice_president;
        private ClubRole? generalSecretary;
        private ClubRole? financeSecretary;





        static public void printwithDelay(string text, int delay = 10)
        {

            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.Write("\n");

        }
        //   public void 
        public void initialize()
        {
            printwithDelay("First Enter Some values for ClubRoles! \nFor President");
            president = new ClubRole();
            president.set_role("President");
            president.Get_values();
            printwithDelay("\nFor Vice President");
            vice_president = new ClubRole();
            vice_president.set_role("Vice President");
            vice_president.Get_values();
            generalSecretary = new ClubRole();
            printwithDelay("\nFor General Secretary");
            generalSecretary.Get_values();
            financeSecretary = new ClubRole();
            printwithDelay("\nFor Finance Secretary");
            financeSecretary.Get_values();
        }
        public List<Society> list_society = new List<Society>();
        public StudentClub()
        {
            List<Society> list_society = new List<Society>();
            president = new ClubRole();
            vice_president = new ClubRole();
            generalSecretary = new ClubRole();
            financeSecretary = new ClubRole();
            budget = 0.0;

        }
        public void add_funds(string n, String f)
        {


            foreach (var s in list_society)
            {
                if (s.name == n)
                {

                    //                    s.add_funds();

                    return;

                }



            }
            printwithDelay("Society Not Found! ...\n");



        }

        public void register_event(string n, string e)
        {


            foreach (var s in list_society)
            {
                if (s.name == n)
                {
                    s.list_activities.Add(e);
                    //                    s.add_funds();

                    return;

                }



            }
            printwithDelay("Society Not Found! ...\n");



        }








        public void dispenseFunds(string n, int del)
        {


        }
        public void registerSociety()
        {
            printwithDelay("Choose option\n 1. Funded Society\n2.NonFunded Society \n");
            int buff = Convert.ToInt32(Console.ReadLine());
            if (buff == null)
            {
                registerSociety();
            }
            else
            {

                if (buff == 1)
                {
                    printwithDelay("Enter Name: ");
                    String? buffer = Console.ReadLine();
                    string name = buffer;
                    printwithDelay("Enter Contact Info: ");
                    buffer = Console.ReadLine();
                    string contact = buffer;
                    FundedSociety newSociety = new FundedSociety(name, contact);
                    printwithDelay("Enter Funds of Society");
                    buffer = Console.ReadLine();
                    int s = Convert.ToInt32(buffer);
                    newSociety.add_funds(s);
                    list_society.Add(newSociety);
                }
                else if (buff == 2)
                {
                    printwithDelay("Enter Name: ");
                    String? buffer = Console.ReadLine();
                    string name = buffer;
                    printwithDelay("Enter Contact Info: ");
                    buffer = Console.ReadLine();
                    string contact = buffer;
                    NonFundedSociety newnonfundedSociety = new NonFundedSociety(name, contact);

                    list_society.Add(newnonfundedSociety);
                }
                // else { registerSociety(); }

            }
        }
        public void display_society(string s)
        {
            foreach (var k in list_society)
            {
                if (k.name == s)
                {
                    k.display();

                    return;

                }



            }
            printwithDelay("Society Not Found! ...\n");






        }




        public void displaySocieties()
        {
            printwithDelay("Printing all Societies Currently in StudentClub! ...\n");
            foreach (var s in list_society)
            {
                s.display();
                return;
            }

            printwithDelay("Displayed All Societies! \n");
        }


        public void display_events(string k)
        {

            foreach (var a in list_society)
            {
                if (a.name == k)
                {
                    a.display();


                    return;

                }



            }
            printwithDelay("Society Not Found! ...\n");






        }



    }












    internal class Program
    {

        static public void printwithDelay(string text, int delay = 10)
        {

            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.Write("\n");
        }







        static void menu()
        {
            Console.Clear();
            printwithDelay("\n\n\tSTUDENT CLUB MANAGEMENT SYSTEM ");
            printwithDelay("-------------------------------------------------");
            printwithDelay("1. Register a New Society ");
            printwithDelay("2. Allocate Funding to Societies ");
            printwithDelay("3. Register an Event for a Society ");
            printwithDelay("4. Display Society Funding Information ");
            printwithDelay("5. Display Event for a Society ");
            printwithDelay("6  Exit ");

        }
        static StudentClub University_Std = new StudentClub();

        static public void run_code()
        {
            menu();
            printwithDelay("\nEnter Option: ");
            string? option = Console.ReadLine();
            if (option == null)
            {
                printwithDelay("Error!\n Invalid Option! ...\n");

            }
            else
            {
                switch (option)
                {
                    case "1":
                        University_Std.registerSociety();
                        run_code();
                        break;
                    case "2":
                        printwithDelay("Enter Name of Society ");
                        string? name = Console.ReadLine();
                        string? funds = Console.ReadLine();
                        University_Std.add_funds(name, funds);
                        run_code();
                        break;
                    case "3":
                        printwithDelay("Enter Name of Society ");
                        string? n = Console.ReadLine();
                        printwithDelay("Enter Event Detail: \n");
                        string? e = Console.ReadLine();
                        run_code();


                        break;
                    case "4":
                        printwithDelay("Enter Name of Society ");
                        string? i = Console.ReadLine();
                        if (i != null)
                        {
                            University_Std.display_society(i);
                        }
                        else
                        {
                            printwithDelay("Invalid Input! \n");

                        }
                        break;
                    case "5":
                        printwithDelay("Enter Name of Society ");
                        string? j = Console.ReadLine();
                        if (j != null)
                        {
                            University_Std.display_events(j);
                        }
                        else
                        {
                            printwithDelay("Invalid Input! \n");

                        }

                        run_code();



                        break;
                    case "6":
                        return;


                    default:
                        printwithDelay("Invalid Option Provided! \nProgram exiting!");
                        break;


                }
                return;



            }
        }



        static void Main(string[] args)
        {
            University_Std.initialize();
            run_code();



        }
    
        }
    }


