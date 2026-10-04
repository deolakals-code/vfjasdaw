// Assembly: UnityEngine.UnityWebRequestAssetBundleModule.dll
// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequestAssetBundle/Public/DownloadHandlerAssetBundle.h")]
public sealed class DownloadHandlerAssetBundle : DownloadHandler // TypeDefIndex: 17872
{
	// Properties
	public AssetBundle assetBundle { get; }

	// Methods

	// RVA: 0x3823F28 Offset: 0x381FF28 VA: 0x3823F28
	private static IntPtr CreateCached(DownloadHandlerAssetBundle obj, string url, string name, Hash128 hash, uint crc) { }

	// RVA: 0x3824004 Offset: 0x3820004 VA: 0x3824004
	private void InternalCreateAssetBundleCached(string url, string name, Hash128 hash, uint crc) { }

	// RVA: 0x3823EB8 Offset: 0x381FEB8 VA: 0x3823EB8
	public void .ctor(string url, CachedAssetBundle cachedBundle, uint crc) { }

	// RVA: 0x382401C Offset: 0x382001C VA: 0x382401C Slot: 7
	protected override byte[] GetData() { }

	// RVA: 0x3824068 Offset: 0x3820068 VA: 0x3824068 Slot: 8
	protected override string GetText() { }

	// RVA: 0x38240B4 Offset: 0x38200B4 VA: 0x38240B4
	public AssetBundle get_assetBundle() { }

	// RVA: 0x3823F98 Offset: 0x381FF98 VA: 0x3823F98
	private static IntPtr CreateCached_Injected(DownloadHandlerAssetBundle obj, string url, string name, ref Hash128 hash, uint crc) { }
}
