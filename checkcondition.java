import java.io.*;
import java.util.Scanner;

class CheckNumber {
	public static void main (String[] args) {
		Scanner sc = new Scanner(System.in);
		int mydata = sc.nextInt();
		if(mydata > 0){
		    System.out.println("Positive");
		}
		else if(mydata == 0){
		    System.out.println("Zero");
		}
		else{
		    System.out.println("Negative");
		}
	}
}
