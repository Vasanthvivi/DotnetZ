using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Go.Models
{
    [MetadataType(typeof(TableMetaData))]
    public partial class Table
    {

    }
    public class TableMetaData
    {
        [Required(AllowEmptyStrings =false,ErrorMessage ="Please provide FirstName")]
        public string FirstName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide LastName")]
        public string LastName { get; set; }
    }
}