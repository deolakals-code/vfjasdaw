// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ParryingSwordBuf : SkillBufferDataBase // TypeDefIndex: 3265
{
	// Fields
	[CompilerGenerated]
	private float <RealLeftTime>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <ParrySuccess>k__BackingField; // 0x24
	[CompilerGenerated]
	private bool <DamageAbnormalCut>k__BackingField; // 0x25

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }
	public float RealLeftTime { get; set; }
	public bool ParrySuccess { get; set; }
	public bool DamageAbnormalCut { get; set; }

	// Methods

	// RVA: 0x2340CE4 Offset: 0x233CCE4 VA: 0x2340CE4 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2340CEC Offset: 0x233CCEC VA: 0x2340CEC Slot: 9
	public override SkillBufferFlag get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x2340CF4 Offset: 0x233CCF4 VA: 0x2340CF4
	public float get_RealLeftTime() { }

	[CompilerGenerated]
	// RVA: 0x2340CFC Offset: 0x233CCFC VA: 0x2340CFC
	private void set_RealLeftTime(float value) { }

	[CompilerGenerated]
	// RVA: 0x2340D04 Offset: 0x233CD04 VA: 0x2340D04
	public bool get_ParrySuccess() { }

	[CompilerGenerated]
	// RVA: 0x2340D0C Offset: 0x233CD0C VA: 0x2340D0C
	private void set_ParrySuccess(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2340D18 Offset: 0x233CD18 VA: 0x2340D18
	public bool get_DamageAbnormalCut() { }

	[CompilerGenerated]
	// RVA: 0x2340D20 Offset: 0x233CD20 VA: 0x2340D20
	private void set_DamageAbnormalCut(bool value) { }

	// RVA: 0x2340D2C Offset: 0x233CD2C VA: 0x2340D2C
	public void .ctor(byte lv) { }

	// RVA: 0x2340D74 Offset: 0x233CD74 VA: 0x2340D74 Slot: 11
	public override void Updata() { }

	// RVA: 0x2340DBC Offset: 0x233CDBC VA: 0x2340DBC Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2340E1C Offset: 0x233CE1C VA: 0x2340E1C
	private int calcDmgCut(int lv) { }

	// RVA: 0x2340ED4 Offset: 0x233CED4 VA: 0x2340ED4
	public void SetParrySuccess() { }

	// RVA: 0x2340EFC Offset: 0x233CEFC VA: 0x2340EFC
	public void EndDamageAbnormalCut() { }

	// RVA: 0x2340F18 Offset: 0x233CF18 VA: 0x2340F18
	public static void Parry(PlayerActionManagerBase playerAction) { }
}
