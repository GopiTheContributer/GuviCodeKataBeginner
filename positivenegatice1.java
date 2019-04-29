import java.io.*;
import java.util.Scanner;
class CheckNumber {
	public static void main (String[] args) {
		Scanner sc = new Scanner(System.in);
		int inDatra = sc.nextInt();
		if(inDatra > 0){
		    System.out.println("Positive");
		}	else if(inDatra == 0){ System.out.println("Zero");
		}
		else{ System.out.println("Negative");}}}
