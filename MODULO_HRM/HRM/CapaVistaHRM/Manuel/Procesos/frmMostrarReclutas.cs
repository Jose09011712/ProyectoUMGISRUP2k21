﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using CapaControladorHRM.Manuel;


namespace CapaVistaHRM.Manuel.Procesos
{
    public partial class frmMostrarReclutas : Form
    {
        public frmMostrarReclutas(int EstadoR)
        {
            InitializeComponent();
            funcMostrarTabla(EstadoR);
        }


        //estado de posible candidato

        //int Estado = 0;
        //int NoEntrevistado = 0;
        //int NoRecomendado = 0;
        int prueba;
        ClsControladorManuel Cont_R = new ClsControladorManuel();
        public void funcMostrarTabla(int EstadoR)
        {

            
            DataTable dt = Cont_R.funcTablaBancoTalento(EstadoR, EstadoR, EstadoR);
            dgvMostrarReclutas.DataSource = dt;
            funcNombresEncabezados();
            prueba = EstadoR;

        }

      
        //función para cambiarle el nombre a las columnas del datagrid al momento de mostrar todos los datos
        public void funcNombresEncabezados()
        {
            dgvMostrarReclutas.Columns[0].HeaderText = "Código ID";
            dgvMostrarReclutas.Columns[1].HeaderText = "Nombres";
            dgvMostrarReclutas.Columns[2].HeaderText = "Apellidos";
            dgvMostrarReclutas.Columns[3].HeaderText = "Puesto a Aplicar ";
            dgvMostrarReclutas.Columns[4].HeaderText = "Departamento a Aplicar ";
            dgvMostrarReclutas.Columns[5].HeaderText = "Horario a Aplicar";
            dgvMostrarReclutas.Columns[6].HeaderText = "Email";
            dgvMostrarReclutas.Columns[7].HeaderText = "Telefono";
            dgvMostrarReclutas.Columns[8].HeaderText = "Tipo Licencia";
            dgvMostrarReclutas.Columns[9].HeaderText = "Profesión Actual";
            dgvMostrarReclutas.Columns[10].HeaderText = "Nivel Formación Académica";


        }
        //función que bloquea todos los txt
        public void funcBloqueoTxt()
        {
            txtDepartamento.Enabled = false;
            txtIdRecluta.Enabled = false;
            txtPrimerNombre.Enabled = false;
            txtPrimerApellido.Enabled = false;
            txtPuesto.Enabled = false;
            txtDepartamento.Enabled = false;
            txtProfesion.Enabled = false;

        }

        //función que limpia todos los texbox
        public void funcLimpieza()
        {
            txtDepartamento.Text = "";
            txtIdRecluta.Text = "";
            txtPrimerNombre.Text = "";
            txtPrimerApellido.Text = "";
            txtPuesto.Text = "";
            txtDepartamento.Text = "";
            txtProfesion.Text = "";
        }

        //funcion que limpia todos los radiobuttons(les quita la seleccion)
        public void funcLimpiezaRbtn()
        {
            rbtnFiltradoId.Checked = false;
            rbtnFiltradoNombres.Checked = false;
            rbtnFiltradoApellidos.Checked = false;
            rbtnFiltradoPuesto.Checked = false;
            rbtnFiltradoDepto.Checked = false;
            rbtnFiltradoHorario.Checked = false;

        }

        //se agrega una condicion if para limpiar todos los textbox con contenido, se bloquean todos excepto el correspondiente al radiobutton
        private void rbtnFiltradoId_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFiltradoId.Checked == true)
            {
                //se llama a la funcion funcLimpieza
                funcLimpieza();
                //se llama a la funcion funcBloqueoTxt
                funcBloqueoTxt();
                //se desbloquea el textbox correspondiente al radiobutton
                txtIdRecluta.Enabled = true;
            }
        }

        //se agrega una condicion if para limpiar todos los textbox con contenido, se bloquean todos excepto el correspondiente al radiobutton
        private void rbtnFiltradoNombre1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFiltradoNombres.Checked == true)
            {
                //se llama a la funcion funcLimpieza
                funcLimpieza();
                //se llama a la funcion funcBloqueoTxt
                funcBloqueoTxt();
                //se desbloquea el textbox correspondiente al radiobutton
                txtPrimerNombre.Enabled = true;
            }
        }

        //se agrega una condicion if para limpiar todos los textbox con contenido, se bloquean todos excepto el correspondiente al radiobutton
        private void rbtnFiltradoApellido1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFiltradoApellidos.Checked == true)
            {
                //se llama a la funcion funcLimpieza
                funcLimpieza();
                //se llama a la funcion funcBloqueoTxt
                funcBloqueoTxt();
                //se desbloquea el textbox correspondiente al radiobutton
                txtPrimerApellido.Enabled = true;
            }
        }
        //se agrega una condicion if para limpiar todos los textbox con contenido, se bloquean todos excepto el correspondiente al radiobutton
        private void rbtnFiltradoPuesto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFiltradoPuesto.Checked == true)
            {
                //se llama a la funcion funcLimpieza
                funcLimpieza();
                //se llama a la funcion funcBloqueoTxt
                funcBloqueoTxt();
                //se desbloquea el textbox correspondiente al radiobutton
                txtPuesto.Enabled = true;
            }
        }

        //se agrega una condicion if para limpiar todos los textbox con contenido, se bloquean todos excepto el correspondiente al radiobutton
        private void rbtnFiltradoDepto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFiltradoDepto.Checked == true)
            {
                //se llama a la funcion funcLimpieza
                funcLimpieza();
                //se llama a la funcion funcBloqueoTxt
                funcBloqueoTxt();
                //se desbloquea el textbox correspondiente al radiobutton
                txtDepartamento.Enabled = true;
            }
        }

        //se agrega una condicion if para limpiar todos los textbox con contenido, se bloquean todos excepto el correspondiente al radiobutton
        private void rbtnFiltradoProfesion_CheckedChanged(object sender, EventArgs e)
        {

            if (rbtnFiltradoHorario.Checked == true)
            {
                //se llama a la funcion funcLimpieza
                funcLimpieza();
                //se llama a la funcion funcBloqueoTxt
                funcBloqueoTxt();
                //se desbloquea el textbox correspondiente al radiobutton
                txtProfesion.Enabled = true;
            }

        }
        //Validacion para solo ingresar números en el txt Id
        private void funcNumero(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcNumeros(e);
        }
        //Validacion para solo ingresar letras
        private void funcLetra(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcLetras(e);
        }
        //Evento KeyUp para realizar el filtrado de los datos por id 
        private void txtIdEmpleado_KeyUp(object sender, KeyEventArgs e)
        {
            string Parametro = txtIdRecluta.Text;
            DataTable dt = Cont_R.funcTablaBancoTalentoId(prueba, prueba, prueba, Parametro);
            dgvMostrarReclutas.DataSource = dt;
            funcNombresEncabezados();

        }
        //Evento KeyUp para realizar el filtrado de los datos por primer nombre
        private void txtPrimerNombre_KeyUp(object sender, KeyEventArgs e)
        {
            string Parametro = txtPrimerNombre.Text;
            DataTable dt = Cont_R.funcTablaBancoTalentoNombre(prueba, prueba, prueba, Parametro);
            dgvMostrarReclutas.DataSource = dt;
            funcNombresEncabezados();

        }
        //Evento KeyUp para realizar el filtrado de los datos por primer apellido
        private void txtPrimerApellido_KeyUp(object sender, KeyEventArgs e)
        {
            string Parametro = txtPrimerApellido.Text;
            DataTable dt = Cont_R.funcTablaBancoTalentoApellido(prueba, prueba, prueba, Parametro);
            dgvMostrarReclutas.DataSource = dt;
            funcNombresEncabezados();
        }
        //Evento KeyUp para realizar el filtrado de los datos por puesto
        private void txtPuesto_KeyUp(object sender, KeyEventArgs e)
        {
            string Parametro = txtPuesto.Text;
            DataTable dt = Cont_R.funcTablaBancoTalentoPuesto(prueba, prueba, prueba, Parametro);
            dgvMostrarReclutas.DataSource = dt;
            funcNombresEncabezados();
        }
        //Evento KeyUp para realizar el filtrado de los datos por departamento
        private void txtDepartamento_KeyUp(object sender, KeyEventArgs e)
        {
            string Parametro = txtDepartamento.Text;
            DataTable dt = Cont_R.funcTablaBancoTalentoDepartamento(prueba, prueba, prueba, Parametro);
            dgvMostrarReclutas.DataSource = dt;
            funcNombresEncabezados();
        }
        //Evento KeyUp para realizar el filtrado de los datos por profesion
        private void txtProfesion_KeyUp(object sender, KeyEventArgs e)
        {
            string Parametro = txtProfesion.Text;
            DataTable dt = Cont_R.funcTablaBancoTalentoHorario(prueba, prueba, prueba, Parametro);
            dgvMostrarReclutas.DataSource = dt;
            funcNombresEncabezados();
        }
        //se coloca un máximo de dígitos para el textbox del id
        private void frmMostrarReclutas_Load(object sender, EventArgs e)
        {
            txtIdRecluta.MaxLength = 8;
        }
        //Se muestran nuevamente todos los datos de la entidad Empleado
        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            //Se llama a la funcion funcLimpiezaRbtn
            funcLimpiezaRbtn();
            //Se llama a la funcion funcLimpieza
            funcLimpieza();
            //Se llama a la funcion funcBloqueoTxt
            funcBloqueoTxt();
            //Se llama a la funcion funcMostrarTabla
            funcMostrarTabla(prueba);
        }

      
    }
}
