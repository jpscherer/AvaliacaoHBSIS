//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class BOOK
    {
        [DisplayName("Id")]
        [Required]
        public int ID { get; set; }
        [DisplayName("T�tulo")]
        [Required]
        public string TITLE { get; set; }
        [DisplayName("Descri��o")]
        [Required]
        public string DESCRIPTION { get; set; }
        [DisplayName("Data Lan�amento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required]
        public System.DateTime RELEASE_DATE { get; set; }
    }
}
