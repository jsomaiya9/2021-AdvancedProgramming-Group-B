using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BARDSports.Models
{
    public class PlayerFansModel
    {
        [Key]
        public virtual int PlayerFansId { get; set; }//primary key
        
        public virtual int PlayerId { get; set; }//foreign key
        
        public virtual string Id { get; set; }//foreign key
        
        public virtual PlayerModel Player { get; set; }
       
      

    }
}