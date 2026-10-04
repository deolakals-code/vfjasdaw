// Assembly: Unity.Services.Analytics.dll
// Namespace: Unity.Services.Analytics
internal class AnalyticsServiceInstance : IAnalyticsService, IUnstructuredEventRecorder // TypeDefIndex: 17435
{
	// Fields
	private const string k_ForgetCallingId = "com.unity.services.analytics.Events.RequestDataDeletion";
	private const string k_StartUpCallingId = "com.unity.services.analytics.Events.Startup";
	private const string k_PlayerChangedCallingId = "com.unity.services.analytics.Events.PlayerChanged";
	internal const string k_InvokedByUserCallingId = "com.unity.services.analytics.Events.UserInvoked";
	private readonly TimeSpan k_BackgroundSessionRefreshPeriod; // 0x10
	private readonly TransactionCurrencyConverter converter; // 0x18
	private readonly IIdentityManager m_UserIdentity; // 0x20
	private readonly ISessionManager m_Session; // 0x28
	private readonly IDataGenerator m_DataGenerator; // 0x30
	private readonly ICoreStatsHelper m_CoreStatsHelper; // 0x38
	private readonly IDispatcher m_DataDispatcher; // 0x40
	private readonly IAnalyticsForgetter m_AnalyticsForgetter; // 0x48
	private readonly IAnalyticsServiceSystemCalls m_SystemCalls; // 0x50
	private readonly IAnalyticsContainer m_Container; // 0x58
	internal IBuffer m_DataBuffer; // 0x60
	private int m_BufferLengthAtLastGameRunning; // 0x68
	private DateTime m_ApplicationPauseTime; // 0x70
	private bool m_IsActive; // 0x78
	private bool m_StartUpEventsRecorded; // 0x79

	// Properties
	internal int AutoflushPeriodMultiplier { get; }

	// Methods

	// RVA: 0x379D5F0 Offset: 0x37995F0 VA: 0x379D5F0
	internal void .ctor(IDataGenerator dataGenerator, IBuffer realBuffer, ICoreStatsHelper coreStatsHelper, IDispatcher dispatcher, IAnalyticsForgetter forgetter, IIdentityManager userIdentity, string environment, IAnalyticsServiceSystemCalls systemCalls, IAnalyticsContainer container, ISessionManager session) { }

	// RVA: 0x379D8D8 Offset: 0x37998D8 VA: 0x379D8D8
	internal void ResumeDataDeletionIfNecessary() { }

	// RVA: 0x379F81C Offset: 0x379B81C VA: 0x379F81C
	internal void DeactivateWithDataDeletionRequest() { }

	// RVA: 0x379FE74 Offset: 0x379BE74 VA: 0x379FE74
	private void DataDeletionCompleted() { }

	// RVA: 0x379FCD4 Offset: 0x379BCD4 VA: 0x379FCD4
	private void Deactivate() { }

	// RVA: 0x379FF2C Offset: 0x379BF2C VA: 0x379FF2C
	private void RecordStartupEvents(string callingId) { }

	// RVA: 0x37A01B4 Offset: 0x379C1B4 VA: 0x37A01B4
	private void PlayerChanged() { }

	// RVA: 0x37A030C Offset: 0x379C30C VA: 0x37A030C
	internal void ApplicationPaused(bool paused) { }

	// RVA: 0x37A04A0 Offset: 0x379C4A0 VA: 0x37A04A0
	internal int get_AutoflushPeriodMultiplier() { }

	// RVA: 0x37A055C Offset: 0x379C55C VA: 0x37A055C Slot: 4
	public void Flush() { }

	// RVA: 0x37A069C Offset: 0x379C69C VA: 0x37A069C
	internal void ApplicationQuit() { }

	// RVA: 0x37A07EC Offset: 0x379C7EC VA: 0x37A07EC
	internal void RecordGameRunningIfNecessary() { }
}
