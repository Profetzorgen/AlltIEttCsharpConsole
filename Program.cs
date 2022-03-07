// Alla övningar ifrån Marcus Näslunds Programmering.Net i en enda meny!
// Av: Matti Heinonen
using SamlingsBlahaAllaÖvningar;
bool programmetKörs = true;
List<User> users = new List<User>();
while (programmetKörs)
{
    Console.Clear();
    Skriv("Välkommen till Alla Övningar Programmering.Net Fördjupning!" +
    "\nHär lägger jag till allt från denna kurs i ett överskådligt menyformat!" +
    "\n 1. Klasser intro, Rektangel" +
    "\n 2. Klasser intro, Kvadrat" +
    "\n 3. Klasser intro, Cirkel" +
    "\n 4. Klasser intro, Bilen (Utökad med lista och väljare!)" +
    "\n 5. Miniräknare för + - * / (Utökad)" +
    "\n 6. User / Admin / Password" +
    "\n 7." +
    "\n 8." +
    "\n 9." +
    "\n 10. AVSLUTA");
    Int32.TryParse(Console.ReadLine(), out int menyVal);
    switch (menyVal)
    {
        case 1: GeometriGenerator(1);
            break;
        case 2: GeometriGenerator(2);
            break;
        case 3: GeometriGenerator(3);
            break;
        case 4: BilHantering();
            break;
        case 5: Miniräknare();
            break;
        case 6: SkapaEnUser();
            break;
        case 7:
            break;
        case 8:
            break;
        case 9:
            break;
        case 10: Environment.Exit(0);
            break;
        default: Skriv("Gratulerar! Du lyckades på något sätt aktivera Default i Switchen.");
            break;
    }
    void Skriv(string input)
    {
        Console.WriteLine(input);
    }
    void GeometriGenerator(int valAvForm)
    {
        switch (valAvForm)
        {
            case 1:
                Skriv("Du vill skapa en Rektangel, välj bredd (int) dvs heltal: ");
                Int32.TryParse(Console.ReadLine(), out int br);
                Skriv(" och Höjd?: ");
                Int32.TryParse(Console.ReadLine(), out int hö);
                Rektangel r = new Rektangel(br,hö);
                Skriv(r.ToString());
                break;
            case 2:
                Skriv("Du vill skapa en Kvadrat, välj sidans storlek (int): ");
                Int32.TryParse(Console.ReadLine(), out int sida);
                Kvadrat k = new Kvadrat(sida);
                Skriv(k.ToString());
                break;
            case 3:
                Skriv("Du vill skapa en Cirkel, välj Radie (double)");
                Double.TryParse(Console.ReadLine(), out double rad);
                Cirkel cirkel = new Cirkel(rad);
                Skriv(cirkel.ToString());
                break;
        }
        Console.ReadLine();
    }
    void ListaBilarna(List<Bil> bilLista)
    {
        Skriv("\n\t\t Lista över bilar: ");
        foreach (Bil b in bilLista)
        {
            Skriv(b.ToString());
        }
    }
    void BilHantering()
    {
        int bilNummer = 1;
        List<Bil> bilLista = new List<Bil>();
        bool bilHantering = true;
        while (bilHantering)
        {
            Console.Clear();
            ListaBilarna(bilLista);
            Skriv("\n Här skapar du bilar och ger dem ett namn plus en Acceleration mellan 1 och 100" +
                "\n 1. Skapa en bil." +
                "\n 2. Gasa eller bromsa " +
                "\n 3. Avsluta bil-övningen ");
            Int32.TryParse(Console.ReadLine(), out int bilMeny);
            switch (bilMeny)
            {
                case 1:
                    Skriv("Du skapar en bil, vad heter den?");
                    string bilNamn = Console.ReadLine();
                    Skriv("Bil skapad vid namn: " + bilNamn + " \n mata in en acceleration mellan 1 och 100");
                    Double.TryParse(Console.ReadLine(), out double acc);
                    Bil bil = new Bil(acc,bilNamn,bilNummer);
                    bilLista.Add(bil);
                    Skriv("Lade till en bil i listan!");
                    bilNummer++;
                    break;
                case 2:
                    Skriv("\n Välj en bil ur listan överst i konsollen med dess bilNr: ");
                    Int32.TryParse(Console.ReadLine(), out int bilVäljaren);
                    
                    for (int i = 0; i < bilLista.Count; i++)
                    {
                        if(bilVäljaren == bilLista[i].ListNr())
                        {
                            Skriv("\n Du har valt: " + bilLista[i].BilNamn().ToString());
                            Skriv("\n Gasa = 1 och ENTER.");
                            Skriv("\n Bromsa = 2 och ENTER.");
                            Int32.TryParse(Console.ReadLine(), out int köra);
                            if(köra == 1) { bilLista[i].Gasa(); break; }
                            else if(köra == 2) { bilLista[i].Bromsa(); break; }
                            else { Skriv("Välj 1 eller 2 för Gasa eller Bromsa!."); }
                        }
                    }
                    break;
                case 3:
                    Skriv("Återgår till huvudmenyn.");
                    Thread.Sleep(1000);
                    bilHantering = false;
                    break;
                default: Skriv("Du har lyckats mata in något knas eftersom du utlöste Default i switchen.");
                    break;
            }
            Console.ReadKey();
        }
    }
    void Miniräknare()
    {
        Miniräknare räknare = new Miniräknare();
        //räknare.PrintaVersion();
        bool räknaPå = true;

        while (räknaPå)
        {
            Console.Clear();
            Skriv("Här kan du räkna ut 2 tal med gånger, delat, plus eller minus." +
                "\n 1. Räkna" +
                "\n 2. Printa Historik" +
                "\n 3. Printa miniräknarens version" +
                "\n 4. Avsluta räknaren och återgå till huvudmenyn");
            Int32.TryParse(Console.ReadLine(), out int menyVal);
            switch (menyVal)
            {
                case 1:
                    Console.WriteLine("Tal 1: ");
                    räknare.NyttTal(Console.ReadLine());
                    Console.WriteLine("Operator: ");
                    räknare.NyOperator(Console.ReadLine());
                    Console.WriteLine("Tal 2: ");
                    räknare.NyttTal(Console.ReadLine());
                    räknare.RäknaUt(); //////////////////////////////////// räkna
                    Console.WriteLine("Resultat:");
                    Console.WriteLine(räknare.Resultat);
                    break;
                case 2: räknare.PrintaHistorik();
                    break;
                case 3:
                    räknare.PrintaVersion();
                    break;
                case 4:
                    Skriv("Miniräknaren avslutas och du återgår till huvudmenyn");
                    räknaPå = false;
                    break;
                default:Skriv("Du lyckades aktivera default, gratulerar.");
                    break;
            }
            Console.ReadKey();
            räknare.PrintaHistorik();
        }
    }
    void SkapaEnUser()
    {
        Console.Clear();
        bool skapa = true;
        while (skapa)
        {
            Skriv("Här skapar du en användare, ger den ett namn, samt ett lösenord och bestämmer om den är en admin!");
            Skriv("\n 1. Skapa användare" +
                  "\n 2. Hantera användare" +
                  "\n 3. Avsluta");
            Int32.TryParse(Console.ReadLine(), out int skapaAnvVal);
            switch (skapaAnvVal)
            {
                case 1: Create(); break;
                case 2: HanteraAnvändare(); break;
                case 3: Skriv("Avslutar och återgår till huvudmenyn"); skapa = false; break;
            }
        }
    }
    void HanteraAnvändare()
    {
        
        bool hanteraAnvändare = true;
        Console.Clear();
        while (hanteraAnvändare)
        {
            Skriv("\n Här hanterar du användare, lösen och om de är admins" +
                  "\n 1. Skriv ut användarlistan." +
                  "\n 2. Byt lösenord" +
                  "\n 3. Återgå.");
            Int32.TryParse(Console.ReadLine(), out int anvVal);
            switch (anvVal)
            {
                case 1:
                    Console.Clear();
                    foreach (User u in users)
                    { Skriv(u.ToString());}
                    break;
                case 2:
                    Console.Clear();
                    Skriv("**** BYTER LÖSENORD ****");
                    foreach (User u in users)
                    {
                        Skriv(u.ToString());
                    }
                    Skriv("Välj användaren genom att skriva in numret längs till höger om användaren.");
                    Int32.TryParse(Console.ReadLine(), out int användarNr);
                    for (int i = 0; i < users.Count; i++)
                    {
                        if(i == användarNr-1)
                        {
                            Skriv("Du har valt användare: " + users[i].UserName +
                                "\n Skriv in det gamla lösenordet: ") ;
                            string gammaltLösenInput = Console.ReadLine();
                            string nyttLösenInput = Console.ReadLine();
                            users[i].ChangePassword(nyttLösenInput,gammaltLösenInput);
                        }
                    }
                    break;
                case 3:
                    Skriv("Återgår...");
                    Thread.Sleep(500);
                    hanteraAnvändare = false;
                    break;
            }
        }
    }
    void Create()
    {
        Console.Clear();
        int ctr = users.Count+1;
        //if (users.Count == 0) { ctr = 1; }
        Skriv("---Skapar användare---");
        bool adminBool;
        Skriv("Skriv in ett användarnamn:");
        string anvNamn = Console.ReadLine();
        Skriv("Välj ett lösenord: ");
        string anvLösen = Console.ReadLine();
        Skriv("Ska användaren vara en Admin?" +
            "\n 1. = Ja" +
            "\n 2. = Nej");
        Int32.TryParse(Console.ReadLine(), out int jaNejAdmin);
        if(jaNejAdmin == 1)
        {
            adminBool = true; User user = new User(anvNamn, anvLösen, adminBool, ctr);
            users.Add(user);
        }
        else if(jaNejAdmin == 2)
        {
            adminBool= false; User user = new User(anvNamn, anvLösen, adminBool,ctr);
            users.Add(user);
        }
        Skriv("Användaren skapades och lades till i listan!");
        Thread.Sleep(500);
        Console.Clear();
    }
}

