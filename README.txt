���״��ڵ��Գ���WindTouch����Ϊ����WindWheelС�鿪���ķ���������ܳ��ĳ����ֹ������ء���������ʹ��Visual Studio 2013������ʹ��C#���Ա�д�������Ҫ�򿪱��밲װVisual Studio 2013����߰汾�����VS�汾�ϵ����½����̣����ҵĹ����еĹؼ��ļ����Ƶ��¹����У������뵽�����б��뼴�ɡ�
�����һ������������ܳ��ĳ�����д�����´���(���´�������ο�����ɾ������)��
/* Event.c Ϊ���ڽ����жϴ������ */
void UARTRXHandler()
{
  recv = SCI0DRL;
  
  switch (runner) {
    case 0:
    //if (recv != 0xFF) return;
    break;
    case 1:
    ServoP = recv;
    break;
    case 2:
    ServoD = recv;
    break;
    case 3:
    EMServoP = recv;
    break;
    case 4:
    EMServoD = recv;
    break;
    case 5:
    MotorP = recv;
    break;
    case 6:
    MotorI = recv;
    break;
    case 7:
    MotorD = recv;
    break;
    case 8:
    BWThreshold = recv;
    break;
    case 9:
    MotorSpeedMax1 = recv;
    break;
    case 10:
    MotorPIDAllow = recv;
    break;
    case 11:
    EmergencyStop = recv;
    break;
    case 12:
    MotorSpeedMax2 = recv;
    break;
    case 13:
    MotorSpeedMax3 = recv;
    break;
    case 14:
    MotorSpeedMax4 = recv;
    break;
    }
  if (runner == 14) runner = 0;
  else runner = runner + 1; 
}
/* main.c */
UARTSendUint8(0xFF); 
UARTSendUint8(MotorSpeedSet / 5);
UARTSendUint8(MotorSpeed / 5);
UARTSendUint8(ServoNow);
UARTSendUint8(MiddleLine);	
UARTSendUint8(GetBatteryVol());
UARTSendUint8(1);
UARTSendStream((u8*)CCD0Pixel, 128);
����Ҫ����ѵ�Ƭ�����ڵĲ����ʣ�����ģ��Ĳ����ʣ�����������������õĲ����ʣ�WindTouch�˵Ĳ�����ͳһ�����������й����е��쳣����û��̫���ע�����Կ��ܻ���bug������ʵ�ʿ���һ�㲻Ӱ��ʹ�á�(����ע��"�򿪴���"����Ĵ�����Ĭ����ʾ����Ϊ"COMx"�����һ������ַ���ע����Ǹ��ַ�ɾ������)
���׳������˵��ȫֻ��һ�����Σ�ϣ���ܹ��Բ��������������������õ���һ��������Ϊ���Թ������Ḻ����
����ƽ(sjtudesigner)
2014-03-05