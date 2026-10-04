// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Home
public class GuildHomeData : UnityHashBase // TypeDefIndex: 11138
{
	// Fields
	[CompilerGenerated]
	private byte <RenovationId>k__BackingField; // 0x19
	[CompilerGenerated]
	private short[] <TopLeftCorner>k__BackingField; // 0x20
	[CompilerGenerated]
	private short[] <BottomRightCorner>k__BackingField; // 0x28
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte <RaidElement>k__BackingField; // 0x3A

	// Properties
	[UnityHash(Code = 200, IsOptional = True)]
	public byte RenovationId { get; set; }
	[UnityHash(Code = 57)]
	public short[] TopLeftCorner { get; set; }
	[UnityHash(Code = 59)]
	public short[] BottomRightCorner { get; set; }
	[UnityHash(Code = 54)]
	public short[] Position { get; set; }
	[UnityHash(Code = 65)]
	public short Rotation { get; set; }
	[UnityHash(Code = 48)]
	public byte RaidElement { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35C73E4 Offset: 0x35C33E4 VA: 0x35C73E4
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35C73EC Offset: 0x35C33EC VA: 0x35C73EC
	public byte get_RenovationId() { }

	[CompilerGenerated]
	// RVA: 0x35C73F4 Offset: 0x35C33F4 VA: 0x35C73F4
	public void set_RenovationId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35C73FC Offset: 0x35C33FC VA: 0x35C73FC
	public short[] get_TopLeftCorner() { }

	[CompilerGenerated]
	// RVA: 0x35C7404 Offset: 0x35C3404 VA: 0x35C7404
	public void set_TopLeftCorner(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x35C740C Offset: 0x35C340C VA: 0x35C740C
	public short[] get_BottomRightCorner() { }

	[CompilerGenerated]
	// RVA: 0x35C7414 Offset: 0x35C3414 VA: 0x35C7414
	public void set_BottomRightCorner(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x35C741C Offset: 0x35C341C VA: 0x35C741C
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x35C7424 Offset: 0x35C3424 VA: 0x35C7424
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x35C742C Offset: 0x35C342C VA: 0x35C742C
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x35C7434 Offset: 0x35C3434 VA: 0x35C7434
	public void set_Rotation(short value) { }

	[CompilerGenerated]
	// RVA: 0x35C743C Offset: 0x35C343C VA: 0x35C743C
	public byte get_RaidElement() { }

	[CompilerGenerated]
	// RVA: 0x35C7444 Offset: 0x35C3444 VA: 0x35C7444
	public void set_RaidElement(byte value) { }

	// RVA: 0x35C744C Offset: 0x35C344C VA: 0x35C744C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35C7454 Offset: 0x35C3454 VA: 0x35C7454 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x35C77FC Offset: 0x35C37FC VA: 0x35C77FC Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
