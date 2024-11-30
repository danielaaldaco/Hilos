namespace Hilos
{
    public partial class Form1 : Form
    {
        byte r, g, b;
        Thread p1, p2, p3, p4;
        int cont1, cont2, cont3, cont4;
        bool b1, b2, b3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            r = g = b = 0;
            b1 = b2 = b3 = false;
            cont1 = cont2 = cont3= cont4 = 0;
        }

        private void Hilo1()
        {
            while (cont1 < 3)
            {
                Thread.Sleep(10);
                if (b1 == false)
                {
                    r++;
                    if (r == 255)
                        b1 = true;
                }
                else
                {
                    r--;
                    if (r == 0)
                    {
                        b1 = false;
                        cont1++;
                    }
                }

                pictureBox1.BackColor = Color.FromArgb(r, 80, 100);
            }
            cont1 = 0;
            p2 = new Thread(new ThreadStart(Hilo2));
            p2.Start();
        }

        private void Hilo2()
        {
            while (cont2 < 3)
            {
                Thread.Sleep(10);
                if (b2 = false)
                {
                    g++;
                    if (g == 255)
                        b2 = true;
                }
                else
                {
                    g--;
                    if (g == 0)
                    {
                        b2 = false;
                        cont2++;
                    }
                }

                pictureBox2.BackColor = Color.FromArgb(100, g, 80);
            }

            cont2 = 0;
            p3 = new Thread(new ThreadStart(Hilo3));
            p3.Start();
        }

        private void Hilo3()
        {
            while (cont3 < 3)
            {
                Thread.Sleep(10);
                if (b3 =  false)
                {
                    b++;
                    if (b == 255)
                        b3 = true;
                }
                else
                {
                    b--;
                    if (b == 0)
                    {
                        b3 = false;
                        cont3++;
                    }
                }

                pictureBox3.BackColor = Color.FromArgb(100, 80, b);
            }
            cont3 = 0;
            p4 = new Thread(new ThreadStart(Hilo4));
            p4.Start();
        }

        private void Hilo4()
        {
            while (cont4 < 3)
            {
                Thread.Sleep(10);
                if (!b1)
                {
                    r++;
                    if (r == 255)
                        b1 = true;
                }
                else
                {
                    r--;
                    if (r == 0)
                    {
                        b1 = false;
                        cont4++;
                    }
                }

                pictureBox4.BackColor = Color.FromArgb(r, 80, 100);
            }

            cont4 = 0;
            p1 = new Thread(new ThreadStart(Hilo1));
            p1.Start();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            p1 = new Thread(new ThreadStart(Hilo1));
            p1.Start(); 
        }
    }
}
