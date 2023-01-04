using Course;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

Course12 c1=new Course12(1,"Akshay",10000,6);
Course12 c2=new Course12(2,"Yash",20000,6);
Course12 c3=new Course12(3,"Vaibhav",30000,6);
Course12 c4=new Course12(4,"Aniket",3000,6);
Course12 c5=new Course12(5,"Ashutosh",60000,6);

List<Course12> courses = new List<Course12>();
// Console.Write(" \n Enter id,name,fees,duration \n \n");
// int id= (int)Convert.ToInt64(Console.ReadLine());
// String name=Console.ReadLine();
// int fees= (int)Convert.ToInt64(Console.ReadLine());
// int duration=(int)Convert.ToInt64(Console.ReadLine());

// Course12 c= new Course12(id,name,fees,duration);

// courses.Add(c);
courses.Add(c1);
courses.Add(c2);
courses.Add(c3);
courses.Add(c4);
courses.Add(c5);

courses.ForEach(delegate(Course12 c){
    Console.WriteLine(c);
});
Console.WriteLine();
Course12 cs=courses.Find(x=>x.c_name.Contains("Akshay"));
    courses.Remove(cs);
courses.ForEach(delegate(Course12 c){
    Console.WriteLine(c);
});
Console.WriteLine();
Course12 cs1=courses.Find(x=>x.c_name.Contains("Ashutosh"));
    if(cs1!=null){
    cs1.c_duration=8;
    Console.WriteLine("Success");
    }
    else{
        Console.WriteLine("enter valid name");
    }

    courses.ForEach(delegate(Course12 c){
    Console.WriteLine(c);
});
    Console.WriteLine();
   Course12 cs2 =courses.Find(x=>x.c_id==3);
    Console.WriteLine(cs2);
    Console.WriteLine();
try{
            // dynamic data type variable
            var options=new JsonSerializerOptions {IncludeFields=true};
            var courseJson=JsonSerializer.Serialize<List<Course12>>(courses,options);
            string fileName=@"D:\.Net\Assignment\courses.json";
            //Serialize all Flowers into json file

            File.WriteAllText(fileName,courseJson);
            //Deserialize from JSON file
            string jsonString = File.ReadAllText(fileName);
            List<Course12> jsonCourse = JsonSerializer.Deserialize<List<Course12>>(jsonString);
            Console.WriteLine("\n JSON : Deserializing data from json file\n \n");
            foreach( Course12 course in jsonCourse)
            {
                Console.WriteLine($"{course.c_id} : {course.c_name} : {course.c_fees} : {course.c_duration}");   
            }
               
    }
   catch(Exception exp){
    
    }
    finally{ }

