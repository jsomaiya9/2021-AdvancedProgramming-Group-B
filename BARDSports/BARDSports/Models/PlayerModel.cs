using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BARDSports.Models
{
    public class PlayerModel
    {
        [Key]
        //Encapsulation get, set methods
        public virtual int PlayerId { get; set; }//primary key
        public virtual int FootballClubId { get; set; }//foreign key
        public virtual string Firstname { get; set; }
        public virtual string Lastname { get; set; }
        public virtual DateTime DateOfBirth { get; set; }
        public virtual string Position { get; set; }
        public virtual int Goals { get; set; }
        public virtual int Assists { get; set; }
        public virtual int YellowCards { get; set; }
        public virtual int RedCards { get; set; }
        public virtual FootballClubModel Football { get; set; }

    }
}