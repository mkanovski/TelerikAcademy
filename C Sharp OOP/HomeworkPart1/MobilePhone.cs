using System;
using System.Collections.Generic;

namespace HomeworkPart1
{
    public class MobilePhone
    {
        private readonly string model;
        private readonly string brand;
        private double price;
        private string owner;
        private PhoneBattery battery;
        private PhoneDisplay display;
        public List<Call> callsHistory = new List<Call>();

        public string Model { get {return model;} }
        public string Brand { get {return brand;} }
        public double Price { get {return price;} set {price = value;} }
        public string Owner { get {return owner;} set {owner = value;} }
        public PhoneBattery Battery { get {return battery;} set {battery = value;} }
        public PhoneDisplay Display { get {return display;} set {display = value;} }

        //Add/Delete Calls
        public void AddCalltoHistory(Call call)
        {
            callsHistory.Add(call);
        }
        public void DeleteCallfromHistory(int index)
        {
            callsHistory.RemoveAt(index);
        }
        public void ClearCallsHistory()
        {
            callsHistory.Clear();
        }

        // iPhone 4S static field and property

        private static string iphone4s = "iphone4s information";
        public static string Iphone4S { get { return iphone4s; } set { iphone4s = value; } }

        //CONSTRUCTORS
        // Constructor with all fields, battery and display optional.
        public MobilePhone(string model, string brand, double price, string owner,
                           PhoneBattery battery = default(PhoneBattery),
                           PhoneDisplay display = default(PhoneDisplay))
        {
            this.model = model;
            this.brand = brand;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        // Constructor which takes only yhe model and the brand of the phone
        public MobilePhone(string model, string brand)
        {
            this.model = model;
            this.brand = brand;
            this.Price = default(double);
            this.Owner = default(string);
            this.Battery = default(PhoneBattery);
            this.Display = default(PhoneDisplay);

        }

        // Empty constructor - sets all fields to their defaul values
        public MobilePhone()
        {
            this.model = default(string);
            this.brand = default(string);
            this.Price = default(double);
            this.Owner = default(string);
            this.Battery = default(PhoneBattery);
            this.Display = default(PhoneDisplay);
        }

        // METHODS
        //Change the default ToString()
       
        public override string ToString()
        {
            return $@"This mobile phones specs are:
Brand: {Brand}
Model: {Model}
Price: {Price}
Owner: {Owner}
Battery type: {Battery.Type}
Display size: {Display.InchSize}
Display colors: {Display.NumberOfColors}";
        }
    }
}
