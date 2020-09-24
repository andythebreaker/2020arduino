//0917_LAB1-1
int x;
void setup() {
  // put your setup code here, to run once:
  for(x = 0;x<10;x++){
    pinMode(x,OUTPUT);
    digitalWrite(x,LOW);
  }
  
}
void loop() {
  // put your main code here, to run repeatedly:
  for(x = 0;x<10;x++){
    digitalWrite(x,HIGH);
    delay(500);
    digitalWrite(x,LOW);
    delay(500);
  }
}

//don't use pin0 pin1
