namespace HajurKoCarRental.App.Routing
{
    public abstract class Class
    {
        private readonly string _name;
        public Class(string name) { 
           _name= name;
        }
    }

    public class Class2 : Class
    {
        //Class2(string x) : base(x) { }
        public Class2(string name) : base(name)
        {
        }
    }
}
