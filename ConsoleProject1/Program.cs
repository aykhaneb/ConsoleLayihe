using ConsoleApp11;
using ConsoleProject.Models;
using ConsoleProject1.Managers;
using System;

namespace ConsoleProject
{
    //Console practise task
    //Kinoteatr
    //Models: Teatr,Zal,Seans,Bilet,Kino
    //Melumatlar static ve ya dinamic daxil edile biler.Secim sizindir.
    //-Evvelce zallar daxil edilir(adi, sira ve cergelerin sayi)
    //-Sonra teatr haqqinda umumi melumatlar daxil edilir.(adi, hansi zallardan ibaretdir)
    //-Daha sonra ise seans melumatlari daxil edilir.(hansi zalda, hansi vaxtlarda, hansi filmler gosterilecek)

    //Ferz edin ki kimse gelir bilet almaga
    //-Seanslara baxir
    //-Hansi seansi secse hemin seansdaki bos ve dolu yerleri gore bileceyi bir melumat cixir ekrana(ancaq bos yer sece bilir)
    //-bos yeri secdikden sonra hemin yer artiq dolu kimi isaretlenir.
    //-ve ona bilet hazirlanir
    // Seans melumatlarini daxil edin
    //int row=int.Parse(Console.Readline());
    //int column=int.Parse(Console.Readline());
    /*if (states[row-1,column-1]==State.)
  {
        states[row-1,column-1]==State.Full;
}*/
    class Program
    {
        static void Main(string[] args)
        {

            SeansManager seansmanager = new SeansManager();
            CinemaManager cinemaManager = new CinemaManager();
            //ZalManager zalManager = new ZalManager();
            string command = "";

            do
            {
                Console.Write("Enter the command:");
                command = Console.ReadLine();


                if (command.ToLower().Equals("add cinema"))
                {
                    var zal1 = new Zal
                    {
                        Id = 1,
                        Name = "Titan",
                        Seats = new int[10, 10]
                    };
                    var zal2 = new Zal
                    {
                        Id = 2,
                        Name = "Jupiter",
                        Seats = new int[15, 15]
                    };
                    var zal3 = new Zal
                    {
                        Id = 3,
                        Name = "SkyBox",
                        Seats = new int[4, 4]
                    };
                    Zal[] zals = { zal1, zal2, zal3 };

                    var cinema1 = new Cinema
                    {
                        Id = 1,
                        Name = "Deniz Mall",
                        Zals = zals

                    };
                    var cinema2 = new Cinema
                    {
                        Id = 2,
                        Name = "28 Mall",

                    }; var cinema3 = new Cinema
                    {
                        Id = 3,
                        Name = "Genclik Mall",

                    }; var cinema4 = new Cinema
                    {
                        Id = 4,
                        Name = "Nizami",

                    }; var cinema5 = new Cinema
                    {

                        Id = 5,
                        Name = "ParkCinema",

                    };
                    cinemaManager.Add(cinema1);
                    cinemaManager.Add(cinema2);
                    cinemaManager.Add(cinema3);
                    cinemaManager.Add(cinema4);
                    cinemaManager.Add(cinema5);
                }
                if (command.ToLower().Equals("print cinema"))
                {
                    cinemaManager.Print();
                }
                else if (command.ToLower().Equals("add seans"))
                {
                    var seans1 = new Seans { Id = 1, film = new Film { Name = "Spiderman" }, zal = new Zal { Id = 1, Name = "Titan" }, StartingTime = DateTime.Now };
                    var seans2 = new Seans { Id = 2, film = new Film { Name = "Titanic" }, zal = new Zal { Id = 2, Name = "Jupiter" }, StartingTime = DateTime.Now };
                    var seans3 = new Seans { Id = 3, film = new Film { Name = "The Notebook" }, zal = new Zal { Id = 3, Name = "Mars" }, StartingTime = DateTime.UtcNow };
                    var seans4 = new Seans { Id = 4, film = new Film { Name = "Avatar" }, zal = new Zal { Id = 4, Name = "Venera" }, StartingTime = DateTime.Now };
                    var seans5 = new Seans { Id = 5, film = new Film { Name = "Sherlock Holmes" }, zal = new Zal { Id = 5, Name = "Saturn" }, StartingTime = DateTime.UtcNow };
                    seansmanager.Add(seans1);
                    seansmanager.Add(seans2);
                    seansmanager.Add(seans3);
                    seansmanager.Add(seans4);
                    seansmanager.Add(seans5);
                }
                else if (command.ToLower().Equals("print seans"))
                {
                    seansmanager.Print();
                }
                else if (command.ToLower().Equals("delete seans"))
                {
                    Console.Write("Enter the id:");
                    var id = int.Parse(Console.ReadLine());
                    seansmanager.Delete(id);
                }
                else if (command.ToLower().Equals("choose seans"))
                {
                    Console.Write("Enter the Id:");
                    var id = int.Parse(Console.ReadLine());
                    var existSeans = seansmanager.Get(id);
                    if (existSeans == null)
                        continue;
                    Console.WriteLine(existSeans);
                }
                else if (command.ToLower().Equals("choose cinema"))
                {
                    Console.Write("Enter the Id:");
                    var id = int.Parse(Console.ReadLine());
                    var existCinema = cinemaManager.Get(id);
                    if (existCinema == null)
                        continue;
                    Console.WriteLine(existCinema);
                }
                else if (command.ToLower().Equals("show seats"))
                {
                    Zal.Arr();
                }

                else if (command.ToLower().Equals("show ticket"))
                {                }

                else if (command.ToLower().Equals("choose seats"))
                {
                    int n = int.Parse(Console.ReadLine());                    int m = int.Parse(Console.ReadLine());                    int[,] buySeat = new int[n, m];

                    //for (int i = 0; i < za; i++)
                    //{
                    //    for (int i = 0; i < length; i++)
                    //    {

                    //    }
                    //}
                }


            } while (command.ToLower() != "quit");
        }
    }
}



