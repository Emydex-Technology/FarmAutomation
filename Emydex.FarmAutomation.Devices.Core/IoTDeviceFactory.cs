#region License Information

// **********************************************************************************************************************************
// IoTDeviceFactory.cs
// Last Modified: 2022/05/08 13:04
// Last Modified By: Sharad Nair
// Copyright Emydex Technology Ltd @2022
// **********************************************************************************************************************************

#endregion

using System;
using System.Collections.Generic;

namespace Emydex.FarmAutomation.IoT.Core
{
    /// <summary>
    ///     Factory to hold all supported automatic device
    /// </summary>
    public static class IoTDeviceFactory
    {
        #region Static Fields and Constants

        private static readonly Dictionary<Guid, IFarmAutomationDevice> _registeredDevices = new Dictionary<Guid, IFarmAutomationDevice>();

        #endregion

        #region Public Static Methods

        public static IEnumerable<IFarmAutomationDevice> GetRegisteredDevices()
        {
            return _registeredDevices.Values;
        }

        public static void RegisterDevice(IFarmAutomationDevice device)
        {
            _registeredDevices.Add(device.SerialNumber, device);
        }

        #endregion
    }
}