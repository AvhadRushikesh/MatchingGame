using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MatchingGame
{
    public partial class Form1 : Form
    {
        //  Use this Random object to choose random icons for the squares
        Random random = new Random();

        /*  Each of these letters is an interesting icon
            in the Webdings font,
            and each icon appears twice in this list    */
        List<string> icons = new List<string>()
        {
            "!", "!", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };

        public Form1()
        {
            InitializeComponent();
        }


    }
}
