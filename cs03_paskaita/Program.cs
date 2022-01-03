using System;

namespace cs03_paskaita
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cs03_PASKAITA");

            #region TEORIJA - Value ir Reference type
            // Trečia paskaita – Duomenų tipai; tipų konversija
            // Value – Reference – Pointer;
            // Value tipo atveju kintamiesiems priskiriama tiesiogiai – int, char, float, bool;
            // Sukuriant value tipo kintamąjį – Sistema išskiria vietą kompiuterio atmintyje;

            // Slankusis kablelis
            // Float turi 7 skaitmenų tikslumą po kablelio;
            float pvz1 = 1;
            double pvz2 = 1;

            var pvz3 = 1;
            var pvz4 = "Labas";
            
            Console.WriteLine(pvz1.GetType()); // <-- Get type funkcija iš esmės tiesiog išspausdina kintamojo tipą;
            Console.WriteLine(pvz2.GetType());
            Console.WriteLine(pvz3.GetType());
            Console.WriteLine(pvz4.GetType());

            // Float turi 7 skaitmenų tikslumą po kablelio;
            var numberFloat = 1f / 3;
            // Double turi 14-15;
            var numberDouble = 1d / 3;

            Console.WriteLine(numberFloat);
            Console.WriteLine(numberDouble);

            // Pinigams yra sukurtas specialus variable – *decimal*, kuris yra 2x didesnis nei double
            // Turi 30 skaičių tikslumą.


            // Char tipai
            // utf-16
            // Tai yra raidinis tipas
            char c = 'c';
            Console.WriteLine(c.GetType());

            // Float'as - naudojamas žaidimų kūrime (nes reikalingas performance);
            // Double - naudojamas ten, kur reikia skaičių su slankiuoju kableliu;
            // Decimal - kaip minėta anksčiau finansams;
            // Integer -naudojamas su sveikais skaičiais;

            Double x = double.MinValue; // <-- atspausdina limitus variable
            Double y = double.MaxValue;
            Console.WriteLine(x); 
            Console.WriteLine(y);

            // byte 0 ... 255; 255+1 = 0;
            // sbyte -127 ... 127; 127 + 1 = error;

            // Reference tipai nelaiko jokių duomenų, turi tik nuorodą į atmintį, kur yra duomenys;
            // Turi tik nuorodą į atmintį, kur yra duomenys;
            // Gali būti kelios nuorodos į tą patį reference;


            // Tipų konversija (casting);
            // implicit, explicit, convert;

            // implicit = numanoma konversija, c# tą daro automatiškai apsaugant tipą;
            // explicit = aiški konversija - konversiją atlieka pats programuotojas, pet funckiją ar operatorių;
            // Convert klasė kaip ir pažįstamas;

            #endregion

            #region TEORIJA - IF, SWITCH
            //// Sąlyginiai sakiniai leidžia pakeisti programos veikimą priklausomai nuo specifinių aplinkybių;
            //int q = 1;
            //int z = 2;

            //if (q > z)
            //{
            //    Console.WriteLine("Q yra didesnis nei Z");
            //};

            //if(!int.TryParse(Console.ReadLine(), out var result)) // <-- result yra naujas kintamasis;
            //{                                                     //     out šiuo atveju kuria naują kintamąjį?
            //    Console.WriteLine(result);                        //     su ! reiškia, kad mes tikimės, kad nepavyks
            //    Environment.Exit(0);
            //}
            //else
            //{
            //    Console.WriteLine("Input not num");               
            //    Environment.Exit(0);
            //}

            //int action = 1;
            //switch (action)
            //{
            //    case 0:
            //        Console.WriteLine("Action == 0");
            //        break;
            //    case 1:
            //        Console.WriteLine("Action == 1");
            //        break;
            //    case 2:
            //        Console.WriteLine("Action == 2");
            //        break;
            //    default:
            //        Console.WriteLine("Default");
            //        break;
            //}

            #endregion

            //Assigment1();
            //Assigment2();
            //Assigment3();
            //Assigment5();
            //Assigment6();
            Assigment7();
            Assigment8_HW();
            Assigment9_HW();

        }

        public static void Assigment1()
        {
            // Parašyti programą, kuri prašo įvesti 3 simbolius ir parodo juos atvirkštine tvarka
            Console.WriteLine("Įvestkite TRIS simbolius: ");
            string string1 = Console.ReadLine();

            Console.WriteLine($"{string1.Substring(2, 1)}{string1.Substring(1, 1)}{string1.Substring(0,1)}");

            char a = Convert.ToChar(string1.Substring(2,1)); // <-- per konversiją;
            char b = Convert.ToChar(string1.Substring(1,1));
            char c = Convert.ToChar(string1.Substring(0,1));
            Console.WriteLine($"{a}{b}{c}");
        }

        public static void Assigment2()
        {
            // Parašyti programą, kuri prašo įvesti atstumą (metrais) ir laiką (sekundėmis), o išveda greitį (km/h), naudoti double
            Console.WriteLine("Įvestkite greitį metrais: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Įvestkite laiką sekundėmis: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"KM/h yra {num1/1000}km/{num2/60/60}h");

            double metPerH = num1 / num2;   // <-- dėstytojo sprendimas;
            double kmh = metPerH * 3.6;     // <-- formulė

            Console.WriteLine(kmh);
        }

        public static void Assigment3()
        {
            // Parašyti programą, kuri prašo įvesti rutulio diametrą, o išveda plotą ir tūrį;
            Console.WriteLine("Įvestkite rutulio diametą: ");
            double num3 = double.Parse(Console.ReadLine());
            double r = num3 / 2;
            double pi = 3.14;

            Console.WriteLine($"Plotas: 4 * π * r² = {4 *  pi * (r*r)} vienetai kvadratu");
            Console.WriteLine($"Tūris: 4/3 * π * r³: = {4 / 3 * pi * (r * r * r)} vienetai kubu");

            Console.WriteLine($"Plotas: 4 * π * r² = {4 * pi * (Math.Pow(r, 2))} vienetai kvadratu");   // <-- su math kėlimu kvardratu
            Console.WriteLine($"Tūris: 4/3 * π * r³: = {4 / 3 * pi * (Math.Pow(r, 3))} vienetai kubu"); //

            double surfaceArea = 4 * Math.PI * Math.Pow(r, 2); // <-- su math kalkuliacijomis
            Console.WriteLine(surfaceArea);                    //
            double volume = 4 / 3 * Math.PI * Math.Pow(r, 3);  //
            Console.WriteLine(volume);                         //
        }

        public static void Assigment4()
        {
            // Parašyti programą, kuri parašo įvesti 2 skaičius. Jeigu abu lyginiai, programa turi išvesti True, jei ne – False;
            Console.WriteLine("Įvestkite du skaičius: ");
            double num4 = double.Parse(Console.ReadLine());
            double num5 = double.Parse(Console.ReadLine());
            var check = num4 % 2 == 0 && num5 % 2 == 0 ? "... abu skaičiai lyginiai" : "... vienas arba abu skaičiai yra nelyginiai";
            Console.WriteLine($"Skaičiai yra {check}");

            Console.WriteLine((num4 % 2 == 0 && num5 % 2 == 0)); // <-- dėstytojo pvz;
        }

        public static void Assigment5()
        {
            Console.WriteLine(new String('1', 1));
            Console.WriteLine(new String('1', 2));
            Console.WriteLine(new String('1', 3));
        }

        public static void Assigment6()
        {
            // Parašyti programą, kuri prašo įvesti vardą ir slaptažodį, po 3 bandymų blokuoja;
            var uName = "username";
            var uPass = "password";
            var uNameInput = Console.ReadLine();
            var uPassInput = Console.ReadLine();

            bool check = uNameInput.Equals(uName) && uPassInput.Equals(uPass);
            int numberOftries = check ? 1 : 0;

            bool check1 = uNameInput.Equals(uName) && uPassInput.Equals(uPass);
            int numberOftries1 = check ? 2 : 0;

            bool check2 = uNameInput.Equals(uName) && uPassInput.Equals(uPass);
            int numberOftries2 = check ? 3 : 0;

            // Bet čia tiesiog su if'u labai paprasta...
        }

        public static void Assigment7()
        {
            // Parašyti programą, kuri paprašo vartotojo įvesti grupės narių skaičių
            // PARASYTI PROGRAMA, KURI PAPRASO
            // VARTOTOJO IVESTI GRUPES NARIU KIEKI.
            // JEI NARIU KIEKIS LYGUS 1 PROGRAMA ISVEDA
            // TAI SOLO ATLIKEJAS", JEI NARIU KIEKIS 2 - „TAI
            // DUETAS", JEI NARIU KIEKIS DAUGIAU NEI 2 BET
            // MAZIAU NEI 10 - „TAI ANSAMBLIS", JEI
            // DAUGIAU NEI 10 - „TAI KAMERINIS ANSAMBLIS".
            // JEI VARTOTOJAS PADARO IVEDIMO KLAIDA -
            // PRANESTI IR UZBAIGTI DARBA

            Console.WriteLine("Vartotojau įveskite grupės narių skaičių");
            var input = Console.ReadLine();
            if(int.TryParse(input, out int inputTP))
            {

                if (inputTP == 1)
                {
                    Console.WriteLine("Tai solo atlikėjas");
                }
                else if (inputTP == 2)
                {
                    Console.WriteLine("Tai yra duetas");
                }
                else if (inputTP > 2 && inputTP < 10)
                {
                    Console.WriteLine("Tai yra ansamblis");
                }
                else if (inputTP >= 10) // <-- neatitinka sąlygos >=, bet whatever;
                {
                    Console.WriteLine("Tai yra kamerinis ansamblis");
                }
                else if (inputTP < 0)
                {
                    Console.WriteLine("Negalima neigiama įvestis");
                }
                else
                {
                    Console.WriteLine("Netinkama įvestis");
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Netinkama įvestis");
            } 
        }

        public static void Assigment8_HW()
        {
            // PARASYTI PROGRAMA, KURI
            // PAPRASO VARTOTOJO IVESTI
            // I§DIRBTAS VALANDAS.
            // JEI VALANDY YA MAZIAU NEI 160,
            // PROGRAMA TURI PARODYTI.KIEK
            // DAR REIKIA ISDIRBTI, JEI LYGIAI 160,
            // PARODO, KAD ISDIRBTAS PILNAS
            // ETATAS.JEI DAUGIAU -PARODO
            // KIEK YA VIRSVALANDZIY.
            // JEI VARTOTOJAS PADARO / VEDIMO
            // KLAIDA - PRANESTI IR UZBAIGTI

            Console.WriteLine("Vartotojau įvesk valandų skaičių");
            var input = Console.ReadLine();
            if (int.TryParse(input, out int inputTP))
            {
                if (inputTP == 160)
                {
                    Console.WriteLine("Išdirbtas pilnas etatas");
                }
                else if(inputTP > 160)
                {
                    Console.WriteLine($"Išdirbtas pilnas, ir {inputTP - 160} viršvalandžių");
                }
                else if (inputTP < 160)
                {
                    Console.WriteLine($"Neišdirbtas pilnas etatas, trūksta {160 - inputTP}");
                }
                else if (inputTP < 0)
                {
                    Console.WriteLine("Netinkama įvestis");
                }
            }
            else
            {
                Console.WriteLine("Netinkama įvestis");
            }
        }

        public static void Assigment9_HW()
        {
            // PARASYTI PROGRAMA, KURI
            // PAPRASO VARTOTOJO IVESTI
            // EGZAMINO PAZYM]. ISVESTI:
            // 0 - 4: NEPATEKINAMAI
            // 5: SILPNAI
            // 6: PATENKINAMAI
            // 7: VIDUTINISKAI
            // 8: GERAI
            // 8: LABAI GERAI
            // 10: PUIKIAI
            // NAUDOTI SWICH ... CASE

            Console.WriteLine("Vartotojau įvesk skaičių: nuo 1 iki 10");
            var input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 0:
                    Console.WriteLine("0 - 4: NEPATEKINAMAI");
                    break;
                case 1:
                    Console.WriteLine("0 - 4: NEPATEKINAMAI");
                    break;
                case 2:
                    Console.WriteLine("0 - 4: NEPATEKINAMAI");
                    break;
                case 3:
                    Console.WriteLine("0 - 4: NEPATEKINAMAI");
                    break;
                case 4:
                    Console.WriteLine("0 - 4: NEPATEKINAMAI");
                    break;
                case 5:
                    Console.WriteLine("5: SILPNAI");
                    break;
                case 6:
                    Console.WriteLine("6: PATENKINAMAI");
                    break;
                case 7:
                    Console.WriteLine("7: VIDUTINISKAI");
                    break;
                case 8:
                    Console.WriteLine("8: GERAI");
                    break;
                case 9:
                    Console.WriteLine("9: LABAI GERAI");
                    break;
                case 10:
                    Console.WriteLine("10: PUIKIAI");
                    break;
            }
        }
    }
}