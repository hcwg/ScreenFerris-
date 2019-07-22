﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WpfDemo
{
    public delegate void AngleChangeHandler(IBLEAccelerationSensor sender, double angle);
    public delegate void AccelerationChangeHandler(IBLEAccelerationSensor sender, Vector3 acceleration);
    public delegate void OrientationChanged(IBLEAccelerationSensor sender, Display.Orientations orientation);
    public interface IBLEAccelerationSensor : INotifyPropertyChanged
    {
        string DeviceId { get;}

        string DeviceName { get; set; }

        string MACAddress { get; }

        bool AutoConnect { get; set; }

        bool Connected { get;}

        Vector3? Baseline { get; }

        Vector3? Normal { get; }

        Vector3? Acceleration { get; }

        DateTime LastReport { get; }
        double? Angle { get; }

        Display.Orientations? Orientation { get; }

        MonitorBinding Binding { get; }

        void Disconnect();

        //event AngleChangeHandler AngleChange;
        //event AccelerationChangeHandler AccelerationChange;
        //event OrientationChanged OrientationChanged;
    }
}
