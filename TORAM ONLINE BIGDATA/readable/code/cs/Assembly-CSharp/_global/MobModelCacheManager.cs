// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobModelCacheManager // TypeDefIndex: 1045
{
	// Fields
	private readonly string actualTagName; // 0x10
	private readonly ResourceManager resourceManager; // 0x18
	private List<IMobModelCacheStrategy> strategyList; // 0x20

	// Methods

	// RVA: 0x1F38C2C Offset: 0x1F34C2C VA: 0x1F38C2C
	public void .ctor(ResourceManager resourceManager) { }

	// RVA: 0x1F38E98 Offset: 0x1F34E98 VA: 0x1F38E98
	public void .ctor(string actualTagName, ResourceManager resourceManager) { }

	// RVA: 0x1F38F80 Offset: 0x1F34F80 VA: 0x1F38F80
	public void AddCache(Object obj, string name, CacheObjectFlag flag, CacheObjectManager.CacheType type, string tag) { }

	// RVA: 0x1F39690 Offset: 0x1F35690 VA: 0x1F39690
	public void AddCache(string name, string tag) { }

	// RVA: 0x1F39848 Offset: 0x1F35848 VA: 0x1F39848
	public void RemoveCache(string name) { }

	// RVA: 0x1F39A10 Offset: 0x1F35A10 VA: 0x1F39A10
	public void RemoveCacheTag(string tag) { }

	// RVA: 0x1F39CCC Offset: 0x1F35CCC VA: 0x1F39CCC
	public void RemoveCacheTag(string name, string tag) { }

	// RVA: 0x1F39E78 Offset: 0x1F35E78 VA: 0x1F39E78
	public void Clear() { }

	// RVA: 0x1F39E9C Offset: 0x1F35E9C VA: 0x1F39E9C
	public bool CheckCache(string name) { }

	// RVA: 0x1F38CFC Offset: 0x1F34CFC VA: 0x1F38CFC
	private void InitStrategyList() { }

	// RVA: 0x1F391D4 Offset: 0x1F351D4 VA: 0x1F391D4
	private bool Containts(string name) { }

	// RVA: 0x1F393B4 Offset: 0x1F353B4 VA: 0x1F393B4
	private void removeCache(IList<string> names, string tag) { }
}
