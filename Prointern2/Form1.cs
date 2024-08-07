using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ProLibrary;

namespace Prointern2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Utilisateur user = new Utilisateur();
        private void Form1_Load(object sender, EventArgs e)
        {
            tbPwd.UseSystemPasswordChar = true;

            //On verifie s'il existe des utilisateurs dans le système
            bool exists = user.ExistUnOuDesUtilisateurs();
            switch (exists)
            {
                case true:
                    this.Show();
                    break;

                case false:
                    {
                        CreationCompte cc = new CreationCompte();
                        cc.ShowDialog();
                    }
                    break;
            }   
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            switch (checkBox1.CheckState) 
            {
                case CheckState.Checked: tbPwd.UseSystemPasswordChar = false;
                    break;
                    
                case CheckState.Unchecked: tbPwd.UseSystemPasswordChar = true;
                    break;
            }
        }
    }
}
