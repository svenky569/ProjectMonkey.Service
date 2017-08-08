#region "Class Header"
//=============================================================================					
// All rights reserved to Nunet Cube Software Solutions.					
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY					
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT					
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR					
// FITNESS FOR A PARTICULAR PURPOSE.					
//=============================================================================					

//*****************************************************************************					
//* Name		    	:   CHC		
//* Type		    	:   Class		
//* Description		    : 		
//* References		    :                                                        			
//* Author	    		:   SivaKumar Jallu
//* Created Date        :   April 06th 2015					
//*****************************************************************************					
//*                             MODIFICATION LOG					
//*****************************************************************************					
//* Ver 	Date	            Modified By			Description
//* 					
//***************************************************************************** 	
//*                             Code Review LOG                    
//*****************************************************************************                    
//* Ver        Date                Code Review By            Observations
//*
//*****************************************************************************  	
#endregion "Class Header"

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nunet.Framework.BusinessObjects;

namespace Nunet.RBSK.BusinessObjects
{
    [Serializable]
    public sealed class CHC : BaseMaster
    {
        #region Constuctor
        /// <summary>
        /// Default constructor
        /// </summary> 
        public CHC()
            : base()
        {

            CHCID = 0;
            CHCName = null;
            CHCNcode = null;
            DistrictID = 0;
            IsSystemDefined = false;
            DisplaySequence = 0;
            IsActive = false;
            IsDeleted = false;
            CreatedByUserID = 0;
            CreatedDateTime = null;
            LastUpdatedByUserID = 0;
            LastUpdatedDateTime = null;
        }

        #endregion constuctor

        #region Properties

        public int CHCID { get; set; }
        public String CHCName { get; set; }
        public String CHCNcode { get; set; }
        public int DistrictID { get; set; }
        #endregion Properties


    }
}
