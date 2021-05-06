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

        public static string valid(string Firstname, string Lastname, DateTime DateOfBirth, string Position, int Goals, int Assists, int YellowCards, int RedCards)
        {
            //var to store the error message
            string errorMsg = "";

            //check the min length of the firstname
            if (Firstname.Length < 2)
            {
                //set the error messsage
                errorMsg = "Firstname is too short";
            }

            if (Firstname.Length > 20)
            {
                //set the error messsage
                errorMsg = "Firstname is too long";
            }

            if (Lastname.Length < 2)
            {
                //set the error messsage
                errorMsg = "Lastname is too short";
            }

            if (Lastname.Length > 50)
            {
                //set the error messsage
                errorMsg = "Lastname is too long";
            }


            if (DateOfBirth < DateTime.Now.AddYears(-16))
            {
                //set the error messsage
                errorMsg = "too old";
            }
            if (DateOfBirth > DateTime.Now.AddYears(+100))
            {
                //set the error messsage
                errorMsg = "too young";
            }

            if (Goals < 0)
            {
                //set the error messsage
                errorMsg = "Cannot have negative goals";
            }
            if (Assists < 0)
            {
                //set the error messsage
                errorMsg = "Cannot have negative assists";
            }
            if (YellowCards < 0)
            {
                //set the error messsage
                errorMsg = "Cannot have negative yellow cards";
            }
            if (RedCards < 0)
            {
                //set the error messsage
                errorMsg = "Cannot have negative red cards";
            }

            return errorMsg;
        }

    }
}