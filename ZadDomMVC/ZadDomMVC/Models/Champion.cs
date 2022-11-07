namespace ZadDomMVC.Models
{
    public class Champion
    {

        public Champion(string name, string subname, string region, string role, string image, string description)
        {
            this.Name = name;
            this.Subname = subname;
            this.Region = region;
            this.Role = role;
            this.Image = image;
            this.Description = description;
        }

        public string Name { get; set; }

        public string Subname { get; set; }

        public string Region { get; set; }

        public string Role { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }
    }
}
