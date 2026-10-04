// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class SupportResultData : UnityHashBase // TypeDefIndex: 13207
{
	// Fields
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <HealHp>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <HealMp>k__BackingField; // 0x2C
	[CompilerGenerated]
	private float <Time>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <Value>k__BackingField; // 0x34
	[CompilerGenerated]
	private int <Value2>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte[] <RemoveAbnomalState>k__BackingField; // 0x40
	[CompilerGenerated]
	private byte[] <RemoveAbnomalStateLocalId>k__BackingField; // 0x48
	[CompilerGenerated]
	private int <Flag>k__BackingField; // 0x50

	// Properties
	[UnityHash(Code = 7)]
	public PlayerStatusData PlayerStatus { get; set; }
	[UnityHash(Code = 12, IsOptional = True)]
	public int HealHp { get; set; }
	[UnityHash(Code = 13, IsOptional = True)]
	public short HealMp { get; set; }
	[UnityHash(Code = 42, IsOptional = True)]
	public float Time { get; set; }
	[UnityHash(Code = 55, IsOptional = True)]
	public int Value { get; set; }
	[UnityHash(Code = 90, IsOptional = True)]
	public int Value2 { get; set; }
	[UnityHash(Code = 52, IsOptional = True)]
	public byte[] RemoveAbnomalState { get; set; }
	public byte[] RemoveAbnomalStateLocalId { get; set; }
	public int Flag { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36C7440 Offset: 0x36C3440 VA: 0x36C7440
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36C9A1C Offset: 0x36C5A1C VA: 0x36C9A1C
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x36C9A24 Offset: 0x36C5A24 VA: 0x36C9A24
	public void set_PlayerStatus(PlayerStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x36C9A2C Offset: 0x36C5A2C VA: 0x36C9A2C
	public int get_HealHp() { }

	[CompilerGenerated]
	// RVA: 0x36C9A34 Offset: 0x36C5A34 VA: 0x36C9A34
	public void set_HealHp(int value) { }

	[CompilerGenerated]
	// RVA: 0x36C9A3C Offset: 0x36C5A3C VA: 0x36C9A3C
	public short get_HealMp() { }

	[CompilerGenerated]
	// RVA: 0x36C9A44 Offset: 0x36C5A44 VA: 0x36C9A44
	public void set_HealMp(short value) { }

	[CompilerGenerated]
	// RVA: 0x36C9A4C Offset: 0x36C5A4C VA: 0x36C9A4C
	public float get_Time() { }

	[CompilerGenerated]
	// RVA: 0x36C9A54 Offset: 0x36C5A54 VA: 0x36C9A54
	public void set_Time(float value) { }

	[CompilerGenerated]
	// RVA: 0x36C9A5C Offset: 0x36C5A5C VA: 0x36C9A5C
	public int get_Value() { }

	[CompilerGenerated]
	// RVA: 0x36C9A64 Offset: 0x36C5A64 VA: 0x36C9A64
	public void set_Value(int value) { }

	[CompilerGenerated]
	// RVA: 0x36C9A6C Offset: 0x36C5A6C VA: 0x36C9A6C
	public int get_Value2() { }

	[CompilerGenerated]
	// RVA: 0x36C9A74 Offset: 0x36C5A74 VA: 0x36C9A74
	public void set_Value2(int value) { }

	[CompilerGenerated]
	// RVA: 0x36C9A7C Offset: 0x36C5A7C VA: 0x36C9A7C
	public byte[] get_RemoveAbnomalState() { }

	[CompilerGenerated]
	// RVA: 0x36C9A84 Offset: 0x36C5A84 VA: 0x36C9A84
	public void set_RemoveAbnomalState(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x36C9A8C Offset: 0x36C5A8C VA: 0x36C9A8C
	public byte[] get_RemoveAbnomalStateLocalId() { }

	[CompilerGenerated]
	// RVA: 0x36C9A94 Offset: 0x36C5A94 VA: 0x36C9A94
	public void set_RemoveAbnomalStateLocalId(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x36C9A9C Offset: 0x36C5A9C VA: 0x36C9A9C
	public int get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x36C9AA4 Offset: 0x36C5AA4 VA: 0x36C9AA4
	public void set_Flag(int value) { }

	// RVA: 0x36C9AAC Offset: 0x36C5AAC VA: 0x36C9AAC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36C9AB4 Offset: 0x36C5AB4 VA: 0x36C9AB4 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36CA160 Offset: 0x36C6160 VA: 0x36CA160 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
