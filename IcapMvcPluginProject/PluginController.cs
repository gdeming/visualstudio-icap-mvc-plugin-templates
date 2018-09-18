// ============================================================================ 
// $safeprojectname$Controller.cs 
// Copyright (c) 2007-2018, PeopleNet Communications Corporation. 
// All rights reserved.  Unauthorized copying prohibited. 
// ============================================================================ 
 
﻿using PNet.Icap.Platform.PluginSdk2;

namespace PNet.Icap.Plugins.$safeprojectname$
{
    /// <summary>
    /// Class $safeprojectname$Controller.
    /// </summary>
    /// <typeparam name="TModel">The type of the model.</typeparam>
    /// <typeparam name="TView">The type of the view.</typeparam>
    internal class $safeprojectname$Controller<TModel, TView> : APluginController<TModel, TView>
        where TModel : IPluginModel
        where TView : IPluginView<TModel>
    {
        #region Object lifecycle

        public $safeprojectname$Controller(TModel model, TView view) 
            : base(model, view)
        {
            if (Log.IsTraceEnabled) Log.EnterMethod(".ctor(TModel model, TView view)");
            
            // TODO: Construct the Controller
        
            if (Log.IsTraceEnabled) Log.LeaveMethod(".ctor(TModel model, TView view) ");
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
    }
}
