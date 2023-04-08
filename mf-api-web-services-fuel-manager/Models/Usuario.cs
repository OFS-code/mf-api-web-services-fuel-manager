﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_api_web_services_fuel_manager.Models
{
    [Table("Usuario")]
    public class Usuario : LinksHATEOS
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public Perfil Perfil { get; set; }

        public ICollection<VeiculoUsuarios> Veiculos { get; set; }
    }
    public enum Perfil
    {
        [Display(Name = "Administrador")]
        Administrador,
        [Display(Name = "Usuario")]
        Usuario
    }
}
