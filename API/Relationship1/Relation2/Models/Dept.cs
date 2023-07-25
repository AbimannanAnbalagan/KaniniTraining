using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Relation2.Models
{
    public class Dept
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int Deptno { get; set; }
        [Required]
        public string DeptName { get; set; } = string.Empty;

        public ICollection<Emp>? EmpRef { get; set; }
    }
}
