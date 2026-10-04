// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PetMobCacheStrategy : IMobModelCacheStrategy // TypeDefIndex: 1040
{
	// Fields
	private List<PetMobCacheStrategy.CacheTimeStamp> CacheObjectName; // 0x10
	private readonly int MaxCacheSize; // 0x18
	[CompilerGenerated]
	private string <AcceptTag>k__BackingField; // 0x20

	// Properties
	public string AcceptTag { get; set; }
	public IList<string> ObjectNames { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1F38204 Offset: 0x1F34204 VA: 0x1F38204 Slot: 4
	public string get_AcceptTag() { }

	[CompilerGenerated]
	// RVA: 0x1F3820C Offset: 0x1F3420C VA: 0x1F3820C
	private void set_AcceptTag(string value) { }

	// RVA: 0x1F38214 Offset: 0x1F34214 VA: 0x1F38214 Slot: 5
	public IList<string> get_ObjectNames() { }

	// RVA: 0x1F38334 Offset: 0x1F34334 VA: 0x1F38334
	public void .ctor(string acceptTag) { }

	// RVA: 0x1F383D8 Offset: 0x1F343D8 VA: 0x1F383D8 Slot: 6
	public IList<string> AddCache(string name) { }

	// RVA: 0x1F38960 Offset: 0x1F34960 VA: 0x1F38960 Slot: 7
	public void RemoveCache(string name) { }

	// RVA: 0x1F387D4 Offset: 0x1F347D4 VA: 0x1F387D4 Slot: 8
	public bool Contains(string name) { }

	// RVA: 0x1F38A88 Offset: 0x1F34A88 VA: 0x1F38A88 Slot: 9
	public void Clear() { }
}
