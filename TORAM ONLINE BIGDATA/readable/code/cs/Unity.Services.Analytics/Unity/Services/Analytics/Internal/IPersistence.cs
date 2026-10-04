// Assembly: Unity.Services.Analytics.dll
// Namespace: Unity.Services.Analytics.Internal
internal interface IPersistence // TypeDefIndex: 17472
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SaveValue(string key, int value);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SaveValue(string key, string value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int LoadInt(string key);
}
