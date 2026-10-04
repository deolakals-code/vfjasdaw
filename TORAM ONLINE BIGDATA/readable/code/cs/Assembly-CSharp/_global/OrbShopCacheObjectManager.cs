// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OrbShopCacheObjectManager : Singleton<OrbShopCacheObjectManager> // TypeDefIndex: 5519
{
	// Fields
	private int releaseInterval; // 0x20
	[SerializeField]
	private float releaseTime; // 0x24
	private int releaseCounter; // 0x28
	private int memoryCheckInterval; // 0x2C
	private int memoryCheckCounter; // 0x30
	[SerializeField]
	private int memoryLowThreshold; // 0x34
	[SerializeField]
	private int memoryMediumThreshold; // 0x38
	[SerializeField]
	private int memoryHighThreshold; // 0x3C
	[SerializeField]
	private int cacheLayer; // 0x40
	private Dictionary<string, OrbShopCacheObjectManager.CacheObject> cacheObject; // 0x48
	private Dictionary<CacheObjectManager.CacheType, List<OrbShopCacheObjectManager.CacheObject>> releaseTypeCacheList; // 0x50

	// Properties
	public int CacheLayer { get; set; }

	// Methods

	// RVA: 0x178D54C Offset: 0x178954C VA: 0x178D54C
	public int get_CacheLayer() { }

	// RVA: 0x178D554 Offset: 0x1789554 VA: 0x178D554
	public void set_CacheLayer(int value) { }

	// RVA: 0x178D55C Offset: 0x178955C VA: 0x178D55C
	private void Awake() { }

	// RVA: 0x178D5E8 Offset: 0x17895E8 VA: 0x178D5E8
	private void Update() { }

	[IteratorStateMachine(typeof(OrbShopCacheObjectManager.<checkMemory>d__17))]
	// RVA: 0x178D57C Offset: 0x178957C VA: 0x178D57C
	private IEnumerator checkMemory() { }

	// RVA: 0x178DB80 Offset: 0x1789B80 VA: 0x178DB80
	private bool removePriorityCache(CacheObjectManager.CacheType type) { }

	// RVA: 0x178E00C Offset: 0x178A00C VA: 0x178E00C
	private void OnApplicationQuit() { }

	// RVA: 0x178E1BC Offset: 0x178A1BC VA: 0x178E1BC
	private void createType(CacheObjectManager.CacheType type) { }

	// RVA: 0x178E290 Offset: 0x178A290 VA: 0x178E290
	public bool Contains(string name) { }

	// RVA: 0x178E2E8 Offset: 0x178A2E8 VA: 0x178E2E8
	public void AddCacheObject(string name, Object obj, CacheObjectFlag flag, CacheObjectManager.CacheType type) { }

	// RVA: 0x178E8F8 Offset: 0x178A8F8 VA: 0x178E8F8
	public void AddCacheObject(string name, Object obj, CacheObjectFlag flag, CacheObjectManager.CacheType type, string tag) { }

	// RVA: 0x178E53C Offset: 0x178A53C VA: 0x178E53C
	private void setLayer(GameObject obj, int layer) { }

	// RVA: 0x178EBEC Offset: 0x178ABEC VA: 0x178EBEC
	public Object GetChashObject(string name) { }

	// RVA: 0x178DF40 Offset: 0x1789F40 VA: 0x178DF40
	private void releaseObject(OrbShopCacheObjectManager.CacheObject cache) { }

	// RVA: 0x178ED70 Offset: 0x178AD70 VA: 0x178ED70
	public void RemoveCache(string name) { }

	// RVA: 0x178EEC4 Offset: 0x178AEC4 VA: 0x178EEC4
	public void RemoveCacheType(CacheObjectManager.CacheType type) { }

	// RVA: 0x178F100 Offset: 0x178B100 VA: 0x178F100
	public void RemoveCacheTag(string tag) { }

	// RVA: 0x178E010 Offset: 0x178A010 VA: 0x178E010
	public void ClearCache() { }

	// RVA: 0x178D5EC Offset: 0x17895EC VA: 0x178D5EC
	private void checkFewSecondsRelease() { }

	// RVA: 0x178F50C Offset: 0x178B50C VA: 0x178F50C
	public void .ctor() { }
}
