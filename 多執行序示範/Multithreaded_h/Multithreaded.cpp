
#include "Arduino.h"
#include "Multithreaded.h"
#include <math.h>

Multithreaded::Multithreaded(int loop_delay_millis)
{
  loop_delay_millis_private = loop_delay_millis;
}

void Multithreaded::infiniteLoop()
{
  if (abs(millis() - exit_time_millis) >= loop_delay_millis_private)
  {
    counter++;
    Serial.println(counter);
    exit_time_millis = millis();
  }
}
