namespace linqpratik.DBOperations
{
    public class DataGenerator
    {
        public static void Initialize()
        {
            //datamız yok datagenerator oluşturalım
            using(var context= new LinqContextDb()) //linqcontextin defaut contractörünü çalıştırarak bir nesnesini oluşturduk
            {
                if(context.Students.Any())//hiç elemanı varmı diye bakıyoruz
                {
                    return; //veri varsa çık burdan
                } 
                //veri yoksa
                context.Students.AddRange
                (
                 //edrange birden fazla ekleme yapıyo
                //ilk verimizi ekleyelim
                    new Student()
                    {
                        
                        name="ayşe",
                        surname="test",
                        ClassId=1
                    },
                    new Student()
                    {
                        
                        name="eylül",
                        surname="can",
                        ClassId=1
                    },
                    new Student()
                    {
                        
                        name="cemre",
                        surname="canan",
                        ClassId=2
                    },
                    new Student()
                    {
                       
                        name="ibrahim",
                        surname="melisa",
                        ClassId=2
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
  //sonra programcs ye gidip datageneratörü çalıştırcaz ve veriyi database insert edicez      