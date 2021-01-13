using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    /// <summary>
    /// represents a person
    /// </summary>
    public class Person
    {
        /// <summary>
        /// unique identifier
        /// </summary>
        public int ID { get; set; } = 0;
        /// <summary>
        /// first name of person
        /// </summary>
        public string FirstName { get; set; } = "";
        /// <summary>
        /// last name of person
        /// </summary>
        public string LastName { get; set; } = "";
    }
}