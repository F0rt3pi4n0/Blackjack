using System;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Witaj w Blackjack'u!");
            Console.WriteLine("Wciśnij dowolny przycisk, aby kontynuować");
            Console.ReadKey();
            Console.WriteLine();
            Opcje:
            Console.WriteLine("Co chcesz zrobić ? Wpisz jedną z podanych cyfr:");
            Console.WriteLine("1 - Zagraj w Blackjack'a !");
            Console.WriteLine("2 - Poznaj zasady Blackjacka'a.");
            Console.WriteLine("3 - O autorze");
            Console.WriteLine("0 - Wyjście");
        
        Console.ForegroundColor = ConsoleColor.Green;
        
        Blad:

            int a = Spraw();


            switch (a)
            {
                case 1:
                    Gra:
                    Console.WriteLine("Zaczynamy grę !");
                    Console.WriteLine();
                    int gr = Gracz();

                    Console.WriteLine("\n");
                                    
                    int wyg = 0;
                    if(gr > 21)
                    {
                        wyg = 4;
                    }
                    else
                    {
                        int kr = Krupier(gr);
                        wyg = Ktow(gr, kr);
                    }
                   
                    if(wyg == 1)
                    {
                        Console.WriteLine("GRACZ wygrał !");
                    }
                    else if(wyg == 2)
                    {
                        Console.WriteLine("KRUPIER wygrał !");
                    }
                    else if(wyg == 3)
                    {
                        Console.WriteLine("REMIS !");
                    }
                    else if(wyg == 4)
                    {
                        Console.WriteLine("GRACZ przegrał !");
                    }
                    else
                    {
                        Console.WriteLine($"Błąd ! { wyg }");
                    }
                    

                    Console.WriteLine("Wciśnij dowolny klawisz, aby kontynuować");
                    Console.ReadKey();

                    Console.WriteLine("Co chcesz robić dalej ?");
                    Console.WriteLine("1 - Graj dalej !");
                    Console.WriteLine("2 - Wróć na początek");
                    Console.WriteLine("3 - Wyjście");

                    Bok:
                    int cd = Spraw();
                    switch (cd)
                    {
                        case 1:
                            goto Gra;
                        case 2:
                            goto Opcje;
                        case 3:
                            goto Wyj;
                        default:
                            Console.WriteLine("Błędna wartość ! Wprowadź właściwą liczbę !");
                            goto Bok;
                    }

                case 2:
                    Console.WriteLine("Zasady Blackjacka!");
                    Console.WriteLine("Oto one: ");
                    Console.WriteLine("Głównym celem gry jest uzbieranie sumy punktów z kart jak najbliższej lub równej 21");
                    Console.WriteLine("- Karty od dwójki do dziesiątki mają wartość równą numerowi karty");
                    Console.WriteLine("- Walet, dama i król mają wartość równą 10 punktów");
                    Console.WriteLine("- As ma wartość równą 1 lub 11, w zależności od decyzji gracza.");
                    Console.WriteLine("Możesz dobrać kartę lub spasować");
                    Console.WriteLine("\nAle przedewszystkim, dobrze się bawić ! :)");

                    Console.WriteLine();
                    Console.WriteLine("Wciśnij dowolny klawisz, aby kontynuować");
                    Console.ReadKey();

                    Console.WriteLine("Co chcesz robić dalej ?");
                    Console.WriteLine("1 - Wróć na początek");
                    Console.WriteLine("2 - Wyjdź");

                    Bok2:
                    cd = Spraw();                   
                    switch (cd)
                    {
                        case 1:
                            goto Opcje;
                        case 2:
                            goto Wyj;
                        default:
                            Console.WriteLine("Błędna wartość ! Wprowadź właściwą liczbę !");
                            goto Bok2;
                    }


                case 3:
                    Console.WriteLine("O autorze:");
                    Console.WriteLine("F0rt3pi4n0");
                    Console.WriteLine();
                    Console.WriteLine("Wciśnij dowolny klawisz, aby kontynuować");
                    Console.ReadKey();

                    Console.WriteLine("Co chcesz robić dalej ?");
                    Console.WriteLine("1 - Wróć na początek");
                    Console.WriteLine("2 - Wyjdź");

                    Bok3:
                    cd = Spraw();
                    switch (cd)
                    {
                        case 1:
                            goto Opcje;
                        case 2:
                            goto Wyj;
                        default:
                            Console.WriteLine("Błędna wartość ! Wprowadź właściwą liczbę !");
                            goto Bok3;
                    }

                case 0:
                    Wyj:
                    Console.WriteLine("Na pewno chcesz wyjść?");
                    Console.WriteLine("T / N");

                    string wyjscie = Tani().ToLower();
                    Console.WriteLine();
                    if( wyjscie == "t" )
                    {
                        Console.WriteLine("Powodzenia następnym razem !");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Zdecyduj się ! !");
                        Console.WriteLine("Wciśnij dowolny klawisz, aby kontynuować");
                        Console.ReadKey();
                        goto Opcje;
                    }
                default:
                    Console.WriteLine("Błędna wartość ! Wprowadź właściwą liczbę !");
                    goto Blad;
              
            }
        }
        static int Gracz()
        {
            int[] wartosci = new int[11] { 1,2,3,4,5,6,7,8,9,10,11 };
            string[] kolor = new string[4] { "Karo", "Trefl", "Pik", "Kier" };
            string[] figura = new string[3] { "WALET","DAMA","KRÓL" };

            int ile = 0;
            int[] kartyg = new int[1];
            string[] kolorg = new string[1];
            int[] czyfig = new int[1];
            Random rnd = new Random();

            int liczba = rnd.Next(2,11);
            int klr = rnd.Next(4);
            int fig = rnd.Next(4);
            int suma = 0;
            string wybor;

            
            Console.WriteLine("Zaczynamy ? (t / n)");
            wybor = Tani().ToLower();
            if ( wybor == "n" )
            {
                goto Koniec;
            }
            else
            {
                while (wybor == "t" && suma < 21)
                {
                    if (liczba >= 10 || liczba == 1)
                    {
                        if (liczba == 10)
                        {
                            if (fig < 3)
                            {
                                Console.WriteLine($"{ figura[fig] } { kolor[klr] } ");
                                czyfig[ile] = fig;
                            }
                            else
                            {
                                Console.WriteLine($"{ liczba } { kolor[klr] } ");
                            }
                            suma = suma + liczba;
                            Console.WriteLine($"Twoja suma to: { suma }");
                            kartyg[ile] = liczba;
                            kolorg[ile] = kolor[klr]; 
                            
                            if (suma == 21)
                            {
                                
                                break;
                            }
                            else if(suma > 21)
                            {
                                
                                break;
                            }
                            Console.WriteLine("Grasz dalej ? (t / n)");
                            wybor = Tani().ToLower();
                            if ( wybor == "n" )
                            {
                                break;
                            }    

                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Wylosowałeś Asa ! ");
                            Console.WriteLine("Który jest wartości 1 czy 11 ?");
                            As:
                            liczba = Spraw();
                            if(liczba != 11 && liczba != 1 )
                            {
                                Console.WriteLine("Wartość musi wynosić 1 lub 11 !");
                                goto As;
                            }
                            Console.WriteLine($"AS { kolor[klr] }");
                            czyfig[ile] = 3;
                            suma = suma + liczba;
                            Console.WriteLine($"Twoja suma to: { suma }");
                            kartyg[ile] = liczba;
                            kolorg[ile] = kolor[klr];                           
                            if (suma == 21)
                            {
                                
                                break;
                            }
                            else if (suma > 21)
                            {
                                
                                break;
                            }
                            Console.WriteLine("Grasz dalej ? (t / n)");
                            wybor = Tani().ToLower();
                            if ( wybor == "n" )
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{ liczba } { kolor[klr] }");
                        czyfig[ile] = 4;
                        suma = suma + liczba;
                        Console.WriteLine($"Twoja suma to: { suma }");
                        kartyg[ile] = liczba;
                        kolorg[ile] = kolor[klr];               
                        if(suma == 21)
                        {
                            
                            break;
                        }
                        else if (suma > 21)
                        {
                            
                            break;
                        }
                        Console.WriteLine("Grasz dalej ? (t / n)");
                        wybor = Tani().ToLower();
                        if ( wybor == "n" )
                        {
                            break;
                        }
                    }

                    Array.Resize(ref kartyg, kartyg.Length + 1);
                    Array.Resize(ref kolorg, kolorg.Length + 1);
                    Array.Resize(ref czyfig, czyfig.Length + 1);
                    liczba = rnd.Next(1, 11);
                    
                    int sprw = klr;


                    
                    klr = rnd.Next(4);
                    fig = rnd.Next(3);
                    

                    while(sprw == klr)
                    { 
                        if (sprw == klr)
                        {
                            klr = rnd.Next(4);

                        }

                    }

                    ile++;



                }
            }
            Console.WriteLine("Twoje karty to: \n");
            for(int kif = 0;kif<kartyg.Length;kif++)
            {
                if(czyfig[kif] == 4)
                {
                    Console.WriteLine($"{ kartyg[kif] } { kolorg[kif] }, ");
                }
                else if(czyfig[kif] == 3)
                {
                    Console.WriteLine($"AS { kolorg[kif] }, ");
                }
                else if(czyfig[kif] < 3)
                {
                    Console.WriteLine($"{ figura[czyfig[kif]] } { kolorg[kif] }, ");
                }



                
            }
            Console.WriteLine($"Razem { kartyg.Length } kart");
            Console.WriteLine($"Ich suma to { suma }");

            Koniec:
            return suma;

            


            
        }

        static int Krupier(int a)
        {
            int[] wartosci = new int[11] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            string[] kolor = new string[4] { "Karo", "Trefl", "Pik", "Kier" };
            string[] figura = new string[3] { "WALET", "DAMA", "KRÓL" };

            int ile = 0;
            int[] kartyg = new int[1];
            string[] kolorg = new string[1];
            int[] czyfig = new int[1];
            Random rnd = new Random();

            int liczba = rnd.Next(2, 11);
            int klr = rnd.Next(4);
            int fig = rnd.Next(4);
            int suma = 0;


            Console.WriteLine("Krupier dopiera karty");
            
                while (suma <= 21)
                {
                    if (liczba >= 10 || liczba == 1)
                    {
                        if (liczba == 10)
                        {
                            if (fig < 3)
                            {
                               
                                czyfig[ile] = fig;
                            }
                            else
                            {
                                continue;
                            }
                            suma = suma + liczba;
                            kartyg[ile] = liczba;
                            kolorg[ile] = kolor[klr];

                            if (suma == 21)
                            {
                                
                                break;
                            }
                            else if (suma > 21)
                            {
                                
                                break;
                            }
                            
                            

                        }
                        else
                        {
                            if(a > suma + 11 && suma + 11 <= 21 )
                            {
                                suma = suma + 11;
                            }
                            else
                            {
                                suma++;
                            }

                            czyfig[ile] = 3;
                                                        
                            kartyg[ile] = liczba;
                            kolorg[ile] = kolor[klr];
                            if (suma == 21)
                            {
                                
                                break;
                            }
                            else if (suma > 21)
                            {
                                
                                break;
                            }                                                       
                        }
                    }
                    else
                    {
                        
                        czyfig[ile] = 4;
                        suma = suma + liczba;
                        kartyg[ile] = liczba;
                        kolorg[ile] = kolor[klr];
                        if (suma == 21)
                        {
                            
                            break;
                        }
                        else if (suma > 21)
                        {
                            
                            break;
                        }
                       
                        
                    }

                    Array.Resize(ref kartyg, kartyg.Length + 1);
                    Array.Resize(ref kolorg, kolorg.Length + 1);
                    Array.Resize(ref czyfig, czyfig.Length + 1);
                    liczba = rnd.Next(1, 11);

                    int sprw = klr;



                    klr = rnd.Next(4);
                    fig = rnd.Next(3);


                    while (sprw == klr)
                    {
                        if (sprw == klr)
                        {
                            klr = rnd.Next(4);

                        }

                    }

                    ile++;

                    if(suma > a && suma <= 21)
                    {
                        break;
                    }
                }
            
            Console.WriteLine("Karty krupiera to: \n");
            for (int kif = 0; kif < kartyg.Length; kif++)
            {
                if (czyfig[kif] == 4)
                {
                    Console.WriteLine($"{ kartyg[kif] } { kolorg[kif] }, ");
                }
                else if (czyfig[kif] == 3)
                {
                    Console.WriteLine($"AS { kolorg[kif] }, ");
                }
                else if (czyfig[kif] < 3)
                {
                    Console.WriteLine($"{ figura[czyfig[kif]] } { kolorg[kif] }, ");
                }




            }
            Console.WriteLine($"Razem { kartyg.Length } kart");
            Console.WriteLine($"Ich suma to { suma }");

            return suma;
        }

        static int Ktow(int a, int b)
        {
            int wygrana = 0;
            while (wygrana == 0)
            {
                if (a > 21)
                {
                    wygrana = 2;
                }
                else if (a < 21)
                {
                    if (a < b && b >= 21)
                    {
                        if (b > 21)
                        {
                            wygrana = 1;
                        }
                        else
                        {
                            wygrana = 2;
                        }
                    }
                    else if (b > a)
                    {
                        wygrana = 2;
                    }
                    else
                    {
                        wygrana = 1;
                    }
                }
                else if (a == 21)
                {
                    if (b == 21)
                    {
                        wygrana = 3;
                    }
                    else
                    {
                        wygrana = 1;
                    }
                }
            }
            
            
            return wygrana;
        }

        static int Spraw()
        {
            
            Start:
            var check = Console.ReadLine();

            int wyb;
            bool prfa = int.TryParse(check, out wyb);

            if (prfa)
            {
                return wyb;
            }
            else
            {
                Console.WriteLine("Zła wartość !!! Wprowadź prawidłową: ");
                goto Start;
            }
        }
        
        static string Tani()
        {
           
            Start:
            var name = Console.ReadLine();
            int wyb;
            bool parseSuccess = int.TryParse(name, out wyb);


            if (parseSuccess)
            {
                Console.WriteLine(" Wpisz t lub n ");
                goto Start;
            }
            else if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine(" Wpisz t lub n ");
                goto Start;

            }
            else
            {
                if (name != "t" && name != "n")
                {
                    Console.WriteLine(" Wpisz t lub n ");
                    goto Start;
                }

            }
            return name;
        }
        
    }
}