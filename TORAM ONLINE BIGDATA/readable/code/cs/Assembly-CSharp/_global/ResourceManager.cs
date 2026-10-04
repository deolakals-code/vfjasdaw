// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ResourceManager : Singleton<ResourceManager> // TypeDefIndex: 5574
{
	// Fields
	[SerializeField]
	private AssetBundleManager assetBundleManager; // 0x20
	[SerializeField]
	private CacheObjectManager cacheManager; // 0x28
	[SerializeField]
	private DownloadManager dlManager; // 0x30
	private string baseUrl; // 0x38
	private WaitForSeconds loadingRetryWait; // 0x40
	[CompilerGenerated]
	private bool <IsLoadFromMemory>k__BackingField; // 0x48
	private List<string> loadingCacheNames; // 0x50
	private float asyncCacheTime; // 0x58
	[CompilerGenerated]
	private bool <IsBreakAssets>k__BackingField; // 0x5C
	private const string saveBreakAssetsTryCountPath = "BreakAssetsTryCount";
	private int breakAssetsTryCount; // 0x60
	private MultiWorkerThread thread; // 0x68

	// Properties
	public static string CommonAssetbundleName { get; }
	public int InitDownloadCount { get; }
	public int InitCurrentDownloadNumber { get; }
	public bool IsDownload { get; }
	public bool IsLoadFromMemory { get; set; }
	public float DownloadProgress { get; }
	public bool IsBreakAssets { get; set; }

	// Methods

	// RVA: 0x179397C Offset: 0x178F97C VA: 0x179397C
	public static string get_CommonAssetbundleName() { }

	// RVA: 0x17939BC Offset: 0x178F9BC VA: 0x17939BC
	public int get_InitDownloadCount() { }

	// RVA: 0x17939D8 Offset: 0x178F9D8 VA: 0x17939D8
	public int get_InitCurrentDownloadNumber() { }

	// RVA: 0x17939F4 Offset: 0x178F9F4 VA: 0x17939F4
	public bool get_IsDownload() { }

	[CompilerGenerated]
	// RVA: 0x1793A10 Offset: 0x178FA10 VA: 0x1793A10
	public bool get_IsLoadFromMemory() { }

	[CompilerGenerated]
	// RVA: 0x1793A18 Offset: 0x178FA18 VA: 0x1793A18
	private void set_IsLoadFromMemory(bool value) { }

	// RVA: 0x1793A24 Offset: 0x178FA24 VA: 0x1793A24
	public float get_DownloadProgress() { }

	[CompilerGenerated]
	// RVA: 0x1793A40 Offset: 0x178FA40 VA: 0x1793A40
	public bool get_IsBreakAssets() { }

	[CompilerGenerated]
	// RVA: 0x1793A48 Offset: 0x178FA48 VA: 0x1793A48
	private void set_IsBreakAssets(bool value) { }

	// RVA: 0x1793A54 Offset: 0x178FA54 VA: 0x1793A54
	private void Start() { }

	// RVA: 0x1793B14 Offset: 0x178FB14 VA: 0x1793B14
	public void Clear() { }

	[IteratorStateMachine(typeof(ResourceManager.<Initialize>d__31))]
	// RVA: 0x1793B78 Offset: 0x178FB78 VA: 0x1793B78
	public IEnumerator Initialize(string url, Action<bool> result) { }

	[IteratorStateMachine(typeof(ResourceManager.<ReInitialize>d__32))]
	// RVA: 0x1793C3C Offset: 0x178FC3C VA: 0x1793C3C
	public IEnumerator ReInitialize(string url, Action<bool> result) { }

	[IteratorStateMachine(typeof(ResourceManager.<LoadSettingData>d__33))]
	// RVA: 0x1793D00 Offset: 0x178FD00 VA: 0x1793D00
	public IEnumerator LoadSettingData(Action<byte[]> result) { }

	// RVA: 0x1793DB0 Offset: 0x178FDB0 VA: 0x1793DB0
	public void CreateAllDownloadList() { }

	// RVA: 0x1793DCC Offset: 0x178FDCC VA: 0x1793DCC
	public void CreateDownloadList(List<string> names) { }

	// RVA: 0x1793DE8 Offset: 0x178FDE8 VA: 0x1793DE8
	public void CreateDownloadList(string[] names) { }

	[IteratorStateMachine(typeof(ResourceManager.<UpdateResources>d__37))]
	// RVA: 0x1793E78 Offset: 0x178FE78 VA: 0x1793E78
	public IEnumerator UpdateResources(Action<bool> result) { }

	[IteratorStateMachine(typeof(ResourceManager.<assetBundleManager_OnLoadAssetBundle>d__38))]
	// RVA: 0x1793F28 Offset: 0x178FF28 VA: 0x1793F28
	private IEnumerator assetBundleManager_OnLoadAssetBundle(AssetBundleManager.AssetBundleDecryptEventArgs arg) { }

	// RVA: 0x1793FD8 Offset: 0x178FFD8 VA: 0x1793FD8
	public static void AssetDecrypt(byte[] data, int key) { }

	[IteratorStateMachine(typeof(ResourceManager.<asyncAssetDecrypt>d__40))]
	// RVA: 0x1794120 Offset: 0x1790120 VA: 0x1794120
	private IEnumerator asyncAssetDecrypt(byte[] data, int key, Action<float> callback) { }

	// RVA: 0x17941D8 Offset: 0x17901D8 VA: 0x17941D8
	public bool CheckBreakAssetsData() { }

	// RVA: 0x1794284 Offset: 0x1790284 VA: 0x1794284
	public void ClearBreakAssetsData() { }

	// RVA: 0x17942D4 Offset: 0x17902D4 VA: 0x17942D4
	public void BreakAssetsData() { }

	// RVA: 0x1794324 Offset: 0x1790324 VA: 0x1794324
	public List<string> GetAssetNamesContains(string name) { }

	// RVA: 0x1794340 Offset: 0x1790340 VA: 0x1794340
	public List<string> GetAssetNamesContains(string name, bool ignoreCase) { }

	[IteratorStateMachine(typeof(ResourceManager.<LoadAssetBundle>d__46))]
	// RVA: 0x1794360 Offset: 0x1790360 VA: 0x1794360
	public IEnumerator LoadAssetBundle(string assetFile, AssetBundleManager.AssetReleaseType type, Action<bool> result) { }

	[IteratorStateMachine(typeof(ResourceManager.<LoadAssetBundle>d__47))]
	// RVA: 0x1794434 Offset: 0x1790434 VA: 0x1794434
	public IEnumerator LoadAssetBundle(string assetFile, AssetBundleManager.AssetReleaseType type, string tag, Action<bool> result) { }

	// RVA: 0x179451C Offset: 0x179051C VA: 0x179451C
	public void RemoveAssetBundle(string assetFile, bool loadObjectRelease) { }

	// RVA: 0x179453C Offset: 0x179053C VA: 0x179453C
	public void RemoveAssetBundle(string assetFile, bool loadObjectRelease, bool isClear) { }

	// RVA: 0x179455C Offset: 0x179055C VA: 0x179455C
	public void RemoveAssetBundleTag(string tag, bool loadObjectRelease) { }

	// RVA: 0x179457C Offset: 0x179057C VA: 0x179457C
	public void LoadCacheFromAssetBundle(string assetFile, string name, CacheObjectFlag flag, CacheObjectManager.CacheType type) { }

	// RVA: 0x17946E4 Offset: 0x17906E4 VA: 0x17946E4
	public void LoadCacheFromAssetBundle(string assetFile, string name, CacheObjectFlag flag, CacheObjectManager.CacheType type, string tag) { }

	// RVA: 0x1794854 Offset: 0x1790854 VA: 0x1794854
	public void LoadCacheFromAssetBundle(string assetFile, string[] names, CacheObjectFlag[] flags, CacheObjectManager.CacheType type) { }

	// RVA: 0x1794AEC Offset: 0x1790AEC VA: 0x1794AEC
	public void LoadCacheFromAssetBundle(string assetFile, string[] names, CacheObjectFlag[] flags, CacheObjectManager.CacheType type, string tag) { }

	[IteratorStateMachine(typeof(ResourceManager.<LoadAsyncCacheFromAssetBundle>d__55))]
	// RVA: 0x1794DE8 Offset: 0x1790DE8 VA: 0x1794DE8
	public IEnumerator LoadAsyncCacheFromAssetBundle(string assetFile, string[] names, CacheObjectFlag[] flags, CacheObjectManager.CacheType type, Action<bool> result) { }

	[IteratorStateMachine(typeof(ResourceManager.<LoadAsyncCacheFromAssetBundle>d__56))]
	// RVA: 0x1794EEC Offset: 0x1790EEC VA: 0x1794EEC
	public IEnumerator LoadAsyncCacheFromAssetBundle(string assetFile, string[] names, CacheObjectFlag[] flags, CacheObjectManager.CacheType type, string tag, Action<bool> result) { }

	[IteratorStateMachine(typeof(ResourceManager.<LoadAsyncCacheFromAssetBundle>d__57))]
	// RVA: 0x1795004 Offset: 0x1791004 VA: 0x1795004
	public IEnumerator LoadAsyncCacheFromAssetBundle(string assetFile, string[] names, CacheObjectFlag[] flags, CacheObjectManager.CacheType type, Action<bool, int> func, int funcArg) { }

	[IteratorStateMachine(typeof(ResourceManager.<LoadAsyncCacheFromAssetBundle>d__58))]
	// RVA: 0x1795110 Offset: 0x1791110 VA: 0x1795110
	public IEnumerator LoadAsyncCacheFromAssetBundle(string assetFile, string[] names, CacheObjectFlag[] flags, CacheObjectManager.CacheType type, Action<bool, int> func, int funcArg, string tag) { }

	// RVA: 0x1795238 Offset: 0x1791238 VA: 0x1795238
	public void AddCache(Object obj, string name, CacheObjectFlag flag, CacheObjectManager.CacheType type) { }

	// RVA: 0x1795260 Offset: 0x1791260 VA: 0x1795260
	public void AddCache(Object obj, string name, CacheObjectFlag flag, CacheObjectManager.CacheType type, string tag) { }

	// RVA: 0x1795288 Offset: 0x1791288 VA: 0x1795288
	public void RemoveCache(string name) { }

	// RVA: 0x17952A4 Offset: 0x17912A4 VA: 0x17952A4
	public void RemoveCacheTag(string tag) { }

	// RVA: 0x17952C0 Offset: 0x17912C0 VA: 0x17952C0
	private Object GetAssetObjectSetting(string name, Object retObj, CacheObjectFlag flag, int layer, bool cache, CacheObjectManager.CacheType cacheType, string tag) { }

	// RVA: 0x1795460 Offset: 0x1791460 VA: 0x1795460
	private Object addCache(string name, Object obj, CacheObjectFlag flag, CacheObjectManager.CacheType type) { }

	// RVA: 0x17954DC Offset: 0x17914DC VA: 0x17954DC
	private Object addCache(string name, Object obj, CacheObjectFlag flag, CacheObjectManager.CacheType type, string tag) { }

	// RVA: 0x17954EC Offset: 0x17914EC VA: 0x17954EC
	private Object addCache(string name, Object obj, CacheObjectFlag flag, int layer, CacheObjectManager.CacheType type) { }

	// RVA: 0x1795418 Offset: 0x1791418 VA: 0x1795418
	private Object addCache(string name, Object obj, CacheObjectFlag flag, int layer, CacheObjectManager.CacheType type, string tag) { }

	// RVA: 0x1795628 Offset: 0x1791628 VA: 0x1795628
	public Object GetAssetObject(string assetFile, string name, CacheObjectFlag flag, bool cache, CacheObjectManager.CacheType cacheType) { }

	// RVA: 0x17957D4 Offset: 0x17917D4 VA: 0x17957D4
	public Object GetAssetObject(string assetFile, string name, CacheObjectFlag flag, bool cache, CacheObjectManager.CacheType cacheType, string tag) { }

	// RVA: 0x17957FC Offset: 0x17917FC VA: 0x17957FC
	public Object GetAssetObject(string assetFile, string name, CacheObjectFlag flag, int layer, bool cache, CacheObjectManager.CacheType cacheType) { }

	// RVA: 0x17956C0 Offset: 0x17916C0 VA: 0x17956C0
	public Object GetAssetObject(string assetFile, string name, CacheObjectFlag flag, int layer, bool cache, CacheObjectManager.CacheType cacheType, string tag) { }

	[IteratorStateMachine(typeof(ResourceManager.<GetAssetObjectAsync>d__72))]
	// RVA: 0x1795898 Offset: 0x1791898 VA: 0x1795898
	public IEnumerator GetAssetObjectAsync(string assetFile, string name, CacheObjectFlag flag, int layer, bool cache, CacheObjectManager.CacheType cacheType, Action<Object> callback) { }

	[IteratorStateMachine(typeof(ResourceManager.<GetAssetObjectAsync>d__73))]
	// RVA: 0x17959AC Offset: 0x17919AC VA: 0x17959AC
	public IEnumerator GetAssetObjectAsync(string assetFile, string name, CacheObjectFlag flag, bool cache, CacheObjectManager.CacheType cacheType, Action<Object> callback) { }

	[IteratorStateMachine(typeof(ResourceManager.<GetAssetObjectAsync>d__74))]
	// RVA: 0x1795AB0 Offset: 0x1791AB0 VA: 0x1795AB0
	public IEnumerator GetAssetObjectAsync(string assetFile, string name, CacheObjectFlag flag, int layer, bool cache, CacheObjectManager.CacheType cacheType, string tag, Action<Object> callback) { }

	// RVA: 0x1795BD8 Offset: 0x1791BD8 VA: 0x1795BD8
	public Object[] GetAssetObjects(string assetFile, string[] names, CacheObjectFlag[] flags, bool cache, CacheObjectManager.CacheType cacheType) { }

	// RVA: 0x1795DCC Offset: 0x1791DCC VA: 0x1795DCC
	public Object[] GetAssetObjects(string assetFile, string[] names, CacheObjectFlag[] flags, int layer, bool cache, CacheObjectManager.CacheType cacheType) { }

	// RVA: 0x1795C70 Offset: 0x1791C70 VA: 0x1795C70
	public Object[] GetAssetObjects(string assetFile, string[] names, CacheObjectFlag[] flags, int layer, bool cache, CacheObjectManager.CacheType cacheType, string tag) { }

	[IteratorStateMachine(typeof(ResourceManager.<GetAssetObjectsAsync>d__78))]
	// RVA: 0x1795E68 Offset: 0x1791E68 VA: 0x1795E68
	public IEnumerator GetAssetObjectsAsync(string assetFile, string[] names, CacheObjectFlag[] flags, int layer, bool cache, CacheObjectManager.CacheType cacheType, Action<Object[]> callback) { }

	[IteratorStateMachine(typeof(ResourceManager.<GetAsyncAssetObjects>d__79))]
	// RVA: 0x1795F88 Offset: 0x1791F88 VA: 0x1795F88
	public IEnumerator GetAsyncAssetObjects(string assetFile, string[] names, CacheObjectFlag[] flags, bool cache, CacheObjectManager.CacheType cacheType, Action<Object[]> result) { }

	[IteratorStateMachine(typeof(ResourceManager.<GetAsyncAssetObjects>d__80))]
	// RVA: 0x1796098 Offset: 0x1792098 VA: 0x1796098
	public IEnumerator GetAsyncAssetObjects(string assetFile, string[] names, CacheObjectFlag[] flags, int layer, bool cache, CacheObjectManager.CacheType cacheType, Action<Object[]> result) { }

	[IteratorStateMachine(typeof(ResourceManager.<GetAsyncAssetObjects>d__81))]
	// RVA: 0x17961B8 Offset: 0x17921B8 VA: 0x17961B8
	public IEnumerator GetAsyncAssetObjects(string assetFile, string[] names, CacheObjectFlag[] flags, int layer, bool cache, CacheObjectManager.CacheType cacheType, string tag, Action<Object[]> result) { }

	[IteratorStateMachine(typeof(ResourceManager.<GetAsyncAssetObjects>d__82))]
	// RVA: 0x17962EC Offset: 0x17922EC VA: 0x17962EC
	public IEnumerator GetAsyncAssetObjects(string assetFile, string[] names, CacheObjectFlag[] flags, bool cache, CacheObjectManager.CacheType cacheType, Action<Object[], int> func, int funcArg) { }

	[IteratorStateMachine(typeof(ResourceManager.<GetAsyncAssetObjects>d__83))]
	// RVA: 0x179640C Offset: 0x179240C VA: 0x179640C
	public IEnumerator GetAsyncAssetObjects(string assetFile, string[] names, CacheObjectFlag[] flags, int layer, bool cache, CacheObjectManager.CacheType cacheType, Action<Object[], int> func, int funcArg) { }

	[IteratorStateMachine(typeof(ResourceManager.<GetAsyncAssetObjects>d__84))]
	// RVA: 0x1796534 Offset: 0x1792534 VA: 0x1796534
	public IEnumerator GetAsyncAssetObjects(string assetFile, string[] names, CacheObjectFlag[] flags, int layer, bool cache, CacheObjectManager.CacheType cacheType, string tag, Action<Object[], int> func, int funcArg) { }

	[IteratorStateMachine(typeof(ResourceManager.<GetEffectModel>d__85))]
	// RVA: 0x1796680 Offset: 0x1792680 VA: 0x1796680
	public IEnumerator GetEffectModel(int modelId, int motionId, CacheObjectFlag flag, bool cache, CacheObjectManager.CacheType type, Action<GameObject> callback) { }

	// RVA: 0x1796748 Offset: 0x1792748 VA: 0x1796748
	public Object[] GetAssetAllObjects(string assetFile) { }

	// RVA: 0x1796764 Offset: 0x1792764 VA: 0x1796764
	public byte[] GetDataBinary(string fileName) { }

	// RVA: 0x17967BC Offset: 0x17927BC VA: 0x17967BC
	public byte[] GetAssetBinary(string assetFile, string name) { }

	// RVA: 0x17968EC Offset: 0x17928EC VA: 0x17968EC
	public byte[] GetAssetBinary(string assetFile, string name, out int key) { }

	// RVA: 0x1796A14 Offset: 0x1792A14 VA: 0x1796A14
	public bool GetAllAssetsBinary(string assetFile, out Object[] assets, out int key) { }

	// RVA: 0x1796A30 Offset: 0x1792A30 VA: 0x1796A30
	public void GetTextureAsset(string url, string cacheFolder, string file, Action<bool, string, Texture2D> callback) { }

	[IteratorStateMachine(typeof(ResourceManager.<GetLoadingTextureAsset>d__92))]
	// RVA: 0x1796B4C Offset: 0x1792B4C VA: 0x1796B4C
	public IEnumerator GetLoadingTextureAsset(string url, string cacheFolder, string file, Action<bool, Texture2D> callback) { }

	// RVA: 0x1796C40 Offset: 0x1792C40 VA: 0x1796C40
	public Dictionary<string, byte[]> GetAssetsBinary(string assetFile, string[] name) { }

	// RVA: 0x1796F18 Offset: 0x1792F18 VA: 0x1796F18
	public Object GetCacheObject(string name) { }

	// RVA: 0x1795574 Offset: 0x1791574 VA: 0x1795574
	public Object GetCacheObject(string name, int layer) { }

	// RVA: 0x1796F20 Offset: 0x1792F20 VA: 0x1796F20
	public Object[] GetCacheObjects(string[] names) { }

	// RVA: 0x1796F28 Offset: 0x1792F28 VA: 0x1796F28
	public Object[] GetCacheObjects(string[] names, int layer) { }

	// RVA: 0x179703C Offset: 0x179303C VA: 0x179703C
	public bool ContainsCache(string name) { }

	// RVA: 0x1797058 Offset: 0x1793058 VA: 0x1797058
	public bool ContainsAsset(string assetFile) { }

	// RVA: 0x1797074 Offset: 0x1793074 VA: 0x1797074
	public ResourceManager.ContainsResourceFlag ContainsAssetOrCache(string assetFile, string name) { }

	// RVA: 0x17970D0 Offset: 0x17930D0 VA: 0x17970D0
	public bool UpdateChangeCacheTag(string name, string baseTag, string tag) { }

	// RVA: 0x17970EC Offset: 0x17930EC VA: 0x17970EC
	public void .ctor() { }
}
