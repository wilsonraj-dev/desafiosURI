//https://www.beecrowd.com.br/judge/pt/problems/view/2712
import java.io.IOException;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) throws IOException {
    	Scanner leitor = new Scanner(System.in);
    	int N = leitor.nextInt();
    	for (int i = 0; i < N; i++) {
    		String placa = leitor.next();
    		if (isValidTag(placa)) {
    			int digit = Integer.valueOf(String.valueOf(placa.charAt(7)));
    		         if (digit == 1 || digit == 2) System.out.println("MONDAY");
    			else if (digit == 3 || digit == 4) System.out.println("TUESDAY");
    			else if (digit == 5 || digit == 6) System.out.println("WEDNESDAY");
    			else if (digit == 7 || digit == 8) System.out.println("THURSDAY");
    			else System.out.println("FRIDAY"); 
    		} else {
    			System.out.println("FAILURE");
    		}
    	}
    }
    
    public static boolean isValidTag(String placa) {
    	return placa.matches("[A-Z]{3}-[0-9]{4}");
    }
}