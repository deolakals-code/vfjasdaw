// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OrbShopResourceManager : Singleton<OrbShopResourceManager> // TypeDefIndex: 5529
{
	// Fields
	[SerializeField]
	private OrbShopAssetBundleManager assetBundleManager; // 0x20
	[SerializeField]
	private OrbShopCacheObjectManager cacheManager; // 0x28
	[SerializeField]
	private DownloadManager dlManager; // 0x30
	private string baseUrl; // 0x38
	[CompilerGenerated]
	private bool <IsLoadFromMemory>k__BackingField; // 0x40
	private List<string> loadingCacheNames; // 0x48
	private float asyncCacheTime; // 0x50

	// Properties
	public int InitDownloadCount { get; }
	public int InitCurrentDownloadNumber { get; }
	public bool IsDownload { get; }
	public bool IsLoadFromMemory { get; set; }
	public float DownloadProgress { get; }

	// Methods

	// RVA: 0x178F91C Offset: 0x178B91C VA: 0x178F91C
	public int get_InitDownloadCount() { }

	// RVA: 0x178F938 Offset: 0x178B938 VA: 0x178F938
	public int get_InitCurrentDownloadNumber() { }

	// RVA: 0x178F954 Offset: 0x178B954 VA: 0x178F954
	public bool get_IsDownload() { }

	[CompilerGenerated]
	// RVA: 0x178F970 Offset: 0x178B970 VA: 0x178F970
	public bool get_IsLoadFromMemory() { }

	[CompilerGenerated]
	// RVA: 0x178F978 Offset: 0x178B978 VA: 0x178F978
	private void set_IsLoadFromMemory(bool value) { }

	// RVA: 0x178F984 Offset: 0x178B984 VA: 0x178F984
	public float get_DownloadProgress() { }

	// RVA: 0x178F9A0 Offset: 0x178B9A0 VA: 0x178F9A0
	public void Clear() { }

	[IteratorStateMachine(typeof(OrbShopResourceManager.<ReInitialize>d__19))]
	// RVA: 0x178F9B8 Offset: 0x178B9B8 VA: 0x178F9B8
	public IEnumerator ReInitialize(Action<int> result) { }

	// RVA: 0x178FA48 Offset: 0x178BA48 VA: 0x178FA48
	private void assetDecrypt(byte[] data, int key) { }

	[IteratorStateMachine(typeof(OrbShopResourceManager.<LoadAssetBundle>d__21))]
	// RVA: 0x178FB94 Offset: 0x178BB94 VA: 0x178FB94
	public IEnumerator LoadAssetBundle(string assetFile, AssetBundleManager.AssetReleaseType type, Action<bool> result) { }

	[IteratorStateMachine(typeof(OrbShopResourceManager.<LoadAssetBundle>d__22))]
	// RVA: 0x178FC48 Offset: 0x178BC48 VA: 0x178FC48
	private IEnumerator LoadAssetBundle(string assetFile, AssetBundleManager.AssetReleaseType type, Action<bool> result, int deep) { }

	[IteratorStateMachine(typeof(OrbShopResourceManager.<LoadAssetBundle>d__23))]
	// RVA: 0x178FD04 Offset: 0x178BD04 VA: 0x178FD04
	public IEnumerator LoadAssetBundle(string assetFile, AssetBundleManager.AssetReleaseType type, string tag, Action<bool> result, int deep) { }

	// RVA: 0x178FDDC Offset: 0x178BDDC VA: 0x178FDDC
	public void RemoveAssetBundle(string assetFile, bool loadObjectRelease) { }

	// RVA: 0x178FDF8 Offset: 0x178BDF8 VA: 0x178FDF8
	public void LoadCacheFromResource(string name, CacheObjectFlag flag, CacheObjectManager.CacheType type) { }

	// RVA: 0x178FE4C Offset: 0x178BE4C VA: 0x178FE4C
	private Object addCache(string name, Object obj, CacheObjectFlag flag, CacheObjectManager.CacheType type) { }

	// RVA: 0x178FF20 Offset: 0x178BF20 VA: 0x178FF20
	public Object GetAssetObject(string assetFile, string name, CacheObjectFlag flag, bool cache, CacheObjectManager.CacheType cacheType) { }

	// RVA: 0x1790070 Offset: 0x178C070 VA: 0x1790070
	public Object GetMainAsset(string assetFile, CacheObjectFlag flag, bool cache, CacheObjectManager.CacheType cacheType) { }

	// RVA: 0x17901C0 Offset: 0x178C1C0 VA: 0x17901C0
	public byte[] GetAssetBinary(string assetFile, string name) { }

	// RVA: 0x17902E8 Offset: 0x178C2E8 VA: 0x17902E8
	public byte[] GetAssetBinary(string assetFile) { }

	// RVA: 0x178FE80 Offset: 0x178BE80 VA: 0x178FE80
	public Object GetCacheObject(string name) { }

	// RVA: 0x1790400 Offset: 0x178C400 VA: 0x1790400
	private void setLayer(GameObject obj, int layer) { }

	// RVA: 0x17904AC Offset: 0x178C4AC VA: 0x17904AC
	public void .ctor() { }
}
