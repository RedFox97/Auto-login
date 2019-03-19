//***************************************************************//
//  Name         : Auto Login V2                                 //
//  Author       : RedFox                                        //
//  Website      : lamchucongnghe.com                            //
//  Fanpage      : fb.com//lamchucongnghevn                      //
//  Shop sendo   : sendo.vn/shop/lamchucongnghe_com              //
//***************************************************************//
#include <Keyboard.h>
#include <EEPROM.h>

#define button          4
#define led         7

unsigned long lastDebounceTime, debounceDelay = 100;
int lastButtonState, buttonState, ledState = LOW;
String duLieu;

// Khởi tạo Serial, EEPROM, pinMode
void setup(){
  Serial.begin(9600);
  pinMode(up, INPUT_PULLUP);
  pinMode(button, INPUT_PULLUP);
  pinMode(down, INPUT_PULLUP);
  pinMode(led, OUTPUT);
}

void loop() {
  nhanDuLieu();
  if (digitalRead(button) != lastButtonState) {         // Nút được nhấn hoặc nhả
    lastDebounceTime = millis();                        // Gán thời gian lúc ấn nút
  }
  if ((millis() - lastDebounceTime) > debounceDelay) {  // Bấm nút được đủ thời gian debounceDelay thì thực hiện lệnh
    if (digitalRead(button) != buttonState) {           // Kiểm tra trạng thái hiện tại với trạng thái nút bấm lần bấm trước
      buttonState = digitalRead(button);                // Lưu trạng thái bấm nút mới
      if (buttonState == HIGH) {                        // Nếu nút đã được nhả thì thay đổi trạng thái led và gõ mật khẩu
        if(duLieu == "")                                // Kiểm tra đã có mật khẩu lưu vào biến duLieu chưa, nếu chưa đọc lại từ EEPROM
          duLieu = readEEPROM();
        Keyboard.print(duLieu);
      }
    }
  }
  lastButtonState = digitalRead(button);                // Liên tục cập nhật trạng thái nút nhấn
  if (digitalRead(button) != lastButtonState) {
    lastDebounceTime = millis();
  }
  if (digitalRead(button) == 0)
    digitalWrite(led, HIGH);
  else
    digitalWrite(led, LOW);
}

// Nhận dữ liệu từ App
void nhanDuLieu() {
  if(Serial.available() > 0) {
    duLieu = Serial.readStringUntil("\n");
    digitalWrite(led, HIGH);
    delay(500);
    digitalWrite(led, LOW);
    writeEEPROM(duLieu);
  }
}

//Lưu dữ liệu vào EEPROM, từ byte 0
void writeEEPROM(String data)
{
  int _size = data.length();
  for(int i=0; i<_size; i++)
  {
    EEPROM.write(i,data[i]);
  }
  EEPROM.write(_size,'\0');
  EEPROM.end();
}

// Đọc dữ liệu từ EEPROM cho tới kí tự NULL
String readEEPROM() {
  char data[100]; //Max 100 Bytes
  int len;
  unsigned char value;
  while(value != '\0')   // Đọc đến kí tự NULL
  {    
    value = EEPROM.read(len);
    data[len] = value;
    len++;
  }
  data[len]='\0';
  return String(data);
}
