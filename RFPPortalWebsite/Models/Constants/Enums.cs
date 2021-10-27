﻿namespace RFPPortalWebsite.Models.Constants
{
    public class Enums
    {
       
        /// <summary>
        ///  Enum of log types in the system
        /// </summary>
        public enum LogTypes
        {
            PublicUserLog,
            UserLog,
            AdminLog,
            ApplicationLog,
            ApplicationError
        }


        /// <summary>
        ///  Enum of user authorization types
        /// </summary>
        public enum UserIdentityType
        {
            Admin,
            Associate,
            VotingAssociate
        }

        /// <summary>
        ///  Enum of user log types in the system
        /// </summary>
        public enum UserLogType
        {
            Auth,
            Request,
            Agreement
        }

    }
}
