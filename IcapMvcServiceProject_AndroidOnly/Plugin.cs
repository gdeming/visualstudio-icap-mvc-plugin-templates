// ============================================================================ 
// $safeprojectname$Plugin.cs 
// Copyright (c) 2007-2018, PeopleNet Communications Corporation. 
// All rights reserved.  Unauthorized copying prohibited. 
// ============================================================================ 
 
﻿using System;
using PNet.Icap.Platform.GlobalConstants;
using PNet.Icap.Platform.PlatformSdk;
using PNet.Icap.Platform.ProgramSdk;
using PNet.Icap.Plugins.BrokerService;

namespace PNet.Icap.Plugins.$safeprojectname$
{
    /// <summary>
    /// Class $safeprojectname$Plugin.
    /// </summary>
    public class $safeprojectname$Plugin : APlugin, I$safeprojectname$Service
    {
        #region Object lifecycle

        /// <summary>
        /// Initializes a new instance of the <see cref="$safeprojectname$Plugin"/> class.
        /// </summary>
        public $safeprojectname$Plugin()
            : base(PluginName, PluginDescription)
        {
            if (Log.IsTraceEnabled) Log.EnterMethod(".ctor()");
            
            // TODO: Construct the plugin
            
            if (Log.IsTraceEnabled) Log.LeaveMethod(".ctor()");
        }

        // TODO: Uncomment and implement to deterministically release resources.
        ///// <summary>
        ///// Releases resources used by this plug-in.
        ///// </summary>
        ///// <param name="disposing">
        ///// <c>true</c> if called from Dispose(), else <c>false</c>.
        ///// </param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (Log.IsTraceEnabled) Log.EnterMethod("Dispose(bool={0})", disposing);
        //
        //    if (disposing)
        //    {
        //        Stop();
        //        Unsubscribe();
        //        Unpublish();
        //        Unload();
        //
        //        // TODO: Release managed resources here.
        //    }
        //
        //    // TODO: Release unmanaged resources here.
        //
        //    base.Dispose(disposing);
        //
        //    if (Log.IsTraceEnabled) Log.LeaveMethod("Dispose(bool)");
        //}

        // TODO: Uncomment and implement to deterministically release unmanaged resources.
        ///// <summary>
        ///// Finalizes an instance of the <see cref="$safeprojectname$Plugin"/> class.
        ///// </summary>
        //~$safeprojectname$Plugin()
        //{
        //    Dispose(false);
        //}

        #endregion Object lifecycle


        #region Plug-in lifecycle

        /// <summary>
        /// Loads resources for this plug-in.
        /// </summary>
        /// <remarks>
        /// Creates the model, view and controller.
        /// </remarks>
        public override void Load()
        {
            if (Log.IsTraceEnabled) Log.EnterMethod("Load()");

            base.Load();
            _model = new $safeprojectname$Model();

            if (Log.IsTraceEnabled) Log.LeaveMethod("Load()");
        }

        /// <summary>
        /// Unloads resources for this plug-in.
        /// </summary>
        /// <remarks>
        /// Releases the model, view and controller.
        /// </remarks>
        public override void Unload()
        {
            if (Log.IsTraceEnabled) Log.EnterMethod("Unload()");

            if (_model != null)
            {
                _model.Dispose();
                _model = null;
            }

            base.Unload();

            if (Log.IsTraceEnabled) Log.LeaveMethod("Unload()");
        }

        /// <summary>
        /// Publishes services for other plug-ins.
        /// </summary>
        public override void Publish()
        {
            if (Log.IsTraceEnabled) Log.EnterMethod("Publish()");

            base.Publish();

            IServiceManager serviceManager = GetService<IServiceManager>();
            if (serviceManager != null)
            {
                serviceManager.RegisterService<I$safeprojectname$Service>(this);
            }

            // TODO: Publish other services.

            if (Log.IsTraceEnabled) Log.LeaveMethod("Publish()");
        }

        /// <summary>
        /// Unpublishes services for other plug-ins.
        /// </summary>
        public override void Unpublish()
        {
            if (Log.IsTraceEnabled) Log.EnterMethod("Unpublish()");

            // TODO: Unpublish other services.

            IServiceManager serviceManager = GetService<IServiceManager>();
            if (serviceManager != null)
            {
                serviceManager.UnregisterService<I$safeprojectname$Service>();
            }
            
            base.Unpublish();

            if (Log.IsTraceEnabled) Log.LeaveMethod("Unpublish()");
        }

        /// <summary>
        /// Subscribes to services published by other plug-ins.
        /// </summary>
        public override void Subscribe()
        {
            if (Log.IsTraceEnabled) Log.EnterMethod("Subscribe()");

            base.Subscribe();

            _broker = GetService<IBrokerService>();
            if (_broker != null)
            {
                _broker.Register((uint)PluginAppId, "", out _brokerKey);
                _broker.SubscribeToUnicast("", _brokerKey, SampleUnicastHandler); // TODO: Change to be a real unicast data container
                _broker.SubscribeToMulticast("", _brokerKey, SampleMulticastHandler); // TODO: Change to be a real multicast data container
            }

            // TODO: Subscribe to other services.

            if (Log.IsTraceEnabled) Log.LeaveMethod("Subscribe()");
        }

        /// <summary>
        /// Unsubscribes from services published by other plug-ins.
        /// </summary>
        public override void Unsubscribe()
        {
            if (Log.IsTraceEnabled) Log.EnterMethod("Unsubscribe()");

            // TODO: Unsubscribe from other services.

            if (_broker != null)
            {
                _broker.UnsubscribeToMulticast("", _brokerKey, SampleMulticastHandler);
                _broker.UnsubscribeToUnicast("", _brokerKey);
                _broker.Unregister(_brokerKey);
                _broker = null;
            }

            base.Unsubscribe();

            if (Log.IsTraceEnabled) Log.LeaveMethod("Unsubscribe()");
        }

        /// <summary>
        /// Signals that plug-ins have been loaded, published, and subscribed.
        /// </summary>
        public override void Run()
        {
            if (Log.IsTraceEnabled) Log.EnterMethod("Run()");

            base.Run();

            _isRunning = true;

            // TODO: Perform system startup tasks.

            if (Log.IsTraceEnabled) Log.LeaveMethod("Run()");
        }

        /// <summary>
        /// Signals that plug-ins will unload, unpublish, and unsubscribe.
        /// </summary>
        public override void Stop()
        {
            if (Log.IsTraceEnabled) Log.EnterMethod("Stop()");

            // TODO: Perform system shutdown tasks.

            _isRunning = false;
            
            base.Stop();

            if (Log.IsTraceEnabled) Log.LeaveMethod("Stop()");
        }

        #endregion Plug-in lifecycle

        
        #region Event handlers

        // TODO: Rename to something descriptive
        private void SampleUnicastHandler(object sender, DataContainerEventArgs dataContainerEventArgs)
        {
            if (Log.IsTraceEnabled) Log.EnterMethod("SampleUnicastHandler(object sender={0}, DataContainerEventArgs dataContainerEventArgs={1})", sender, dataContainerEventArgs);

            if (_isRunning)
            {
                // TODO: Handle the unicast.
            }

            if (Log.IsTraceEnabled) Log.LeaveMethod("SampleUnicastHandler(object, DataContainerEventArgs)");
        }

        // TODO: Rename to something descriptive
        private void SampleMulticastHandler(object sender, DataContainerEventArgs dataContainerEventArgs)
        {
            if (Log.IsTraceEnabled) Log.EnterMethod("SampleMulticastHandler(object sender={0}, DataContainerEventArgs dataContainerEventArgs={1})", sender, dataContainerEventArgs);

            if (_isRunning)
            {
                // TODO: Handle the multicast.
            }

            if (Log.IsTraceEnabled) Log.LeaveMethod("SampleMulticastHandler(object, DataContainerEventArgs)");
        }

        #endregion Event handlers

        private bool _isRunning;

        private IBrokerService _broker;
        private Guid _brokerKey;

        private $safeprojectname$Model _model;

        private static readonly ILog Log = LogManager.GetLog(typeof($safeprojectname$Plugin));

        // TODO: Change type PenPalId to NonPenpalId if this app will not communicate with the PFM.
        private const PenpalId PluginAppId = PenpalId.$safeprojectname$Plugin; // TODO: Add the app id to GlobalConst.cs.
        private const string PluginName = "$safeprojectname$"; // TODO: Specify plugin name
        private const string PluginDescription = "PeopleNet ICAP $safeprojectname$"; // TODO: Specify plugin description
    }
}
