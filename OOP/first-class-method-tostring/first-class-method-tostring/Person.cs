namespace first_class_method_tostring
{
    public class Person
    {
        private string _name;

        public Person(string name)
        {
            _name = name;
        }

        public override string ToString()
        {
            return @"Hello! My name is " + _name.ToString();
        }
    }
}