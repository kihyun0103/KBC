#include <Mouse.h>

int mouse_up = 3;
int mouse_down = 4;
int mouse_left = 5;
int mouse_right = 6;
int mouse_click = 2;

boolean state = true;

void setup() {    
  pinMode(mouse_up, INPUT_PULLUP); 
  pinMode(mouse_down, INPUT_PULLUP);
  pinMode(mouse_left, INPUT_PULLUP);
  pinMode(mouse_right, INPUT_PULLUP);
  pinMode(mouse_click, INPUT_PULLUP);

  attachInterrupt(digitalPinToInterrupt(mouse_click), exchange, FALLING);  

   Mouse.begin();
}

void loop() {
    if(state==true){
 
      if(digitalRead(mouse_up) == LOW){ //위로
         Mouse.move(0, -1, 0);
      }else if(digitalRead(mouse_down) == LOW){ //아래로
         Mouse.move(0, 1, 0);
      }
      
      if(digitalRead(mouse_left) == LOW){ //왼쪽
         Mouse.move(-1, 0, 0);
      }else if(digitalRead(mouse_right) == LOW){ //오른쪽
         Mouse.move(1, 0, 0);
      }
      
      if(digitalRead(mouse_click) == LOW){
        Mouse.click();
    }
    
  } 
}
void exchange() {
 state=!state;
}
