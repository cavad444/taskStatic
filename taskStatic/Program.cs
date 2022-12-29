using taskStatic;

Console.WriteLine("0.Cixish");
Console.WriteLine("1.Create");
Console.WriteLine("2.Delete");
Console.WriteLine("3.Edit");
Console.WriteLine("4.GetAll");
Console.WriteLine("5.GetById");
Console.WriteLine("Yuxaridakilardan birini sechin.");
string decision = Console.ReadLine();

Group studentGroup = new Group();
StudentService studentService = new StudentService();
if (string.IsNullOrEmpty(decision))
{
    Console.WriteLine("Sechiminizi bosh saxlaya bilmersiniz!!!!!");
}
else
{
    while (decision != "0")
    {

        if (decision == "1")
        {
            Console.WriteLine("Ad daxil edin");
            string name = Console.ReadLine();
            Console.WriteLine("Soyad daxil edin");
            string surname = Console.ReadLine();
            Console.WriteLine("Ortalama daxil edin");
            double avarage = Convert.ToInt32(Console.ReadLine());
            studentService.Create(name, surname, avarage, studentGroup);
        }
        else if (decision == "2")
        {
            Console.WriteLine("Index daxil edin");
            int id = Convert.ToInt32(Console.ReadLine());
            studentService.Delete(id, studentGroup);
        }
        else if (decision == "3")
        {
            Console.WriteLine("Index daxil edin");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ad daxil edin");
            string name = Console.ReadLine();
            Console.WriteLine("Soyad daxil edin");
            string surname = Console.ReadLine();
            double avarage = Convert.ToInt32(Console.ReadLine());
            studentService.Create(name, surname, avarage, studentGroup);

            studentService.Edit(id, name, surname, avarage, studentGroup);


        }
        else if (decision == "4")
        {
            studentService.GetAll(studentGroup);
        }
        else if (decision == "5")
        {
            Console.WriteLine("Index daxil edin");
            int id = Convert.ToInt32(Console.ReadLine());
            studentService.GetById(id, studentGroup);
        }
        else
        {
            Console.WriteLine("Yanlish sechim etdiniz!");
        }
        Console.WriteLine("Bir sechim edin");
        decision = Console.ReadLine();

    }
    Console.WriteLine("Cixdiniz");
}





