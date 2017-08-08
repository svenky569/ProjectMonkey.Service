#region ClassHeader
//=============================================================================
// All rights reserved to [[Company]].
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR
// FITNESS FOR A PARTICULAR PURPOSE.
//=============================================================================

//*****************************************************************************
//* Name		    	: AgeGroup
//* Type		    	: Class
//* Description		    : Age group details class
//* References		    :
//* Author	    		: krishna Murthy
//* Created Date        : Feb 09th 2015
//*****************************************************************************
//*                             MODIFICATION LOG
//*****************************************************************************
//* Ver	Date	     Modified By			Description
//*
//*
//*****************************************************************************

//*                             Code Review LOG
//*****************************************************************************
//* Ver        Date                Code Review By            Observations
//* 1.0        02/20/2015           Self

//* 1.0        02/20/2015          Pavan Kalyan Ram (Peer)    Organized code with regions
//*                                                          Class name should be in singular
//*****************************************************************************
#endregion

using System.Collections.Generic;
using V1.ProjectMonkey.DataObjects;
using V1.ProjectMonkey.DataObjects.Interface;
using V1.ProjectMonkey.DataObjects.SqlServer;
using V1.ProjectMonkey.Service.Interface;

namespace V1.ProjectMonkey.Service
{
    public class AgeGroup : ServiceBase, IAgeGroup
    {
        static readonly IAgeGroupDao AgeGroupDao = DataAccess.AgeGroupDao;

        /// <summary> Method for getting All Age Group Details  </summary>
        /// <returns> List of All Age Groups </returns>
        /// <remarks>  </remarks>

        public List<BusinessObjects.AgeGroup> GetAllAgeGroups()
        {
            AgeGroupDao.ConnectionString = ConnectionString;
            return AgeGroupDao.GetAllAgeGroups();
        }

        public List<BusinessObjects.AgeGroup> GetAllAgeGroupsByIDs(List<BusinessObjects.Objects> objects)
        {
            AgeGroupDao.ConnectionString = ConnectionString;
            return AgeGroupDao.GetAllAgeGroupsByIDs(objects);
        }
    }
}
