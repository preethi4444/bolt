class Side{
    int s;
    protected Side(){
        s=4;
    }
}
class Square extends Side{
    int area(){
        return s*s;
    }
}
public class No_cons{
    public static void main(String args[]){
        Square sq=new Square();
        System.out.println("Area is "+sq.area());
    }
}