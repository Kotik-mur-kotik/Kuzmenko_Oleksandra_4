using System;

namespace laba4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Computer computer = new Computer(256, "white");
            Notebook notebook = new Notebook(512, "pink");
            PersonalComputer personalComputer = new PersonalComputer(1024, "black");
            computer.MyOperationalMemory();
            computer.MyColorKeyboard();
            notebook.MyColorKeyboard();
            personalComputer.MyColorKeyboard();
        }
    }
    abstract class ElectronicDevice
    {
        public int charge;
        public int load;
        public int operationalMemory;
        public int Charge { get; set; }
        public int Load { get; set; }
        public int OperationalMemory { get; set; }
        public ElectronicDevice(int variable)
        {
            operationalMemory = variable;
        }
        ~ElectronicDevice()
        {
            Console.WriteLine("Reboot");
        }
        public abstract void MyOperationalMemory();
    }
    class Computer : ElectronicDevice
    {
        public string colorKeyboard;
        public string operatingSystem;
        public string processorModel;
        public string ColorKeyboard { get; set; }
        public string OperatingSystem { get; set; }
        public string ProcessorModel { get; set; }
        public Computer(int variable, string color) :base(variable)
        {
            operationalMemory = variable;
            colorKeyboard = color;
        }
        public virtual void MyColorKeyboard()
        {
            Console.WriteLine($"Color of my keyboard: {colorKeyboard}");
        }
        public override void MyOperationalMemory()
        {
            Console.WriteLine($"My Operational Memory: {operationalMemory}Kb");
        }
    }
    class Notebook : Computer
    {
        public int weight;
        public bool backlightPresence;
        public string modelNotebook;
        public int Weight { get; set; }
        public bool BacklightPresence { get; set; }
        public string ModelNotebook { get; set; }
        public Notebook(int variable, string color) : base(variable,color)
        {
            operationalMemory = variable;
            colorKeyboard = color;
        }
        public override void MyColorKeyboard()
        {
            Console.WriteLine($"And the color of my keyboard: {colorKeyboard}");
        }
        public override void MyOperationalMemory()
        {
            Console.WriteLine($"My Operational Memory: {operationalMemory}Mb");
        }
    }
    class PersonalComputer : Computer
    {
        public int screenDiagonal;
        public bool presenceBluetooth;
        public int price;
        public int ScreenDiagonal { get; set; }
        public bool PresenceBluetooth { get; set; }
        public int Price { get; set; }
        public PersonalComputer(int variable, string color) : base(variable, color)
        {
            operationalMemory = variable;
            colorKeyboard = color;
        }
        public override void MyColorKeyboard()
        {
            Console.WriteLine($"And my keyboard has a color: {colorKeyboard}");
        }
        public override void MyOperationalMemory()
        {
            Console.WriteLine($"My Operational Memory: {operationalMemory}Gb");
        }
    }
    class Cellphone : ElectronicDevice
    {
        public int cameraQuality;
        public bool presenceFingerprint;
        public bool presenceFrontCamera;
        public int CameraQuality { get; set; }
        public bool PresenceFingerprint { get; set; }
        public bool PresenceFrontCamera { get; set; }
        public Cellphone(int variable) :base(variable)
        {
            operationalMemory = variable;
        }
        public override void MyOperationalMemory()
        {
            Console.WriteLine($"My Operational Memory: {operationalMemory}b");
        }
    }
}
