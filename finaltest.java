import java.util.*;

class positivenegative
{
    public static void main(String []s)
    {
        int num;
        Scanner sc=new Scanner(System.in);
        num=sc.nextInt();
        if(num>0)
            System.out.print("Positive");
        else if(num<0)
            System.out.print("Negative");
        else
            System.out.print("Zero");
         
    }
}
