#region ClassHeader
//=============================================================================					
// All rights reserved to [[Company]].					
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY					
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT					
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR					
// FITNESS FOR A PARTICULAR PURPOSE.					
//=============================================================================					

//*****************************************************************************					
//* Name		    	: IAgeGroupDao		
//* Type		    	: Interface		
//* Description		    : Data object Interface for Age groups 		
//* References		    :                                                        			
//* Author	    		: Krishna Murthy
//* Created Date       : Feb 09th 2015					
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

//* 1.0        02/24/2015           Pavan      Interface name should be in singular 

//1.0         02/26/2015         Krishna Murthy              Added Comments                                   
//*****************************************************************************  
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  V1.ProjectMonkey.BusinessObjects;
using V1.ProjectMonkey.BusinessObjects;

namespace V1.ProjectMonkey.DataObjects.Interface
{
    public interface IAgeGroupDao
    {
        /// <summary>
        /// Connection String
        /// </summary>
        string ConnectionString { get; set; }
        /// <summary> GetAllAgeGroups method for getting All Age Groups </summary>                
        /// <returns> List of All Age Groups</returns>
        /// <remarks>  </remarks>
        List<AgeGroup> GetAllAgeGroups();

        /// <summary> GetAllAgeGroupsByIDs method for getting All AgeGroups </summary>   
        /// <param name="objects"></param>
        /// <returns> List of All AgeGroups</returns>
        /// <remarks>  </remarks>
        List<AgeGroup> GetAllAgeGroupsByIDs(List<Objects> objects);
    }
}
