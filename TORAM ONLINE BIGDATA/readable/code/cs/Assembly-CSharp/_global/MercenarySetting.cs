// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MercenarySetting : NPCPartySettingBase // TypeDefIndex: 696
{
	// Fields
	[CompilerGenerated]
	private bool <IsMan>k__BackingField; // 0x90
	public StanceType Stance; // 0x94
	[CompilerGenerated]
	private bool <IsPartner>k__BackingField; // 0x98
	[CompilerGenerated]
	private CompanionStatusDataBase <PartnerStatus>k__BackingField; // 0xA0
	[CompilerGenerated]
	private DateTime <UsageTime>k__BackingField; // 0xA8
	[CompilerGenerated]
	private float <DamageRate>k__BackingField; // 0xB0

	// Properties
	public bool IsMan { get; set; }
	public bool IsPartner { get; set; }
	public CompanionStatusDataBase PartnerStatus { get; set; }
	public DateTime UsageTime { get; set; }
	public float DamageRate { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1AC5C80 Offset: 0x1AC1C80 VA: 0x1AC5C80
	private void set_IsMan(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1AC5C8C Offset: 0x1AC1C8C VA: 0x1AC5C8C
	public bool get_IsMan() { }

	[CompilerGenerated]
	// RVA: 0x1AC5C94 Offset: 0x1AC1C94 VA: 0x1AC5C94
	public bool get_IsPartner() { }

	[CompilerGenerated]
	// RVA: 0x1AC5C9C Offset: 0x1AC1C9C VA: 0x1AC5C9C
	private void set_IsPartner(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1AC5CA8 Offset: 0x1AC1CA8 VA: 0x1AC5CA8
	public CompanionStatusDataBase get_PartnerStatus() { }

	[CompilerGenerated]
	// RVA: 0x1AC5CB0 Offset: 0x1AC1CB0 VA: 0x1AC5CB0
	private void set_PartnerStatus(CompanionStatusDataBase value) { }

	[CompilerGenerated]
	// RVA: 0x1AC5CB8 Offset: 0x1AC1CB8 VA: 0x1AC5CB8
	public DateTime get_UsageTime() { }

	[CompilerGenerated]
	// RVA: 0x1AC5CC0 Offset: 0x1AC1CC0 VA: 0x1AC5CC0
	private void set_UsageTime(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x1AC5CC8 Offset: 0x1AC1CC8 VA: 0x1AC5CC8
	public float get_DamageRate() { }

	[CompilerGenerated]
	// RVA: 0x1AC5CD0 Offset: 0x1AC1CD0 VA: 0x1AC5CD0
	private void set_DamageRate(float value) { }

	// RVA: 0x1AC5CD8 Offset: 0x1AC1CD8 VA: 0x1AC5CD8
	public void .ctor(PartnerArchetype partnerArchetype) { }

	// RVA: 0x1AC65EC Offset: 0x1AC25EC VA: 0x1AC65EC
	public void .ctor(MercenaryArchetype mercenaryArchtype) { }

	// RVA: 0x1AC6030 Offset: 0x1AC2030 VA: 0x1AC6030
	private void SetSkillDate(Dictionary<short, byte> skillData) { }

	// RVA: 0x1AC688C Offset: 0x1AC288C VA: 0x1AC688C
	private AIActionCondition GetTransFarConditon(byte target) { }

	// RVA: 0x1AC5F6C Offset: 0x1AC1F6C VA: 0x1AC5F6C
	private Vector3 RandamPos(Vector3 orgPos, float rad) { }
}
