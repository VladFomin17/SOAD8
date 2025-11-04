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

        // === Метод середины квадрата ===
        private int hashMidSquare(int K, int n)
        {
            long square = (long)K * (long)K;

            int digits = (int)Math.Floor(Math.Log10(n - 1)) + 1;

            int numDigits = (int)Math.Floor(Math.Log10(square)) + 1;

            int shift = (numDigits - digits) / 2;

            if (((numDigits - digits) % 2) != 0)
                shift++; 

            long divisor = (long)Math.Pow(10, shift);
            long middle = (square / divisor) % n;
            return (int)middle;
        }

        // === Метод свёртывания ===
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

        // === Метод умножения ===
        private int hashMultiplication(int K, int n)
        {
            const double A = 0.6180339887;
            double frac = (K * A) - Math.Floor(K * A);
            return (int)Math.Floor(n * frac);
        }

        private void onCalculateClick(object sender, EventArgs e)
        {
            int K = 45678; // ключ
            int n = 1000; // диапазон 

            int divisionHashAdress = hashDivision(K, n);
            int midSquareHashAdress = hashMidSquare(K, n);
            int foldingHashAdress = hashFolding(K, n);
            int multiplyHashAdress = hashMultiplication(K, n);

            divisionMethodTextBox.Text = divisionHashAdress.ToString();
            midSquareTextBox.Text = midSquareHashAdress.ToString();
            foldingTextBox.Text = foldingHashAdress.ToString();
            multiplyTextBox.Text = multiplyHashAdress.ToString();
        }

        private void onCloseClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
