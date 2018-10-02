// ============================================================================ 
// $safeprojectname$Model.cs 
// Copyright (c) 2007-2018, PeopleNet Communications Corporation. 
// All rights reserved.  Unauthorized copying prohibited. 
// ============================================================================ 
 
﻿using PNet.Icap.Platform.PlatformSdk;
using PNet.Icap.Platform.PluginSdk2;

namespace PNet.Icap.Plugins.$safeprojectname$
{
    /// <summary>
    /// Class $safeprojectname$Model.
    /// </summary>
    internal class $safeprojectname$Model : APluginModel
    {
        #region Object lifecycle

        public $safeprojectname$Model()
        {
            if (Log.IsTraceEnabled) Log.EnterMethod(".ctor()");
            
            // TODO: Construct the model
        
            if (Log.IsTraceEnabled) Log.LeaveMethod(".ctor()");
        }

        // TODO: Uncomment and implement to deterministically release resources.
        ///// <summary>
        ///// Releases resources used by this plug-in.
        ///// </summary>
        ///// <param name="disposing">
        ///// <c>true</c> if called from Dispose(), else <c>false</c>.
        ///// </param>
        // protected override void Dispose(bool disposing)
        // {
        //     if (Log.IsTraceEnabled) Log.EnterMethod("Dispose(bool disposing)");
        //     
        //     if (disposing)
        //     {
        //         // Deallocate managed resources here
        //     }
        //     
        //     // Deallocate unmanaged resources here
        //
        //     base.Dispose(disposing);
        //
        //     if (Log.IsTraceEnabled) Log.LeaveMethod("Dispose(bool disposing)");
        // }

        #endregion Object lifecycle

        // TODO: Define model properties.
        /// <summary>
        /// My property.
        /// </summary>
        public Property<int> MyProperty = new Property<int>(0);
    }
}
