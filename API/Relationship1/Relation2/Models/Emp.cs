namespace Relation2.Models
{
    public class Emp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmpNo { get; set; }
        [Required]
        public string EmpName { get; set; } = string.Empty;
        
        public Dept? DeptNo { get; set; }
        public virtual Dept? DeptnoNavigation { get; set; }

    }
}
