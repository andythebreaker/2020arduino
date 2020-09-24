#include <Multithreaded.h>

Multithreaded multithreaded(1000);//big M -> class ; small m -> variable

void setup()
{
  Serial.begin(9600);
}

void loop()
{
  multithreaded.infiniteLoop();
  Serial.println("----------------------------------------");
}
