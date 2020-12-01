#include <Servo.h>

#define FLCpin1 10
#define FLCpin2 11
#define Tthr 1999


Servo motor0;
Servo motor1;
Servo motor2;
Servo motor3;
void setup() {

    pinMode(FLCpin1,INPUT);//flc
    pinMode(FLCpin2,INPUT);//flc

  
  Serial.begin(9600);
  Serial.println("OG!");
  motor0.attach(9);
  for (int i = 0; i<1502;i++){
    motor0.writeMicroseconds(i);
  }
  for (int i = 0; i<499;i++){
    motor0.writeMicroseconds(1500-i);
  }
  motor0.writeMicroseconds(1000);
  Serial.println("FSED!");

motor1.attach(8);
  for (int i = 0; i<1502;i++){
    motor1.writeMicroseconds(i);
  }
  for (int i = 0; i<499;i++){
    motor1.writeMicroseconds(1500-i);
  }
  motor1.writeMicroseconds(1000);



  motor2.attach(6);
  for (int i = 0; i<1502;i++){
    motor2.writeMicroseconds(i);
  }
  for (int i = 0; i<499;i++){
    motor2.writeMicroseconds(1500-i);
  }
  motor2.writeMicroseconds(1000);




  motor3.attach(12);
  for (int i = 0; i<1502;i++){
    motor3.writeMicroseconds(i);
  }
  for (int i = 0; i<499;i++){
    motor3.writeMicroseconds(1500-i);
  }
  motor3.writeMicroseconds(1000);



  
}

void loop() {
  // put your main code here, to run repeatedly:
  
if(digitalRead(FLCpin1)==0&&digitalRead(FLCpin2)==1){

    motor0.writeMicroseconds(Tthr);
    motor1.writeMicroseconds(Tthr);
    motor2.writeMicroseconds(Tthr);
    motor3.writeMicroseconds(Tthr);
}else{
motor0.writeMicroseconds(1000);
motor1.writeMicroseconds(1000);
motor2.writeMicroseconds(1000);
motor3.writeMicroseconds(1000);
}
}
