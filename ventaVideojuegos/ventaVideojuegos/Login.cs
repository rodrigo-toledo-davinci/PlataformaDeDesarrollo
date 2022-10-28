﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using ventaVideojuegos;

namespace ventaVideojuegos
{
    public partial class Login : Form
    {

        private string usuario = "";
        public Login()
        {

            InitializeComponent();
            limpiarErrores();
             
    }


        private void limpiarErrores()
        {
            errLogin.Text = "";
            errLogin.Hide();
        }

        private void bttnAcceder_Click_1(object sender, EventArgs e)
        {
            bool valido = false;

            if (!File.Exists("usuarios.txt"))
            {
                StreamWriter archivo = new StreamWriter("usuarios.txt");
                archivo.Close();
            }
            else
            {


                StreamReader archivo = new StreamReader("usuarios.txt");
                while (!archivo.EndOfStream)
                {
                    string usuario = archivo.ReadLine();
                    string[] datos = usuario.Split(',');

                    if (datos[1].Equals(txtUsuarioLogin.Text) && datos[2].Equals(txtContrasenaLogin.Text))
                    {
                        valido = true;
                       
                        
                    }

                }
                archivo.Close();


                if (valido)
                {
                    usuario = txtUsuarioLogin.Text;
                    this.Hide();
                    Form1 form = new Form1();
                    form.Show();


                }
                else
                {
                    string error = "Credenciales invalidas";
                    errLogin.Text = error;
                    errLogin.Show();
                }
            }
        }

        public string getUsuario() 
        { 
            return usuario;
        }

        private void txtUsuarioLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}