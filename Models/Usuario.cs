using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sharks.Sprint04.Web.Models
{
    [Table("T_ACI_USUARIO_CHUVEIRO")] // Nome da tabela
    public class Usuario
    {
        [Column("Id"), HiddenInput] // Nome da coluna
        public int UsuarioId { get; set; }

        [Required, MaxLength(64)]
        public string Nome { get; set; }

        public int Celular { get; set; }

        [Required, MaxLength(50)]
        public string Email { get; set; }

        [Required, MaxLength(64)]
        public string Senha { get; set; }

        [Column("Dt_Nascimento"), Required, DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
        public Genero? Genero { get; set; }
        public Pressao Pressao { get; set; }
        public int Temperatura { get; set; }
        public float? Duracao { get; set; }
    }

    public enum Genero
    {
        Feminino, Masculino, Outro
    }

    public enum Pressao
    {
        Fraca, Media, Forte
    }
}
