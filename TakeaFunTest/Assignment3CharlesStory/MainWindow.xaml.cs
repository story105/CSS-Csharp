using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Assignment3CharlesStory
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        bool anabutton = false; // these are to set up boolean values for the submit button.
        bool meibutton = false; //easiest for me if I can just "if" statement them
        bool PCTrue = false;
        bool ObamaTrue = false;
        bool Allselected = false;
        bool MW2Selected = false;

        bool FirstComboBox = false;
        bool SecondComboBox = false;

        float AnswersCorrect = 0; //This will be added up if the answer is right (upon submission)
        float TotalQuestions = 8;
        int Attempts = 0;
        
        SolidColorBrush red = new SolidColorBrush(Color.FromArgb(235, 235, 0, 50)); // this makes the color red!!
        SolidColorBrush green = new SolidColorBrush(Color.FromArgb(235, 0, 235, 50)); //Apparently I need the color to be a brush.

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //This is the Submit. Prints to screen the score. And highlights questions if wrong/right
            //Also restarts AnswersCorrect if hit submit multiple times
            AnswersCorrect = 0;
            Attempts++; //Adds one attempt (to show those people who need help... :)
            {
                if (anabutton == true)
                {
                    HealerLabel.Foreground = green;
                    AnswersCorrect++;
                }
                else
                {
                    HealerLabel.Foreground = red;
                }
            }
            {
                if (meibutton == true)
                {
                    CancerLabel.Foreground = green;
                    AnswersCorrect++;
                }
                else
                {
                    CancerLabel.Foreground = red;
                }
            }

            {
                if (PCTrue == true)
                {
                    MacLabel.Foreground = green;
                    AnswersCorrect++;
                }
                else
                {
                    MacLabel.Foreground = red;
                }
            }

            {
                if (ObamaTrue == true)
                {
                    ObamaLabel.Foreground = green;
                    AnswersCorrect++;
                }
                else
                {
                    ObamaLabel.Foreground = red;
                }
            }

            {
                if (GormleyComboBox.SelectedIndex == 3)
                {
                    PralleLabel.Foreground = green;
                    AnswersCorrect++;
                }
                else
                {
                    PralleLabel.Foreground = red;
                }
            }

            {
                if (WarfareComboBox.SelectedIndex == 1)
                {
                    CODLabel.Foreground = green;
                    AnswersCorrect++;
                }
                else
                {
                    CODLabel.Foreground = red;
                }
            }

            {
                if (Colortextbox.Text == "green")
                {
                    ColorLabel.Foreground = green;
                    AnswersCorrect++;
                }
                else if(Colortextbox.Text == "Green")
                {
                    ColorLabel.Foreground = green;
                    AnswersCorrect++;
                }
                else
                {
                    ColorLabel.Foreground = red;
                }
            }

            {
                if (Persontextbox.Text == "charlie")
                {
                    DudeLabel.Foreground = green;
                    AnswersCorrect++;
                }
                else if (Persontextbox.Text == "Charlie") //All DIFFERENT VARIATIONS OF MY NAMEEE MUAHAHAHHAHAHAHAHAHAH
                {
                    DudeLabel.Foreground = green;
                    AnswersCorrect++;
                }
                else if (Persontextbox.Text == "Charles")
                {
                    DudeLabel.Foreground = green;
                    AnswersCorrect++;
                }
                else if (Persontextbox.Text == "charles")
                {
                    DudeLabel.Foreground = green;
                    AnswersCorrect++;
                }
                else if (Persontextbox.Text == "Chuck") //Really there's no way you can mess my name up
                {
                    DudeLabel.Foreground = green;
                    AnswersCorrect++;
                }
                else if (Persontextbox.Text == "Chuckles")
                {
                    DudeLabel.Foreground = green;

                    AnswersCorrect++;
                }
                else if (Persontextbox.Text == "Chazz")
                {
                    DudeLabel.Foreground = green;
                    AnswersCorrect++;
                }
                else if (Persontextbox.Text == "Charlie Story")
                {
                    DudeLabel.Foreground = green;
                    AnswersCorrect++;
                }
                else if (Persontextbox.Text == "Story")
                {
                    DudeLabel.Foreground = green;
                    AnswersCorrect++;
                }
                else if (Persontextbox.Text == "Charles Story")
                {
                    DudeLabel.Foreground = green;
                    AnswersCorrect++;
                }
                else
                {
                    DudeLabel.Foreground = red;
                }
            } //I don't really know how to shorten this all into one method, I kinda enjoy seeing it all laid out.

            //Quiz Score Area
            float QuizPercentage = (AnswersCorrect / TotalQuestions)*100;
            MessageBox.Show("You got " + AnswersCorrect + " answers correct and your percentage was " + QuizPercentage + "%");
            QuizScore.Text = (QuizPercentage.ToString());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // This is the Clear button, sets all (clicked) to false (unclicked)
             

            radio1.IsChecked = false;
            radio2.IsChecked = false;
            radio3.IsChecked = false;
            radio4.IsChecked = false;
            radio5.IsChecked = false;
            radio6.IsChecked = false;

            checkbox1.IsChecked = false;
            checkbox2.IsChecked = false;
            checkbox3.IsChecked = false;
            checkbox4.IsChecked = false;

            GormleyComboBox.SelectedIndex = 0;
            WarfareComboBox.SelectedIndex = 0; // resets the combo box to show first possible answer
           
            bool anabutton = false; // Resets the boolean values associated with the buttons
            bool meibutton = false; 
            bool PCTrue = false;
            bool ObamaTrue = false;
            bool Allselected = false;
            bool MW2Selected = false;

            bool FirstComboBox = false;
            bool SecondComboBox = false;

            Persontextbox.Text = ""; //Resets any letters typed in answer box
            Colortextbox.Text = "";
            QuizScore.Text = ""; //Resets shown quiz score in box
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            anabutton = true;
            //If Ana is checked= if radioButton.isChecked. Value == True (will be checkedby SUbmit button)
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            meibutton = true;
            // If mei is checked.
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            //PCCheckBox = true; CHANGE this charlie to be .ischecked!
            //If False (PC)
            PCTrue = true;
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            ObamaTrue = true;
            //Obama
        }

      
        
        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            anabutton = false; // resets the Ana button
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            anabutton = false;
        }

        private void RadioButton_Checked_4(object sender, RoutedEventArgs e)
        {
            meibutton = false;
        }

        private void RadioButton_Checked_5(object sender, RoutedEventArgs e)
        {
            meibutton = false;
        }

        private void CheckBox_Checked_2(object sender, RoutedEventArgs e)
        {
            PCTrue = false;
        }

        private void CheckBox_Checked_3(object sender, RoutedEventArgs e)
        {
            ObamaTrue = false;
        }

        
    }
}

