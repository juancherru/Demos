using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace MusicStoreMVC.Models
{
    public partial class Album
    {
        public Album()
        {
            Tracks = new HashSet<Track>();
        }

        public long AlbumId { get; set; }
        public string Title { get; set; } = null!;

        [Display(Name = "Artist")]
        public long ArtistId { get; set; }

        [ValidateNever]
        public virtual Artist? Artist { get; set; }
        [ValidateNever]
        public virtual ICollection<Track> Tracks { get; set; }
    }
}
