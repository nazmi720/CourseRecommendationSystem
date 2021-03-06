﻿using CRS.Entity.Generics;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CRS.Entity.Models
{
    public class ProgramCourseAssociation : BaseEntity
    {
        // Database fields
        [Column("ProgramCourseAssociationId")]
        [Key]
        public override int Id { get; set; }
        public int ProgramId { get; set; }
        public int CourseId { get; set; }

        // Navigation properties
        [ForeignKey("ProgramId")]
        public virtual Program Program { get; set; }
        [ForeignKey("CourseId")]
        public virtual Course Course { get; set; }
    }
}
