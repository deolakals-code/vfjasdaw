// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OrbShopAssetBundleManager : Singleton<OrbShopAssetBundleManager> // TypeDefIndex: 5516
{
	// Fields
	private static readonly string AssetExtension; // 0x0
	private int releaseInterval; // 0x20
	[SerializeField]
	private float releaseTime; // 0x24
	private int releaseCounter; // 0x28
	private Dictionary<string, int> versionTable; // 0x30
	private Dictionary<string, int> downloadTable; // 0x38
	private Dictionary<string, OrbShopAssetBundleManager.AssetObject> bundleTable; // 0x40
	private Dictionary<AssetBundleManager.AssetReleaseType, List<OrbShopAssetBundleManager.AssetObject>> releaseTypeBundleList; // 0x48
	private List<string> dlList; // 0x50
	private string downloadURL; // 0x58
	private string versionFile; // 0x60
	private bool isInit; // 0x68
	[CompilerGenerated]
	private int <DownloadCount>k__BackingField; // 0x6C
	[CompilerGenerated]
	private int <CurrentDownloadNumber>k__BackingField; // 0x70

	// Properties
	public int DownloadCount { get; set; }
	public int CurrentDownloadNumber { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1789428 Offset: 0x1785428 VA: 0x1789428
	public int get_DownloadCount() { }

	[CompilerGenerated]
	// RVA: 0x1789430 Offset: 0x1785430 VA: 0x1789430
	private void set_DownloadCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x1789438 Offset: 0x1785438 VA: 0x1789438
	public int get_CurrentDownloadNumber() { }

	[CompilerGenerated]
	// RVA: 0x1789440 Offset: 0x1785440 VA: 0x1789440
	private void set_CurrentDownloadNumber(int value) { }

	// RVA: 0x1789448 Offset: 0x1785448 VA: 0x1789448
	private void Update() { }

	// RVA: 0x1789A6C Offset: 0x1785A6C VA: 0x1789A6C
	private void OnApplicationQuit() { }

	// RVA: 0x1789C5C Offset: 0x1785C5C VA: 0x1789C5C
	public void Clear() { }

	[IteratorStateMachine(typeof(OrbShopAssetBundleManager.<Initialize>d__25))]
	// RVA: 0x1789CC8 Offset: 0x1785CC8 VA: 0x1789CC8
	public IEnumerator Initialize(string dlUrl, string verFile, Action<bool> result) { }

	[IteratorStateMachine(typeof(OrbShopAssetBundleManager.<ReInitialize>d__26))]
	// RVA: 0x1789DA8 Offset: 0x1785DA8 VA: 0x1789DA8
	public IEnumerator ReInitialize(string dlUrl, string verFile, Action<bool> result) { }

	// RVA: 0x1789E88 Offset: 0x1785E88 VA: 0x1789E88
	private bool createVersionTable(string text, Dictionary<string, int> table) { }

	// RVA: 0x178A188 Offset: 0x1786188 VA: 0x178A188
	private string getFileNameWithoutExtension(string name) { }

	// RVA: 0x178A244 Offset: 0x1786244 VA: 0x178A244
	private void createType(AssetBundleManager.AssetReleaseType type) { }

	// RVA: 0x178A318 Offset: 0x1786318 VA: 0x178A318
	public bool Contains(string assetFile) { }

	// RVA: 0x178A370 Offset: 0x1786370 VA: 0x178A370
	public int GetVersion(string assetFile) { }

	// RVA: 0x178A454 Offset: 0x1786454 VA: 0x178A454
	public int GetFlagVersion(string assetFile) { }

	[IteratorStateMachine(typeof(OrbShopAssetBundleManager.<LoadCacheAssetBundle>d__33))]
	// RVA: 0x178A4E8 Offset: 0x17864E8 VA: 0x178A4E8
	public IEnumerator LoadCacheAssetBundle(string assetFile, AssetBundleManager.AssetReleaseType type, Action<bool> result) { }

	[IteratorStateMachine(typeof(OrbShopAssetBundleManager.<LoadCacheAssetBundle>d__34))]
	// RVA: 0x178A5BC Offset: 0x17865BC VA: 0x178A5BC
	public IEnumerator LoadCacheAssetBundle(string assetFile, AssetBundleManager.AssetReleaseType type, string tag, Action<bool> result) { }

	[IteratorStateMachine(typeof(OrbShopAssetBundleManager.<LoadCacheAssetBundle>d__35))]
	// RVA: 0x178A6A4 Offset: 0x17866A4 VA: 0x178A6A4
	public IEnumerator LoadCacheAssetBundle(string url, string assetFile, AssetBundleManager.AssetReleaseType type, Action<bool> result) { }

	[IteratorStateMachine(typeof(OrbShopAssetBundleManager.<LoadCacheAssetBundle>d__36))]
	// RVA: 0x178A78C Offset: 0x178678C VA: 0x178A78C
	public IEnumerator LoadCacheAssetBundle(string url, string assetFile, AssetBundleManager.AssetReleaseType type, string tag, Action<bool> result) { }

	// RVA: 0x178A890 Offset: 0x1786890 VA: 0x178A890
	public void AddAssetBundle(string assetFile, AssetBundleManager.AssetReleaseType type, AssetBundle bundle) { }

	// RVA: 0x178AB78 Offset: 0x1786B78 VA: 0x178AB78
	public void AddAssetBundle(string assetFile, AssetBundleManager.AssetReleaseType type, AssetBundle bundle, string tag) { }

	// RVA: 0x178AE1C Offset: 0x1786E1C VA: 0x178AE1C
	public void RemoveAssetBundle(string assetFile, bool loadObjectRelease) { }

	// RVA: 0x1789A74 Offset: 0x1785A74 VA: 0x1789A74
	public void RemoveAllAssetBundle(bool loadObjectRelease) { }

	// RVA: 0x178AFA0 Offset: 0x1786FA0 VA: 0x178AFA0
	public Object GetAssetBundleObject(string assetFile, string name) { }

	// RVA: 0x178B0C8 Offset: 0x17870C8 VA: 0x178B0C8
	public Object[] GetAssetBundleObject(string assetFile, string[] names) { }

	// RVA: 0x178B2A0 Offset: 0x17872A0 VA: 0x178B2A0
	public Object GetMainAssetObject(string assetFile) { }

	// RVA: 0x178B398 Offset: 0x1787398 VA: 0x178B398
	public bool GetAsset(string assetFile, string name, out Object asset, out int version) { }

	// RVA: 0x178B4F0 Offset: 0x17874F0 VA: 0x178B4F0
	public bool GetMainAsset(string assetFile, out Object asset, out int version) { }

	// RVA: 0x178944C Offset: 0x178544C VA: 0x178944C
	private void checkFewSecondsRelease() { }

	// RVA: 0x178B670 Offset: 0x1787670 VA: 0x178B670
	public void .ctor() { }

	// RVA: 0x178B874 Offset: 0x1787874 VA: 0x178B874
	private static void .cctor() { }
}
