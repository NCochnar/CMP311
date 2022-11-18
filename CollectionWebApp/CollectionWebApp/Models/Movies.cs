using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using CollectionWebApp.Models;

namespace CollectionWebApp.Models
{
    public class Movies
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool Watched { get; set; }
    }
}

