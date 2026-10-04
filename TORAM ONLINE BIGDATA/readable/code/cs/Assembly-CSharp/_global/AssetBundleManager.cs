// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AssetBundleManager : Singleton<AssetBundleManager> // TypeDefIndex: 5459
{
	// Fields
	private static readonly string AssetExtension; // 0x0
	private int releaseInterval; // 0x20
	[SerializeField]
	private float releaseTime; // 0x24
	private int releaseCounter; // 0x28
	private Dictionary<string, AssetBundleManager.VersionData> versionTable; // 0x30
	private Dictionary<string, int> downloadTable; // 0x38
	private Dictionary<string, AssetBundleManager.AssetObject> bundleTable; // 0x40
	private Dictionary<AssetBundleManager.AssetReleaseType, List<AssetBundleManager.AssetObject>> releaseTypeBundleList; // 0x48
	private List<string> dlList; // 0x50
	private string downloadURL; // 0x58
	private string versionFile; // 0x60
	private bool isInit; // 0x68
	[CompilerGenerated]
	private bool <IsLowMemory>k__BackingField; // 0x69
	[CompilerGenerated]
	private bool <IsWarningMemory>k__BackingField; // 0x6A
	private PlayerDataManager pdManager; // 0x70
	[CompilerGenerated]
	private int <DownloadCount>k__BackingField; // 0x78
	[CompilerGenerated]
	private int <CurrentDownloadNumber>k__BackingField; // 0x7C
	[CompilerGenerated]
	private AssetBundleManager.AssetBundleDecryptHandler OnLoadAssetBundle; // 0x80

	// Properties
	public bool IsLowMemory { get; set; }
	public bool IsWarningMemory { get; set; }
	private PlayerDataManager playerDataManager { get; }
	public int DownloadCount { get; set; }
	public int CurrentDownloadNumber { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x176784C Offset: 0x176384C VA: 0x176784C
	public bool get_IsLowMemory() { }

	[CompilerGenerated]
	// RVA: 0x1767854 Offset: 0x1763854 VA: 0x1767854
	private void set_IsLowMemory(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1767860 Offset: 0x1763860 VA: 0x1767860
	public bool get_IsWarningMemory() { }

	[CompilerGenerated]
	// RVA: 0x1767868 Offset: 0x1763868 VA: 0x1767868
	private void set_IsWarningMemory(bool value) { }

	// RVA: 0x1767874 Offset: 0x1763874 VA: 0x1767874
	private PlayerDataManager get_playerDataManager() { }

	[CompilerGenerated]
	// RVA: 0x17678F8 Offset: 0x17638F8 VA: 0x17678F8
	public int get_DownloadCount() { }

	[CompilerGenerated]
	// RVA: 0x1767900 Offset: 0x1763900 VA: 0x1767900
	private void set_DownloadCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x1767908 Offset: 0x1763908 VA: 0x1767908
	public int get_CurrentDownloadNumber() { }

	[CompilerGenerated]
	// RVA: 0x1767910 Offset: 0x1763910 VA: 0x1767910
	private void set_CurrentDownloadNumber(int value) { }

	[CompilerGenerated]
	// RVA: 0x1767918 Offset: 0x1763918 VA: 0x1767918
	public void add_OnLoadAssetBundle(AssetBundleManager.AssetBundleDecryptHandler value) { }

	[CompilerGenerated]
	// RVA: 0x17679B4 Offset: 0x17639B4 VA: 0x17679B4
	public void remove_OnLoadAssetBundle(AssetBundleManager.AssetBundleDecryptHandler value) { }

	// RVA: 0x1767A50 Offset: 0x1763A50 VA: 0x1767A50
	private void Start() { }

	// RVA: 0x1767AA4 Offset: 0x1763AA4 VA: 0x1767AA4
	private void Update() { }

	// RVA: 0x17688A8 Offset: 0x17648A8 VA: 0x17688A8
	private void OnApplicationQuit() { }

	// RVA: 0x1768A98 Offset: 0x1764A98 VA: 0x1768A98
	public void Clear() { }

	[IteratorStateMachine(typeof(AssetBundleManager.<Initialize>d__43))]
	// RVA: 0x1768B18 Offset: 0x1764B18 VA: 0x1768B18
	public IEnumerator Initialize(string dlUrl, string verFile, Action<bool> result) { }

	[IteratorStateMachine(typeof(AssetBundleManager.<AddEx>d__44))]
	// RVA: 0x1768BF8 Offset: 0x1764BF8 VA: 0x1768BF8
	public IEnumerator AddEx(string dlUrl, string verFile, Action<bool> result) { }

	[IteratorStateMachine(typeof(AssetBundleManager.<ReInitialize>d__45))]
	// RVA: 0x1768CD8 Offset: 0x1764CD8 VA: 0x1768CD8
	public IEnumerator ReInitialize(string dlUrl, string verFile, Action<bool> result) { }

	// RVA: 0x1768DB8 Offset: 0x1764DB8 VA: 0x1768DB8
	private bool createVersionTable(string text, Dictionary<string, AssetBundleManager.VersionData> table) { }

	// RVA: 0x17691B0 Offset: 0x17651B0 VA: 0x17691B0
	private bool createVersionTable(byte[] binary, Dictionary<string, AssetBundleManager.VersionData> table) { }

	// RVA: 0x1769804 Offset: 0x1765804 VA: 0x1769804
	public void CreateAllDownloadList() { }

	// RVA: 0x1769B24 Offset: 0x1765B24 VA: 0x1769B24
	public void CreateDownloadList(List<string> assetFiles) { }

	[IteratorStateMachine(typeof(AssetBundleManager.<UpdateResources>d__50))]
	// RVA: 0x1769EF0 Offset: 0x1765EF0 VA: 0x1769EF0
	public IEnumerator UpdateResources(Action<bool> result) { }

	[IteratorStateMachine(typeof(AssetBundleManager.<downloadOneAndReport>d__51))]
	// RVA: 0x1769FA0 Offset: 0x1765FA0 VA: 0x1769FA0
	private IEnumerator downloadOneAndReport(string fileKey, Action<bool> onDone) { }

	// RVA: 0x1769A68 Offset: 0x1765A68 VA: 0x1769A68
	private string getFileNameWithoutExtension(string name) { }

	// RVA: 0x176A064 Offset: 0x1766064 VA: 0x176A064
	private void createType(AssetBundleManager.AssetReleaseType type) { }

	// RVA: 0x176A138 Offset: 0x1766138 VA: 0x176A138
	public bool Contains(string assetFile) { }

	// RVA: 0x1769E0C Offset: 0x1765E0C VA: 0x1769E0C
	public int GetVersion(string assetFile) { }

	// RVA: 0x176A190 Offset: 0x1766190 VA: 0x176A190
	public float GetDownLoadAssetBundlesSize(string[] files) { }

	// RVA: 0x176A384 Offset: 0x1766384 VA: 0x176A384
	public float GetDownLoadAssetBundlesSize(List<string> files) { }

	// RVA: 0x176A218 Offset: 0x1766218 VA: 0x176A218
	private float GetDownLoadAssetBundleSize(string file) { }

	[IteratorStateMachine(typeof(AssetBundleManager.<LoadInitCacheAssetBundle>d__59))]
	// RVA: 0x176A4D4 Offset: 0x17664D4 VA: 0x176A4D4
	public IEnumerator LoadInitCacheAssetBundle(string assetFile, Action<bool> result) { }

	[IteratorStateMachine(typeof(AssetBundleManager.<LoadInitCacheAssetBundle>d__60))]
	// RVA: 0x176A598 Offset: 0x1766598 VA: 0x176A598
	public IEnumerator LoadInitCacheAssetBundle(string url, string assetFile, Action<bool> result) { }

	[IteratorStateMachine(typeof(AssetBundleManager.<LoadCacheAssetBundle>d__61))]
	// RVA: 0x176A678 Offset: 0x1766678 VA: 0x176A678
	public IEnumerator LoadCacheAssetBundle(string assetFile, AssetBundleManager.AssetReleaseType type, Action<bool> result) { }

	[IteratorStateMachine(typeof(AssetBundleManager.<LoadCacheAssetBundle>d__62))]
	// RVA: 0x176A74C Offset: 0x176674C VA: 0x176A74C
	public IEnumerator LoadCacheAssetBundle(string assetFile, AssetBundleManager.AssetReleaseType type, string tag, Action<bool> result) { }

	[IteratorStateMachine(typeof(AssetBundleManager.<LoadCacheAssetBundle>d__63))]
	// RVA: 0x176A834 Offset: 0x1766834 VA: 0x176A834
	public IEnumerator LoadCacheAssetBundle(string url, string assetFile, AssetBundleManager.AssetReleaseType type, Action<bool> result) { }

	[IteratorStateMachine(typeof(AssetBundleManager.<LoadCacheAssetBundle>d__64))]
	// RVA: 0x176A91C Offset: 0x176691C VA: 0x176A91C
	public IEnumerator LoadCacheAssetBundle(string url, string assetFile, AssetBundleManager.AssetReleaseType type, string tag, Action<bool> result) { }

	[IteratorStateMachine(typeof(AssetBundleManager.<AddAssetBundleBuffer>d__65))]
	// RVA: 0x176AA20 Offset: 0x1766A20 VA: 0x176AA20
	public IEnumerator AddAssetBundleBuffer(string assetFile, AssetBundleManager.AssetReleaseType type, byte[] buf) { }

	[IteratorStateMachine(typeof(AssetBundleManager.<AddAssetBundleBuffer>d__66))]
	// RVA: 0x176AAF4 Offset: 0x1766AF4 VA: 0x176AAF4
	public IEnumerator AddAssetBundleBuffer(string assetFile, AssetBundleManager.AssetReleaseType type, byte[] buf, string tag) { }

	// RVA: 0x176ABDC Offset: 0x1766BDC VA: 0x176ABDC
	public void AddAssetBundle(string assetFile, AssetBundleManager.AssetReleaseType type, AssetBundle bundle) { }

	// RVA: 0x176AF00 Offset: 0x1766F00 VA: 0x176AF00
	public void AddAssetBundle(string assetFile, AssetBundleManager.AssetReleaseType type, AssetBundle bundle, string tag) { }

	// RVA: 0x176B1A4 Offset: 0x17671A4 VA: 0x176B1A4
	public void RemoveAssetBundle(string assetFile, bool loadObjectRelease) { }

	// RVA: 0x176B350 Offset: 0x1767350 VA: 0x176B350
	public void RemoveAssetBundleTag(string tag, bool loadObjectRelease) { }

	// RVA: 0x17688B0 Offset: 0x17648B0 VA: 0x17688B0
	public void RemoveAllAssetBundle(bool loadObjectRelease) { }

	// RVA: 0x176B7B8 Offset: 0x17677B8 VA: 0x176B7B8
	public List<string> GetAssetNamesContains(string name) { }

	// RVA: 0x176B974 Offset: 0x1767974 VA: 0x176B974
	public List<string> GetAssetNamesContains(string name, bool ignoreCase) { }

	// RVA: 0x176BBD4 Offset: 0x1767BD4 VA: 0x176BBD4
	public bool GetAsset(string assetFile, string name, out Object asset, out int version) { }

	// RVA: 0x176BE5C Offset: 0x1767E5C VA: 0x176BE5C
	public bool GetAssets(string assetFile, string[] name, Dictionary<string, TextAsset> retObj, out int version) { }

	// RVA: 0x176C07C Offset: 0x176807C VA: 0x176C07C
	public bool GetAllAssets(string assetFile, out Object[] rets, out int version) { }

	// RVA: 0x176BD34 Offset: 0x1767D34 VA: 0x176BD34
	public Object GetAssetBundleObject(string assetFile, string name) { }

	[IteratorStateMachine(typeof(AssetBundleManager.<GetAssetBundleObjectAsync>d__78))]
	// RVA: 0x176C22C Offset: 0x176822C VA: 0x176C22C
	public IEnumerator GetAssetBundleObjectAsync(string assetFile, string name, Action<Object> callback) { }

	// RVA: 0x176C30C Offset: 0x176830C VA: 0x176C30C
	public Object[] GetAssetBundleObject(string assetFile, string[] names) { }

	// RVA: 0x176C4E4 Offset: 0x17684E4 VA: 0x176C4E4
	public Object[] GetAssetBundleAllObject(string assetFile) { }

	// RVA: 0x176C5DC Offset: 0x17685DC VA: 0x176C5DC
	public Object GetMainAssetObject(string assetFile) { }

	// RVA: 0x176C72C Offset: 0x176872C VA: 0x176C72C
	public bool CheckHaveAssetObject(string assetFile) { }

	[IteratorStateMachine(typeof(AssetBundleManager.<GetAsyncAssetBundleObject>d__83))]
	// RVA: 0x176C734 Offset: 0x1768734 VA: 0x176C734
	public IEnumerator GetAsyncAssetBundleObject(string assetFile, string name, Action<Object> result) { }

	[IteratorStateMachine(typeof(AssetBundleManager.<GetAsyncAssetBundleObject>d__84))]
	// RVA: 0x176C814 Offset: 0x1768814 VA: 0x176C814
	public IEnumerator GetAsyncAssetBundleObject(string assetFile, string[] names, Action<Object[]> result) { }

	[IteratorStateMachine(typeof(AssetBundleManager.<GetAsyncAssetBundleObject>d__85<T>))]
	// RVA: -1 Offset: -1
	public IEnumerator GetAsyncAssetBundleObject<T>(string assetFile, string name, Action<T> result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27D6F20 Offset: 0x27D2F20 VA: 0x27D6F20
	|-AssetBundleManager.GetAsyncAssetBundleObject<object>
	*/

	// RVA: 0x1767ACC Offset: 0x1763ACC VA: 0x1767ACC
	private void checkFewSecondsRelease() { }

	// RVA: 0x1768178 Offset: 0x1764178 VA: 0x1768178
	private void checkFewSecondsReleaseImmediate() { }

	// RVA: 0x176C8F4 Offset: 0x17688F4 VA: 0x176C8F4
	private void checkUnloadUnuseAsset() { }

	// RVA: 0x176CB3C Offset: 0x1768B3C VA: 0x176CB3C
	public void .ctor() { }

	// RVA: 0x176CD68 Offset: 0x1768D68 VA: 0x176CD68
	private static void .cctor() { }
}
