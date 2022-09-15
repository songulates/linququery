using System.ComponentModel.DataAnnotations.Schema;

namespace linqpratik
{
    public class Student
    {
        //id nin autoincrement arttış için
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//prop metodu kulan özellik oluştururkn
        
        public int StudentId { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int ClassId { get; set; }
        

    }
}