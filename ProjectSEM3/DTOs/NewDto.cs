using System;
using ProjectSEM3.Entities;

namespace ProjectSEM3.DTOs
{
	public class NewDto
	{
        public int Id { get; set; }

        public string Title { get; set; }

        public string ShortDescription { get; set; }

        public string Thumbnail { get; set; }

        public string? Content { get; set; }

        public DateTime? Create_at { get; set; } = null!;

        public DateTime? Update_at { get; set; } = null!;

        public virtual ICollection<Admin> Admins { get; set; } = new List<Admin>();
    }
}

