﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class UserComment
    {
        [Key]
        public int UserCommentID { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public int CommentId { get; set; }
        public Comments Comments { get; set; }
    }
}
