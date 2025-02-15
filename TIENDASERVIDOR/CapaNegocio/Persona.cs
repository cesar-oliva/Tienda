﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Persona
    {
        private int idPersona;
        private string tipoDocumento;
        private string numeroDocumento;
        private string nombres;
        private string apellidos;
        private Sexo oSexo;
        private DateTime fechaNacimiento;
        private string domicilio;
        private string telefono;
        private Estado oEstado;
        private DateTime fechaRegistro;

        public int IdPersona { get => idPersona; set => idPersona = value; }
        public string TipoDocumento { get => tipoDocumento; set => tipoDocumento = value; }
        public string NumeroDocumento { get => numeroDocumento; set => numeroDocumento = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public Sexo OSexo { get => oSexo; set => oSexo = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public Estado OEstado { get => oEstado; set => oEstado=value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro=value; }

        public Persona()
        {
        }
    }
}
