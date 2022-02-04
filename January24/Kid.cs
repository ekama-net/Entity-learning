
namespace January24
{
    public class Kid
    {
        public int Id { get; set; }
        public int TestProp { get; set; }

        public ICollection <People>? Peoples { get; set; }
    }
}
