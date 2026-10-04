// Assembly: Unity.Services.Analytics.dll
// Namespace: Unity.Services.Analytics.Internal
internal class AnalyticsForgetter : IAnalyticsForgetter // TypeDefIndex: 17457
{
	// Fields
	private readonly string m_CollectUrl; // 0x10
	private readonly IPersistence m_Persistence; // 0x18
	private readonly IWebRequestHelper m_WebRequestHelper; // 0x20
	private Action m_Callback; // 0x28
	private AnalyticsForgetter.DataDeletionStatus m_DeletionStatus; // 0x30
	private IWebRequest m_Request; // 0x38

	// Properties
	public bool DeletionInProgress { get; }

	// Methods

	// RVA: 0x37A3A9C Offset: 0x379FA9C VA: 0x37A3A9C Slot: 4
	public bool get_DeletionInProgress() { }

	// RVA: 0x379D4D4 Offset: 0x37994D4 VA: 0x379D4D4
	internal void .ctor(string collectUrl, IPersistence persistence, IWebRequestHelper webRequestHelper) { }

	// RVA: 0x37A3AAC Offset: 0x379FAAC VA: 0x37A3AAC
	private void SetForgettingStatus(AnalyticsForgetter.DataDeletionStatus state) { }

	// RVA: 0x37A3B74 Offset: 0x379FB74 VA: 0x37A3B74 Slot: 5
	public void AttemptToForget(string userId, string installationId, string playerId, string timestamp, string callingMethod, Action successfulUploadCallback) { }

	// RVA: 0x37A4204 Offset: 0x37A0204 VA: 0x37A4204
	private void UploadComplete(long code) { }
}
