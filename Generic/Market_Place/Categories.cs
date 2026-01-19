namespace Generic.Market_Place
{
    public class BookCategory : Category
    {
        public string Genre { get; set; }

        public BookCategory(string name, string genre)
        {
            this.name = name;
            Genre = genre;
        }
    }

    public class ClothingCategory : Category
    {
        public string Size { get; set; }

        public ClothingCategory(string name, string size)
        {
            this.name = name;
            Size = size;
        }
    }
}
