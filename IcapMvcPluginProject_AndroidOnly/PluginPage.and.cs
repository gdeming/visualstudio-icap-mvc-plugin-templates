// ============================================================================ 
// $safeprojectname$Page.and.cs 
// Copyright (c) 2007-2018, PeopleNet Communications Corporation. 
// All rights reserved.  Unauthorized copying prohibited. 
// ============================================================================ 
 
﻿using Android.OS;
using Android.Views;

namespace PNet.Icap.Plugins.$safeprojectname$
{
    partial class $safeprojectname$Page
    {
        #region Object lifecycle

        /// <summary>
        /// Platform-specific page initialization.
        /// </summary>
        public override void PlatformInitialize()
        {
            if (Log.IsTraceEnabled) Log.EnterMethod("PlatformInitialize()");
            
            base.PlatformInitialize();

            // TODO: Add code to construct the page.
        
            if (Log.IsTraceEnabled) Log.LeaveMethod("PlatformInitialize()");
        }

        /// <summary>
        /// Platform-specific page show.
        /// </summary>
        public override void PlatformShow()
        {
            if (Log.IsTraceEnabled) Log.EnterMethod("PlatformShow()");
            
            base.PlatformShow();

            // TODO: Add code to show the page.
        
            if (Log.IsTraceEnabled) Log.LeaveMethod("PlatformShow()");
        }

        /// <summary>
        /// Platform-specific page hide.
        /// </summary>
        public override void PlatformHide()
        {
            if (Log.IsTraceEnabled) Log.EnterMethod("PlatformHide()");
            
            // TODO: Add code to hide the page.

            base.PlatformHide();
        
            if (Log.IsTraceEnabled) Log.LeaveMethod("PlatformHide()");
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
        //     if (Log.IsTraceEnabled) Log.EnterMethod("PlatformDispose(bool disposing)");
        //
        //     if (disposing)
        //     {
        //         // Deallocate managed resources here
        //     }
        //     
        //     // Deallocate unmanaged resources here
        //     
        //     if (Log.IsTraceEnabled) Log.LeaveMethod("PlatformDispose(bool disposing)");
        // }

        #endregion Object lifecycle


        #region View lifecycle

        /// <summary>
        /// Called when the view is created.
        /// </summary>
        /// <param name="inflater">The inflater.</param>
        /// <param name="container">The container.</param>
        /// <param name="savedInstanceState">State of the saved instance.</param>
        /// <returns>The view.</returns>
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            if (Log.IsTraceEnabled) Log.EnterMethod("OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceStat()");
            
            View view = base.OnCreateView(inflater, container, savedInstanceState);
            
            // TODO: Add view creation code.
        
            if (Log.IsTraceEnabled) Log.LeaveMethod("OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)");

            return view;
        }

        /// <summary>
        /// Called when the view is destroyed.
        /// </summary>
        public override void OnDestroyView()
        {
            if (Log.IsTraceEnabled) Log.EnterMethod("OnDestroyView()");
            
            // TODO: Add view destruction code.

            base.OnDestroyView();
        
            if (Log.IsTraceEnabled) Log.LeaveMethod("OnDestroyView()");
        }

        #endregion View lifecycle
    }
}
