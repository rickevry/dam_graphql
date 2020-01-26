public class Publication  {
    public string Guid { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public List<Edition> Editions { get; set; }
}