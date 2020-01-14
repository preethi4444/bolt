class Square{
    int s;
    public Square(int s){
        this.s=s;
    }
    int area(){
        return s*s;
    }
}
public class Para_cons{
    public static void main(String args[]){
        Square sq=new Square(4);
        System.out.println("Area is "+sq.area());
    }
}