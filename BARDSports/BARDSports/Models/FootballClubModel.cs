using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BARDSports.Models
{
    
    public class FootballClubModel
    {
        [Key]
        //Encapsulation get, set methods
        public virtual int FootballClubId { get; set; }//primary key
        public virtual int LeagueId { get; set; }//foreign key
        public virtual string FootballClubName { get; set; }
        public virtual int Goals { get; set; }
        public virtual int Passes { get; set; }
        public virtual int Cleansheets { get; set; }
        public virtual int Wins { get; set; }
        public virtual int Draws { get; set; }
        public virtual int Lost { get; set; }
        public virtual int Points { get; set; }
        public virtual LeagueModel League { get; set; }




    }
}