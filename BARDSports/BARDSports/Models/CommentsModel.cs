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
        public virtual string Rating { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual PlayerModel Player { get; set; }
       

    }
}