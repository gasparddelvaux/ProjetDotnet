using ProjetDotnet.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDotnet.Domain.NewFolder
{
    internal class Tasks : Entity
    {
        public int Id { get; set; }

        public string Titre { get; set; }

        public string Description { get; set; }

        public DateTime DateEcheance { get; set; }

        public bool Statut { get; set; }

        public string? UserId { get; set; }

        public Users.User? Utilisateur { get; set; }
    }
}
