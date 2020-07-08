﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one person.
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// The Unique identifier for the person.
        /// </summary>

        public int Id { get; set; }

        /// <summary>
        /// The first name of the person.
        /// </summary>

        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the person.
        /// </summary>

        public string LastName { get; set; }

        /// <summary>
        /// The primary email adress of the person.
        /// </summary>

        public string EmailAdress { get; set; }

        /// <summary>
        /// The primary cell phone number of the person.
        /// </summary>

        public string CellphoneNumber { get; set; }
   

        public string FullName
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
            
        }

    }
}
