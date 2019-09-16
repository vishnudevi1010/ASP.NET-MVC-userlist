using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace entityframe.Models.entities
{
    [ModelMetadataType(typeof(UserMetadataType))]

    public partial class User
    {
    }
    public partial class UserMetadataType
    {
        [Required,StringLength(30)]
        public string firstname { get; set; }
        [Required, StringLength(30)]
        public string lastname { get; set; }
        [Required, EmailAddress]
        public string email { get; set; }
    }
}
