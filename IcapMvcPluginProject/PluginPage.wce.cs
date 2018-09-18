// ============================================================================ 
// $safeprojectname$Page.wce.cs 
// Copyright (c) 2007-2018, PeopleNet Communications Corporation. 
// All rights reserved.  Unauthorized copying prohibited. 
// ============================================================================ 
 
﻿using System;
using System.Windows.Forms;
using PNet.Icap.Platform.ControlSdk2;
using PNet.Icap.Platform.PlatformSdk;

namespace PNet.Icap.Plugins.$safeprojectname$
{
    partial class $safeprojectname$Page
    {
        /// <summary>
        /// Initializes the page.
        /// </summary>
        public override void PlatformInitialize()
        {
            if (Log.IsTraceEnabled) Log.EnterMethod("PlatformInitialize()");

            InitializeComponent();

            // TODO: Construct the page

            if (Log.IsTraceEnabled) Log.LeaveMethod("PlatformInitialize()");
        }

        // TODO: Uncomment and implement to deterministically release resources.
        ///// <summary>
        ///// Releases resources used by this plug-in.
        ///// </summary>
        ///// <param name="disposing">
        ///// <c>true</c> if called from Dispose(), else <c>false</c>.
        ///// </param>
        // protected void PlatformDispose(bool disposing)
        // {
        //     if (Log.IsDebugEnabled) Log.EnterMethod("PlatformDispose(bool)");
        //
        //     if (disposing)
        //     {
        //         // Deallocate managed resources here
        //     }
        //     
        //     // Deallocate unmanaged resources here
        //
        //     if (Log.IsDebugEnabled) Log.LeaveMethod("PlatformDispose(bool)");
        // }
    }
}
