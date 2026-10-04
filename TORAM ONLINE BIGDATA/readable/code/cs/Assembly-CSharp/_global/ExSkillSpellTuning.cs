// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ExSkillSpellTuning : ExSkillDataBase // TypeDefIndex: 1824
{
	// Fields
	[CompilerGenerated]
	[TupleElementNames(new[] { "a", "b" })]
	private ValueTuple<bool, bool> <MagicArrow>k__BackingField; // 0x10
	[CompilerGenerated]
	[TupleElementNames(new[] { "a", "b" })]
	private ValueTuple<bool, bool> <MagicJabelin>k__BackingField; // 0x12
	[CompilerGenerated]
	[TupleElementNames(new[] { "a", "b" })]
	private ValueTuple<bool, bool> <MagicWall>k__BackingField; // 0x14
	[CompilerGenerated]
	[TupleElementNames(new[] { "a", "b" })]
	private ValueTuple<bool, bool> <MagicLancer>k__BackingField; // 0x16
	[TupleElementNames(new[] { "a", "b" })]
	[CompilerGenerated]
	private ValueTuple<bool, bool> <MagicBlast>k__BackingField; // 0x18
	[TupleElementNames(new[] { "a", "b" })]
	[CompilerGenerated]
	private ValueTuple<bool, bool> <MagicImpact>k__BackingField; // 0x1A
	[TupleElementNames(new[] { "a", "b" })]
	[CompilerGenerated]
	private ValueTuple<bool, bool> <MagicStorm>k__BackingField; // 0x1C
	[TupleElementNames(new[] { "a", "b" })]
	[CompilerGenerated]
	private ValueTuple<bool, bool> <MagicEgel>k__BackingField; // 0x1E
	[CompilerGenerated]
	private int <TotalPoint>k__BackingField; // 0x20
	private PlayerDataManager playerDataManager; // 0x28

	// Properties
	public override SkillId SkillId { get; }
	[TupleElementNames(new[] { "a", "b" })]
	public ValueTuple<bool, bool> MagicArrow { get; set; }
	[TupleElementNames(new[] { "a", "b" })]
	public ValueTuple<bool, bool> MagicJabelin { get; set; }
	[TupleElementNames(new[] { "a", "b" })]
	public ValueTuple<bool, bool> MagicWall { get; set; }
	[TupleElementNames(new[] { "a", "b" })]
	public ValueTuple<bool, bool> MagicLancer { get; set; }
	[TupleElementNames(new[] { "a", "b" })]
	public ValueTuple<bool, bool> MagicBlast { get; set; }
	[TupleElementNames(new[] { "a", "b" })]
	public ValueTuple<bool, bool> MagicImpact { get; set; }
	[TupleElementNames(new[] { "a", "b" })]
	public ValueTuple<bool, bool> MagicStorm { get; set; }
	[TupleElementNames(new[] { "a", "b" })]
	public ValueTuple<bool, bool> MagicEgel { get; set; }
	public int TotalPoint { get; set; }
	private int MaxPoint { get; }
	private bool IsEnable { get; }

	// Methods

	// RVA: 0x20E6AF4 Offset: 0x20E2AF4 VA: 0x20E6AF4 Slot: 4
	public override SkillId get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x20E6AFC Offset: 0x20E2AFC VA: 0x20E6AFC
	public ValueTuple<bool, bool> get_MagicArrow() { }

	[CompilerGenerated]
	// RVA: 0x20E6B04 Offset: 0x20E2B04 VA: 0x20E6B04
	private void set_MagicArrow(ValueTuple<bool, bool> value) { }

	[CompilerGenerated]
	// RVA: 0x20E6B0C Offset: 0x20E2B0C VA: 0x20E6B0C
	public ValueTuple<bool, bool> get_MagicJabelin() { }

	[CompilerGenerated]
	// RVA: 0x20E6B14 Offset: 0x20E2B14 VA: 0x20E6B14
	private void set_MagicJabelin(ValueTuple<bool, bool> value) { }

	[CompilerGenerated]
	// RVA: 0x20E6B1C Offset: 0x20E2B1C VA: 0x20E6B1C
	public ValueTuple<bool, bool> get_MagicWall() { }

	[CompilerGenerated]
	// RVA: 0x20E6B24 Offset: 0x20E2B24 VA: 0x20E6B24
	private void set_MagicWall(ValueTuple<bool, bool> value) { }

	[CompilerGenerated]
	// RVA: 0x20E6B2C Offset: 0x20E2B2C VA: 0x20E6B2C
	public ValueTuple<bool, bool> get_MagicLancer() { }

	[CompilerGenerated]
	// RVA: 0x20E6B34 Offset: 0x20E2B34 VA: 0x20E6B34
	private void set_MagicLancer(ValueTuple<bool, bool> value) { }

	[CompilerGenerated]
	// RVA: 0x20E6B3C Offset: 0x20E2B3C VA: 0x20E6B3C
	public ValueTuple<bool, bool> get_MagicBlast() { }

	[CompilerGenerated]
	// RVA: 0x20E6B44 Offset: 0x20E2B44 VA: 0x20E6B44
	private void set_MagicBlast(ValueTuple<bool, bool> value) { }

	[CompilerGenerated]
	// RVA: 0x20E6B4C Offset: 0x20E2B4C VA: 0x20E6B4C
	public ValueTuple<bool, bool> get_MagicImpact() { }

	[CompilerGenerated]
	// RVA: 0x20E6B54 Offset: 0x20E2B54 VA: 0x20E6B54
	private void set_MagicImpact(ValueTuple<bool, bool> value) { }

	[CompilerGenerated]
	// RVA: 0x20E6B5C Offset: 0x20E2B5C VA: 0x20E6B5C
	public ValueTuple<bool, bool> get_MagicStorm() { }

	[CompilerGenerated]
	// RVA: 0x20E6B64 Offset: 0x20E2B64 VA: 0x20E6B64
	private void set_MagicStorm(ValueTuple<bool, bool> value) { }

	[CompilerGenerated]
	// RVA: 0x20E6B6C Offset: 0x20E2B6C VA: 0x20E6B6C
	public ValueTuple<bool, bool> get_MagicEgel() { }

	[CompilerGenerated]
	// RVA: 0x20E6B74 Offset: 0x20E2B74 VA: 0x20E6B74
	private void set_MagicEgel(ValueTuple<bool, bool> value) { }

	[CompilerGenerated]
	// RVA: 0x20E6B7C Offset: 0x20E2B7C VA: 0x20E6B7C
	public int get_TotalPoint() { }

	[CompilerGenerated]
	// RVA: 0x20E6B84 Offset: 0x20E2B84 VA: 0x20E6B84
	private void set_TotalPoint(int value) { }

	// RVA: 0x20E6B8C Offset: 0x20E2B8C VA: 0x20E6B8C
	private int get_MaxPoint() { }

	// RVA: 0x20E6CBC Offset: 0x20E2CBC VA: 0x20E6CBC
	private bool get_IsEnable() { }

	// RVA: 0x20E6E64 Offset: 0x20E2E64 VA: 0x20E6E64
	public void .ctor() { }

	// RVA: 0x20E5420 Offset: 0x20E1420 VA: 0x20E5420
	public void .ctor(byte[] binary) { }

	// RVA: 0x20E6FB8 Offset: 0x20E2FB8 VA: 0x20E6FB8
	public int CalcPoint(ValueTuple<bool, bool> config) { }

	// RVA: 0x20E6FD4 Offset: 0x20E2FD4 VA: 0x20E6FD4
	public int CalcAllPoint() { }

	// RVA: 0x20E70C8 Offset: 0x20E30C8 VA: 0x20E70C8 Slot: 6
	public override void SetValue(byte[] binary) { }

	// RVA: 0x20E73F4 Offset: 0x20E33F4 VA: 0x20E73F4 Slot: 5
	public override byte[] ToBinary() { }

	// RVA: 0x20E797C Offset: 0x20E397C VA: 0x20E797C
	public ValueTuple<bool, bool> GetConfig(int skillId) { }

	// RVA: 0x20E7A50 Offset: 0x20E3A50 VA: 0x20E7A50
	public ValueTuple<bool, bool> GetEnabledConfig(int skillId) { }

	// RVA: 0x20E7ADC Offset: 0x20E3ADC VA: 0x20E7ADC
	public void SetConfig(int skillId, ValueTuple<bool, bool> config) { }

	// RVA: 0x20E796C Offset: 0x20E396C VA: 0x20E796C
	private byte ConvertBinary(ValueTuple<bool, bool> config) { }

	// RVA: 0x20E7390 Offset: 0x20E3390 VA: 0x20E7390
	private ValueTuple<bool, bool> ConvertConfig(byte binary) { }
}
