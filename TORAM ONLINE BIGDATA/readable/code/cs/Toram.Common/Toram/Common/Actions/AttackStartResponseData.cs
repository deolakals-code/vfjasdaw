// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class AttackStartResponseData : UnityHashBase // TypeDefIndex: 13116
{
	// Fields
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <SkillId>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <LocalId>k__BackingField; // 0x2A
	[CompilerGenerated]
	private int <SkillIndividualFlag>k__BackingField; // 0x2C
	[CompilerGenerated]
	private int <SkillParamFlag>k__BackingField; // 0x30
	[CompilerGenerated]
	private MobResponseData <Target>k__BackingField; // 0x38
	[CompilerGenerated]
	private short <GemCartStartDashCoolTime>k__BackingField; // 0x40
	[CompilerGenerated]
	private int <HealHp>k__BackingField; // 0x44
	[CompilerGenerated]
	private short <HealMp>k__BackingField; // 0x48
	[CompilerGenerated]
	private ActionAppendData <AppendData>k__BackingField; // 0x50

	// Properties
	[UnityHash(Code = 7)]
	public PlayerStatusData PlayerStatus { get; set; }
	[UnityHash(Code = 39, IsOptional = True)]
	public short SkillId { get; set; }
	[UnityHash(Code = 23, IsOptional = True)]
	public byte LocalId { get; set; }
	[UnityHash(Code = 59, IsOptional = True)]
	public int SkillIndividualFlag { get; set; }
	[UnityHash(Code = 85, IsOptional = True)]
	public int SkillParamFlag { get; set; }
	[UnityHash(Code = 20, IsOptional = True)]
	public MobResponseData Target { get; set; }
	public short GemCartStartDashCoolTime { get; set; }
	public int HealHp { get; set; }
	public short HealMp { get; set; }
	public ActionAppendData AppendData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36A8424 Offset: 0x36A4424 VA: 0x36A8424
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36A842C Offset: 0x36A442C VA: 0x36A842C
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x36A8434 Offset: 0x36A4434 VA: 0x36A8434
	public void set_PlayerStatus(PlayerStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x36A843C Offset: 0x36A443C VA: 0x36A843C
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x36A8444 Offset: 0x36A4444 VA: 0x36A8444
	public void set_SkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x36A844C Offset: 0x36A444C VA: 0x36A844C
	public byte get_LocalId() { }

	[CompilerGenerated]
	// RVA: 0x36A8454 Offset: 0x36A4454 VA: 0x36A8454
	public void set_LocalId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36A845C Offset: 0x36A445C VA: 0x36A845C
	public int get_SkillIndividualFlag() { }

	[CompilerGenerated]
	// RVA: 0x36A8464 Offset: 0x36A4464 VA: 0x36A8464
	public void set_SkillIndividualFlag(int value) { }

	[CompilerGenerated]
	// RVA: 0x36A846C Offset: 0x36A446C VA: 0x36A846C
	public int get_SkillParamFlag() { }

	[CompilerGenerated]
	// RVA: 0x36A8474 Offset: 0x36A4474 VA: 0x36A8474
	public void set_SkillParamFlag(int value) { }

	[CompilerGenerated]
	// RVA: 0x36A847C Offset: 0x36A447C VA: 0x36A847C
	public MobResponseData get_Target() { }

	[CompilerGenerated]
	// RVA: 0x36A8484 Offset: 0x36A4484 VA: 0x36A8484
	public void set_Target(MobResponseData value) { }

	[CompilerGenerated]
	// RVA: 0x36A848C Offset: 0x36A448C VA: 0x36A848C
	public short get_GemCartStartDashCoolTime() { }

	[CompilerGenerated]
	// RVA: 0x36A8494 Offset: 0x36A4494 VA: 0x36A8494
	public void set_GemCartStartDashCoolTime(short value) { }

	[CompilerGenerated]
	// RVA: 0x36A849C Offset: 0x36A449C VA: 0x36A849C
	public int get_HealHp() { }

	[CompilerGenerated]
	// RVA: 0x36A84A4 Offset: 0x36A44A4 VA: 0x36A84A4
	public void set_HealHp(int value) { }

	[CompilerGenerated]
	// RVA: 0x36A84AC Offset: 0x36A44AC VA: 0x36A84AC
	public short get_HealMp() { }

	[CompilerGenerated]
	// RVA: 0x36A84B4 Offset: 0x36A44B4 VA: 0x36A84B4
	public void set_HealMp(short value) { }

	[CompilerGenerated]
	// RVA: 0x36A84BC Offset: 0x36A44BC VA: 0x36A84BC
	public ActionAppendData get_AppendData() { }

	[CompilerGenerated]
	// RVA: 0x36A84C4 Offset: 0x36A44C4 VA: 0x36A84C4
	public void set_AppendData(ActionAppendData value) { }

	// RVA: 0x36A84CC Offset: 0x36A44CC VA: 0x36A84CC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36A84D4 Offset: 0x36A44D4 VA: 0x36A84D4 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36A8C3C Offset: 0x36A4C3C VA: 0x36A8C3C Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
