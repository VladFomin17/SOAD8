using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOAD8
{
    public partial class HashForm : Form
    {
        Random rnd = new Random();

        public HashForm()
        {
            InitializeComponent();
        }

        private int hashDivision(int K, int n)
        {
            int m = 2;
            for (int i = n - 1; i >= 2; i--) 
            {
                bool isPrime = true;
                for (int j = 2; j * j <= i; j++) 
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime) { 
                    m = i; 
                    break;
                }
            }
            return K % m;
        }

        private int hashMidSquare(int K, int n)
        {
            long square = (long)K * (long)K;

            if (square < n) return (int)square;

            int digits = (int)Math.Floor(Math.Log10(n - 1)) + 1;
            int numDigits = (int)Math.Floor(Math.Log10(square)) + 1;
            int shift = (numDigits - digits) / 2;

            if (((numDigits - digits) % 2) != 0)
                shift++; 

            long divisor = (long)Math.Pow(10, shift);
            long middle = (square / divisor) % n;
            return (int)middle;
        }

        private int hashFolding(long K, int n)
        {
            int digits = (int)Math.Floor(Math.Log10(n - 1)) + 1;

            long sum = 0;
            long divider = (long)Math.Pow(10, digits);

            while (K > 0)
            {
                sum += K % divider;
                K /= divider;
            }

            return (int)(sum % n);
        }

        private int hashMultiplication(int K, int n)
        {
            double A = (Math.Sqrt(5) - 1) / 2;
            double frac = (K * A) % 1;
            return (int)Math.Floor(n * frac);
        }

        private void analyzeHashFunctions(int n, int[] t)
        {
            int methodsAmount = t.Length;

            int[] M = new int[1000];
            for (int i = 0; i < M.Length; i++)
                M[i] = rnd.Next(0, 100000);

            // счетчики коллизий
            int[] collisions = new int[methodsAmount];

            List<int>[] chains = new List<int>[n];
            for (int i = 0; i < n; i++)
                chains[i] = new List<int>();

            for (int f = 0; f < methodsAmount; f++)
            {
                for (int i = 0; i < n; i++)
                    chains[i].Clear();

                foreach (int key in M)
                {
                    int hash = 0;
                    switch (f)
                    {
                        case 0:
                            hash = hashDivision(key, n);
                            break;
                        case 1:
                            hash = hashMidSquare(key, n);
                            break;
                        case 2:
                            hash = hashFolding(key, n);
                            break;
                        case 3:
                            hash = hashMultiplication(key, n);
                            break;
                    }

                    if (chains[hash].Count > 0)
                        collisions[f]++;

                    chains[hash].Add(key);
                }
            }

            int min = Math.Min(Math.Min(collisions[0], collisions[1]),
                               Math.Min(collisions[2], collisions[3]));

            for (int i = 0; i < methodsAmount; i++)
                if (collisions[i] == min)
                    t[i]++;
        }

        private void onCalculateClick(object sender, EventArgs e)
        {
            int iterations = (int)comparisonAmount.Value;

            int n = 1000;
            const int methodsAmount = 4;
            int[] t = new int[methodsAmount];

            for(int i = 0; i < iterations; i++) analyzeHashFunctions(n, t);

            divisionMethodTextBox.Text = t[0].ToString();
            midSquareTextBox.Text = t[1].ToString();
            foldingTextBox.Text = t[2].ToString();
            multiplyTextBox.Text = t[3].ToString();
        }

        private void onCloseClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
