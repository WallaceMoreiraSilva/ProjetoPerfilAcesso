using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPerfilAcesso.Models
{    
    public class PerfilUsuario
    {
        [Display(Name = "Código")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "TipoUsuario")]
        [ForeignKey("TipoUsuario")]
        [Column(Order = 1)]
        public int IdTipoUsuario { get; set; }

        public virtual TipoUsuario TipoUsuario { get; set; }


        //Não precisa criar Usuario na minha Model o Identity ja faz isso. Só preciso referenciar aqui
        [Display(Name = "Usuário")]
        [ForeignKey("IdentityUser")]
        [Column(Order = 1)]
        public string UserId { get; set; }

        public virtual IdentityUser IdentityUser { get; set; }



    }
}
