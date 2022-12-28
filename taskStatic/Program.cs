using taskStatic;

Student student = new();
Group studentGroup = new Group();
StudentService studentService = new StudentService();
studentService.Create("cavad","manafov",studentGroup);
studentService.GetAll(studentGroup);



    

