// Assembly: UnityEngine.AndroidJNIModule.dll
// Namespace: 
private class AndroidAssetPacks.AssetPackManagerDownloadStatusCallback : AndroidJavaProxy // TypeDefIndex: 17076
{
	// Fields
	private Action<AndroidAssetPackInfo> m_Callback; // 0x20
	private string[] m_AssetPacks; // 0x28

	// Methods

	// RVA: 0x37C69BC Offset: 0x37C29BC VA: 0x37C69BC
	public void .ctor(Action<AndroidAssetPackInfo> callback, string[] assetPacks) { }

	[Preserve]
	// RVA: 0x37C6A58 Offset: 0x37C2A58 VA: 0x37C6A58
	private void onStatusUpdate(string assetPackName, int assetPackStatus, long assetPackSize, long assetPackBytesDownloaded, int assetPackTransferProgress, int assetPackErrorCode) { }
}
