// Assembly: Firebase.Platform.dll
// Namespace: Firebase.Platform
internal interface IFirebaseAppUtils // TypeDefIndex: 17744
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void TranslateDllNotFoundException(Action action);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void PollCallbacks();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract PlatformLogLevel GetLogLevel();
}
