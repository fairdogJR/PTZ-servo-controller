//a few speed m and limit mods by tim
// suggestion by adding a 100uF capacitor between 5V and GND, the capacitor will help calm the sudden rush you might get when the servo first starts to turn
// heres a nice library for easing servo https://github.com/todbot/ServoEaser try that next
//
//TKF
//adding stored position preset 
//adding second servo
//When you attach a servo the arduino starts sending position information to it. 
//By default, that starting position is 90. You can change that by doing a servo.Write before you do the attach.
//servos seem to go madd if too much movement.
//could be that debug  reads arent being handled when too much data (backlogged) 
//try suppresssing output vals, we dont use them. dont use serial.print.
//this didnt fix the issue,
//try setting lower limits not to zero but to just above zero otehrwise wrap around
// seems the delay has to be much highe and may need positional feedback if I want to go faster on big turns
//the servos I have are set for 360 degree motion. No locking pin , so how can I gurantee the starting point?
//added some caps to power supply lines and lowered baud, seems better
// it also seems that the arduino is reading only 1 byte at a time
//there is clearly a queue as messages are lagged with time delay could be that we should clear the arduino buffer after each action or increas buffer
//maybe increase baud rate again
// win 10 seems to have this wierd trans mission lag which may be making things worse
//i think I damaged a servo so I replaced it, its a lot better, may be a ripped cable or something with all the force.
// this may help https://dronebotworkshop.com/servo-motors-with-arduino/
//http://www.rccrawler.com/forum/electronics/142369-how-diagnose-servo-failures-hopefully-repair-them.html
//gear replacement https://www.youtube.com/watch?v=ossSoV94q6U


#include<Servo.h> // include server library
Servo ser; // create servo object to control a servo
Servo ser2; // create servo object to control a servo
Servo ser3; // create servo object to control a servo

//int poser = 143; // initial position of serv0
//int poser2 = 6; // initial position of serv0
//int poser3 = 6; // initial position of serv0

int poser = 36; // initial position of serv0
int poser2 =93; // initial position of serv0
int poser3 =101; // initial position of serv0


int val; // initial value of input

int delaycount=15;
int delayval=delaycount;
int delayval2=delaycount;
int delayval3=delaycount;
int delayvallong=100;
String out;
String out1;
String out2;
String out3;
//second Servo

int val2; // initial value of input




void setup() {
  Serial.begin(57600); // Serial comm begin at xbps
 //Serial.begin(9600); // Serial comm begin at xbps
  //setting start positions before attach

ser.write(poser);
ser2.write(poser2);
ser3.write(poser3);  

ser.attach(9);// servo rotation is connected at pin 9
ser2.attach(10); //servo elbow
ser3.attach(11); //servo wrist

}

void loop() {
  if (Serial.available()) // if serial value is available 
///////////////  
  {
    val = Serial.read();// then read the serial value


///---rotation
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
//////--elbow/////////////
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

    
////--wrist

//wrist up
        if (val == 't') //if value input is this char go up
    {
      poser3 += 1; //than position of servo motor increases by 1 ( anti clockwise)
      ser3.write(poser3);// the servo will move according to position 
      delay(delayval3);//delay for the servo to get to the position
     }

     
     //wrist down
    if (val == 'g') //if value input go down
    {
      poser3 -= 1; //than position of servo motor decreases by 1 (clockwise)
      ser3.write(poser3);// the servo will move according to position 
      delay(delayval3);//delay for the servo to get to the position
    }

 ///////////////////   
//fixt fast absolutepositions
      //speed move to far left
      if (val == 'q') //if value input 
            {
              poser=175;
              ser.write(poser);// the servo will move according to position 
              delay(delayvallong);//delay for the servo to get to the position
                }

                
//replaced with up (to conform to game imput style since arrows can be used in serial input scenerio)      
//      if (val == 'w') //if value input 
//    {poser=90;
//    ser.write(poser);// the servo will move according to position 
//      delay(delayvallong);//delay for the servo to get to the position
//        }
        //speed move to far right
        if (val == 'e') //if value 

              {
                poser=5;
                ser.write(poser);// the servo will move according to position 
                delay(delayvallong);//delay for the servo to get to the position
                  }

      //speed move to horizontal
      if (val == 'h') //if value input 
            {
              poser=92;
              poser2=6;
              poser3=102;
              ser.write(poser);// the servo will move according to position

              ser2.write(poser2);// the servo will move according to position

              ser3.write(poser3);// the servo will move according to position
              delay(delayvallong);//delay for the servo to get to the position
                }
      //speed move to vertical
      if (val == 'y') //if value input 
            {
              poser=36;
              poser2=93;
              poser3=101;
              ser.write(poser);// the servo will move according to position

              ser2.write(poser2);// the servo will move according to position

              ser3.write(poser3);// the servo will move according to position
              delay(delayvallong);//delay for the servo to get to the position
                }



 //////////////////
 //check limits
    //left/right limits
      if (poser>175){
        poser=175;}
      if (poser<5){
        poser=5;}
        //Serial.print ("L/R:");
        //Serial.println(poser);
        
     //up down limits   
      if (poser2>175){
        poser2=175;}
      if (poser2<5){
        poser2=5;}
        //Serial.print ("Arm:");
       // Serial.println(poser2);

       //wrist up down limits   
      if (poser3>175){
        poser3=175;}
      if (poser3<5){
        poser3=5;}
        //Serial.print ("wrist:");
        //Serial.println(poser3);
        out1= String (poser);
        out2= String (poser2);
        out3= String (poser3);
      Serial.println(out1+" "+out2+" "+out3);
  delay(delayval3);
  }
}
