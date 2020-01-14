class Cons{
    int id;
    String name;
    void display(){
        System.out.println("id is "+id);
        System.out.println("id is "+name);
    }
}
public class Def_cons{
    public static void main(String args[]){
        Cons ob=new Cons();
        ob.display();
    }
    
}