namespace Arrays_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] students = new string[5];
            students[0] = "Salvador";
            students[1] = "Maria";
            students[2] = "Ivan";
            students[3] = "julio";
            students[4] = "Mariana";
            
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine(students.Length + " Students");
        }
    }
}
