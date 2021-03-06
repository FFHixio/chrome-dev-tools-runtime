namespace BaristaLabs.ChromeDevTools.Runtime.Emulation
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents an adapter for the Emulation domain to simplify the command interface.
    /// </summary>
    public class EmulationAdapter
    {
        private readonly ChromeSession m_session;
        
        public EmulationAdapter(ChromeSession session)
        {
            m_session = session ?? throw new ArgumentNullException(nameof(session));
        }

        /// <summary>
        /// Gets the ChromeSession associated with the adapter.
        /// </summary>
        public ChromeSession Session
        {
            get { return m_session; }
        }

        /// <summary>
        /// Tells whether emulation is supported.
        /// </summary>
        public async Task<CanEmulateCommandResponse> CanEmulate(CanEmulateCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<CanEmulateCommand, CanEmulateCommandResponse>(command ?? new CanEmulateCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Clears the overriden device metrics.
        /// </summary>
        public async Task<ClearDeviceMetricsOverrideCommandResponse> ClearDeviceMetricsOverride(ClearDeviceMetricsOverrideCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ClearDeviceMetricsOverrideCommand, ClearDeviceMetricsOverrideCommandResponse>(command ?? new ClearDeviceMetricsOverrideCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Clears the overriden Geolocation Position and Error.
        /// </summary>
        public async Task<ClearGeolocationOverrideCommandResponse> ClearGeolocationOverride(ClearGeolocationOverrideCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ClearGeolocationOverrideCommand, ClearGeolocationOverrideCommandResponse>(command ?? new ClearGeolocationOverrideCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Requests that page scale factor is reset to initial values.
        /// </summary>
        public async Task<ResetPageScaleFactorCommandResponse> ResetPageScaleFactor(ResetPageScaleFactorCommand command = null, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<ResetPageScaleFactorCommand, ResetPageScaleFactorCommandResponse>(command ?? new ResetPageScaleFactorCommand(), cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Enables CPU throttling to emulate slow CPUs.
        /// </summary>
        public async Task<SetCPUThrottlingRateCommandResponse> SetCPUThrottlingRate(SetCPUThrottlingRateCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetCPUThrottlingRateCommand, SetCPUThrottlingRateCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Sets or clears an override of the default background color of the frame. This override is used
        /// if the content does not specify one.
        /// </summary>
        public async Task<SetDefaultBackgroundColorOverrideCommandResponse> SetDefaultBackgroundColorOverride(SetDefaultBackgroundColorOverrideCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetDefaultBackgroundColorOverrideCommand, SetDefaultBackgroundColorOverrideCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Overrides the values of device screen dimensions (window.screen.width, window.screen.height,
        /// window.innerWidth, window.innerHeight, and "device-width"/"device-height"-related CSS media
        /// query results).
        /// </summary>
        public async Task<SetDeviceMetricsOverrideCommandResponse> SetDeviceMetricsOverride(SetDeviceMetricsOverrideCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetDeviceMetricsOverrideCommand, SetDeviceMetricsOverrideCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// setScrollbarsHidden
        /// </summary>
        public async Task<SetScrollbarsHiddenCommandResponse> SetScrollbarsHidden(SetScrollbarsHiddenCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetScrollbarsHiddenCommand, SetScrollbarsHiddenCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// setDocumentCookieDisabled
        /// </summary>
        public async Task<SetDocumentCookieDisabledCommandResponse> SetDocumentCookieDisabled(SetDocumentCookieDisabledCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetDocumentCookieDisabledCommand, SetDocumentCookieDisabledCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// setEmitTouchEventsForMouse
        /// </summary>
        public async Task<SetEmitTouchEventsForMouseCommandResponse> SetEmitTouchEventsForMouse(SetEmitTouchEventsForMouseCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetEmitTouchEventsForMouseCommand, SetEmitTouchEventsForMouseCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Emulates the given media for CSS media queries.
        /// </summary>
        public async Task<SetEmulatedMediaCommandResponse> SetEmulatedMedia(SetEmulatedMediaCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetEmulatedMediaCommand, SetEmulatedMediaCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Overrides the Geolocation Position or Error. Omitting any of the parameters emulates position
        /// unavailable.
        /// </summary>
        public async Task<SetGeolocationOverrideCommandResponse> SetGeolocationOverride(SetGeolocationOverrideCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetGeolocationOverrideCommand, SetGeolocationOverrideCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Overrides value returned by the javascript navigator object.
        /// </summary>
        public async Task<SetNavigatorOverridesCommandResponse> SetNavigatorOverrides(SetNavigatorOverridesCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetNavigatorOverridesCommand, SetNavigatorOverridesCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Sets a specified page scale factor.
        /// </summary>
        public async Task<SetPageScaleFactorCommandResponse> SetPageScaleFactor(SetPageScaleFactorCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetPageScaleFactorCommand, SetPageScaleFactorCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Switches script execution in the page.
        /// </summary>
        public async Task<SetScriptExecutionDisabledCommandResponse> SetScriptExecutionDisabled(SetScriptExecutionDisabledCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetScriptExecutionDisabledCommand, SetScriptExecutionDisabledCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Enables touch on platforms which do not support them.
        /// </summary>
        public async Task<SetTouchEmulationEnabledCommandResponse> SetTouchEmulationEnabled(SetTouchEmulationEnabledCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetTouchEmulationEnabledCommand, SetTouchEmulationEnabledCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Turns on virtual time for all frames (replacing real-time with a synthetic time source) and sets
        /// the current virtual time policy.  Note this supersedes any previous time budget.
        /// </summary>
        public async Task<SetVirtualTimePolicyCommandResponse> SetVirtualTimePolicy(SetVirtualTimePolicyCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetVirtualTimePolicyCommand, SetVirtualTimePolicyCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Resizes the frame/viewport of the page. Note that this does not affect the frame's container
        /// (e.g. browser window). Can be used to produce screenshots of the specified size. Not supported
        /// on Android.
        /// </summary>
        public async Task<SetVisibleSizeCommandResponse> SetVisibleSize(SetVisibleSizeCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetVisibleSizeCommand, SetVisibleSizeCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }
        /// <summary>
        /// Allows overriding user agent with the given string.
        /// </summary>
        public async Task<SetUserAgentOverrideCommandResponse> SetUserAgentOverride(SetUserAgentOverrideCommand command, CancellationToken cancellationToken = default(CancellationToken), int? millisecondsTimeout = null, bool throwExceptionIfResponseNotReceived = true)
        {
            return await m_session.SendCommand<SetUserAgentOverrideCommand, SetUserAgentOverrideCommandResponse>(command, cancellationToken, millisecondsTimeout, throwExceptionIfResponseNotReceived);
        }

        /// <summary>
        /// Notification sent after the virtual time has advanced.
        /// </summary>
        public void SubscribeToVirtualTimeAdvancedEvent(Action<VirtualTimeAdvancedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Notification sent after the virtual time budget for the current VirtualTimePolicy has run out.
        /// </summary>
        public void SubscribeToVirtualTimeBudgetExpiredEvent(Action<VirtualTimeBudgetExpiredEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
        /// <summary>
        /// Notification sent after the virtual time has paused.
        /// </summary>
        public void SubscribeToVirtualTimePausedEvent(Action<VirtualTimePausedEvent> eventCallback)
        {
            m_session.Subscribe(eventCallback);
        }
    }
}