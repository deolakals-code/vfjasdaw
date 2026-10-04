// Assembly: Unity.Services.Analytics.dll
// Namespace: Unity.Services.Analytics.Internal
internal interface ISessionManager // TypeDefIndex: 17479
{
	// Properties
	public abstract string SessionId { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_SessionId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void StartNewSession();
}
