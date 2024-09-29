using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace appGestionBanco.Models
{
    public class CuentaBanco
    {
            public int Id { get; set; }
            public string? nombreTitular { get; set; } /*AccountHolderName*/
            public string? tipoCuenta { get; set; }    /*AccountType*/
            public decimal? saldoInicial { get; set; } /*InitialBalance*/
            public string? Email { get; set; }
    }
}