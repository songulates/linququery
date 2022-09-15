using linqpratik.DBOperations;
namespace linqpratik
{
    class Program
    {
        //datageneratörü çalıştırcaz ve veriyi database insert edicez
        static void Main(string[] args)
        {
            DataGenerator.Initialize();
            LinqContextDb _context=new LinqContextDb();
            var students=_context.Students.ToList<Student>();
            //find metodu dbset'de arama yaparak veriye ulaşmayı sağlıyor
            var student=_context.Students.Where(student=>student.StudentId==1).FirstOrDefault();//ilk veriyi
            student=_context.Students.Find(1);
            Console.WriteLine(student.name); //1 numaralı verinin name ni getirck bized
            //firstordefault eleman bulamasa geriye nul döndürüün firs te hata fırlatır bulamazsa fırlatır
            student=_context.Students.Where(student=>student.surname=="canan").FirstOrDefault();
             Console.WriteLine(student.name); 
            //yada
            student=_context.Students.FirstOrDefault(x=>x.surname=="canan");
             Console.WriteLine(student.name); 
             //Singleordefaut sadevce 1 veri getiriyo
             student=_context.Students.SingleOrDefault(student=>student.surname=="can");
             Console.WriteLine(student.ClassId);
             //to list
            var studentlist=_context.Students.Where(student=>student.ClassId==2).ToList();//ilk veriyi
            Console.WriteLine(studentlist.Count);
            //order by
            students=_context.Students.OrderBy(x=>x.StudentId).ToList();
            foreach (var st in students)
            {
                Console.WriteLine(st.StudentId+" - "+st.name+ " "+st.surname);
            }
            students=_context.Students.OrderByDescending(x=>x.StudentId).ToList();//sondan başa sırala
            foreach (var st in students)
            {
                Console.WriteLine(st.StudentId+" - "+st.name+ " "+st.surname);
            }
            //anonuymus object result
            var anoymusobject=_context.Students.Where(x=>x.ClassId==2).Select(x=> new {
                id=x.StudentId,  //buraya maple
                fullname=x.name +" "+x.surname
            });
            foreach (var obj in anoymusobject)
            {
                 Console.WriteLine(obj.id+" - "+obj.fullname);
            } //select yeni birobje oluşturuyo

        }
    }
}