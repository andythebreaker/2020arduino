const byte colPins[4] = {2,3,4,5};
const byte rowPins[4] = {A0,A1,A2,A3};
const char keymap[4][4]={
  {'1','2','3','A'},
  {'4','5','6','B'},
  {'7','8','9','C'},
  {'1','2','3','D'},
};

byte i,j;//index
byte scanVal;

void setup(){
  Serial.begin(9600);

  for(i=0;i<4;i++){
    pinMode(rowPins[i],INPUT_PULLUP);
    pinMode(colPins[i],OUTPUT);
    digitalWrite(colPins[i],HIGH);
  }
}

void loop(){
  boolean got= false;
  for (i=0;i<4;i++){
    digitalWrite(colPins[i],LOW);
    for (j=0;j<4;j++){
      if(!digitalRead(rowPins[j])){
        got=true;
        break;
      }
    }
    break;
  }
  if(got){
    scanVal=keymap[i][j];
    Serial.println(scanVal);
  }
}
