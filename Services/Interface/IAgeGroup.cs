
#region ClassHeader
//=============================================================================
// All rights reserved to [[Company]].
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR
// FITNESS FOR A PARTICULAR PURPOSE.
//=============================================================================

//*****************************************************************************
//* Name		    	: IAgeGroup
//* Type		    	: Interface
//* Description		    : Interface for Agegroup details
//* References		    :
//* Author	    		: 
//* Created Date        : 08-Aug-2017
//*****************************************************************************
//*                             MODIFICATION LOG
//*****************************************************************************
//* Ver	Date	     Modified By			Description
//*
//*
//****************************************************************************

//*                             Code Review LOG
//*****************************************************************************
//* Ver        Date                Code Review By            Observations
//*****************************************************************************
//*<summary>	Short description	Type or Member
//*<remarks>	Describes preconditions and other additional information	Type or member
//*<param>	Describes the parameters of a method	Method
//*<returns>	Describes the return value of a method	Method
#endregion

using System.Collections.Generic;
namespace V1.ProjectMonkey.Service.Interface
{
    public interface IAgeGroup
    {
        /// <summary> Method for getting All Age Group Details  </summary>
        /// <returns> List of All Age Groups </returns>
        /// <remarks>  </remarks>
        List<BusinessObjects.AgeGroup> GetAllAgeGroups();

        /// <summary> GetAllAgeGroupsByIDs method for getting All AgeGroups </summary>
        /// <param name="objects"></param>
        /// <returns> List of All AgeGroups</returns>
        /// <remarks>  </remarks>
        List<BusinessObjects.AgeGroup> GetAllAgeGroupsByIDs(List<BusinessObjects.Objects> objects);
    }
}
