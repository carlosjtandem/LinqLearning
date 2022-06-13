namespace LinqLibary
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastaName { get; set; }
        public int YearsOfExpericience { get; set; }
        public DateTime Birthday { get; set; }

        public string FullName
        {
            get { return String.Format("{0} {0}", FirstName, LastaName); }
        }


    }
}