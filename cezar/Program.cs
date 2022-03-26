string tekst;
Console.WriteLine("Wiadomość");
tekst = Console.ReadLine();
int przesunięcie;
Console.WriteLine("przesunięcie");
przesunięcie = Int32.Parse(Console.ReadLine());
char[] tab = tekst.ToCharArray();
for (int i = 0; i < tab.Length; i++)
{
    tab[i] = (char)((char)tab[i] + przesunięcie);
}
string szyfr = new string(tab);
Console.WriteLine("Zaszyfrowany kod to: " + szyfr);