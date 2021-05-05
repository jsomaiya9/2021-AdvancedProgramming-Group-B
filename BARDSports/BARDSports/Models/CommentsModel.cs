using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BARDSports.Models
{
    public class CommentsModel
    {

        [Key]
        //Encapsulation get, set methods
        public virtual int CommentsId { get; set; }//primary key       
        public virtual int PlayerId { get; set; } //foreign key       
        public virtual string Id { get; set; } //foreign key
        public virtual int Rating { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual PlayerModel Player { get; set; }




        public string valid(int rating, DateTime date)
        {
            string ErrorMessage = "";

            if (date < DateTime.Now.AddYears(-1))
            {
                ErrorMessage = "Too long ago";
            }
            if (date > DateTime.Now.AddYears(+10))
            {
                ErrorMessage = "Too far in the future";
            }

            if (rating < 0)
            {
                ErrorMessage = "Too low rating";
            }
            if (rating > 10)
            {
                ErrorMessage = "To high rating";
            }

            return ErrorMessage;
        }
    }
}