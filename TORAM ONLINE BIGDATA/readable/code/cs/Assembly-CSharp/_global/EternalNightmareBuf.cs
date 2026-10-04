// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EternalNightmareBuf : SkillBufferDataBase // TypeDefIndex: 3155
{
	// Fields
	[CompilerGenerated]
	private short <SkillLocalId>k__BackingField; // 0x1E
	private static readonly int[] DemonCrowParamTable; // 0x0
	private int allDarkPowerSkillLevel; // 0x20
	private List<CharacterActionManagerBase> mobList; // 0x28
	private bool activeDefDown; // 0x30

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }
	public short SkillLocalId { get; set; }

	// Methods

	// RVA: 0x232CF54 Offset: 0x2328F54 VA: 0x232CF54 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x232CF5C Offset: 0x2328F5C VA: 0x232CF5C Slot: 9
	public override SkillBufferFlag get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x232CF64 Offset: 0x2328F64 VA: 0x232CF64
	public short get_SkillLocalId() { }

	[CompilerGenerated]
	// RVA: 0x232CF6C Offset: 0x2328F6C VA: 0x232CF6C
	private void set_SkillLocalId(short value) { }

	// RVA: 0x232CF74 Offset: 0x2328F74 VA: 0x232CF74
	public void .ctor(byte lv, int val, short localId) { }

	// RVA: 0x232D06C Offset: 0x232906C VA: 0x232D06C
	public void .ctor(byte lv, int val) { }

	// RVA: 0x232CF9C Offset: 0x2328F9C VA: 0x232CF9C
	private void .ctor(byte lv, int val, bool isSelf) { }

	// RVA: 0x232D094 Offset: 0x2329094 VA: 0x232D094 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x232D120 Offset: 0x2329120 VA: 0x232D120
	public int GetParam(EternalNightmareBuf.BonusType type) { }

	// RVA: 0x232D20C Offset: 0x232920C VA: 0x232D20C Slot: 11
	public override void Updata() { }

	// RVA: 0x232D260 Offset: 0x2329260 VA: 0x232D260
	public void PlayEffect(CharacterActionManagerBase mobActionManager) { }

	// RVA: 0x232D48C Offset: 0x232948C VA: 0x232D48C
	public void ActiveDefDown(bool active) { }

	// RVA: 0x232D498 Offset: 0x2329498 VA: 0x232D498
	private static void .cctor() { }
}
