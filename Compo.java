class Players{
    int jerseyno;
    String name;
    Players()
        {
            jerseyno=41;
            name="shreyas";
        }
    int getNo(){
        return jerseyno;
    }
    String getName(){
        return name;
    }
}
class CricketTeam{
    Players p=new Players();
    public void display(){
        System.out.println("player name is "+p.getName());
        System.out.println("player jersey no is "+p.getNo());
    }
}
public class Compo{
    public static void main(String args[]){
        CricketTeam ob=new CricketTeam();
        ob.display();
    }
}