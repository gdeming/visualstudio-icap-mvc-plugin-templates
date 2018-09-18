// ============================================================================ 
// $safeprojectname$Plugin.cs 
// Copyright (c) 2007-2018, PeopleNet Communications Corporation. 
// All rights reserved.  Unauthorized copying prohibited. 
// ============================================================================ 
 
using System;
using PNet.Icap.Platform.ControlSdk2;
using PNet.Icap.Platform.GlobalConstants;
using PNet.Icap.Platform.PlatformSdk;
using PNet.Icap.Platform.ProgramSdk;
using PNet.Icap.Plugins.BrokerService;

using FormEventArgs = PNet.Icap.Presentation.PresentationSdk.FormEventArgs;
using ICommandManager = PNet.Icap.Presentation.PresentationSdk.ICommandManager;
using IDisplayManager = PNet.Icap.Presentation.PresentationSdk.IDisplayManager;

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
            if (Log.IsDebugEnabled) Log.EnterMethod(".ctor()");
        
            // TODO: Construct the Plugin
        
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
        //     if (Log.IsDebugEnabled) Log.EnterMethod("Dispose(bool)");
        //
        //     if (disposing)
        //     {
        //         Stop();
        //         Unsubscribe();
        //         Unpublish();
        //         Unload();
        //
        //         // TODO: Release managed resources here.
        //     }
        //
        //     // TODO: Release unmanaged resources here.
        //
        //     base.Dispose(disposing);
        //
        //     if (Log.IsDebugEnabled) Log.LeaveMethod("Dispose(bool)");
        // }

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
            if (Log.IsDebugEnabled) Log.EnterMethod("Load()");

            base.Load();
            
            _model = new $safeprojectname$Model();
            _view = new $safeprojectname$View<$safeprojectname$Model>(_model);
            _controller = new $safeprojectname$Controller<$safeprojectname$Model, $safeprojectname$View<$safeprojectname$Model>>(_model, _view);
        
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
        
            if (_controller != null)
            
            {
                _controller.Dispose();
                _controller = null;
            }

            if (_view != null)
            {
                _view.Dispose();
                _view = null;
            }

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
            if (Log.IsDebugEnabled) Log.EnterMethod("Publish()");

            base.Publish();

            IServiceManager serviceManager = GetService<IServiceManager>();
            
            if (serviceManager != null)
            {
                serviceManager.RegisterService<I$safeprojectname$Service>(this);
            }
            else
            {
                if (Log.IsErrorEnabled) Log.Error("Unable to access the ServiceManager");
            }

            // TODO: Publish other services.
            
            if (Log.IsTraceEnabled) Log.LeaveMethod("Publish()");
        }

        /// <summary>
        /// Unpublishes services for other plug-ins.
        /// </summary>
        public override void Unpublish()
        {
            if (Log.IsDebugEnabled) Log.EnterMethod("Unpublish()");

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
            if (Log.IsDebugEnabled) Log.EnterMethod("Subscribe()");

            base.Subscribe();

            _broker = GetService<IBrokerService>();
            if (_broker != null)
            {
                _broker.Register((uint)PluginAppId, "", out _brokerKey);
                _broker.SubscribeToUnicast("", _brokerKey, SampleUnicastHandler); // TODO: Change to be a real unicast data container
                _broker.SubscribeToMulticast("", _brokerKey, SampleMulticastHandler); // TODO: Change to be a real multicast data container
            }
            else
            {
                if (Log.IsErrorEnabled) Log.Error("Unable to access the Broker");
            }

            _commandManager = GetService<ICommandManager>();
            if (_commandManager != null)
            {
                _command = new PNetCommand(PluginCommand);
                _command.Executed += CommandSelected;
                _commandManager.RegisterCommand(_command);
            }
            else
            {
                if (Log.IsErrorEnabled) Log.Error("Unable to access the CommandManager");
            }

            _displayManager = GetService<IDisplayManager>();
            if (_displayManager != null)
            {
                _displayManager.FormShown += FormShown;
                _displayManager.FormHidden += FormHidden;
            }
            else
            {
                if (Log.IsErrorEnabled) Log.Error("Unable to access the DisplayManager");
            }

            // TODO: Subscribe to other services.
            
            if (Log.IsTraceEnabled) Log.LeaveMethod("Unpublish()");
        }

        /// <summary>
        /// Unsubscribes from services published by other plug-ins.
        /// </summary>
        public override void Unsubscribe()
        {
            if (Log.IsDebugEnabled) Log.EnterMethod("Unsubscribe()");

            // TODO: Unsubscribe from other services.

            if (_displayManager != null)
            {

                _displayManager.FormShown -= FormShown;
                _displayManager.FormHidden -= FormHidden;
                _displayManager = null;
            }

            if (_commandManager != null)
            {
                if (_command != null)
                {
                    _commandManager.RemoveCommand(_command);
                }
                _commandManager = null;
            }

            if (_broker != null)
            {
                _broker.UnsubscribeToMulticast("", _brokerKey, SampleMulticastHandler); // TODO: Change to be a real unicast data container
                _broker.UnsubscribeToUnicast("", _brokerKey); // TODO: Change to be a real multicast data container
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

        
        #region Plugin methods

        /// <summary>
        /// Shows the view.
        /// </summary>
        public void ShowView()
        {
            if (Log.IsTraceEnabled) Log.EnterMethod("ShowView()");
            
            PNetPage page = _view.CurrentPage;
            if (page != null)
            {                
                _view.HomeSelected += ViewOnHomeSelected;
                _view.BackSelected += ViewOnBackSelected;
                _displayManager.Show(page, (uint)PluginDisplayPriority);
            }
            
            if (Log.IsTraceEnabled) Log.LeaveMethod("ShowView()");
        }

        /// <summary>
        /// Hides the view.
        /// </summary>
        public void HideView()
        {
            if (Log.IsTraceEnabled) Log.EnterMethod("HideView()");

            PNetPage page = _view.CurrentPage;
            if (page != null)
            {
                _displayManager.Hide(page);
                _view.BackSelected -= ViewOnBackSelected;
                _view.HomeSelected -= ViewOnHomeSelected;
            }

            if (Log.IsTraceEnabled) Log.LeaveMethod("HideView()");
        }

        private void ViewOnHomeSelected(object sender, EventArgs eventArgs)
        {
            if (Log.IsTraceEnabled) Log.EnterMethod("ViewOnHomeSelected(object sender, EventArgs eventArgs)");

            _commandManager.ExecuteCommand(PNetCommandNames.Home);
            HideView();

            if (Log.IsTraceEnabled) Log.LeaveMethod("ViewOnHomeSelected(object sender, EventArgs eventArgs)");
        }

        private void ViewOnBackSelected(object sender, EventArgs eventArgs)
        {
            if (Log.IsTraceEnabled) Log.EnterMethod("ViewOnBackSelected(object sender, EventArgs eventArgs)");

            HideView();

            if (Log.IsTraceEnabled) Log.LeaveMethod("ViewOnBackSelected(object sender, EventArgs eventArgs)");
        }

        #endregion Plugin methods


        #region Event handlers

        // TODO: Rename to something descriptive
        private void SampleUnicastHandler(object sender, DataContainerEventArgs dataContainerEventArgs)
        {
            if (Log.IsTraceEnabled) Log.EnterMethod("SampleUnicastHandler(object sender, DataContainerEventArgs dataContainerEventArgs)");

            if (_isRunning)
            {
                // TODO: Handle the unicast.
            }

            if (Log.IsTraceEnabled) Log.LeaveMethod("SampleUnicastHandler(object sender, DataContainerEventArgs dataContainerEventArgs)");
        }

        // TODO: Rename to something descriptive
        private void SampleMulticastHandler(object sender, DataContainerEventArgs dataContainerEventArgs)
        {
            if (Log.IsTraceEnabled) Log.EnterMethod("SampleMulticastHandler(object sender, DataContainerEventArgs dataContainerEventArgs)");

            if (_isRunning)
            {
                // TODO: Handle the multicast.
            }

            if (Log.IsTraceEnabled) Log.LeaveMethod("SampleMulticastHandler(object sender, DataContainerEventArgs dataContainerEventArgs)");
        }

        private void CommandSelected(object sender, EventArgs e)
        {
            if (Log.IsTraceEnabled) Log.EnterMethod("CommandSelected(object sender, EventArgs e)");

            // TODO: Add code to handle command selection.
            
            ShowView();

            if (Log.IsTraceEnabled) Log.LeaveMethod("CommandSelected(object sender, EventArgs e)");
        }

        private void FormShown(object sender, FormEventArgs e)
        {
            if (Log.IsTraceEnabled) Log.EnterMethod("FormShown(object sender, FormEventArgs e)");

            // TODO: Add code to handle form shown.

            if (Log.IsTraceEnabled) Log.LeaveMethod("FormShown(object sender, FormEventArgs e)");
        }

        private void FormHidden(object sender, FormEventArgs e)
        {
            if (Log.IsTraceEnabled) Log.EnterMethod("FormHidden(object sender, FormEventArgs e)");

            // TODO: Add code to handle form hidden.

            if (Log.IsTraceEnabled) Log.LeaveMethod("FormHidden(object sender, FormEventArgs e)");
        }

        #endregion Event handlers

        private bool _isRunning;

        private IBrokerService _broker;
        private Guid _brokerKey;

        private ICommandManager _commandManager;
        private PNetCommand _command;

        private IDisplayManager _displayManager;

        private $safeprojectname$Model _model;
        private $safeprojectname$View<$safeprojectname$Model> _view;
        private $safeprojectname$Controller<$safeprojectname$Model, $safeprojectname$View<$safeprojectname$Model>> _controller;

        private static readonly ILog Log = LogManager.GetLog(typeof($safeprojectname$Plugin));

        // TODO: Change type PenPalId to NonPenpalId if this app will not communicate with the PFM.
        private const PenpalId PluginAppId = PenpalId.$safeprojectname$Plugin; // TODO: Add the app id to GlobalConst.cs.
        private const string PluginName = "$safeprojectname$"; // TODO: Specify plugin name
        private const string PluginDescription = "PeopleNet ICAP $safeprojectname$"; // TODO: Specify plugin description
        private const string PluginCommand = PNetCommandNames.$safeprojectname$Command; // TODO: Add command to PNetCommandNames.cs.
        private const ScreenPriority PluginDisplayPriority = ScreenPriority.$safeprojectname$; // TODO: Add screen priority to GlobalConst.cs
    }
}
