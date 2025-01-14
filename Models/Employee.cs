namespace Testgithub2.Models
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        //relation
        public int ProfessionId { get; set; }
        public Profession Profession { get; set; }
        

    }
}
