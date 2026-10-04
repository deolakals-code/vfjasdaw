// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PetAttackPatternData.PatternData // TypeDefIndex: 1055
{
	// Fields
	[SerializeField]
	private short motionId; // 0x10
	[SerializeField]
	private short attackRate; // 0x12
	[SerializeField]
	private byte stable; // 0x14
	[SerializeField]
	private short hitRate; // 0x16
	[SerializeField]
	private byte startSoundTiming; // 0x18
	[SerializeField]
	private byte attackSoundTiming; // 0x19
	[SerializeField]
	private int flag; // 0x1C
	[SerializeField]
	private byte continuousAttackNum; // 0x20
	[CompilerGenerated]
	private PetAttackPatternData <Parent>k__BackingField; // 0x28
	[CompilerGenerated]
	private PetAttackPatternData.PatternData <ContinuousAttackData>k__BackingField; // 0x30
	[CompilerGenerated]
	private List<PetAttackPatternData.PatternData> <ContinuousAttackList>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <Index>k__BackingField; // 0x40

	// Properties
	public short MotionId { get; }
	public short AttackRate { get; }
	public byte Stable { get; }
	public short HitRate { get; }
	public byte StartSoundTiming { get; }
	public byte AttackSoundTiming { get; }
	public PetAttackPatternData.SuitableFlag Flag { get; }
	public PetAttackPatternData Parent { get; set; }
	public PetAttackPatternData.PatternData ContinuousAttackData { get; set; }
	public List<PetAttackPatternData.PatternData> ContinuousAttackList { get; set; }
	public int Index { get; set; }

	// Methods

	// RVA: 0x1F3FAA0 Offset: 0x1F3BAA0 VA: 0x1F3FAA0
	public short get_MotionId() { }

	// RVA: 0x1F3FAA8 Offset: 0x1F3BAA8 VA: 0x1F3FAA8
	public short get_AttackRate() { }

	// RVA: 0x1F3FAB0 Offset: 0x1F3BAB0 VA: 0x1F3FAB0
	public byte get_Stable() { }

	// RVA: 0x1F3FAB8 Offset: 0x1F3BAB8 VA: 0x1F3FAB8
	public short get_HitRate() { }

	// RVA: 0x1F3FAC0 Offset: 0x1F3BAC0 VA: 0x1F3FAC0
	public byte get_StartSoundTiming() { }

	// RVA: 0x1F3FAC8 Offset: 0x1F3BAC8 VA: 0x1F3FAC8
	public byte get_AttackSoundTiming() { }

	// RVA: 0x1F3FAD0 Offset: 0x1F3BAD0 VA: 0x1F3FAD0
	public PetAttackPatternData.SuitableFlag get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x1F3FAD8 Offset: 0x1F3BAD8 VA: 0x1F3FAD8
	private void set_Parent(PetAttackPatternData value) { }

	[CompilerGenerated]
	// RVA: 0x1F3FAE0 Offset: 0x1F3BAE0 VA: 0x1F3FAE0
	public PetAttackPatternData get_Parent() { }

	[CompilerGenerated]
	// RVA: 0x1F3FAE8 Offset: 0x1F3BAE8 VA: 0x1F3FAE8
	private void set_ContinuousAttackData(PetAttackPatternData.PatternData value) { }

	[CompilerGenerated]
	// RVA: 0x1F3FAF0 Offset: 0x1F3BAF0 VA: 0x1F3FAF0
	public PetAttackPatternData.PatternData get_ContinuousAttackData() { }

	[CompilerGenerated]
	// RVA: 0x1F3FAF8 Offset: 0x1F3BAF8 VA: 0x1F3FAF8
	private void set_ContinuousAttackList(List<PetAttackPatternData.PatternData> value) { }

	[CompilerGenerated]
	// RVA: 0x1F3FB00 Offset: 0x1F3BB00 VA: 0x1F3FB00
	public List<PetAttackPatternData.PatternData> get_ContinuousAttackList() { }

	[CompilerGenerated]
	// RVA: 0x1F3FB08 Offset: 0x1F3BB08 VA: 0x1F3FB08
	private void set_Index(int value) { }

	[CompilerGenerated]
	// RVA: 0x1F3FB10 Offset: 0x1F3BB10 VA: 0x1F3FB10
	public int get_Index() { }

	// RVA: 0x1F3FB18 Offset: 0x1F3BB18 VA: 0x1F3FB18
	public void .ctor() { }

	// RVA: 0x1F3F854 Offset: 0x1F3B854 VA: 0x1F3F854
	public void .ctor(BinaryReader br, PetAttackPatternData parent, int index) { }

	// RVA: 0x1F3F93C Offset: 0x1F3B93C VA: 0x1F3F93C
	public void AddContinuousAttack(PetAttackPatternData.PatternData data) { }
}
