// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class PetAttackPatternData // TypeDefIndex: 1056
{
	// Fields
	private List<PetAttackPatternData.PatternData> patternList; // 0x10
	[CompilerGenerated]
	private int <Uuid>k__BackingField; // 0x18
	[CompilerGenerated]
	private int <ModelId>k__BackingField; // 0x1C

	// Properties
	public int Uuid { get; set; }
	public int ModelId { get; set; }
	public IEnumerable<PetAttackPatternData.PatternData> Pattern { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1F3F470 Offset: 0x1F3B470 VA: 0x1F3F470
	public int get_Uuid() { }

	[CompilerGenerated]
	// RVA: 0x1F3F478 Offset: 0x1F3B478 VA: 0x1F3F478
	public void set_Uuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x1F3F480 Offset: 0x1F3B480 VA: 0x1F3F480
	public int get_ModelId() { }

	[CompilerGenerated]
	// RVA: 0x1F3F488 Offset: 0x1F3B488 VA: 0x1F3F488
	public void set_ModelId(int value) { }

	// RVA: 0x1F3F490 Offset: 0x1F3B490 VA: 0x1F3F490
	public IEnumerable<PetAttackPatternData.PatternData> get_Pattern() { }

	// RVA: 0x1F3F498 Offset: 0x1F3B498 VA: 0x1F3F498
	public void .ctor(int uuid, int modelId, BinaryReader binary) { }

	// RVA: 0x1F3F6B4 Offset: 0x1F3B6B4 VA: 0x1F3F6B4
	private bool ReadStream(MemoryStream ms) { }

	// RVA: 0x1F3F544 Offset: 0x1F3B544 VA: 0x1F3F544
	private bool ReadBinary(BinaryReader br) { }
}
