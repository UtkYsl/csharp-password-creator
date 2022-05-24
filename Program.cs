char[] karakter = "abcdefghijklmnoprstuvwxyz0123456789+*/-@#&".ToArray();
string result = string.Empty;
Console.WriteLine("Oluşturulacak şifrenin uzunluğunu girin.");
int karaktersayısı = Convert.ToInt32(Console.ReadLine());
Random rand = new Random();
for (int i= 0; i < karaktersayısı; i++)
{
    result += karakter[rand.Next(0, karakter.Length - 1)].ToString();
}
Console.WriteLine(result);