using System;
namespace Basics
{
    public class Stopwatch
    {
       
        private DateTime _start;
        private DateTime _stop;
        private TimeSpan _duration;
        private bool _running = false;
        public DateTime Start()
        {
            if(!_running)
            _running = true;
            else
            throw new InvalidOperationException("stopwatch started twice in a row");

            return  _start = DateTime.Now;

        }

         public DateTime Stop()
        {
            if(_running)
            _running = false;
           return _stop  = DateTime.Now;
        }

        public TimeSpan Duration()
        { 
            
            return _duration = _stop - _start;
        }
    }
}