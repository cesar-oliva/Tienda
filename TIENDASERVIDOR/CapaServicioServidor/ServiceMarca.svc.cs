﻿using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CapaServicioServidor
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceMarca" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceMarca.svc o ServiceMarca.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceMarca : IServiceMarca
    {
        public bool AgregarMarca(DtoMarca oMarca)
        {
            var nuevo = new Marca
            {
                DescripcionMarca = oMarca.Descripcion,
                OEstado = oMarca.OEstado
            };
            int i = CapaDatos.BD_Marca.RegistrarMarca(nuevo);
            if (i != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool EliminarMarca(int IdMarca)
        {
            return CapaDatos.BD_Marca.EliminarMarca(IdMarca);
        }
        public bool ModificarMarca(DtoMarca oMarca, int IdMarca)
        {
            var nuevo = new Marca
            {
                DescripcionMarca = oMarca.Descripcion,
                OEstado = oMarca.OEstado,
            };

            return CapaDatos.BD_Marca.ActualizarMarca(nuevo, IdMarca);

        }
        public List<DtoMarca> ListaMarca()
        {
            List<Marca> dato = CapaDatos.BD_Marca.MostrarMarca();
            List<DtoMarca> marc = new List<DtoMarca>();
            foreach (var item in dato)
            {
                DtoMarca marca = new DtoMarca
                {
                    IdMarca = item.IdMarca,
                    Descripcion = item.DescripcionMarca,
                    OEstado = item.OEstado,
                };
                marc.Add(marca);
            }
            return marc;

        }
        public Marca ObtenerMarca(string oMarca)
        {
            return BD_Marca.BuscarMarcaByDescripcion(oMarca);
        }
    }
}
