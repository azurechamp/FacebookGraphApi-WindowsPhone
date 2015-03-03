using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook
{

    public class CategoryList
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Cover
    {
        public long cover_id { get; set; }
        public int offset_x { get; set; }
        public int offset_y { get; set; }
        public string source { get; set; }
        public string id { get; set; }
    }

    public class Location
    {
        public string city { get; set; }
        public string country { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string zip { get; set; }
    }

    public class Parking
    {
        public int lot { get; set; }
        public int street { get; set; }
        public int valet { get; set; }
    }

    public class RootObject
    {
        public string id { get; set; }
        public string about { get; set; }
        public string awards { get; set; }
        public bool can_post { get; set; }
        public string category { get; set; }
        public List<CategoryList> category_list { get; set; }
        public int checkins { get; set; }
        public Cover cover { get; set; }
        public bool has_added_app { get; set; }
        public bool is_community_page { get; set; }
        public bool is_published { get; set; }
        public int likes { get; set; }
        public string link { get; set; }
        public Location location { get; set; }
        public string name { get; set; }
        public Parking parking { get; set; }
        public string phone { get; set; }
        public int talking_about_count { get; set; }
        public string username { get; set; }
        public string website { get; set; }
        public int were_here_count { get; set; }
    }
}
