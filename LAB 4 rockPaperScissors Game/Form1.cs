using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_4_rockPaperScissors_Game
{
    public partial class Form1 : Form
    {

        Boolean rockk = false;
        Boolean paperr = false;
        Boolean scissorss = false;

        Boolean pcRockk = false;
        Boolean pcPaper = false;
        Boolean pcScissors = false;

        int points=0; //the winner gets 3 points
        int pcPoints = 0; //the winner gets 3 points

        public Form1()
        {
            InitializeComponent();
        }

        //these button are getting my input

        //this is the rock button
        private void button2_Click(object sender, EventArgs e)
        {

            rockk = true;
            paper_user.Visible = false; //we hide paper user image
            scissors_user.Visible=false; //we hide scissors user image
        }

        //paper button
        private void paper_button_Click(object sender, EventArgs e)
        {
            paperr = true;
            rock_user.Visible = false; //we hide rock user image
            scissors_user.Visible = false; //we hide paper user image
        }

        //scissors button
        private void scissors_button_Click(object sender, EventArgs e)
        {
            scissorss = true;
            rock_user.Visible = false; //we hide rock user image
            paper_user.Visible = false; //we hide paper user image
        }




        int counter=0;

        //PLAY button
        private void button1_Click(object sender, EventArgs e)
        {
            if (counter >0)//we only reset the image beginning of the second play
                resetImage();


            //first if we click on play without choosing an option we get a message
            if(rockk == false && paperr == false && scissorss == false)
            {
                MessageBox.Show("Please choose rock, paper or scissors");
            }

            else
            {
                pcInput(); //we get the computers input
                

                //now we compare our choise with the computer choice to see who wins
                pointsForWinner();


                //if we have a winner
                if(winner() == true)
                {
                    if(points == 3)
                    {
                        MessageBox.Show("You Won!!");
                        points = 0;
                        pcPoints = 0;
                    }

                    else
                    {
                        MessageBox.Show("You Lost!!");
                        points = 0;
                        pcPoints = 0;
                    }
                        
                }

                  reset();// this reset the boolean variables to false

                counter++;
                label3.Text = pcPoints.ToString();
                label5.Text = points.ToString();

            }
        }

        private void pointsForWinner()
        {
            //now we compare our choise with the computer choice to see who wins
            if (rockk == true && pcPaper == true)
            {
                pcPoints++;
            }

            else if (rockk == true && pcScissors == true)
            {
                points++;
            }

            else if (paperr == true && pcRockk == true)
            {
                points++;
            }

            else if (paperr == true && pcScissors == true)
            {
                pcPoints++;
            }

            else if (scissorss == true && pcRockk == true)
                pcPoints++;

            else if (scissorss == true && pcPaper == true)
                points++;
        }


        private void pcInput()
        {
            //this will choose rock, paper or scissors for pc and then compare them to user choice, user choice was already chosen with the buttons

            //this is for the computers choice
            Random random = new Random();
            int choice = random.Next(1, 4); //random number 1 to 3, for rock, paper, scissors

            if (choice == 1)
            {
                pcRockk = true;
                paper.Visible = false; //we hide paper user image
                scissors.Visible = false; //we hide scissors user image
            }

            else if (choice == 2)
            {
                pcPaper = true;
                rock.Visible = false; //we hide rock user image
                scissors.Visible = false; //we hide paper user image
            }

            else if (choice == 3)
            {
                pcScissors = true;
                rock.Visible = false; //we hide rock user image
                paper.Visible = false; //we hide paper user image
            }
        }

        private bool winner()
        {
            if(points == 3 || pcPoints == 3)
            {
               
                return true;
            }
            return false;
        }

        //reset boolean values and images so they all became visible again
        private void reset()
        {
            rockk = false;
            paperr = false;
            scissorss = false;

            pcRockk = false;
            pcPaper = false;
            pcScissors=false;

           
        }

        private void resetImage()
        {
            rock_user.Visible = true;
            paper_user.Visible = true;
            scissors_user.Visible = true;

            rock.Visible = true;
            paper.Visible = true;
            scissors.Visible = true;
        }

        

       
    }
}
