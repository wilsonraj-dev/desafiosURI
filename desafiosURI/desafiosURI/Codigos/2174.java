﻿https://www.beecrowd.com.br/judge/pt/problems/view/2174
import java.util.Scanner;
import java.util.LinkedHashSet;
import java.util.Set;

public class Main {
 
    public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);

		Set<String> nomesPomekon = new LinkedHashSet<>();
		int contaPomekon = Integer.parseInt(sc.nextLine());
		
		for (int i=0 ; i<contaPomekon ; i++)
			nomesPomekon.add(sc.nextLine());
		
		System.out.printf("Falta(m) %d pomekon(s).\n",(151 - nomesPomekon.size()));
	}
}