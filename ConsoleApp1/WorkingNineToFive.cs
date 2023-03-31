using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class WorkingNineToFive
    {
       private float _startHour, _endHour,_hourlyRate,_overtimeMultiplier;

        public WorkingNineToFive(float startHour, float endHour, float hourlyRate, float overtimeMultiplier)
        {
            _startHour = startHour;
            _endHour = endHour;
            _hourlyRate = hourlyRate;
            _overtimeMultiplier = overtimeMultiplier;
        }

        public float StartHour => this._startHour;

        public float EndHour => this._endHour;

        public float HourlyRate => this._hourlyRate;

        public float OvertimeMultiplier => this._overtimeMultiplier;





        public float CalculatePay()
        {
            float pay = 0.0f;
            if (this._endHour > 17.0f)
            {
                pay=((17.0f-this._startHour) * this._hourlyRate)+((this._endHour-17.0f)*this._hourlyRate*this._overtimeMultiplier);
                

            }
            else
            {
                pay=(this._endHour-this._startHour) * this._hourlyRate;
            }

            return pay;
        }


    }
}
