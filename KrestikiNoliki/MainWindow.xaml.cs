using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KrestikiNoliki
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int roly = 1;
        int a = 1;
        string[,] matrix = new string[3, 3] { { "", "", "" },
                                              { "", "", "" }, 
                                              { "", "", "" } };

        public MainWindow()
        {
            InitializeComponent();
        }
        public void Blockirovka()
        {
            first.IsEnabled = false;
            second.IsEnabled = false;
            tri.IsEnabled = false;
            chetiri.IsEnabled = false;
            pyt.IsEnabled = false;
            shest.IsEnabled = false;
            sem.IsEnabled = false;
            vosem.IsEnabled = false;
            devyt.IsEnabled = false;
        }
        public void Cnopka(Button qwa)
        {
            if ( roly == 0)
            {
                qwa.Content = "X";
                qwa.IsEnabled = false;
                if(qwa == first) { qwa.Content = "X"; }
                if (qwa == second) { qwa.Content = "X"; }
                if (qwa == tri) { qwa.Content = "X"; }
                if (qwa == chetiri) { qwa.Content = "X"; }
                if (qwa == pyt) { qwa.Content = "X"; }
                if (qwa == shest) { qwa.Content = "X"; }
                if (qwa == sem) { qwa.Content = "X"; }
                if (qwa == vosem) { qwa.Content = "X"; }
                if (qwa == devyt) { qwa.Content = "X"; }

            }
            else
            {
                qwa.Content = "O";
                if (qwa == first) { qwa.Content = "O"; }
                if (qwa == second) { qwa.Content = "O"; }
                if (qwa == tri) { qwa.Content = "O"; }
                if (qwa == chetiri) { qwa.Content = "O"; }
                if (qwa == pyt) { qwa.Content = "O"; }
                if (qwa == shest) { qwa.Content = "O"; }
                if (qwa == sem) { qwa.Content = "O"; }
                if (qwa == vosem) { qwa.Content = "O"; }
                if (qwa == devyt) { qwa.Content = "O"; }
            }
        }
        public void Chek()
        {
            if (matrix[0, 0] == "X" && matrix[1, 0] == "X" && matrix[2, 0] == "X") { Vigral.Text = "Победа крестиков"; Blockirovka(); }
            if (matrix[0, 0] == "X" && matrix[0, 1] == "X" && matrix[0, 2] == "X") { Vigral.Text = "Победа крестиков"; Blockirovka(); }
            if (matrix[0, 0] == "X" && matrix[1, 1] == "X" && matrix[2, 2] == "X") { Vigral.Text = "Победа крестиков"; Blockirovka(); }
            if (matrix[1, 0] == "X" && matrix[1, 1] == "X" && matrix[1, 2] == "X") { Vigral.Text = "Победа крестиков"; Blockirovka(); }
            if (matrix[2, 0] == "X" && matrix[2, 1] == "X" && matrix[2, 2] == "X") { Vigral.Text = "Победа крестиков"; Blockirovka(); }
            if (matrix[2, 0] == "X" && matrix[1, 1] == "X" && matrix[0, 2] == "X") { Vigral.Text = "Победа крестиков"; Blockirovka(); }
            if (matrix[0, 2] == "X" && matrix[1, 2] == "X" && matrix[2, 2] == "X") { Vigral.Text = "Победа крестиков"; Blockirovka(); }
            if (matrix[0, 1] == "X" && matrix[1, 1] == "X" && matrix[2, 1] == "X") { Vigral.Text = "Победа крестиков"; Blockirovka(); }

            if (matrix[0, 0] == "O" && matrix[1, 0] == "O" && matrix[2, 0] == "O") { Vigral.Text = "Победа ноликов"; Blockirovka(); }
            if (matrix[0, 0] == "O" && matrix[0, 1] == "O" && matrix[0, 2] == "O") { Vigral.Text = "Победа ноликов"; Blockirovka(); }
            if (matrix[0, 0] == "O" && matrix[1, 1] == "O" && matrix[2, 2] == "O") { Vigral.Text = "Победа ноликов"; Blockirovka(); }
            if (matrix[1, 0] == "O" && matrix[1, 1] == "O" && matrix[1, 2] == "O") { Vigral.Text = "Победа ноликов"; Blockirovka(); }
            if (matrix[2, 0] == "O" && matrix[2, 1] == "O" && matrix[2, 2] == "O") { Vigral.Text = "Победа ноликов"; Blockirovka(); }
            if (matrix[2, 0] == "O" && matrix[1, 1] == "O" && matrix[0, 2] == "O") { Vigral.Text = "Победа ноликов"; Blockirovka(); }
            if (matrix[0, 2] == "O" && matrix[1, 2] == "O" && matrix[2, 2] == "O") { Vigral.Text = "Победа ноликов"; Blockirovka(); }
            if (matrix[0, 1] == "O" && matrix[1, 1] == "O" && matrix[2, 1] == "O") { Vigral.Text = "Победа ноликов"; Blockirovka(); }

        }
        public void Ya(Button qwa)
        {
            if (roly == 1)
            {
                qwa.Content = "X";
                qwa.IsEnabled = false;
                if (qwa == first)
                {
                    matrix[0, 0] = "X";

                }
                if (qwa == second)
                {
                    matrix[0,1] = "X";
                }
                if (qwa == tri) { matrix[0,2] = "X"; }
                if (qwa == chetiri) { matrix[1, 0] = "X"; }
                if (qwa == pyt) { matrix[1, 1] = "X"; }
                if (qwa == shest) { matrix[1, 2] = "X"; }
                if (qwa == sem) { matrix[2, 0] = "X"; }
                if (qwa == vosem) { matrix[2, 1] = "X"; }
                if (qwa == devyt) { matrix[2, 2] = "X"; }
                roly = 0;
            }
            else
            {
                qwa.Content = "O";
                qwa.IsEnabled = false;
                if (qwa == first)
                {
                    matrix[0, 0] = "O";

                }
                if (qwa == second)
                {
                    matrix[0, 1] = "O";
                }
                if (qwa == tri) { matrix[0, 2] = "O"; }
                if (qwa == chetiri) { matrix[1, 0] = "O"; }
                if (qwa == pyt) { matrix[1, 1] = "O"; }
                if (qwa == shest) { matrix[1, 2] = "O"; }
                if (qwa == sem) { matrix[2, 0] = "O"; }
                if (qwa == vosem) { matrix[2, 1] = "O"; }
                if (qwa == devyt) { matrix[2, 2] = "O"; }
                roly = 1;
            }
            Chek();  
            if (a < 9)
            {
                Compi(); 
                Chek();   
            }
            else
            {
                Vigral.Text = "Ничья";
                Chek();
            }

        }
        public void Compi()
        {
            int run;
            Random rand = new Random();
            do
            {
                run = rand.Next(1, 9);
                if (run == 1 && matrix[0, 0] == "")
                {
                    if (roly == 0) { matrix[0, 0] = "O"; first.Content = "O"; } else { matrix[0, 0] = "X"; first.Content = "X"; }
                    first.IsEnabled = false;

                    break;
                }
                if (run == 2 && matrix[0, 1] == "")
                {
                    if (roly == 0) { matrix[0, 1] = "O"; second.Content = "O"; } else { matrix[0, 1] = "X"; second.Content = "X"; }
                    second.IsEnabled = false;

                    break;
                }
                if (run == 3 && matrix[0, 2] == "")
                {
                    if (roly == 0) { matrix[0, 2] = "O"; tri.Content = "O"; } else { matrix[0, 2] = "X"; tri.Content = "X"; }
                    tri.IsEnabled = false;

                    break;
                }
                if (run == 4 && matrix[1, 0] == "")
                {
                    if (roly == 0) { matrix[1, 0] = "O"; chetiri.Content = "O"; } else { matrix[1, 0] = "X"; chetiri.Content = "X"; }
                    chetiri.IsEnabled = false;

                    break;
                }
                if (run == 5 && matrix[1, 1] == "")
                {
                    if (roly == 0) { matrix[1, 1] = "O"; pyt.Content = "O"; } else { matrix[1, 1] = "X"; pyt.Content = "X"; }
                    pyt.IsEnabled = false;

                    break;
                }
                if (run == 6 && matrix[1, 2] == "")
                {
                    if (roly == 0) { matrix[1, 2] = "O"; shest.Content = "O"; } else { matrix[1, 2] = "X"; shest.Content = "X"; }
                    shest.IsEnabled = false;

                    break;
                }
                if (run == 7 && matrix[2, 0] == "")
                {
                    if (roly == 0) { matrix[2, 0] = "O"; sem.Content = "O"; } else { matrix[2, 0] = "X"; sem.Content = "X"; }
                    sem.IsEnabled = false;

                    break;
                }
                if (run == 8 && matrix[2, 1] == "")
                {
                    if (roly == 0) { matrix[2, 1] = "O"; vosem.Content = "O"; } else { matrix[2, 1] = "X"; vosem.Content = "X"; }
                    vosem.IsEnabled = false;

                    break;
                }
                if (run == 9 && matrix[2, 2] == "")
                {
                    if (roly == 0) { matrix[2, 2] = "O"; devyt.Content = "O"; } else { matrix[2, 2] = "X"; devyt.Content = "X"; }
                    devyt.IsEnabled = false;

                    break;
                }



            }while(true);
        }
                
        private void nachat_Click(object sender, RoutedEventArgs e)
        {
            first.IsEnabled = true;
            second.IsEnabled = true;
            tri.IsEnabled = true;
            chetiri.IsEnabled = true;
            pyt.IsEnabled = true;
            shest.IsEnabled = true;
            sem.IsEnabled = true;
            vosem.IsEnabled = true;
            devyt.IsEnabled = true;

        }

        private void first_Click(object sender, RoutedEventArgs e)
        {
            Ya(first);
            /*first.Content = "X";
            first.IsEnabled = false;*/
        }

        private void second_Click(object sender, RoutedEventArgs e)
        {
            Ya(second);
        }

        private void tri_Click(object sender, RoutedEventArgs e)
        {
            Ya(tri);
        }

        private void chetiri_Click(object sender, RoutedEventArgs e)
        {
            Ya(chetiri);
        }

        private void pyt_Click(object sender, RoutedEventArgs e)
        {
            Ya(pyt);
        }

        private void shest_Click(object sender, RoutedEventArgs e)
        {
            Ya(shest);
        }

        private void sem_Click(object sender, RoutedEventArgs e)
        {
            Ya(sem);
        }

        private void vosem_Click(object sender, RoutedEventArgs e)
        {
            Ya(vosem);
        }

        private void devyt_Click(object sender, RoutedEventArgs e)
        {
            Ya(devyt);
        }

        private void restart_Click(object sender, RoutedEventArgs e)
        {
            first.Content = "";
            second.Content = "";
            tri.Content = "";
            chetiri.Content = "";
            pyt.Content = "";
            shest.Content = "";
            sem.Content = "";
            vosem.Content = "";
            devyt.Content = "";

            matrix[0, 0] = "";
            matrix[0, 1] = "";
            matrix[0, 2] = "";
            matrix[1, 0] = "";
            matrix[1, 1] = "";
            matrix[1, 2] = "";
            matrix[2, 1] = "";
            matrix[2, 2] = "";



            

        }

    }
}
