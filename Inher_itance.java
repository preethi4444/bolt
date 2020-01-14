class Values{
    int base,height;
    Values(int b,int h){
        base=b;
        height=h;
    }
}
class Triangle extends Values{
    Triangle(int ba,int he){
        super(ba,he);
    }
    int area(){
        return (base*height)/2;
    }
}
public class Inher_itance{
    public static void main (String[] args) {
        Triangle obj=new Triangle(6,4);
        int area1=obj.area();
        System.out.println("Area is "+area1);
        
    }
}