#include <SoftwareSerial.h>

#include <ESP8266WiFi.h>
//設定wifi帳密(明碼)
#ifndef STASSID
#define STASSID "BenQ"
#define STAPSK "00000000"
#endif
#define FLCpin1 5
#define FLCpin2 4

//設定wifi帳密
const char *ssid = STASSID;
const char *password = STAPSK;

// Socket Server
const char *host = "192.168.43.225";
const uint16_t port = 9999;

int i = 0;
char inport_c='`';
uint8_t stat_alm=0;
char stat001='`';

WiFiClient client;

void setup()
{
    Serial.begin(115200);
    pinMode(FLCpin1, OUTPUT);//flc
    pinMode(FLCpin2, OUTPUT);//flc
    digitalWrite(FLCpin1, HIGH);
    digitalWrite(FLCpin2, HIGH);
    Serial.print("Start...");

    WiFi.mode(WIFI_STA);
    WiFi.begin(ssid, password);
    while (WiFi.status() != WL_CONNECTED)
    {
        delay(500);
        Serial.println(".");
    }
    Serial.println("");
    Serial.println("WiFi connected");
    Serial.println("IP address: ");
    Serial.println(WiFi.localIP());

    delay(500);
    // Use WiFiClient class to create TCP connections

    if (!client.connect(host, port))
    {
        Serial.println("connection failed");
        Serial.println("wait 5 sec...");
        delay(5000);
        return;
    }
    //[B]
    digitalWrite(FLCpin1, LOW);
    digitalWrite(FLCpin2, LOW);
}

void loop()
{
    if (client.available())
    {
         inport_c = client.read();
        Serial.print(inport_c);
        if(stat_alm==1){
             
          stat001=inport_c;
          stat_alm=2;
        }
        else if(stat_alm==2){
          
          
          if(stat001=='T'&&inport_c=='T'){
            digitalWrite(FLCpin1, HIGH);
    digitalWrite(FLCpin2, HIGH);
              

          }
if(stat001=='S'&&inport_c=='B'){
  
            digitalWrite(FLCpin1, LOW);
    digitalWrite(FLCpin2, LOW);
          }
          
if(stat001=='S'&&inport_c=='T'){
  
            digitalWrite(FLCpin1, LOW);
    digitalWrite(FLCpin2, HIGH);
          }
          
if(stat001=='M'&&inport_c=='S'){
  
            digitalWrite(FLCpin1, HIGH);
    digitalWrite(FLCpin2, LOW);
          }
          stat_alm=0;
        }
        if(inport_c=='$'){
         
          stat_alm=1;
        }else{
         
        }
        
    }

   
    client.println(millis());

}
