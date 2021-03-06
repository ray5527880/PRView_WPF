﻿using System;
using System.Collections.Generic;
using System.Text;
using GSF.COMTRADE;

namespace PRView.Model
{    public class MainWindowData
    {
        public string Location;
        public string Device;
        public string StartData;
        public string TriggerData;
        public string StartTime;
        public string TriggerTime;
        public Parser Parsers;
        public List<double[]> PrimaryData;
        public List<double[]> SecondaryData;
        public List<double[]> PerUnitData;
        public string[] AnalogNames;
        public string[] DigitalNames;
    }
}
