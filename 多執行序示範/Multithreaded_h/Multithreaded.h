
//you must add _h Behind it
#ifndef Multithreaded_h
#define Multithreaded_h

#include "Arduino.h"
#include <math.h>

class Multithreaded
{
public:
  Multithreaded(int loop_delay_millis); //need to input a int !
  void infiniteLoop();

private:
  int counter = 0;
  int loop_delay_millis_private = 0;
  unsigned long exit_time_millis = 0;
};

#endif