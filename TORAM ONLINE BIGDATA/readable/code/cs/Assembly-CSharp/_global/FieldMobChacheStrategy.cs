// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FieldMobChacheStrategy : IMobModelCacheStrategy // TypeDefIndex: 1033
{
	// Fields
	private List<string> CacheObjectName; // 0x10
	[CompilerGenerated]
	private string <AcceptTag>k__BackingField; // 0x18

	// Properties
	public string AcceptTag { get; set; }
	public IList<string> ObjectNames { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1F37F28 Offset: 0x1F33F28 VA: 0x1F37F28 Slot: 4
	public string get_AcceptTag() { }

	[CompilerGenerated]
	// RVA: 0x1F37F30 Offset: 0x1F33F30 VA: 0x1F37F30
	private void set_AcceptTag(string value) { }

	// RVA: 0x1F37F38 Offset: 0x1F33F38 VA: 0x1F37F38 Slot: 5
	public IList<string> get_ObjectNames() { }

	// RVA: 0x1F37F88 Offset: 0x1F33F88 VA: 0x1F37F88
	public void .ctor(string acceptTag) { }

	// RVA: 0x1F38024 Offset: 0x1F34024 VA: 0x1F38024 Slot: 6
	public IList<string> AddCache(string name) { }

	// RVA: 0x1F3813C Offset: 0x1F3413C VA: 0x1F3813C Slot: 7
	public void RemoveCache(string name) { }

	// RVA: 0x1F380E4 Offset: 0x1F340E4 VA: 0x1F380E4 Slot: 8
	public bool Contains(string name) { }

	// RVA: 0x1F38194 Offset: 0x1F34194 VA: 0x1F38194 Slot: 9
	public void Clear() { }
}
