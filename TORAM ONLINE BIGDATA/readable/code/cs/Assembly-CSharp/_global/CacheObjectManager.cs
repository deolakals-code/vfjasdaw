// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CacheObjectManager : Singleton<CacheObjectManager> // TypeDefIndex: 5464
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
	private Dictionary<string, CacheObjectManager.CacheObject> cacheObject; // 0x48
	private Dictionary<CacheObjectManager.CacheType, List<CacheObjectManager.CacheObject>> releaseTypeCacheList; // 0x50

	// Properties
	public int CacheLayer { get; set; }

	// Methods

	// RVA: 0x17711DC Offset: 0x176D1DC VA: 0x17711DC
	public int get_CacheLayer() { }

	// RVA: 0x17711E4 Offset: 0x176D1E4 VA: 0x17711E4
	public void set_CacheLayer(int value) { }

	// RVA: 0x17711EC Offset: 0x176D1EC VA: 0x17711EC
	private void Update() { }

	[IteratorStateMachine(typeof(CacheObjectManager.<checkMemory>d__17))]
	// RVA: 0x177175C Offset: 0x176D75C VA: 0x177175C
	private IEnumerator checkMemory() { }

	// RVA: 0x17717F0 Offset: 0x176D7F0 VA: 0x17717F0
	private bool removePriorityCache(CacheObjectManager.CacheType type) { }

	// RVA: 0x1771CCC Offset: 0x176DCCC VA: 0x1771CCC
	private void OnApplicationQuit() { }

	// RVA: 0x1771E7C Offset: 0x176DE7C VA: 0x1771E7C
	private void createType(CacheObjectManager.CacheType type) { }

	// RVA: 0x1771F50 Offset: 0x176DF50 VA: 0x1771F50
	public bool Contains(string name) { }

	// RVA: 0x1771FA8 Offset: 0x176DFA8 VA: 0x1771FA8
	public bool UpdateCacheTag(string name, string baseTag, string tag) { }

	// RVA: 0x17720B0 Offset: 0x176E0B0 VA: 0x17720B0
	public void AddCacheObject(string name, Object obj, CacheObjectFlag flag, CacheObjectManager.CacheType type) { }

	// RVA: 0x17726C0 Offset: 0x176E6C0 VA: 0x17726C0
	public void AddCacheObject(string name, Object obj, CacheObjectFlag flag, CacheObjectManager.CacheType type, string tag) { }

	// RVA: 0x1772304 Offset: 0x176E304 VA: 0x1772304
	private void setLayer(GameObject obj, int layer) { }

	// RVA: 0x17729B4 Offset: 0x176E9B4 VA: 0x17729B4
	public Object GetChashObject(string name) { }

	// RVA: 0x1772B2C Offset: 0x176EB2C VA: 0x1772B2C
	public Object[] GetCacheObjectFromTag(string tag) { }

	// RVA: 0x1771BB0 Offset: 0x176DBB0 VA: 0x1771BB0
	private void releaseObject(CacheObjectManager.CacheObject cache) { }

	// RVA: 0x1772DA8 Offset: 0x176EDA8 VA: 0x1772DA8
	public void RemoveCache(string name) { }

	// RVA: 0x1772EFC Offset: 0x176EEFC VA: 0x1772EFC
	public void RemoveCacheType(CacheObjectManager.CacheType type) { }

	// RVA: 0x1773138 Offset: 0x176F138 VA: 0x1773138
	public void RemoveCacheTag(string tag) { }

	// RVA: 0x1771CD0 Offset: 0x176DCD0 VA: 0x1771CD0
	public void ClearCache() { }

	// RVA: 0x17711F0 Offset: 0x176D1F0 VA: 0x17711F0
	private void checkFewSecondsRelease() { }

	// RVA: 0x1773544 Offset: 0x176F544 VA: 0x1773544
	public void .ctor() { }
}
