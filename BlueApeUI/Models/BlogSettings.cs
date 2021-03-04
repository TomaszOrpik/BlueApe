using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlueApeUI.Models
{
    public class BlogSettings
    {
        public BlogSettings(string title, string logoUrl, string description, 
                            string primaryColor, string secondaryColor, string backgroundColor, 
                            List<string> categories, List<string> pages, string facebookLink, string instagramLink, string twitterLink)
        {
            this.title = title;
            this.logoUrl = logoUrl;
            this.description = description;
            this.primaryColor = primaryColor;
            this.secondaryColor = secondaryColor;
            this.backgroundColor = backgroundColor;
            this.categories = categories;
            this.pages = pages;
            this.facebookLink = facebookLink;
            this.instagramLink = instagramLink;
            this.twitterLink = twitterLink;
        }
        [Required]
        public string title { get; set; }
        public string logoUrl { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        public string primaryColor { get; set; }
        [Required]
        public string secondaryColor { get; set; }
        [Required]
        public string backgroundColor { get; set; }

        [Required]
        public List<string> categories { get; set; }
        [Required]
        public List<string> pages { get; set; }
        public string facebookLink { get; set; }
        public string instagramLink { get; set; }
        public string twitterLink { get; set; }
    }
    public class Page
    {
        public Page(string title, string imageUrl, string[] categories,
                    string date, string intro, string content)
        {
            this.title = title;
            this.imageUrl = imageUrl;
            this.categories = categories;
            this.date = date;
            this.intro = intro;
            this.content = content;
        }
        [Required]
        public string title { get; set; }
        [Required]
        public string imageUrl { get; set; }
        [Required]
        public string[] categories { get; set; }
        [Required]
        public string date { get; set; }
        [Required]
        public string intro { get; set; }
        [Required]
        public string content { get; set; }
    }
}
