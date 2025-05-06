using System;

namespace Paulo_Dias_TP1
{
    class Temperature
    {

        public event EventHandler TemperatureExceeded;

        public void CheckTemperature(double temperature)
        {
            if (temperature > 100)
            {
                OnTemperatureExceeded(EventArgs.Empty);
            }

        }

        public virtual void OnTemperatureExceeded(EventArgs e)
        {
            TemperatureExceeded?.Invoke(this, e);
        }

        public void Sensor_TemperatureExceeded(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ALERTA: Temperatura acima do limite seguro!");
            Console.ResetColor();
        }
    }
}
