using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;


namespace UrlShortener2.Entities

{
    public class UrlEntity : DbContext
    {

        public string DbPath { get; }

        public UrlEntity()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "urls.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

    }

    public class UrlModel
    {
        public int id { get; set; }
        public string shortUrl { get; set; }

        public string fullUrl { get; set; } 
    }

}

