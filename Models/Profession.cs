namespace Testgithub2.Models
{
    public class Profession : BaseEntity
    {
        public string Name { get; set; }
        //relation 
        public List<Employee> Employees { get; set; }
    }
}
