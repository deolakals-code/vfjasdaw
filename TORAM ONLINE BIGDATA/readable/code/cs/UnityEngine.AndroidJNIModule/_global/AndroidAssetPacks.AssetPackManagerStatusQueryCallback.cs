// Assembly: UnityEngine.AndroidJNIModule.dll
// Namespace: 
private class AndroidAssetPacks.AssetPackManagerStatusQueryCallback : AndroidJavaProxy // TypeDefIndex: 17078
{
	// Fields
	private Action<ulong, AndroidAssetPackState[]> m_Callback; // 0x20
	private List<string> m_AssetPackNames; // 0x28
	private List<AndroidAssetPackState> m_States; // 0x30
	private long m_Size; // 0x38

	// Methods

	// RVA: 0x37C6C7C Offset: 0x37C2C7C VA: 0x37C6C7C
	public void .ctor(Action<ulong, AndroidAssetPackState[]> callback, string[] assetPacks) { }

	[Preserve]
	// RVA: 0x37C6D94 Offset: 0x37C2D94 VA: 0x37C6D94
	private void onStatusResult(long totalBytes, string[] assetPackNames, int[] assetPackStatuses, int[] assetPackErrorCodes) { }
}
