using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course("CodeAcademy");
            while (true)
            {
                Head:
                Console.WriteLine("1.Yeni qrup yarat ");
                Console.WriteLine("2.Qruplarin Siyahisi");
                Console.WriteLine("3.Qrup uzre duzelis ");
                Console.WriteLine("4.Qrupdaki telebeler siyahisi");
                Console.WriteLine("5.Butun telebelerin siyahisi");
                Console.WriteLine("6.Telebe yarat");
                Console.WriteLine("7.Telebe silmek");
                string men = Console.ReadLine();
                bool isInt = int.TryParse(men, out int menu);
                if (!isInt)
                {
                    Console.WriteLine("Duzgun daxil edilmeyib,Zehmet olmasa duzgun daxil edin");
                    goto Head;
                }
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Qrupun adini daxil edin");
                        string gname = Console.ReadLine();
                        num:
                        Console.WriteLine("Qrupun nomresini daxil edin");
                        string gnum = Console.ReadLine();
                        bool isNum = int.TryParse(gnum, out int num);
                        if (!isNum)
                        {
                            Console.WriteLine("Yanlis daxil edildi,zehmet olmasa yeniden daxil edin");
                            goto num;
                        }
                        foreach (var item in course.groups)
                        {
                            if (item.Number==num)
                            {
                                Console.WriteLine("Bu nomreli qrup movcuddur, yeni nomre daxil edin");
                                goto num;
                            }
                        }
                        Group group = new Group();
                        group.Name = gname;
                        group.Number = num;
                        course.groups.Add(group);
                        Console.WriteLine($"{gname} {num} adli ve nomreli qrup yaradildi maci<3");
                        break;
                    case 2:
                        if (course.groups.Count == 0)
                        {
                            Console.WriteLine("Yaradilmiz qrup yoxdur!");
                            break;
                        }
                        foreach (var item in course.groups)
                        {
                           
                            Console.WriteLine($"qrup nomresi: {item.Number} qrup novu :{item.Name}");
                        }
                        break;
                    case 3:
                        if (course.groups.Count == 0)
                        {
                            Console.WriteLine("Yaradilmiz qrup yoxdur!");
                            break;
                        }
                        foreach (var item in course.groups)
                        {

                            Console.WriteLine($"qrup nomresi: {item.Number} qrup novu :{item.Name}");
                        }
                        Console.WriteLine("Duzelis etmek istediyiniz qrup nomresin daxil edin");
                        numme:
                        string numm=Console.ReadLine();
                        bool isNumm = int.TryParse(numm, out int nume);
                        if (!isNumm)
                        {
                            Console.WriteLine("Yanlis daxil edildi,zehmet olmasa yeniden daxil edin");
                            goto numme;
                        }
                        foreach (var item in course.groups)
                        {
                            if (item.Number==nume)
                            {
                                newnume:
                                Console.WriteLine("Qrupun yeni nomresini daxil edin");
                                string newnum = Console.ReadLine();
                                bool isnewNum = int.TryParse(newnum, out int newn);
                                if (!isnewNum)
                                {
                                    Console.WriteLine("Yanlis daxil edildi,zehmet olmasa yeniden daxil edin");
                                    goto newnume;
                                }
                                foreach (var item1 in course.groups)
                                {
                                    if (newn == item1.Number)
                                    {
                                        Console.WriteLine("Bu nomreli qrup movcuddur ,Yeniden daxil edin");
                                        goto newnume;

                                    }
                                }
                                

                                item.Number = newn;
                                Console.WriteLine("Basariyla deisdirildi");
                            }
                        }
                        break;
                    case 4:
                        if (course.groups.Count == 0)
                        {
                            Console.WriteLine("Yaradilmiz qrup yoxdur!");
                            break;
                        }
                        foreach (var item in course.groups)
                        {

                            Console.WriteLine($"qrup nomresi: {item.Number} ");
                        }
                        Console.WriteLine("Telebelerin gormek istediyiniz qrup nomresin daxil edin");
                        nummme:
                        string numme = Console.ReadLine();
                        bool isNumme = int.TryParse(numme, out int numee);
                        if (!isNumme)
                        {
                            Console.WriteLine("Yanlis daxil edildi,zehmet olmasa yeniden daxil edin");
                            goto nummme;
                        }
                        foreach (var item in course.groups)
                        {
                           
                            if (item.Number==numee)
                            {
                                foreach (var item1 in item.students)
                                {
                                    Console.WriteLine($"{item1.Name} {item1.Surname} {item1.Fathername}");
                                }
                            }
                        }
                        break;
                    case 5:
                        foreach (var item in course.students)
                        {
                            Console.WriteLine($"{item.Name} {item.Surname} {item.Fathername} {item.Zemanet}");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Telebenin adi");
                        string tname = Console.ReadLine();
                        Console.WriteLine("Telebenin soyadi");
                        string tsname = Console.ReadLine();
                        Console.WriteLine("Telebenin ata adi");
                        string fname = Console.ReadLine();
                        Console.WriteLine("Telebenin zemaneti");
                        string zment = Console.ReadLine();
                        foreach (var item in course.groups)
                        {
                            Console.WriteLine($"{item.Number}");
                            nameee:
                            Console.WriteLine("Elave etmek istediyiniz qrup");
                            string adn = Console.ReadLine();
                            bool IsAdd = int.TryParse(adn, out int adnn);
                            if (!IsAdd)
                            {
                                Console.WriteLine("Duzgun daixl edin");
                                goto nameee;
                            }
                            if (item.Number==adnn)
                            {
                                Student student = new Student();
                                student.Name = tname;
                                student.Surname = tsname;
                                student.Fathername = fname;
                                student.Zemanet = zment;
                                course.students.Add(student);
                                item.students.Add(student);
                                Console.WriteLine($"{tname} adli student yaradildi ");
                                
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
