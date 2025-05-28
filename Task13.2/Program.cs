namespace Example2
{
    // Делегат для события операции с балансом
    public delegate void DeviceStateHandler(string device, string status);
    public class SmartHomeSystem // Класс управления умным домом
    {
        public event DeviceStateHandler DeviceState;
        public string[] Devices { get; }      //Light Thermostat  Door
        public string lightStatus { get; set; }
        public string thermostatTemp { get; set; }
        public string doorStatus { get; set; }
        public SmartHomeSystem(string[] devices)
        {
            Devices = devices;
        }
        public void TurnOnLight()
        {
            foreach (var item in Devices)
            {
                if (item == "Light")
                    lightStatus = "Включен";
            }

            DeviceState?.Invoke("Light", lightStatus);
        }
        public void TurnOffLight()
        {
            foreach (var item in Devices)
            {
                if (item == "Light")
                    lightStatus = "Выключен";
            }

            DeviceState?.Invoke("Light", lightStatus);
        }
        public void SetTemperature(int newTemp)
        {
            foreach (var item in Devices)
            {
                if (item == "Thermostat")
                    thermostatTemp = $"Temperature set to {newTemp}°C";
            }
            DeviceState?.Invoke("Thermostat", thermostatTemp);
        }
        public void LockDoor()
        {
            foreach (var item in Devices)
            {
                if (item == "Door")
                    doorStatus = "Заблокирована";
            }
            DeviceState?.Invoke("Door", doorStatus);
        }
        public void UnlockDoor()
        {
            foreach (var item in Devices)
            {
                if (item == "Door")
                    doorStatus = "Разблокирована";
            }
            DeviceState?.Invoke("Door", doorStatus);
        }
    }
    //
    class Program
    {
        static void Main(string[] args)
        {
            var smartHome = new SmartHomeSystem(["Light", "Door", "Thermostat"]);
            smartHome.DeviceState += (device, status) =>
            {
                Console.WriteLine($"[{DateTime.Now:T}] {device}: {status}");
            };
            
            try
            {
                smartHome.LockDoor();
                smartHome.UnlockDoor();
                smartHome.TurnOnLight();
                smartHome.TurnOffLight();
                smartHome.SetTemperature(25);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            Console.ReadKey();


        }

    }
}