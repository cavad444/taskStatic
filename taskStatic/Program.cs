using taskStatic;
Console.WriteLine("Bir eded daxil edin");
int decision = Convert.ToInt32(Console.ReadLine());

while (decision != 0) {
    Console.WriteLine("Ad daxil edin");
    string name = Console.ReadLine();
    Console.WriteLine("Soyad daxil edin");
    string surname = Console.ReadLine();
    Group studentGroup = new Group();
    StudentService studentService = new StudentService();
    studentService.Create(name, surname, studentGroup);
    studentService.GetAll(studentGroup);
    studentService.GetById(2,studentGroup);
}
Console.WriteLine("Cixdiniz!");




    

