using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            string id, name, street1, street2, city, area, pincode, email, contactNumber, linkURL, slack, facebook, twitter, newId;
            int emp, horDev, n, flag = 0;


            Employee e = new Hr();
            List<Employee> list = new List<Employee>();
            Console.WriteLine("enter the no of employee inputs you want to make");
            emp = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < emp; i++)
            {
                Console.WriteLine("what type of employee enter 1 for hr and 2 for developer");
                horDev = Convert.ToInt32(Console.ReadLine());
                switch (horDev)
                {
                    case 1: Console.WriteLine("enter the id");
                        id = Console.ReadLine();
                        Console.WriteLine("enter the name");
                        name = Console.ReadLine();
                        Console.WriteLine("enter the street1");
                        street1 = Console.ReadLine();
                        Console.WriteLine("enter the street2");
                        street2 = Console.ReadLine();
                        Console.WriteLine("enter the city");
                        city = Console.ReadLine();
                        Console.WriteLine("enter the area");
                        area = Console.ReadLine();
                        Console.WriteLine("enter the pincode");
                        pincode = Console.ReadLine();
                        Console.WriteLine("enter the email");
                        email = Console.ReadLine();
                        Console.WriteLine("enter the contact no");
                        contactNumber = Console.ReadLine();
                        Console.WriteLine("enter the linked in url");
                        linkURL = Console.ReadLine();
                        Hr p = new Hr();

                       
                         Console.WriteLine("do you want to update any entry if yes type 1 else type 2");
                    int update = Convert.ToInt32(Console.ReadLine());
                    if (update == 1)
                    {
                        Console.WriteLine("which entry do you want to change\n if id type1\nif name type 2\nif street1type3");
                        int entryupdat = Convert.ToInt32(Console.ReadLine());
                        switch (entryupdat)
                        {
                            case 1:
                                Console.WriteLine("enter the new id");
                                string updateId = Console.ReadLine();
                                e.id = updateId;
                                list.Add(p.Register(e.id, name, street1, street2, city, area, pincode, email, contactNumber, linkURL));
                                break;
                            case 2: Console.WriteLine("enter the new name");
                                string updateName = Console.ReadLine();
                                e.name = updateName;
                                list.Add(p.Register(id, e.name, street1, street2, city, area, pincode, email, contactNumber, linkURL));
                                break;
                            case 3: Console.WriteLine("enter the new street 1");
                                string updateStreet1 = Console.ReadLine();
                                e.street1 = updateStreet1;
                                list.Add(p.Register(id, name, e.street1, street2, city, area, pincode, email, contactNumber, linkURL));
                                break;

                        }

                    } list.Add(p.Register(id, name, street1, street2, city, area, pincode, email, contactNumber, linkURL));

                        Console.WriteLine("do you want to display anyones details If yes type 1 else type 2");
                        int y = Convert.ToInt32(Console.ReadLine());
                        if (y == 1)
                        {
                            Console.WriteLine("enter the id of the employee whose details you want");
                            newId = Console.ReadLine();
                            e = p.display(newId, list);

                        }
                        else
                        {
                            continue;
                        }
                        break;

                    case 2: Console.WriteLine("enter the id");
                        id = Console.ReadLine();
                        Console.WriteLine("enter the name");
                        name = Console.ReadLine();
                        Console.WriteLine("enter the street1");
                        street1 = Console.ReadLine();
                        Console.WriteLine("enter the street2");
                        street2 = Console.ReadLine();
                        Console.WriteLine("enter the city");
                        city = Console.ReadLine();
                        Console.WriteLine("enter the area");
                        area = Console.ReadLine();
                        Console.WriteLine("enter the pincode");
                        pincode = Console.ReadLine();
                        Console.WriteLine("enter the slack account ");
                        slack = Console.ReadLine();
                        Console.WriteLine("enter the facebook pages");
                        facebook = Console.ReadLine();
                        Console.WriteLine("enter the twitter pages");
                        twitter = Console.ReadLine();
                        
                      
                         Console.WriteLine("do you want to update any entry if yes type 1 else type 2");
                    int updated = Convert.ToInt32(Console.ReadLine());
                    Developer d = new Developer(id, name, street1, street2, city, area, pincode, slack, facebook, twitter);

                    if (updated == 1)
                    {
                        Console.WriteLine("which entry do you want to change\n if id type1\nif name type 2\nif street1type3");
                        int entryupdated = Convert.ToInt32(Console.ReadLine());
                        switch (entryupdated)
                        {
                            case 1:
                                 Console.WriteLine("enter the new id");
                                string updatedId = Console.ReadLine();
                                d.id = updatedId;
                                d.Register(list,d);
                                break;
                            case 2: Console.WriteLine("enter the new name");
                                string updatedName = Console.ReadLine();
                                d.name = updatedName;
                                d.Register(list,d);
                                break;
                            case 3: Console.WriteLine("enter the new street 1");
                                string updatedStreet1 = Console.ReadLine();
                                d.street1 = updatedStreet1;
                                d.Register(list,d);
                                break;

                        }

                    }

                        d.Register(list, d);
                        Console.WriteLine("do you want to display anyones details If yes type 1 else type 2");
                        int x = Convert.ToInt32(Console.ReadLine());
                        if (x == 1)
                        {
                            Console.WriteLine("enter the id of the employement whose details you want");
                            newId = Console.ReadLine();
                            e = d.display(newId, list);
                        }
                        else { continue; }
                        break;
                }



                    
                    Console.WriteLine("{0}", e.id);
                    Console.WriteLine(e.name);
                    Console.WriteLine(e.street1);
                    Console.WriteLine(e.street2);
                    Console.WriteLine(e.city);
                    Console.WriteLine(e.area);
                    Console.WriteLine(e.pincode);

                    Hr h = e as Hr;

                    if (h != null)
                    {
                        Console.WriteLine(((Hr)e).email);
                        Console.WriteLine(((Hr)e).contactNumber);
                        Console.WriteLine(((Hr)e).linkURL);
                        Console.ReadKey();
                    }

                    Developer developer = e as Developer;
                    if (developer != null)
                    {
                        Console.WriteLine(((Developer)e).dslack);
                        Console.WriteLine(((Developer)e).dfacebook);
                        Console.WriteLine(((Developer)e).dtwitter);
                    }
                   

               

            }
            


            Console.ReadKey();
        }
    }
    public class Employee
    {
        public string id, name, street1, street2, city, area, pincode;


    }


    public class Hr : Employee
    {
        public string email, contactNumber, linkURL;

        List<Employee> a1 = new List<Employee>();
        public Employee Register(string id, string name, string street1, string street2, string city, string area, string pincode, string email, string contactNumber, string linkURL)
        {


            Hr p = new Hr();

            p.id = id;

            p.name = name;
            p.city = city;
            p.street1 = street1;
            p.street2 = street2;
            p.area = area;
            p.pincode = pincode;
            p.email = email;
            p.contactNumber = contactNumber;
            p.linkURL = linkURL;
            return p;
            //a1.Add(p);


        }
        public void Register()
        {
            Console.WriteLine("");
        }
        public Employee display(string newId, List<Employee> list)
        {
            foreach (Employee e in list)
            {
                if (newId == e.id)
                {
                    return e;
                }
            }
            return new Employee();
        }
        ~Hr()
        {

        }
    }
    public class Developer : Employee
    {
        public string did, dname, dstreet1, dstreet2, dcity, darea, dpincode, dslack, dfacebook, dtwitter;
        List<Employee> a1 = new List<Employee>();

        public Developer()
        {
        }
        public Developer(string id, string name, string street1, string street2, string city, string area, string pincode, string slack, string facebook, string twitter)
        {
            did = id;
            dname = name;
            dstreet1 = street1;
            dstreet2 = street2;
            dcity = city;
            darea = area;
            dpincode = pincode;
            dslack = slack;
            dfacebook = facebook;
            dtwitter = twitter;

        }
        public void Register(List<Employee> list, Developer d1)
        {
            d1.id = did;

            d1.name = dname;
            d1.city = dcity;
            d1.street1 = dstreet1;
            d1.street2 = dstreet2;
            d1.area = darea;
            d1.pincode = dpincode;
            d1.dslack = dslack;
            d1.dfacebook = dfacebook;
            d1.dtwitter = dtwitter;
            list.Add(d1);
        }
        public void Register(Employee e1,string id, string name, string street1, string street2, string city, string area, string pincode, string email, string contactNumber, string linkURL)
        {
           
        }
        public Employee display(string newId,List<Employee> list)
        {
            foreach (Employee e in list)
            {
                if (e.id == newId)
                {
                    return e;
                }

            } 
            return new Employee();
        }
        ~Developer()
        {

        }
    }

}

