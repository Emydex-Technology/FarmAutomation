using System;
using System.Collections.Generic;
using Emydex.FarmAutomation.IoT.Core;

namespace Emydex.FarmAutomation.WebApi.DeviceWrappers
{
    /// <summary>
    ///     Wrapper class to work with the AutoFarmPLC IoT device.
    ///     This wrapper is intended to wrap the low level communication with the hardware device
    ///     This wrapper is still under development and currently is not wired up with the physical device
    ///     THIS CLASS SHOULD NOT BE ACCESSED DIRECTLY
    /// </summary>
    public class AutoFarmPLC : IFarmAutomationDevice
    {
        #region Private Members

        private bool _isOnline;

        #endregion

        #region Constructors

        public AutoFarmPLC()
        {
            SerialNumber = Guid.NewGuid();
            ActivationKey = Guid.NewGuid();
        }

        #endregion

        #region Public Methods

        /// <summary>
        ///     Given the type of animal sends instruction to the IoT device to start the feeder machine to feed the animals for a
        ///     specific period of time
        /// </summary>
        /// <param name="animalIndentifier"></param>
        /// <returns></returns>
        public bool ActivateFeeder(AnimalRFIDTag animalIndentifier)
        {
            //This is send instruction to the physical device to open the feeder 
            //This part will be implemented in the next phase
            return true;
        }

        /// <summary>
        ///     Reads all the tags available on the IoT devices and returns the count of animals to the caller
        /// </summary>
        /// <returns></returns>
        public List<AnimalScanResult> CountAnimals()
        {
            //This method is meant to interact with the low level hardware and return the result to the caller
            //for this prototype there is no hardware interaction implemented
            var result = new List<AnimalScanResult>();

            var cow = new AnimalScanResult();
            cow.Count = new Random().Next(0, 100);
            cow.RFID = AnimalRFIDTag.Cow;
            result.Add(cow);

            var sheep = new AnimalScanResult();
            sheep.Count = new Random().Next(0, 200);
            sheep.RFID = AnimalRFIDTag.Sheep;
            result.Add(sheep);
            return result;
        }

        /// <summary>
        ///     Indicates if the IoT device is powered On or Off
        /// </summary>
        /// <returns></returns>
        public bool IsDeviceOnline()
        {
            return _isOnline;
        }

        /// <summary>
        ///     Sends instruction to the Rotolactor to start milking the cows
        /// </summary>
        /// <returns></returns>
        public bool StartMilking()
        {
            //This will send instruction to the physical hardware to attach the milk extractor to the cow and start milking 
            return true;
        }

        /// <summary>
        ///     Sends instruction to the automatic sheep shearing machine to begin shearing sheeps in the queue
        /// </summary>
        /// <returns></returns>
        public bool StartShearing()
        {
            //this will send instruction to the automatic shearing machine to shear the sheep currently in the shearing chamber
            return true;
        }

        /// <summary>
        ///     Sends instruction to the Rotolactor to stop milking the cows
        /// </summary>
        /// <returns></returns>
        public bool StopMilking()
        {
            //This will send instruction to the physical hardware to disconnect the milk extractor 
            return true;
        }

        /// <summary>
        ///     Sends instruction to the connected IoT device to power down
        /// </summary>
        /// <returns></returns>
        public bool TurnOff()
        {
            _isOnline = false;
            return true;
        }

        /// <summary>
        ///     Sends instruction to the connected IoT device to power up
        /// </summary>
        /// <returns></returns>
        public bool TurnOn()
        {
            _isOnline = true;
            return true;
        }

        #endregion

        #region IFarmAutomationDevice

        /// <summary>
        ///     This is a priviate activation key for the device and must not be exposed outside
        /// </summary>
        public Guid ActivationKey { get; }

        /// <summary>
        ///     Serial number of this IoT device
        /// </summary>
        public Guid SerialNumber { get; }

        /// <summary>
        ///     Name of the manufacturer of this IoT device
        /// </summary>
        public string Manufacturer => "Farm Automation Ltd";

        /// <summary>
        ///     Name of this automation IoT device
        /// </summary>
        public string Name => nameof(AutoFarmPLC);

        #endregion
    }
}