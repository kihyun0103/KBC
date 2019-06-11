const int up_button = 2;
int down_button = 4;

void setup() 
{ 

   digitalWrite (up_button, HIGH);
   digitalWrite (down_button, HIGH);
   Serial.begin(9600);
   delay(10);
 }
 
void loop() 
{ 
  int val_pass = 0x00;
 
  if(!digitalRead(up_button))
    val_pass += 1;
    
  if(!digitalRead(down_button))
    val_pass += 4;
    
if (Serial.available()){
    if(Serial.read() == 's') {
      Serial.write(val_pass) ;
      Serial.flush();
  
    }
}
}
