﻿using CRS.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRS.DAL.Interfaces
{
    public interface IProgramCourseAssociationRepository : IGenericRepository<ProgramCourseAssociation>
    {
        void DeleteCollection(IEnumerable<ProgramCourseAssociation> programCourseAssociations);
    }
}
