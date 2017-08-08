#region ClassHeader
//=============================================================================
// All rights reserved to [[Company]].
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR
// FITNESS FOR A PARTICULAR PURPOSE.
//=============================================================================

//*****************************************************************************
//* Name		    	: AgeGroupsDao
//* Type		    	: Class
//* Description		    :
//* References		    :
//* Author	    		: 
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
// *****************************************************************************
#endregion

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using ProjectMonkey.Framework.DataObjects;
using V1.ProjectMonkey.DataObjects.Interface;
using V1.ProjectMonkey.BusinessObjects;

namespace V1.ProjectMonkey.DataObjects.SqlServer
{
    public class AgeGroupDao : BaseDao, IAgeGroupDao
    {
        /// </summary>
        ///
        #region "SP Names"
        //Sp to get all age groups...
        private readonly string SPGetAllAgeGroups = "[Rbsk].[uspAgeGroups_GetAllAgeGroups]";
        private readonly string SPGetAllAgeGroupsByIDs = "[Rbsk].[uspAgeGroups_GetAllAgeGroupDetailsByAgeGroupIDs]";

        #endregion "SP Names"

        #region "Method"
        /// <summary> GetAllAgeGroups method for getting All Age groups </summary>
        /// <returns> List of AllAgeGroups</returns>
        /// <remarks>  </remarks>
        public List<AgeGroup> GetAllAgeGroups()
        {

            return DbCore.ReadList<AgeGroup>(SPGetAllAgeGroups, Make, ConnectionString, CommandType.StoredProcedure);
        }

        /// <summary> GetAllAgeGroupsByIDs method for getting All AgeGroup Details </summary>
        /// <param name="objects">The objects.</param>
        /// <returns>  List of All AgeGroup Details  </returns>
        ///
        public List<AgeGroup> GetAllAgeGroupsByIDs(List<BusinessObjects.Objects> objects)
        {
            string CSVAgeGroup = string.Join(",", objects.Select(p => p.ID.ToString()));
            CSVAgeGroup = CSVAgeGroup.Trim(',');
            return DbCore.ReadList<AgeGroup>(SPGetAllAgeGroupsByIDs, Make, ConnectionString, CommandType.StoredProcedure, DbCore.CreateParameter("@AgeGroupsIDs", CSVAgeGroup));
        }


        public static Func<IDataReader, AgeGroup> Make = reader => new BusinessObjects.AgeGroup
        {
            AgeGroupID = (reader.ContainsColumn("AgeGroupID") && reader["AgeGroupID"] != DBNull.Value ? reader["AgeGroupID"].AsInt() : (int?)null),
            AgeGroupCode = (reader.ContainsColumn("AgeGroupCode") && reader["AgeGroupCode"] != DBNull.Value ? reader["AgeGroupCode"].AsString() : null),
            RangeEndNo = (reader.ContainsColumn("RangeEndNo") && reader["RangeEndNo"] != DBNull.Value ? (decimal)reader["RangeEndNo"] : 0),
            RangeStartNo = (reader.ContainsColumn("RangeStartNo") && reader["RangeStartNo"] != DBNull.Value ? (decimal)reader["RangeStartNo"] : 0),
            AgeGroupName = (reader.ContainsColumn("AgeGroupName") && reader["AgeGroupName"] != DBNull.Value ? reader["AgeGroupName"].AsString() : null),
            IsYears = (reader.ContainsColumn("IsYears") && reader["IsYears"] != DBNull.Value ? reader["IsYears"].AsBool() : false),
            AgeGroupNCode = (reader.ContainsColumn("AgeGroupNCode") && reader["AgeGroupNCode"] != DBNull.Value ? reader["AgeGroupNCode"].AsString() : null),
            IsActive = (reader.ContainsColumn("IsActive") && reader["IsActive"] != DBNull.Value ? reader["IsActive"].AsBool() : false),
            IsDeleted = (reader.ContainsColumn("IsDeleted") && reader["IsDeleted"] != DBNull.Value ? reader["IsDeleted"].AsBool() : false),
            CreatedByUserID = (reader.ContainsColumn("CreatedByUserID") && reader["CreatedByUserID"] != DBNull.Value ? reader["CreatedByUserID"].AsInt() : (int?)null),
            CreatedDateTime = (reader.ContainsColumn("CreatedDateTime") && reader["CreatedDateTime"] != DBNull.Value ? reader["CreatedDateTime"].AsDateTime() : (DateTime?)null),
            LastUpdatedByUserID = (reader.ContainsColumn("LastUpdatedByUserID") && reader["LastUpdatedByUserID"] != DBNull.Value ? reader["LastUpdatedByUserID"].AsInt() : (int?)null),
            LastUpdatedDateTime = (reader.ContainsColumn("LastUpdatedDateTime") && reader["LastUpdatedDateTime"] != DBNull.Value ? reader["LastUpdatedDateTime"].AsDateTime() : (DateTime?)null),
            DisplayText = (reader.ContainsColumn("DisplayText") && reader["DisplayText"] != DBNull.Value ? reader["DisplayText"].AsString() : null),
            DisplaySequence = (reader.ContainsColumn("DisplaySequence") && reader["DisplaySequence"] != DBNull.Value ? reader["DisplaySequence"].AsInt() : (int?)null)
        };
        #endregion "Method"
    }
}

