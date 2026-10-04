// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class EmotionData : UnityHashBase // TypeDefIndex: 13181
{
	// Fields
	[CompilerGenerated]
	private byte <EmotionType>k__BackingField; // 0x19
	[CompilerGenerated]
	private byte <EmotionId>k__BackingField; // 0x1A
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsMove>k__BackingField; // 0x2A

	// Properties
	[UnityHash(Code = 59, IsOptional = True)]
	public byte EmotionType { get; set; }
	[UnityHash(Code = 38)]
	public byte EmotionId { get; set; }
	[UnityHash(Code = 10, IsOptional = True)]
	public short[] Position { get; set; }
	[UnityHash(Code = 11, IsOptional = True)]
	public short Rotation { get; set; }
	public bool IsMove { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36C0B34 Offset: 0x36BCB34 VA: 0x36C0B34
	public void .ctor() { }

	// RVA: 0x36C0B3C Offset: 0x36BCB3C VA: 0x36C0B3C
	public void .ctor(Dictionary<object, object> hash) { }

	[CompilerGenerated]
	// RVA: 0x36C0B44 Offset: 0x36BCB44 VA: 0x36C0B44
	public byte get_EmotionType() { }

	[CompilerGenerated]
	// RVA: 0x36C0B4C Offset: 0x36BCB4C VA: 0x36C0B4C
	public void set_EmotionType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36C0B54 Offset: 0x36BCB54 VA: 0x36C0B54
	public byte get_EmotionId() { }

	[CompilerGenerated]
	// RVA: 0x36C0B5C Offset: 0x36BCB5C VA: 0x36C0B5C
	public void set_EmotionId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36C0B64 Offset: 0x36BCB64 VA: 0x36C0B64
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x36C0B6C Offset: 0x36BCB6C VA: 0x36C0B6C
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36C0B74 Offset: 0x36BCB74 VA: 0x36C0B74
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x36C0B7C Offset: 0x36BCB7C VA: 0x36C0B7C
	public void set_Rotation(short value) { }

	[CompilerGenerated]
	// RVA: 0x36C0B84 Offset: 0x36BCB84 VA: 0x36C0B84
	public bool get_IsMove() { }

	[CompilerGenerated]
	// RVA: 0x36C0B8C Offset: 0x36BCB8C VA: 0x36C0B8C
	private void set_IsMove(bool value) { }

	// RVA: 0x36C0B98 Offset: 0x36BCB98 VA: 0x36C0B98 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36C0BA0 Offset: 0x36BCBA0 VA: 0x36C0BA0 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36C0F94 Offset: 0x36BCF94 VA: 0x36C0F94 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
