#region License Information

// **********************************************************************************************************************************
// FarmOperationIndicator.cs
// Last Modified: 2022/05/08 12:27
// Last Modified By: Sharad Nair
// Copyright Emydex Technology Ltd @2022
// **********************************************************************************************************************************

#endregion

using System.ComponentModel;

namespace Emydex.FarmAutomation.IoT.Core
{
    /// <summary>
    ///     Indicates the common operations supported by all IoT farm automation devices
    /// </summary>
    public enum OperationIndicator
    {
        [Description("Instruction to start the feeding")]
        StartAnimalFeed = 9002,
        StartMilking = 9003,
        StopMilking = 9004,
        ShearSheep = 9005
    }
}