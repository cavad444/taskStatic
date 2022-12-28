using taskStatic;
Console.WriteLine("Bir eded daxil edin");
int decision = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("1.Create");
Console.WriteLine("2.Delete");
Console.WriteLine("3.Edit");
Console.WriteLine("4.GetAll");
Console.WriteLine("5.GetById");
Group studentGroup = new Group();
StudentService studentService = new StudentService();
while (decision != 0)
{
    decision = Convert.ToInt32(Console.ReadLine());
    if (decision == 1)
    {
        Console.WriteLine("Ad daxil edin");
        string name = Console.ReadLine();
        Console.WriteLine("Soyad daxil edin");
        string surname = Console.ReadLine();
        studentService.Create(name, surname, studentGroup);
    }
    else if (decision == 2)
    {
        Console.WriteLine("Index daxil edin");
        int id = Convert.ToInt32(Console.ReadLine());
        studentService.Delete(id, studentGroup);
    }else if(decision == 3)
    {
        Console.WriteLine("Index daxil edin");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ad daxil edin");
        string name = Console.ReadLine();
        Console.WriteLine("Soyad daxil edin");
        string surname = Console.ReadLine();

        studentService.Edit(id, name, surname, studentGroup);

        
    }else if(decision == 4)
    {
        studentService.GetAll(studentGroup);
    }else if(decision == 5)
    {
        Console.WriteLine("Index daxil edin");
        int id = Convert.ToInt32(Console.ReadLine());
        studentService.GetById(id,studentGroup);
    }

    studentGroup.GetAll(studentGroup);
}
Console.WriteLine("Cixdiniz");




    

