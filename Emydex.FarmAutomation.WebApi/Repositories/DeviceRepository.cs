using System.Collections.Generic;
using Emydex.FarmAutomation.IoT.Core;

namespace Emydex.FarmAutomation.WebApi.Repositories
{
    public interface IDeviceRepository
    {
        #region Public Methods

        IEnumerable<IFarmAutomationDevice> GetRegisteredDevices();

        #endregion
    }

    /// <summary>
    ///     Repository to manage all the IoT devices.
    ///     Currently the registered devices are being returned from a factory but in future this may nee to be coming from a
    ///     database
    ///     So all access to devices must be done thru this repository
    /// </summary>
    public class DeviceRepository : IDeviceRepository
    {
        #region Public Methods

        /// <summary>
        ///     Returns a list of registered devices
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IFarmAutomationDevice> GetRegisteredDevices()
        {
            var devices = new List<IFarmAutomationDevice>();

            //Get all the registered devices and return the list
            var registeredDevices = IoTDeviceFactory.GetRegisteredDevices();
            foreach (var device in registeredDevices)
            {
                devices.Add(device);
            }

            return devices;
        }

        #endregion
    }
}