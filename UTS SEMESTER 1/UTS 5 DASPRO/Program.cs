using System;
using System.Threading;
namespace UTS5TIC_TAC_TOE
{
    class Program
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int pemain = 1;
        static int choice;
        static int flag = 0;
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Pemain1:X and Pemain2:O");
                Console.WriteLine("\n");
                if (pemain % 2 == 0)
                {
                    Console.WriteLine("Kesempatan pemain 2");
                }
                else
                {
                    Console.WriteLine("Kesempatan pemain 1");
                }
                Console.WriteLine("\n");
                Board();
                choice = int.Parse(Console.ReadLine());
                
                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (pemain % 2 == 0)
                    {
                        arr[choice] = 'O';
                        pemain++;
                    }
                    else
                    {
                        arr[choice] = 'X';
                        pemain++;
                    }
                }
                else
                {
                    Console.WriteLine("Maaf baris {0} sudah diisi oleh {1}", choice, arr[choice]);
                    Console.WriteLine("\n");
                    Console.WriteLine("Harap tunggu 2 detik papan sedang memuat...");
                    Thread.Sleep(2000);
                }
                flag = CheckWin();
            }
            while (flag != 1 && flag != -1);
            Console.Clear();
            Board();
            if (flag == 1)
            {
                Console.WriteLine("Pemain {0} menang!", (pemain % 2) + 1);
            }
            else
            {
                Console.WriteLine("Seri!");
            }
            Console.ReadLine();
        }
        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");
        }
        private static int CheckWin()
        {
            #region Horzontal Winning Condtion
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }
            #endregion
            #region vertical Winning Condtion
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            #endregion
            #region Diagonal Winning Condition
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            #endregion
            #region Checking For Draw
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            #endregion
            else
            {
                return 0;
            }
        }
    }
}