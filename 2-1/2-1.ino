int led[] = {8,9,10,11};
int sw_up=2, sw_down=3 ;
void setup() {
  // put your setup code here, to run once:
  for(i=0; i<4; i++){
    pinMode(led[i],OUTPUT);
    digitalWrite(led[i],LOW);
  }
  pinMode(sw_up,INPUT);
  pinMode(sw_down,INPUT);
  
  int on = 3;
  digitalWrite(led[on],HIGH); 
}
void loop() {
  // put your main code here, to run repeatedly:
  if(!digitalRead(sw_up)){
    digitalWrite(led[on],LOW)
    digitalWrite(led[on-1],HIGH)
    on-=1;
  }
  else if(digitalRead(sw_down)){
    digitalWrite(led[on],LOW)
    digitalWrite(led[on+1],HIGH)
    on+=1;
  }
}
