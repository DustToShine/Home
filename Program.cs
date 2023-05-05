using System;

namespace Bank 
{
    
        class bank
        {
            static void Main(string[] args)
            {
            //Program a = new();

            // Create size of array for user
            User[] cust = new User[3];
            int userCount = 0;

            // Bank Name Options
            Console.WriteLine("Select The Option : ");
            Console.WriteLine("[A] HDFC Bank");
            Console.WriteLine("[B] ICI Bank");
            Console.WriteLine("[C] SBI Bank");
            Console.WriteLine("");
            Console.WriteLine("Enter The Option :");
            string option = Console.ReadLine();
            string bname = "";
            switch (option)
            {
                case "A":
                    bname = "HDFC";
                    break;

                case "B":
                    bname = "ICI";
                    break;
                
                case "C":
                    bname = "SBI";
                    break;

                default:
                    Console.WriteLine("Invalid Choice !!");
                    return;
            }

            // User details here
            Console.WriteLine("Enter Username : ");
            string uname = Console.ReadLine();
            Console.WriteLine("");

            User user = new User(uname, bname);
            cust[userCount] = user;
            userCount++;

            // Display Account Details

            Console.WriteLine("Account Created");
            Console.WriteLine("User Name : " + user.Uname);
            Console.WriteLine("Bank Name  : " + user.Bname);

            // Random bid
            Random num = new Random();
            int bid = num.Next();
            Console.WriteLine("Bank id : " + bid);
            Console.WriteLine("Date & Time : " + user.Date);

            // Options here
            Console.WriteLine("");
            Console.WriteLine("Select the option : ");
            //Console.WriteLine("[a]. display the Details");
            Console.WriteLine("[a]. Edit Username");
            Console.WriteLine("[b]. Delete");
            Console.WriteLine("[c]. Exit");
            string dis = Console.ReadLine();

            switch (dis)
            {
                //case "a":
                //    Console.WriteLine("Username is : {0}", uname);
                //    Console.WriteLine("Bank ID is : {0}", bid);
                //    Console.WriteLine("Date and Time is : {0}", Date);
                //    break;

                case "a":
                    Console.WriteLine("Current Username is : " + user.Uname);
                    Console.WriteLine("Enter New Username : ");
                    string re_name = Console.ReadLine();

                    //---------------Error --------------
                    //user.Uname(re_name);
                    Console.WriteLine("New Username : " + user.Uname);
                    break;

                case "b":
                    for (int i = 0; i < userCount; i++)
                    {
                        if (cust[i].Uname == user.Uname)
                        {
                            for (int j = i; j < userCount; j++)
                            {
                                cust[j] = cust[j + 1];
                            }
                            cust[userCount - 1] = null;
                            userCount--;
                            Console.WriteLine("Account Delete");
                            break;
                        }
                    }
                    break;
                case "c":
                    return;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;

            }

            //string Uname = "";
                //string Bname = "";
                //if (option == "A" || option == "a")
                //{
                //    string Bname = "HDFC Bank";
                //    Console.WriteLine("Bank Name : {0}", Bname);
                //}
                //else if (option == "B" || option == "b")
                //{
                //    string Bname = "ICI Bank";
                //    Console.WriteLine("Bank Name : {0}", Bname);
                //}
                //else if (option == "C" || option == "c")
                //{
                //    string Bname = "SBI Bank";
                //    Console.WriteLine("Bank Name : {0}", Bname);
                //}
                //else
                //{
                //    return;
                //}
                //DateTime date = new DateTime.Now;
                //DateTime Date = DateTime.Now;
                //Console.WriteLine();
                //Console.WriteLine("Date and Time is : {0}", Date);
                //Console.WriteLine();
            }
        }
    class User
    {
        private string uname;
        private string bname;
        private int bid;
        private DateTime date;

        public User(string uname, string bname)
        {
            this.bname = bname;
            this.uname = uname;
            this.bid = bid;
            this.date = DateTime.Now;

        }
        //---Error----------
        public string Uname 
        { 
            get { return this.uname; }
            set { this.uname = value; }
        }
        public string Bname
        {
            get { return bname; }
            set { this.bname = value; }
        }
        public int Bid
        {
            get { return bid; }
            set { this.bid = value; }
        //Random num = new Random();
        //int bid = num.Next();

    }
        public DateTime Date
        {
            get { return date; }
        }

        //public string Cre_bid
        //{
        //    get {; }
        //}


    }
}