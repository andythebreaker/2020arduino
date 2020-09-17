//0917_LAB3-1

int seg_com[4]={10,11,12,13};
int seg_data[10][8]={{1,1,1,1,1,1,0,0},//0
                     {0,1,1,0,0,0,0,0},//1
                     {1,1,0,1,1,0,1,0},//2
                     {1,1,1,1,0,0,1,0},//3
                     {0,1,1,0,0,1,1,0},//4
                     {1,0,1,1,0,1,1,0},//5
                     {1,0,1,1,1,1,1,0},//6
                     {1,1,1,0,0,0,0,0},//7
                     {1,1,1,1,1,1,1,0},//8
                     {1,1,1,0,0,1,1,0},//9
};

int number=1234;
int disp[4]={0,0,0,0};
int i=0;
int j=0;
void setup() {
  for(int i=2;i<10;i++){
    pinMode(i,OUTPUT);
    digitalWrite(i,LOW);
    }
  for(int i=10;i<14;i++){
    pinMode(i,OUTPUT);
    digitalWrite(i,HIGH);
    }
  Serial.begin(9600);
}

void loop() {
  number_transfer(number);
  for(i=0;i<4;i++){  //個 十 百 千
    digitalWrite(seg_com[i],LOW);
    seg_drive(disp[i]);
    delay(5);
    digitalWrite(seg_com[i],HIGH); 
    Serial.println(i);
  }
}

void number_transfer(int num ){
  //將四位數的number拆成獨立的四個數字，存入陣列disp[]中
  disp[0] = number%10;
  disp[1] = (number/10)%10;  
  disp[2] = (number/100)%10;  
  disp[3] = (number/1000);
  //Serial.println(disp[0]);  
}

void seg_drive(int number){
  //將字元變數從SEG_DATA[][]找到相對應的位置，並寫入a-g中
  for(j = 2;j<9;j++){ //pin2~8=a~g
    digitalWrite(j,seg_data[number][j-2]);
    //Serial.println(j);
    //Serial.println(seg_data[number][j-2]);
  }
}


//全域變數不要重複用:)
