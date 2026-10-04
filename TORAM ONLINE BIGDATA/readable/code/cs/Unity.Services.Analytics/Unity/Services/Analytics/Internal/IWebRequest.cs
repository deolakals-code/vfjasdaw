// Assembly: Unity.Services.Analytics.dll
// Namespace: Unity.Services.Analytics.Internal
internal interface IWebRequest : IDisposable // TypeDefIndex: 17474
{
	// Properties
	public abstract bool IsNetworkError { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract UnityWebRequestAsyncOperation SendWebRequest();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetRequestHeader(string key, string value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsNetworkError();
}
