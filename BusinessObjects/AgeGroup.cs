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
//* Description		    : 		
//* References		    :                                                        			
//* Author	    		: Krishna Murthy
//* Created Date       : Feb 09th 2015					
//*****************************************************************************					
//*                             MODIFICATION LOG					
//*****************************************************************************					
//* Ver 	Date	            Modified By			Description
//* 					
//***************************************************************************** 
//*                             Code Review LOG                    
//*****************************************************************************                    
//* Ver        Date                Code Review By            Observations

//*****************************************************************************  
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjectMonkey.Framework.BusinessObjects;

namespace V1.ProjectMonkey.BusinessObjects
{
    [Serializable]
    public sealed class AgeGroup : BaseMaster
    {
        #region Constuctor
        /// <summary>
        /// Default constructor
        /// </summary> 
        public AgeGroup()
            : base()
        {
            AgeGroupID = null;
            AgeGroupCode = null;
            AgeGroupNCode = null;
            AgeGroupName = null;
            RangeStartNo = null;
            RangeEndNo =    null;
            IsYears = false;
            IsSystemDefined = false;
            DisplaySequence = null;
            IsActive = true ;
            IsDeleted = false;
            CreatedByUserID = null;
            CreatedDateTime = null;
            LastUpdatedByUserID = null;
            LastUpdatedDateTime = null;
        }

        #endregion constuctor

        #region Properties

        public int? AgeGroupID { get; set; }
        public String AgeGroupCode { get; set; }
        public String AgeGroupNCode { get; set; }
        public String AgeGroupName { get; set; }
        public decimal? RangeStartNo { get; set; }
        public decimal? RangeEndNo { get; set; }
        public bool? IsYears { get; set; }
      
        #endregion Properties




    }
}
