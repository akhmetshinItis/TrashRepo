using System.Text;

namespace ControlWork;

public class Student
{
    public string name { get; set; }
    public int group { get; set; }

    public Student(string name, int group)
    {
        this.name = name;
        this.group = group;
    }

    public override string ToString()
    {
        return $"{name} {group}";
    }
    
    public override bool Equals(object obj)
    {
        if (obj == null)
        {
            return false;
        }
        Student other = (Student)obj;
        return (name == other.name) && (group == other.group);
    }
}