namespace Course;
using System.ComponentModel.DataAnnotations;
[Serializable]
public class Course12
{
    [Required]
    public int c_id {get;set;}
    public String? c_name {get;set;}
    public int c_fees {get;set;}
    public int c_duration {get;set;}
    

    public Course12()
    {
        this.c_id=1;
        this.c_name="Akshay";
        this.c_fees=10000;
        this.c_duration=6;
    }
    public Course12( int id,String name,int fees,int duration)
    {
        this.c_id=id;
        this.c_name=name;
        this.c_fees=fees;
        this.c_duration=duration;        
    }
    public override string ToString()
    {
        return "c_id = " + this.c_id +" c_name = "+ this.c_name + " c_fees = " + this.c_fees+" c_duration = " + this.c_duration ;
    }
}
