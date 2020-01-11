abstract class Epam{
    Epam(){
        System.out.println("Hi Team");
    }
    public abstract void dot_net();
    public abstract void java();
    public abstract void devops();
    public abstract void dep();
}
abstract class Dot_net extends Epam{
    public void dot_net(){
        System.out.println("This is .Net practice");
    }
}
abstract class Java extends Dot_net{
    public void java(){
        System.out.println("This is java practice");
    }
}
abstract class Devops extends Java{
    public void devops(){
        System.out.println("This is devops practice");
    }
}
class Dep extends Devops{
    public void dep(){
        System.out.println("This is dep practice");
    } 
}
public class Main
{
	public static void main(String[] args) {
		Dep obj=new Dep();
		obj.dot_net();
		obj.java();
		obj.devops();
		obj.dep();
	}
}
