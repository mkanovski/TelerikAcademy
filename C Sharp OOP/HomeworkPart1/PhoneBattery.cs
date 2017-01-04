using System;

namespace HomeworkPart1
{
    public class PhoneBattery
    {
        private readonly string model;
        private int idleHours;
        private int talkHours;
        private readonly BatteryTypeEnum type;
        private MobilePhone parent;

        public MobilePhone Parent { get { return parent; } set { parent = value; } }

        public string Model { get { return model; } }
        public int IdleHours { get { return idleHours; } set { idleHours = value; } }
        public int TalkHours { get { return talkHours; } set { talkHours = value; } }
        public BatteryTypeEnum Type { get { return type; } }

        // Empty constructor - sets all fields to their defaul values
        public PhoneBattery()
        {
            this.model = default(string);
            this.IdleHours = default(int);
            this.TalkHours = default(int);
            this.type = default(BatteryTypeEnum);
            this.parent = default(MobilePhone);
        }

        // Constructor with only model mendatory and all the other fields optional
        public PhoneBattery(string model, int idleHours = default(int), int talkHours = default(int), BatteryTypeEnum type = default(BatteryTypeEnum))
        {
            this.model = model;
            this.IdleHours = idleHours;
            this.TalkHours = talkHours;
            this.type = type;
        }

        //Constructor with model and type mendatory and the rest optional
        public PhoneBattery(string model, BatteryTypeEnum type, int idleHours = default(int), int talkHours = default(int))
        {
            this.model = model;
            this.IdleHours = idleHours;
            this.TalkHours = talkHours;
            this.type = type;
        }
    }

    
}
