using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joquempô
{        
    // 0 - pedra, 1 - papel, 2 tesoura.
    public partial class Form1 : Form
    {
        int maoPlayer, maoIa, pPlayer, pIa;
        public Form1()
        {
            InitializeComponent();


            

        }

        private void buttonPedra_Click(object sender, EventArgs e)
        {
            labelPlayer.Text = "Pedra";

            Random rand = new Random();

            maoIa = rand.Next(3);

            if(maoIa == 0)
            {
                labelIA.Text = "Pedra";

                labelVencedor.Text = "Empate";    
            }
            else
            {
                if (maoIa == 1)
                {
                    labelIA.Text = "Papel";

                    labelVencedor.Text = "IA";

                    pIa++;
                }
                else
                {
                    if (maoIa == 2)
                    {
                        labelIA.Text = "Tesoura";

                        labelVencedor.Text = "Player";

                        pPlayer++;
                    }
                    else
                    {


                    }



                }

                labelpPlayer.Text = pPlayer.ToString();
                labelpIa.Text = pIa.ToString();

            }
           
          



        }

        private void buttonPapel_Click(object sender, EventArgs e)
        {
            labelPlayer.Text = "Papel";

            Random rand = new Random();

            maoIa = rand.Next(3);

            if (maoIa == 0 )
            {
                labelIA.Text = "Pedra";

                labelVencedor.Text = "Player";

                pPlayer++;
            }
            else
            {
                if (maoIa == 1)
                {
                    labelIA.Text = "Papel";

                    labelVencedor.Text = "Empate";
                }
                else
                {

                    if (maoIa == 2)
                    {
                        labelIA.Text = "Tesoura";

                        labelVencedor.Text = "IA";

                        pIa++;
                    }
                    else
                    {


                    }


                }

                labelpPlayer.Text = pPlayer.ToString();
                labelpIa.Text = pIa.ToString();

            }
           
           

        }

        private void buttonTesoura_Click(object sender, EventArgs e)
        {
            labelPlayer.Text = "Tesoura";

            Random rand = new Random();

            maoIa = rand.Next(3);

            if (maoIa == 0)
            {
                labelIA.Text = "Pedra";

                labelVencedor.Text = "IA";

                pIa++;
            }
            else
            {
                if (maoIa == 1)
                {
                    labelIA.Text = "Papel";

                    labelVencedor.Text = "Player";

                    pPlayer++;
                }
                else
                {
                    if (maoIa == 2)
                    {
                        labelIA.Text = "Tesoura";

                        labelVencedor.Text = "Empate";
                    }
                    else
                    {


                    }

                }

                labelpPlayer.Text = pPlayer.ToString();
                labelpIa.Text = pIa.ToString();

            }
           

        }

        




    }




}
