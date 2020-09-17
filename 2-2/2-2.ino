const byte led = 13;
const byte button =2;
boolean ledstate=LOW;
int debouncetime=200;

unsinged long time2 = 0;

void setup(){
    pinMode(13, OUTPUT);
    digitalWrite(13, ledstate);
    pinMode(2, INPUT_PULLUP);
}

void loop(){
    boolean swstate = digitalRead(button);
    if(swstate==low){//pull up :: pressed -> low
        if(debounce()){
            ledstate = !ledstate;
            digitalWrite(led, ledstate);
        }
    }
}

boolean debounce(){
    unsigned long time1 = millis();
    while((millis()-time1)>=debouncetime){
      
    }
    return digitalRead(button);
}
