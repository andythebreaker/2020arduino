/* ��@��k
 * 	
	*/
package andythebreaker.command;



/*area of import*/
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
/*EOF import*/

public class commandSTRING{
	private static String bufferSTR = "EMPTY";
	private static int ifnew = 1;
public static void changIFNEWtoZERO() {
	ifnew=1;
}
	/*
	int INTcheckcommand(){
		ReadInput ri = new ReadInput();
		ri.Getinput(0);
	indexOf(int ch, int fromIndex)
	}
	*/
	//int EMPTY =0 ;//no use~
	
	//int maxCMDlim=0;//overwride
	/*
	public void epmty() {
		int EMPTY2 =0 ;//no use~

	}
*/

	int limit=0;//sympley not change ~
	int maxCMDlim=4;//changeable!�аȥ���@�ɽƼg�аȥ���@�ɽƼg�аȥ���@�ɽƼg�аȥ���@�ɽƼg�аȥ���@�ɽƼg�аȥ���@�ɽƼg�аȥ���@�ɽƼg�аȥ���@�ɽƼg�аȥ���@�ɽƼg�аȥ���@�ɽƼg�аȥ���@�ɽƼg�аȥ���@�ɽƼg�аȥ���@�ɽƼg�аȥ���@�ɽƼg�аȥ���@�ɽƼg
	char splitCHAR = ' ';//�Y���j���O�ť�->���o��
	//int CMDINtowordOK=1;
	/*
	public default void maxCMDlimC(int maxCMDlimT){
		maxCMDlim = maxCMDlimT;
	}
	*/
	//public int INTcheckcommand();
	
	//public void epmty();
	public /*default */String CMDINtoword(int pattern){/*pattern~~�q0�}�l*/
		if (ifnew==1) {	
		ReadInput ri = new ReadInput();
			String Input=ri.Getinput(0);
			String[] SPL = Input.split(Character.toString(splitCHAR),limit);
			
			if((SPL.length>maxCMDlim)) {
				ifnew = 1 ;
				System.out.println("���~!��J�榡���X�G�W�w�A�֦��L�h���ѼƩΫ��O���A�Ъ`�N�O�_���L�h���ť���X�{�b���O��J��줤!");
				//int CMDINtowordOK=0;
				//bufferSTR.removeAll(bufferSTR);
				 bufferSTR = "EMPTY";
				return ("");
			}else {
				if((SPL.length<(pattern+1))) {
					ifnew = 0 ;
					//int CMDINtowordOK=1;
					//bufferSTR = Arrays.asList(SPL);
					bufferSTR= Input;
					return ("");
				}else {
					
					ifnew = 0 ;
					//int CMDINtowordOK=1;
					//bufferSTR = Arrays.asList(SPL);
					bufferSTR= Input;
					return (SPL[pattern]);
				}
				
			}
	}else{
		//bufferSTR
		ifnew = 0 ;
		String[] SPLbuf = bufferSTR.split(Character.toString(splitCHAR),limit);

		if((SPLbuf.length<(pattern+1))) {
			//ifnew = 0 ;
			//int CMDINtowordOK=1;
			//bufferSTR = Arrays.asList(SPL);
			//bufferSTR= Input;
			return ("");
		}else {
			
			//ifnew = 0 ;
			//int CMDINtowordOK=1;
			//bufferSTR = Arrays.asList(SPL);
			//bufferSTR= Input;
			return (SPLbuf[pattern]);
		}
		
		
		//return (SPLbuf[pattern]);
	}
			//indexOf(int ch, int fromIndex)
			}
	/*
	public default int CMDint(int pattern){
		CMDstr = CMDINtoword(pattern);
		if (CMDINtowordOK==1) {
			
		}else {
			return (-1);
		}
		
	}
	*/
	
	public String BUF(int wantBUF){
		String[] SPLbuf = bufferSTR.split(Character.toString(splitCHAR),limit);

			return (SPLbuf[wantBUF]);
		
		
	}
}// {public class command}