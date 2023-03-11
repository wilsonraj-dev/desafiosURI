//https://www.beecrowd.com.br/judge/pt/problems/view/1072
import java.io.IOException;
import java.util.Scanner;
 
public class Main {
 
    public static void main(String[] args) throws IOException {
 
        Scanner leitor = new Scanner(System.in);
    	int N = leitor.nextInt();
    	int in = 0;
    	int out = 0;
    	for (int i = 0; i < N; i++) {
    		int x = leitor.nextInt();
    		if (x >= 10 && x <= 20) in++;
    		else out++;
    	}
    	System.out.println(in + " in");
    	System.out.println(out + " out");
 
    }
 
}