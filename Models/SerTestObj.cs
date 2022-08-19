using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace SerTestCore.Models
{
    /// <summary>
    /// Dato base SerTest
    /// </summary>
	[DataContract]
    public class SerTestObj
    {
		/// <summary>
		/// ID
		/// </summary>
		[DataMember(Name = "ID")]
		[Required]
		public int id { get; set; }

		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "Name")]
		[Required]
		public string name { get; set; }="";

        /// <summary>
		/// Value
		/// </summary>
		[DataMember(Name = "Value")]
		[Required]
		public string value { get; set; }="";
	}
}