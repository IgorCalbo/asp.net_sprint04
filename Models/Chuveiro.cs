using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sharks.Sprint04.Web.Models
{
    [Table("T_ACI_CHUVEIRO")] // Nome da tabela
    public class Chuveiro
    {
        [Column("Id"), HiddenInput] // Nome da coluna
        public int ChuveiroId { get; set; }

        [Required, MaxLength(15)]
        public string Pressao { get; set; }

        public int Temperatura { get; set; }

        public float? Duracao { get; set; }
    }
}
