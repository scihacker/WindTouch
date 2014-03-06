这套串口调试程序WindTouch是我为我们WindWheel小组开发的方便调试智能车的程序，现公开下载。本工程是使用Visual Studio 2013建立，使用C#语言编写，如果需要打开必须安装Visual Studio 2013或更高版本。如果VS版本较低请新建工程，把我的工程中的关键文件复制到新工程中，并导入到工程中编译即可。
配合这一程序必须在智能车的程序中写下如下代码(以下代码仅供参考，可删减功能)：
/* Event.c 为串口接收中断处理程序 */
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
另外要留意把单片机串口的波特率，蓝牙模块的波特率，计算机蓝牙驱动设置的波特率，WindTouch端的波特率统一。程序在运行过程中的异常处理没有太多关注，所以可能会有bug，不过实际看来一般不影响使用。(例如注意"打开串口"界面的串口名默认显示可能为"COMx"后面加一个随机字符，注意把那个字符删掉就行)
这套程序可以说完全只是一个雏形，希望能够对参赛队伍有所帮助，并得到进一步开发，为调试工作减轻负担。
周来平(sjtudesigner)
2014-03-05