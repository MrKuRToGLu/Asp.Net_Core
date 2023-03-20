namespace _11_DependencyInjection_LifeTime.Models
{
    public class MyClass
    {
        public Guid uid { get; }
        //public int num { get; }
        public MyClass()
        {
            uid = Guid.NewGuid(); // Guid tipinde değer oluşuturulur
            //Random rnd = new Random();
            //num = rnd.Next(0, int.MaxValue);
        }
    }
}