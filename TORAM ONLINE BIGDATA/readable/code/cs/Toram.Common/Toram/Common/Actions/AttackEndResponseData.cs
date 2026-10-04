// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class AttackEndResponseData : SkillIdData // TypeDefIndex: 13111
{
	// Fields
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <SkillParamFlag>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <SkillIndividualFlag>k__BackingField; // 0x2C

	// Properties
	[UnityHash(Code = 7, IsOptional = True)]
	public PlayerStatusData PlayerStatus { get; set; }
	public int SkillParamFlag { get; set; }
	public int SkillIndividualFlag { get; set; }

	// Methods

	// RVA: 0x36A4A88 Offset: 0x36A0A88 VA: 0x36A4A88
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36A4A90 Offset: 0x36A0A90 VA: 0x36A4A90
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x36A4A98 Offset: 0x36A0A98 VA: 0x36A4A98
	public void set_PlayerStatus(PlayerStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x36A4AA0 Offset: 0x36A0AA0 VA: 0x36A4AA0
	public int get_SkillParamFlag() { }

	[CompilerGenerated]
	// RVA: 0x36A4AA8 Offset: 0x36A0AA8 VA: 0x36A4AA8
	public void set_SkillParamFlag(int value) { }

	[CompilerGenerated]
	// RVA: 0x36A4AB0 Offset: 0x36A0AB0 VA: 0x36A4AB0
	public int get_SkillIndividualFlag() { }

	[CompilerGenerated]
	// RVA: 0x36A4AB8 Offset: 0x36A0AB8 VA: 0x36A4AB8
	public void set_SkillIndividualFlag(int value) { }

	// RVA: 0x36A4AC0 Offset: 0x36A0AC0 VA: 0x36A4AC0 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36A4E0C Offset: 0x36A0E0C VA: 0x36A4E0C Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
