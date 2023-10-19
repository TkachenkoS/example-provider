
namespace Walks
{
    public class Walk
    {
        public Walk(int id, string name, string status) {
            this.Id = id;
            this.Name = name;
            this.Status = status;
        }
        public string Status { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
