using System.ComponentModel.Design;

namespace city_simulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //inne
            int ekwipunek = 0;
            //stan postaci
            int glod = 75, szczescie = 50, zmeczenie = 0, dzien = 0, nair = 100;
            //pętle
            bool flaga = true, flaga2 = true, flaga3 = true;
            //przedmioty
            bool auto = false, worek = false, noz = false, chleb = false, banan = false;
            //prace
            bool robotnik = false, zlodziej = false, mechanik = false;
            //wybory
            string wybor, wybor2, wybor3, kod;
            //menu główne
            while (flaga3)
            {
                Console.WriteLine($"Dzień {dzien}. Co chcesz zrobić? \n G-Rozpocznij Grę \n O-Opis \n K-Kody \n W-Wyjście Z Gry");
                wybor = Console.ReadLine();
                //gra
                if (wybor.ToUpper() == "G")
                {
                    while (flaga)
                    {
                        Console.Clear();
                        Console.WriteLine($"Dzień {dzien}. \n witamy w Afryce twój stan konta to {nair}, głód {glod}%, szczęście {szczescie}% a zmeczenie {zmeczenie}%");
                        Console.WriteLine("wybierz gdzie chcesz iść \n eq-ekwipunek \n S-Sklep(10) \n Sp-Szukaj pracy(20) \n Za-zakup domu(25) \n G-Giełda aut(15) \n Z-znajomi(15) \n zzz-idź spać(+75) \n End-zakończenie gry(0) \n Help-Pomoc(0) \n ?-port(0) \n Exit-Powrót do menu głównego(gra nie ma zapisu! jedynie kody które odblokowujesz za postęp w grze)");
                        wybor2 = Console.ReadLine();
                        //pomoc
                        if (wybor2 == "Help")
                        {
                            Console.Clear();
                            Console.WriteLine("Witaj w pomocy City Simulator wytłumaczymy tobie jak działa gra. \n Sklep-w nim możesz w nim kupić różne rzeczy np. chleb(+10 do głodu) banany(+5 do głodu i +5 do szczęścia) worek do bananów(chwilowo nie działa ale jak będzie działać będzie przechowywać banany) \n nóż('nie działa' jeśli ktoś ciebie zaatakuję możesz się obronić) \n Szukaj pracy-W szukaj pracy możesz jak nazwa wskazuję znaleźć prace np. robotnik(zarabia 75₦ ale podczas spania traci -20% z spania), mechanik(zarabia 100₦ ale podczas spania traci 30% z spania) i jeszcze jest złodziej który zarabia 130 ale jest 30% że zostaniesz złapany przez policje, podczas spania tracisz 10% z spania \n");
                            Console.WriteLine("By wrócić z powrotem do gry kliknij dowolny przycisk");
                            Console.ReadKey();
                        }
                        //sklep
                        else if (wybor2.ToUpper() == "S")
                        {
                            flaga2 = true;
                            while (flaga2)
                            {
                                Console.Clear();
                                Console.WriteLine($"twój stan konta:{nair}");
                                Console.WriteLine("co chciałbyś kupić? \nC-Chleb(10) \nB-Banany(15) \nW-worek(1niedziała00) \nN-nóż(ni5ed0ziała) \n???-...(9de s999999)"); //jeszcze debilu nie wymyśliłeś co to ten ... ale może być helikopter co cie wyjebał z afryki do america ez
                                Console.WriteLine("jeśli jednak nie chcesz nic kupić lub już kupiłeś co chciałeś napisz Exit");
                                wybor3 = Console.ReadLine();
                                //chleb
                                if (wybor3.ToUpper() == "C")
                                {
                                    if (nair > 9 & ekwipunek < 3)
                                    {
                                        ekwipunek += 1;
                                        nair -= 10;
                                        chleb = true;
                                        Console.WriteLine("Pomyślnie zakupiłeś chleb");
                                        Console.WriteLine("aby przejść dalej kliknij dowolny przycisk");
                                        Console.ReadKey();
                                    }
                                    else
                                        Console.WriteLine("nie masz wystarczająco środków");
                                }
                                //banan
                                else if (wybor3.ToUpper() == "B")
                                {
                                    if (nair > 14 & ekwipunek < 3)
                                    {
                                        ekwipunek += 1;
                                        nair -= 15;
                                        banan = true;
                                        Console.WriteLine("banan został pomyślnie zakupiony");
                                        Console.WriteLine("aby przejść dalej kliknij dowolny przycisk");
                                        Console.ReadKey();
                                    }
                                    else
                                        Console.WriteLine("nie masz wystarczająco środków");
                                }
                                else if (wybor3 == "Exit")
                                {
                                    flaga2 = false;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}