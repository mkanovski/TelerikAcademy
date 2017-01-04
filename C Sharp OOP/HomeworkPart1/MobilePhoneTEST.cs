using System;


namespace HomeworkPart1
{
    class MobilePhoneTEST
    {
        public static void GSMCallHistoryTest(double costOfCallsPerMinute)
        {
            PhoneBattery battery1 = new PhoneBattery("Battery model", BatteryTypeEnum.LiIon);
            PhoneDisplay display1 = new PhoneDisplay(4.7, 256);
            MobilePhone phone1 = new MobilePhone("One M7", "HTC", 150, "Martin", battery1, display1);
            battery1.Parent = phone1;
            display1.Parent = phone1;

            Call call1 = new Call(100);
            Call call2 = new Call(20);

            phone1.AddCalltoHistory(call1);
            phone1.AddCalltoHistory(call2);

            int callsDuration = 0;
            foreach (var call in phone1.callsHistory)
            {
                callsDuration += call.DurationOfCall;
            }
            double cost = (callsDuration / 60) * costOfCallsPerMinute;
            Console.WriteLine(cost);

        }
        public static void GSMTest()
        {
            PhoneBattery battery1 = new PhoneBattery("Battery model", BatteryTypeEnum.LiIon);
            PhoneDisplay display1 = new PhoneDisplay(4.7, 256);
            MobilePhone phone1 = new MobilePhone("One M7", "HTC", 150, "Martin", battery1, display1);
            battery1.Parent = phone1;
            display1.Parent = phone1;

            PhoneBattery battery2 = new PhoneBattery("Battery model", BatteryTypeEnum.NiCd);
            PhoneDisplay display2 = new PhoneDisplay(4.2, 1024);
            MobilePhone phone2 = new MobilePhone("S7", "Samsung", 899.99, "Pesho", battery2, display2);
            battery2.Parent = phone2;
            display2.Parent = phone2;

            PhoneBattery battery3 = new PhoneBattery("Battery model", BatteryTypeEnum.Unknown);
            PhoneDisplay display3 = new PhoneDisplay(5.2, 256);
            MobilePhone phone3 = new MobilePhone("3310", "Nokia", 150, "Gosho", battery3, display3);
            battery3.Parent = phone3;
            display3.Parent = phone3;

            MobilePhone[] gsms = new MobilePhone[3];

            gsms[0] = phone1;
            gsms[1] = phone2;
            gsms[2] = phone3;

            foreach (var phone in gsms)
            {
                Console.WriteLine(phone.ToString());
                Console.WriteLine("__________________");
            }

            Console.WriteLine(MobilePhone.Iphone4S);




        }
    }
}
