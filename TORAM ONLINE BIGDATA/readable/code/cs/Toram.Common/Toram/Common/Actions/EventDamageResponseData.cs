// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class EventDamageResponseData : UnityHashBase // TypeDefIndex: 13191
{
	// Fields
	[CompilerGenerated]
	private byte <DamageId>k__BackingField; // 0x19
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <AbnormalState>k__BackingField; // 0x28
	[CompilerGenerated]
	private float <AbnormalStateTime>k__BackingField; // 0x2C

	// Properties
	[UnityHash(Code = 50)]
	public byte DamageId { get; set; }
	[UnityHash(Code = 7)]
	public PlayerStatusData PlayerStatus { get; set; }
	[UnityHash(Code = 52, IsOptional = True)]
	public byte AbnormalState { get; set; }
	[UnityHash(Code = 53, IsOptional = True)]
	public float AbnormalStateTime { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36C4070 Offset: 0x36C0070 VA: 0x36C4070
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36C4078 Offset: 0x36C0078 VA: 0x36C4078
	public byte get_DamageId() { }

	[CompilerGenerated]
	// RVA: 0x36C4080 Offset: 0x36C0080 VA: 0x36C4080
	public void set_DamageId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36C4088 Offset: 0x36C0088 VA: 0x36C4088
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x36C4090 Offset: 0x36C0090 VA: 0x36C4090
	public void set_PlayerStatus(PlayerStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x36C4098 Offset: 0x36C0098 VA: 0x36C4098
	public byte get_AbnormalState() { }

	[CompilerGenerated]
	// RVA: 0x36C40A0 Offset: 0x36C00A0 VA: 0x36C40A0
	public void set_AbnormalState(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36C40A8 Offset: 0x36C00A8 VA: 0x36C40A8
	public float get_AbnormalStateTime() { }

	[CompilerGenerated]
	// RVA: 0x36C40B0 Offset: 0x36C00B0 VA: 0x36C40B0
	public void set_AbnormalStateTime(float value) { }

	// RVA: 0x36C40B8 Offset: 0x36C00B8 VA: 0x36C40B8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36C40C0 Offset: 0x36C00C0 VA: 0x36C40C0 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36C440C Offset: 0x36C040C VA: 0x36C440C Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
