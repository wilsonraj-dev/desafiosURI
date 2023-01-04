//https://www.beecrowd.com.br/judge/pt/problems/view/2146
import java.io.IOException;
import java.util.Scanner;

public class Main {
 
    public static void main(String[] args) throws IOException {
 
        Scanner sc = new Scanner(System.in);
		
		while(sc.hasNext()){
			int senha = sc.nextInt();
			System.out.println(senha-1);
		}
		sc.close();
    }
}