#region License Information

// **********************************************************************************************************************************
// IFarmAutomationDevice.cs
// Last Modified: 2022/05/08 13:36
// Last Modified By: Sharad Nair
// Copyright Emydex Technology Ltd @2022
// **********************************************************************************************************************************

#endregion

using System;
using System.Collections.Generic;

namespace Emydex.FarmAutomation.IoT.Core
{
    /// <summary>
    ///     This interface provides a standard and consistent access to all the operations supported by different farm
    ///     automation IoT device from different manufacturer.
    ///     All operations must be performed using this interface instead of direct access to the device itself
    /// </summary>
    public interface IFarmAutomationDevice
    {
        #region Public Properties

        /// <summary>
        ///     Name of the manufacturer of this IoT device
        /// </summary>
        string Manufacturer { get; }

        /// <summary>
        ///     Name of this automation IoT device
        /// </summary>
        string Name { get; }

        /// <summary>
        ///     Serial number of this IoT device
        /// </summary>
        Guid SerialNumber { get; }

        /// <summary>
        ///     This is a priviate activation key for the device and must not be exposed outside
        /// </summary>
        Guid ActivationKey { get; }

        #endregion

        #region Public Methods

        /// <summary>
        ///     Given the type of animal sends instruction to the IoT device to start the feeder machine to feed the animals for a
        ///     specific period of time
        /// </summary>
        /// <param name="animalIndentifier"></param>
        /// <returns></returns>
        bool ActivateFeeder(AnimalRFIDTag animalIndentifier);

        /// <summary>
        ///     Reads all the tags available on the IoT devices and returns the count of animals to the caller
        /// </summary>
        /// <returns></returns>
        List<AnimalScanResult> CountAnimals();

        /// <summary>
        ///     Indicates if the IoT device is powered On or Off
        /// </summary>
        /// <returns></returns>
        bool IsDeviceOnline();

        /// <summary>
        ///     Sends instruction to the Rotolactor to start milking the cows
        /// </summary>
        /// <returns></returns>
        bool StartMilking();

        /// <summary>
        ///     Sends instruction to the automatic sheep shearing machine to begin shearing sheeps in the queue
        /// </summary>
        /// <returns></returns>
        bool StartShearing();

        /// <summary>
        ///     Sends instruction to the Rotolactor to stop milking the cows
        /// </summary>
        /// <returns></returns>
        bool StopMilking();

        /// <summary>
        ///     Sends instruction to the connected IoT device to power down
        /// </summary>
        /// <returns></returns>
        bool TurnOff();

        /// <summary>
        ///     Sends instruction to the connected IoT device to power up
        /// </summary>
        /// <returns></returns>
        bool TurnOn();

        #endregion
    }
}