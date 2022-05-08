#region License Information

// **********************************************************************************************************************************
// AnimalScanResult.cs
// Last Modified: 2022/05/08 13:21
// Last Modified By: Sharad Nair
// Copyright Emydex Technology Ltd @2022
// **********************************************************************************************************************************

#endregion

namespace Emydex.FarmAutomation.IoT.Core
{
    public class AnimalScanResult
    {
        #region Public Properties

        public AnimalRFIDTag RFID { get; set; }
        public int Count { get; set; }

        #endregion
    }
}