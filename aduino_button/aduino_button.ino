int up_button = 2;
int right_button = 3;
int down_button = 4;
int left_button = 5;
int start_button = 6;
int select_button = 7;
int analog_button = 8;
int VRX = A0;
int VRY = A1;

void setup() 
{ 

   digitalWrite (up_button, HIGH);
   digitalWrite (down_button, HIGH);
   digitalWrite (left_button, HIGH);
   digitalWrite (right_button, HIGH);
   digitalWrite (select_button, HIGH);
   digitalWrite (start_button, HIGH);
   digitalWrite (analog_button, HIGH);
   Serial.begin(9600);
   delay(10);
 }
 
void loop() 
{ 
  int val_pass = 0x00;
  int val_x = analogRead(VRX);
  int val_y = analogRead(VRY);
  
   if (val_x > 768) {
    val_pass += 1;
   } 
   else if (val_x < 256) {
    val_pass += 2;
   }
   if (val_y > 768) {
    val_pass += 4;
   }
   else if (val_y < 256) {
    val_pass += 8 ;
   }

  if(!digitalRead(up_button))
    val_pass += 1;
  if(!digitalRead(down_button))
    val_pass += 2;
  if(!digitalRead(right_button))
    val_pass += 4;
  if(!digitalRead(left_button))
    val_pass += 8;
    
if (Serial.available()){
    if(Serial.read() == 's') {
      Serial.write(val_pass) ;
      Serial.flush();
  
    }
}
}
