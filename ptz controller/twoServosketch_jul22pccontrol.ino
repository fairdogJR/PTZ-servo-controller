//a few speed m and limit mods by tim
// suggestion by adding a 100uF capacitor between 5V and GND, the capacitor will help calm the sudden rush you might get when the servo first starts to turn
// heres a nice library for easing servo https://github.com/todbot/ServoEaser try that next
//
//TKF
//adding stored position preset 
//adding second servo
//When you attach a servo the arduino starts sending position information to it. 
//By default, that starting position is 90. You can change that by doing a servo.Write before you do the attach.


#include<Servo.h> // include server library
Servo ser; // create servo object to control a servo
Servo ser2; // create servo object to control a servo

int poser = 143; // initial position of serv0
int val; // initial value of input
int delayval=10;

//second Servo
int poser2 = 6; // initial position of serv0
int val2; // initial value of input
int delayval2=10;


void setup() {
  Serial.begin(57600); // Serial comm begin at xbps
  //setting start positions before attach

ser.write(poser);
ser2.write(poser2);
  
  ser.attach(9);// server is connected at pin 9
  ser2.attach(10);
}

void loop() {
  if (Serial.available()) // if serial value is available 
///////////////  
  {
    val = Serial.read();// then read the serial value

//left
    if (val == 'a') //if value input is this char
    {
      poser += 1; //than position of servo motor increases by 1 ( anti clockwise)
      ser.write(poser);// the servo will move according to position 
      delay(delayval);//delay for the servo to get to the position
     }
 //right
    if (val == 'd') //if value input 
    {
      poser -= 1; //than position of servo motor decreases by 1 (clockwise)
      ser.write(poser);// the servo will move according to position 
      delay(delayval);//delay for the servo to get to the position
    }
/////////////////////
    //up
    if (val == 's') //if value input is this char go up
    {
      poser2 += 1; //than position of servo motor increases by 1 ( anti clockwise)
      ser2.write(poser2);// the servo will move according to position 
      delay(delayval2);//delay for the servo to get to the position
     }
     //down
    if (val == 'w') //if value input go down
    {
      poser2 -= 1; //than position of servo motor decreases by 1 (clockwise)
      ser2.write(poser2);// the servo will move according to position 
      delay(delayval2);//delay for the servo to get to the position
    }

 ///////////////////   
    //fixt fast positions
      //speed move to far left
      if (val == 'q') //if value input 
            {
              poser=175;
              ser.write(poser);// the servo will move according to position 
              delay(delayval);//delay for the servo to get to the position
                }
//replaced with up (to conform to game imput style since arrows can be used in serial input scenerio)      
//      if (val == 'w') //if value input 
//    {poser=90;
//    ser.write(poser);// the servo will move according to position 
//      delay(delayval);//delay for the servo to get to the position
//        }
        //speed move to far right
        if (val == 'e') //if value 

              {
                poser=5;
                ser.write(poser);// the servo will move according to position 
                delay(delayval);//delay for the servo to get to the position
                  }

 //////////////////
 //check limits
    //left/right limits
      if (poser>175){
        poser=175;}
      if (poser<0){
        poser=0;}
        Serial.print ("L/R position");
        Serial.println(poser);
        
     //up down limits   
      if (poser2>175){
        poser2=175;}
      if (poser2<0){
        poser2=0;}
        Serial.print ("U/D position");
        Serial.println(poser2);
 
  
  }
}
