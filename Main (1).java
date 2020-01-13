class Example{
    private String name;
    public void set_mthd(String name){
        this.name=name;
    }
    public String get_mthd(){
        return name;
    }
}
public class Main
{
	public static void main(String[] args) {
	    Example obj=new Example();
	    obj.set_mthd("preethi");
		System.out.println("Hello , this is "+obj.get_mthd());
	}
}
