namespace DesignPattern.CQRS.CQRSPattern.Results
{
    public class GetProductUpdateQueryResult
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
}
