// ============================================================================ 
// $safeprojectname$View.cs 
// Copyright (c) 2007-2018, PeopleNet Communications Corporation. 
// All rights reserved.  Unauthorized copying prohibited. 
// ============================================================================ 
 
﻿using System;
using PNet.Icap.Platform.ControlSdk2;
using PNet.Icap.Platform.PluginSdk2;

namespace PNet.Icap.Plugins.$safeprojectname$
{
    /// <summary>
    /// Class $safeprojectname$View.
    /// </summary>
    /// <typeparam name="TModel">The type of the model.</typeparam>
    internal class $safeprojectname$View<TModel> : APluginView<TModel>
        where TModel : IPluginModel
    {
        #region Object lifecycle

        /// <summary>
        /// Initializes a new instance of the <see cref="$safeprojectname$View{TModel}"/> class.
        /// </summary>
        /// <param name="model">The model.</param>
        public $safeprojectname$View(TModel model) : base(model)
        {
            if (Log.IsTraceEnabled) Log.EnterMethod("$safeprojectname$View(TModel model)");

            _page.PlatformInitialize();

            // TODO: Construct the view

            if (Log.IsTraceEnabled) Log.LeaveMethod("$safeprojectname$View(TModel model)");
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

        
        #region View methods

        /// <summary>
        /// Gets the current page.
        /// </summary>
        /// <value>The current page.</value>
        public PNetPage CurrentPage
        {
            get { return _page; }
        }
        
        /// <summary>
        /// Show this view.
        /// </summary>
        public void Show()
        {
            if (Log.IsTraceEnabled) Log.EnterMethod("Show()");

            _page.PlatformShow();

            // TODO: Add code to show the view.

            _page.HomeClicked += PageHomeClicked;
            _page.HomeEnabled = true;
            _page.BackClicked += PageBackClicked;
            _page.BackEnabled = true;

            if (Log.IsTraceEnabled) Log.LeaveMethod("Show()");
        }

        /// <summary>
        /// Hide this view.
        /// </summary>
        public void Hide()
        {
            if (Log.IsTraceEnabled) Log.EnterMethod("Hide()");

            _page.BackEnabled = false;
            _page.BackClicked -= PageBackClicked;
            _page.HomeEnabled = false;
            _page.HomeClicked -= PageHomeClicked;

            // TODO: Add code to hide the view.

            _page.PlatformHide();

            if (Log.IsTraceEnabled) Log.LeaveMethod("Hide()");
        }

        #endregion View methods

        
        #region Event handlers

        private void PageHomeClicked(object sender, EventArgs e)
        {
            if (Log.IsTraceEnabled) Log.EnterMethod("PageHomeClicked(object sender, EventArgs e)");

            OnHomeSelected(EventArgs.Empty);

            if (Log.IsTraceEnabled) Log.LeaveMethod("PageHomeClicked(object sender, EventArgs e)");
        }

        private void PageBackClicked(object sender, EventArgs e)
        {
            if (Log.IsTraceEnabled) Log.EnterMethod("PageBackClicked(object sender, EventArgs e)");

            OnBackSelected(EventArgs.Empty);

            if (Log.IsTraceEnabled) Log.LeaveMethod("PageBackClicked(object sender, EventArgs e)");
        }

        #endregion Event handlers


        #region Event sources

        /// <summary>
        /// Occurs when the user selects "Home".
        /// </summary>
        public event EventHandler HomeSelected;

        /// <summary>
        /// Occurs when the user selects "Back".
        /// </summary>
        public event EventHandler BackSelected;

        protected virtual void OnHomeSelected(EventArgs e)
        {
            if (Log.IsTraceEnabled) Log.EnterMethod("OnHomeSelected(EventArgs e)");

            EventHandler handler = HomeSelected;
            if (handler != null)
            {
                handler.Invoke(this, e);
            }

            if (Log.IsTraceEnabled) Log.LeaveMethod("OnHomeSelected(EventArgs e)");
        }

        protected virtual void OnBackSelected(EventArgs e)
        {
            if (Log.IsTraceEnabled) Log.EnterMethod("OnBackSelected(EventArgs e)");

            EventHandler handler = BackSelected;
            if (handler != null)
            {
                handler.Invoke(this, e);
            }

            if (Log.IsTraceEnabled) Log.LeaveMethod("OnBackSelected(EventArgs e)");
        }

        #endregion Event sources

        private readonly PNetPage _page = new PNetPage();
    }
}
