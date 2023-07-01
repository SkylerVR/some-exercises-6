using some_exercises_6;

Student student = new Student();
Console.WriteLine("name: " + student.name);
Console.WriteLine("lastname: " + student.lastName);
Console.WriteLine("Gpa: " + student.Gpa);

Rectangle rectangle = new Rectangle();
Console.WriteLine("Area: " + rectangle.getArea());

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
Triangle triangle = new Triangle();
Console.WriteLine("Perimeter: " + triangle.GetPerimeter(a,b,c));

