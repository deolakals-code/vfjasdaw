// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class SkillEventResponseData : UnityHashBase // TypeDefIndex: 13121
{
	// Fields
	[CompilerGenerated]
	private short <SkillId>k__BackingField; // 0x1A
	[CompilerGenerated]
	private byte <LocalId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <SkillEventId>k__BackingField; // 0x28

	// Properties
	public short SkillId { get; set; }
	public byte LocalId { get; set; }
	public PlayerStatusData PlayerStatus { get; set; }
	public short SkillEventId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36AB220 Offset: 0x36A7220 VA: 0x36AB220
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36AB228 Offset: 0x36A7228 VA: 0x36AB228
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x36AB230 Offset: 0x36A7230 VA: 0x36AB230
	public void set_SkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x36AB238 Offset: 0x36A7238 VA: 0x36AB238
	public byte get_LocalId() { }

	[CompilerGenerated]
	// RVA: 0x36AB240 Offset: 0x36A7240 VA: 0x36AB240
	public void set_LocalId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36AB248 Offset: 0x36A7248 VA: 0x36AB248
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x36AB250 Offset: 0x36A7250 VA: 0x36AB250
	public void set_PlayerStatus(PlayerStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x36AB258 Offset: 0x36A7258 VA: 0x36AB258
	public short get_SkillEventId() { }

	[CompilerGenerated]
	// RVA: 0x36AB260 Offset: 0x36A7260 VA: 0x36AB260
	public void set_SkillEventId(short value) { }

	// RVA: 0x36AB268 Offset: 0x36A7268 VA: 0x36AB268 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36AB270 Offset: 0x36A7270 VA: 0x36AB270 Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x36AB468 Offset: 0x36A7468 VA: 0x36AB468 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }
}
