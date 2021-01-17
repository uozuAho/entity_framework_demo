namespace EfDemo.Db
{
    public class BoxOffice
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public double Rating { get; set; }
        public long DomesticSales { get; set; }
        public long InternationalSales { get; set; }

        public virtual Movie Movie { get; set; }
    }
}
