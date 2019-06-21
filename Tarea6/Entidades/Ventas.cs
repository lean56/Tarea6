﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6.Entidades
{
   public class Ventas
    {
        [Key]
        public int VentaId { get; set; }
        public int UsuarioId { get; set; }
        public int ClienteId { get; set; }
        public int ComprobanteId { get; set; }
        public DateTime FechaVenta { get; set; }
        public double Igv { get; set; }
        public double SubTotal { get; set; }
        public double CostoVenta { get; set; }

        public Ventas()
        {
            VentaId = 0;
            UsuarioId = 0;
            ClienteId = 0;
            ComprobanteId = 0;
            FechaVenta = DateTime.Now;
            Igv = 0.0;
            SubTotal = 0;
            CostoVenta = 0;
        }
    }
}
