using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using BARDSports.Models;

namespace BARDSports.Models
{
    public class LeagueModel
    {
        [Key]
        //Encapsulation get, set methods
        public virtual int LeagueId { get; set; }//primary key
        public virtual string LeagueName { get; set; }
        public virtual string Description { get; set; }
        public virtual string Seasons { get; set; }

        public string valid(string LeaugeName, string Description, string Seasons)
        {
            string ErrorMessage = "";

            //LeaugeName
            if (LeaugeName.Length < 2)
            {
                ErrorMessage = "Too Short";
            }
            if (LeaugeName.Length > 30)
            {
                ErrorMessage = "Too long";
            }
            //Description
            if (Description.Length < 1)
            {
                ErrorMessage = "Too Short";
            }
            if (Description.Length > 50)
            {
                ErrorMessage = "Too long";
            }
            //Seasons
            if (Seasons.Length < 7)
            {
                ErrorMessage = "Too short";
            }
            if (Seasons.Length > 7)
            {
                ErrorMessage = "Too long";
            }

            return ErrorMessage;
        }
    }


}