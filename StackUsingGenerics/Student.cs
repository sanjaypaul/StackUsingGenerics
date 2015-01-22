namespace StackUsingGenerics
{
    internal class Student
    {
        public string RegNo { set; get; }
        public string Name { set; get; }

        public Student(string regNo, string name)
        {
            RegNo = regNo;
            Name = name;
        }
    }
}