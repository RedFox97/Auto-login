//***************************************************************//
//  Name         : Auto Login V1                                 //
//  Author       : RedFox                                        //
//  Website      : lamchucongnghe.com                            //
//  Fanpage      : fb.com//lamchucongnghevn                      //
//  Shop sendo   : sendo.vn/shop/lamchucongnghe_com              //
//***************************************************************//
#include <Keyboard.h>

#define desktop     4
#define fb          5
#define google      6
#define led         7

String passDesktop  = "Pass Desktop";
String passFB       = "Pass Facebook";
String passGG       = "Pass Google";
unsigned long lastDebounceTimeDesktop, lastDebounceTimeFB, lastDebounceTimeGG;
unsigned long debounceDelay = 100;
int lastButtonStateDesktop, lastButtonStateFB, lastButtonStateGG;
int buttonStateDesktop, buttonStateFB, buttonStateGG;
int ledState = LOW;

void setup(){
  Serial.begin(9600);
  pinMode(desktop, INPUT_PULLUP);
  pinMode(fb, INPUT_PULLUP);
  pinMode(google, INPUT_PULLUP);
  pinMode(led, OUTPUT);
}

void loop() {
  if (digitalRead(desktop) != lastButtonStateDesktop) {         // Nút được nhấn hoặc nhả
    lastDebounceTimeDesktop = millis();                         // Gán thời gian lúc ấn nút
  }
  if ((millis() - lastDebounceTimeDesktop) > debounceDelay) {   // Bấm nút được đủ thời gian debounceDelay thì thực hiện lệnh
    if (digitalRead(desktop) != buttonStateDesktop) {           // Kiểm tra trạng thái hiện tại với trạng thái nút bấm lần bấm trước
      buttonStateDesktop = digitalRead(desktop);                // Lưu trạng thái bấm nút mới
      if (buttonStateDesktop == HIGH) {                         // Nếu nút đã được nhả thì thay đổi trạng thái led và gõ mật khẩu
        Keyboard.println(passDesktop);
        Keyboard.releaseAll();
      }
    }
  }
  lastButtonStateDesktop = digitalRead(desktop);                // Liên tục cập nhật trạng thái nút nhấn
  
/*--------------------------------------Đối với 2 nút còn lại làm tương tự ----------------------------------------*/
  if (digitalRead(fb) != lastButtonStateFB) {
    lastDebounceTimeFB = millis();
  }
  if ((millis() - lastDebounceTimeFB) > debounceDelay) {
    if (digitalRead(fb) != buttonStateFB) {
      buttonStateFB = digitalRead(fb);
      if (buttonStateFB == HIGH) {                            
        Keyboard.println(passFB);
        Keyboard.releaseAll();
      }
    }
  }
  lastButtonStateFB = digitalRead(fb);
  
/*-----------------------------------------------------------------------------------------------------------------*/
  if (digitalRead(google) != lastButtonStateGG) {
    lastDebounceTimeGG = millis();
  }
  if ((millis() - lastDebounceTimeGG) > debounceDelay) {
    if (digitalRead(google) != buttonStateGG) {
      buttonStateGG = digitalRead(google);
      if (buttonStateGG == HIGH) {                            
        Keyboard.println(passGG);
        Keyboard.releaseAll();
      }
    }
  }
  lastButtonStateGG = digitalRead(google);
  
/*-----------------------------------------------------------------------------------------------------------------*/
  if (digitalRead(desktop) == 0 || digitalRead(fb) == 0 || digitalRead(google) == 0)
    digitalWrite(led, HIGH);
  else
    digitalWrite(led, LOW);
}
