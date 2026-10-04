// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[UsedByNativeCode]
public struct CachedAssetBundle // TypeDefIndex: 16211
{
	// Fields
	private string m_Name; // 0x0
	private Hash128 m_Hash; // 0x8

	// Properties
	public string name { get; }
	public Hash128 hash { get; }

	// Methods

	// RVA: 0x37CDE74 Offset: 0x37C9E74 VA: 0x37CDE74
	public void .ctor(string name, Hash128 hash) { }

	// RVA: 0x37CDEA0 Offset: 0x37C9EA0 VA: 0x37CDEA0
	public string get_name() { }

	// RVA: 0x37CDEA8 Offset: 0x37C9EA8 VA: 0x37CDEA8
	public Hash128 get_hash() { }
}
