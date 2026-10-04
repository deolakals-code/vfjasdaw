// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class SupportStartResponseData : UnityHashBase // TypeDefIndex: 13146
{
	// Fields
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <SkillId>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <LocalId>k__BackingField; // 0x2A
	[CompilerGenerated]
	private int <SkillParamFlag>k__BackingField; // 0x2C
	[CompilerGenerated]
	private int <SkillIndividualFlag>k__BackingField; // 0x30
	[CompilerGenerated]
	private ActionAppendData <AppendData>k__BackingField; // 0x38

	// Properties
	[UnityHash(Code = 7)]
	public PlayerStatusData PlayerStatus { get; set; }
	public short SkillId { get; set; }
	public byte LocalId { get; set; }
	[UnityHash(Code = 85, IsOptional = True)]
	public int SkillParamFlag { get; set; }
	[UnityHash(Code = 59, IsOptional = True)]
	public int SkillIndividualFlag { get; set; }
	public ActionAppendData AppendData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36B2FA4 Offset: 0x36AEFA4 VA: 0x36B2FA4
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36B2FAC Offset: 0x36AEFAC VA: 0x36B2FAC
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x36B2FB4 Offset: 0x36AEFB4 VA: 0x36B2FB4
	public void set_PlayerStatus(PlayerStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x36B2FBC Offset: 0x36AEFBC VA: 0x36B2FBC
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x36B2FC4 Offset: 0x36AEFC4 VA: 0x36B2FC4
	public void set_SkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x36B2FCC Offset: 0x36AEFCC VA: 0x36B2FCC
	public byte get_LocalId() { }

	[CompilerGenerated]
	// RVA: 0x36B2FD4 Offset: 0x36AEFD4 VA: 0x36B2FD4
	public void set_LocalId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36B2FDC Offset: 0x36AEFDC VA: 0x36B2FDC
	public int get_SkillParamFlag() { }

	[CompilerGenerated]
	// RVA: 0x36B2FE4 Offset: 0x36AEFE4 VA: 0x36B2FE4
	public void set_SkillParamFlag(int value) { }

	[CompilerGenerated]
	// RVA: 0x36B2FEC Offset: 0x36AEFEC VA: 0x36B2FEC
	public int get_SkillIndividualFlag() { }

	[CompilerGenerated]
	// RVA: 0x36B2FF4 Offset: 0x36AEFF4 VA: 0x36B2FF4
	public void set_SkillIndividualFlag(int value) { }

	[CompilerGenerated]
	// RVA: 0x36B2FFC Offset: 0x36AEFFC VA: 0x36B2FFC
	public ActionAppendData get_AppendData() { }

	[CompilerGenerated]
	// RVA: 0x36B3004 Offset: 0x36AF004 VA: 0x36B3004
	public void set_AppendData(ActionAppendData value) { }

	// RVA: 0x36B300C Offset: 0x36AF00C VA: 0x36B300C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36B3014 Offset: 0x36AF014 VA: 0x36B3014 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36B34B0 Offset: 0x36AF4B0 VA: 0x36B34B0 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
