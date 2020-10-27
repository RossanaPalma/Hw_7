using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Project2
{
    public class Temperature
    {
        // Instance Variables
        private float temperature;
        private char scale;


        // Constructors
        public Temperature()  // no-argument constructor
        {
            temperature = 0;
            scale = 'C';
        }
        public Temperature(float temperature, char scale)
        {
            this.temperature = temperature;
            this.scale = scale;
        }
        public Temperature(float temperature)
        {
            this.temperature = temperature;
            scale = 'C';
        }
        public Temperature(char scale)
        {
            this.scale = scale;
            scale = 'C';
        }
        // Methods
        public void setTemperature(float t)
        {
            temperature = t;
        }
        public float getCelsius()
        {
            if (scale == 'C')
            {
                return temperature;
            }
            else
            {
                return ((float)(Math.Round(5 * (temperature - 32.0) / 9.0) * 10.0)) / 10);
            }
        }
        public float getFahreinheit()
        {
            if (scale == 'F')
            {
                return temperature;
            }
            else
            {
                return (float)(Math.Round((9 * (temperature / 5) + 32) * 10) / 10);
            }
        }
        public void setTemperature(float temperature)
        {
            this.temperature = temperature;
        }
        public void setScale(char scale)
        {
            this.scale = scale;
        }
        public void setTemperatureScale(float temperature, char scale)
        {
            this.temperature = temperature;
            this.scale = scale;
        }
    }



    public string toString()
    {
        return " " + getTemperature;
    }
    public bool equals(Temperature other)
    {
        return (this.getCelsius == other.getCelsius()) || (this.getFahreinhei() == other.getFahreinhei());
    }
}

