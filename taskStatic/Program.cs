using taskStatic;
Console.WriteLine("Ad daxil edin");
string name = Console.ReadLine();
Console.WriteLine("Soyad daxil edin");
string surname = Console.ReadLine();
Group studentGroup = new Group();
StudentService studentService = new StudentService();
studentService.Create(name,surname,studentGroup);
studentService.GetAll(studentGroup);



    

