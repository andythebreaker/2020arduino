/* ��@��k
 * 	
	*/
package andythebreaker.command;



/*area of import*/
import andythebreaker.fileIO.*;
import andythebreaker.ConsoleOutput.*;
import andythebreaker.ConsoleInput.*;
import andythebreaker.cls.*;
import java.util.ArrayList; //'motivation array used import
import java.util.Arrays; //'same as up
import java.util.*;
import static java.lang.System.out;
import java.io.*;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.nio.file.Files;
import java.io.IOException;
import java.nio.charset.StandardCharsets;
import java.nio.file.Paths;
import java.lang.ArrayStoreException;
import java.nio.charset.Charset;
//import java.lang.String.PatternSyntaxException;
import java.lang.Math;

/*EOF import*/

public interface INTCMDInterface{
	String COMEstr = "unDEF";//PLEESZZZZZE!!!!!!!!!!!!!!!!!!!!DO THIS
	
	public default float comeInAStringAndSeeIfIsTheTargetCommand(String COMEstr,String ref) {
		
		int[] intYESorNO = new int[ref.length()];
		char[] STRchar = COMEstr.toCharArray();
		
		if(COMEstr.equalsIgnoreCase(ref)) {
			return((float)0);//is all OK!!
		}else {
			int counter = 0 ;
			int counterBUFEFER = 0;
			float disADDALL = 0;
			
			if (STRchar.length==0) {
				return ((float)5000);
			}else {
			
			
			
			for(char cWANTCHECK : STRchar) {
				
				//�H�U���Ӥ���
				//intYESorNO[counter]=COMEstr.indexOf(Character.toString(cWANTCHECK)/*char is base obj not ref / class  ->  cannot do "." method*/,counterBUFEFER);
				//counterBUFEFER=intYESorNO[counter]+1;
				//�H�W���Ӥ���
				
				
				//�p��~�t
				disADDALL=disADDALL+(float)((Math.abs((COMEstr.indexOf(Character.toString(cWANTCHECK),counterBUFEFER)-counter))+1)/(counter+1));
						/*
						 * abs
						 * in
						 * 2
						 * bin
						 * -->
						 * ��������
						 * ���X�[�@
						 * �ϥ��N�O�δ
						 * ��X���t����
						 * �A���
						 * OK�a
						 * XDD
						 * 
						 * 
						 * 
						 */
				
				
				
				
				counter++;
			}
			disADDALL=disADDALL/(float)ref.length();
			return (disADDALL);
			}
		}
//x
	
		}
}// file










