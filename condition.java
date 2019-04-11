import java.io.*;
import java.util.Scanner;

class CheckNumber {
	public static void main (String[] args) {
		Scanner sc = new Scanner(System.in);
		int inData = sc.nextInt();
		if(inData > 0){
		    System.out.println("Positive");
		}
		else if(inData == 0){
		    System.out.println("Zero");
		}
		else{
		    System.out.println("Negative");
		}
	}
}
