// Assembly: UnityEngine.AndroidJNIModule.dll
// Namespace: 
private class AndroidAssetPacks.AssetPackManagerMobileDataConfirmationCallback : AndroidJavaProxy // TypeDefIndex: 17077
{
	// Fields
	private Action<AndroidAssetPackUseMobileDataRequestResult> m_Callback; // 0x20

	// Methods

	// RVA: 0x37C6B70 Offset: 0x37C2B70 VA: 0x37C6B70
	public void .ctor(Action<AndroidAssetPackUseMobileDataRequestResult> callback) { }

	[Preserve]
	// RVA: 0x37C6BF8 Offset: 0x37C2BF8 VA: 0x37C6BF8
	private void onMobileDataConfirmationResult(bool allowed) { }
}
