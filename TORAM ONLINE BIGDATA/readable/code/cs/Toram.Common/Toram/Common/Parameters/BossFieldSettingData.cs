// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Parameters
public class BossFieldSettingData : UnityHashBase // TypeDefIndex: 11114
{
	// Fields
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <RoomId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <EventHoldFlag>k__BackingField; // 0x21
	[CompilerGenerated]
	private byte <EntreeStagingFlag>k__BackingField; // 0x22

	// Properties
	public override byte Code { get; }
	[UnityHash(Code = 60, IsOptional = True)]
	public int FieldId { get; set; }
	[UnityHash(Code = 106, IsOptional = True)]
	public byte RoomId { get; set; }
	[UnityHash(Code = 140, IsOptional = True)]
	public byte EventHoldFlag { get; set; }
	[UnityHash(Code = 161, IsOptional = True)]
	public byte EntreeStagingFlag { get; set; }

	// Methods

	// RVA: 0x35BDC68 Offset: 0x35B9C68 VA: 0x35BDC68
	public void .ctor(Dictionary<object, object> parameters) { }

	// RVA: 0x35BDC70 Offset: 0x35B9C70 VA: 0x35BDC70 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x35BDC78 Offset: 0x35B9C78 VA: 0x35BDC78
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x35BDC80 Offset: 0x35B9C80 VA: 0x35BDC80
	public void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35BDC88 Offset: 0x35B9C88 VA: 0x35BDC88
	public byte get_RoomId() { }

	[CompilerGenerated]
	// RVA: 0x35BDC90 Offset: 0x35B9C90 VA: 0x35BDC90
	public void set_RoomId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35BDC98 Offset: 0x35B9C98 VA: 0x35BDC98
	public byte get_EventHoldFlag() { }

	[CompilerGenerated]
	// RVA: 0x35BDCA0 Offset: 0x35B9CA0 VA: 0x35BDCA0
	public void set_EventHoldFlag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35BDCA8 Offset: 0x35B9CA8 VA: 0x35BDCA8
	public byte get_EntreeStagingFlag() { }

	[CompilerGenerated]
	// RVA: 0x35BDCB0 Offset: 0x35B9CB0 VA: 0x35BDCB0
	public void set_EntreeStagingFlag(byte value) { }

	// RVA: 0x35BDCB8 Offset: 0x35B9CB8 VA: 0x35BDCB8 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x35BE010 Offset: 0x35BA010 VA: 0x35BE010 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
