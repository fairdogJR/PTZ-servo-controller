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

//next stage adding full commands like move to
// https://www.norwegiancreations.com/2017/12/arduino-tutorial-serial-inputs/#:~:text=To%20send%20characters%20over%20serial,on%20your%20keyboard%20to%20send.
//parsing help here ".startswith" https://www.arduino.cc/en/Tutorial/StringStartsWithEndsWith
//implemented commands (sender has to now send line feeds but has the advantage of sending full coordinates and reading info directly, single hot commands were too restrictive
//for motor control commant  parser https://forum.arduino.cc/index.php?topic=548640.0 and more help on implementation here https://stackoverflow.com/questions/50967807/arduino-error-cannot-convert-string-to-char-for-argument-1-to-char-str

// now that ive added preset positions the servers seem to never stop turning. this could be that I have not checked the limits and forced them to stay in a boundary (I think the sense r
//resistor is not working at all there and causes the feedback circuit to go nuts so i will add a check limits routine to try and take care of this

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

int MAXRANGE=150;
int MINRANGE=25;

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
String command;
 

void setup() {
  Serial.begin(57600); // Serial comm begin at xbps
  //setting start positions before attach

ser.write(poser);
ser2.write(poser2);
ser3.write(poser3);  

ser.attach(9);// servo rotation is connected at pin 9
ser2.attach(10); //servo elbow
ser3.attach(11); //servo wrist

}
 
void loop() {
    if(Serial.available()){
        command = Serial.readStringUntil('\n');
         
        if(command.equals("a")){
            left_rotate();
        }
        else if(command.equals("d")){
            right_rotate();
        }
        else if(command.equals("s")){
            up_elbow();
        }
        else if(command.equals("w")){
            down_elbow();
        }
        else if(command.equals("t")){
            wrist_up();
        }
        else if(command.equals("g")){
            wrist_down();
        }
        else if(command.equals("q")){
    speed_move_1eft();
        }
          else if(command.equals("e")){
    speed_move_right();
        }
        else if(command.equals("h")){
    speed_move_horizontal();
        }
        else if(command.equals("y")){
    speed_move_vertical();
        } 
        else if(command.equals("get_motor_positions")){
    send_motor_positions();
        }
        else if(command.startsWith("set_motor_positions")){
    set_all_motor_positions();
    send_motor_positions();//send back what was done
        }
        else{
            Serial.println("Invalid command");
        }
    }
}

void left_rotate(){
      poser += 1; //than position of servo motor increases by 1 ( anti clockwise)
      check_limits();
      ser.write(poser);// the servo will move according to position 
      delay(delayval);//delay for the servo to get to the position  
}

void right_rotate(){
      poser -= 1; //than position of servo motor decreases by 1 (clockwise)
      check_limits();
      ser.write(poser);// the servo will move according to position 
      delay(delayval);//delay for the servo to get to the position
}

void up_elbow(){
      poser2 += 1; //than position of servo motor increases by 1 ( anti clockwise)
      check_limits();
      ser2.write(poser2);// the servo will move according to position 
      delay(delayval2);//delay for the servo to get to the position  
}

void down_elbow(){
      poser2 -= 1; //than position of servo motor decreases by 1 (clockwise)
      check_limits();
      ser2.write(poser2);// the servo will move according to position 
      delay(delayval2);//delay for the servo to get to the position  
}

void wrist_up(){
      poser3 += 1; //than position of servo motor increases by 1 ( anti clockwise)
      check_limits();
      ser3.write(poser3);// the servo will move according to position 
      delay(delayval3);//delay for the servo to get to the position  
}

void wrist_down(){
      poser3 -= 1; //than position of servo motor decreases by 1 (clockwise)
      check_limits();
      ser3.write(poser3);// the servo will move according to position 
      delay(delayval3);//delay for the servo to get to the position  
}

void speed_move_1eft(){
      poser=MAXRANGE;
      ser.write(poser);// the servo will move according to position 
      delay(delayvallong);//delay for the servo to get to the position  
}

void speed_move_right(){
      poser=MINRANGE;
      ser.write(poser);// the servo will move according to position 
      delay(delayvallong);//delay for the servo to get to the position  
}

void speed_move_horizontal(){
      poser=92;
      poser2=6;
      poser3=102;
      check_limits();
      ser.write(poser);// the servo will move according to position
      ser2.write(poser2);// the servo will move according to position
      ser3.write(poser3);// the servo will move according to position
      delay(delayvallong);//delay for the servo to get to the position  
}

void speed_move_vertical(){
      poser=36;
      poser2=93;
      poser3=101;
      check_limits();
      ser.write(poser);// the servo will move according to position
      ser2.write(poser2);// the servo will move according to position
      ser3.write(poser3);// the servo will move according to position
      delay(delayvallong);//delay for the servo to get to the position  
}

void send_motor_positions(){
        out1= String (poser);
        out2= String (poser2);
        out3= String (poser3);
      Serial.println(out1+" "+out2+" "+out3);
      delay(delayvallong);    
}

void set_all_motor_positions(){

      char command_array[command.length()];
      command.toCharArray(command_array, command.length());
      char * pch;  
      String mot1;
      String mot2;
      String mot3;
      
      pch = strtok (command_array," ");         // get first token and thow it away (that is the command and we just want the numbers)
    // while (pch != NULL)
     //   {
        
        //int x=999;
        //Serial.print("string found ");
        //Serial.println(pch);          // print it
        pch = strtok (NULL, " ");     // get next token
        mot1=pch;
        pch = strtok (NULL, " ");     // get next token
        mot2=pch;
        pch = strtok (NULL, " ");     // get next token
        mot3=pch;

      poser=mot1.toInt();
      poser2=mot2.toInt();
      poser3=mot3.toInt();

      check_limits();
      ser.write(poser);// the servo will move according to position
      ser2.write(poser2);// the servo will move according to position
      ser3.write(poser3);// the servo will move according to position
      delay(delayvallong);//delay for the servo to get to the position 
        
       } 

void check_limits(){
       //left/right limits
      if (poser>MAXRANGE){
        poser=MAXRANGE;}
        
      if (poser<5){
        poser=MINRANGE;}

        
     //up down limits   
      if (poser2>MAXRANGE){
        poser2=MAXRANGE;}
      if (poser2<5){
        poser2=MINRANGE;}


       //wrist up down limits   
      if (poser3>MAXRANGE){
        poser3=MAXRANGE;}
      if (poser3<5){
        poser3=MINRANGE;}
  }
  

  
