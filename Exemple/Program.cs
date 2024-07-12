
using System.Security.Cryptography;

namespace Exemple
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int Rand()
            {
                var rand = new Random();
                return rand.Next(1, 200);
            }

            int TrueRandom()
            {
                RandomNumberGenerator rng = new RNGCryptoServiceProvider();
                try
                {
                    
                    byte[] bytes = new byte[4];
                    rng.GetBytes(bytes);
                    rng.Dispose();
                    return BitConverter.ToInt32(bytes, 0);
                }
                catch (CryptographicException)
                {
                    return Rand();
                }
                finally
                {
                    rng.Dispose();
                }
            }

            for (int i = 0, j = 0; i < 100; i++, j++)
            {
                Console.WriteLine(TrueRandom());
            }

        }
    }
}
