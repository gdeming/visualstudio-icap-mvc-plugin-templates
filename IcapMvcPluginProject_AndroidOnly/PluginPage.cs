// ============================================================================ 
// $safeprojectname$Page.cs 
// Copyright (c) 2007-2018, PeopleNet Communications Corporation. 
// All rights reserved.  Unauthorized copying prohibited. 
// ============================================================================ 
 
﻿using PNet.Icap.Platform.ControlSdk2;
using PNet.Icap.Platform.PlatformSdk;

namespace PNet.Icap.Plugins.$safeprojectname$
{
    /// <summary>
    /// Class $safeprojectname$Page.
    /// </summary>
    internal partial class $safeprojectname$Page : PNetPage
    {
        #region Object lifecycle

        /// <summary>
        /// Initializes a new instance of the <see cref="$safeprojectname$Page"/> class.
        /// </summary>
        /// <param name="defaultPriority">The default priority.</param>
        public $safeprojectname$Page(uint defaultPriority) : base(defaultPriority)
        {
            if (Log.IsTraceEnabled) Log.EnterMethod(".ctor(uint defaultPriority)");

            // TODO: Construct the page

            if (Log.IsTraceEnabled) Log.LeaveMethod(".ctor(uint defaultPriority)");
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
        //     if (Log.IsDebugEnabled) Log.EnterMethod("Dispose(bool)");
        //
        //     PlatformDispose(disposing);
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
        //     if (Log.IsDebugEnabled) Log.LeaveMethod("Dispose(bool)");
        // }

        #endregion Object lifecycle

        private static readonly ILog Log = LogManager.GetLog(typeof($safeprojectname$Page));
    }
}
