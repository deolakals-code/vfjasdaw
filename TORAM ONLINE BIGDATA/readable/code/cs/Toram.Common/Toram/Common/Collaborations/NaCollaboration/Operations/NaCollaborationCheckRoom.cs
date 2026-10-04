// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Collaborations.NaCollaboration.Operations
public class NaCollaborationCheckRoom : OperationRequestBase // TypeDefIndex: 13084
{
	// Fields
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <RoomId>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x25

	// Properties
	public int FieldId { get; set; }
	public byte RoomId { get; set; }
	public byte Flag { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x369FD00 Offset: 0x369BD00 VA: 0x369FD00
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x369FD08 Offset: 0x369BD08 VA: 0x369FD08
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x369FD10 Offset: 0x369BD10 VA: 0x369FD10
	public void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x369FD18 Offset: 0x369BD18 VA: 0x369FD18
	public byte get_RoomId() { }

	[CompilerGenerated]
	// RVA: 0x369FD20 Offset: 0x369BD20 VA: 0x369FD20
	public void set_RoomId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x369FD28 Offset: 0x369BD28 VA: 0x369FD28
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x369FD30 Offset: 0x369BD30 VA: 0x369FD30
	public void set_Flag(byte value) { }

	// RVA: 0x369FD38 Offset: 0x369BD38 VA: 0x369FD38 Slot: 3
	public override string ToString() { }

	// RVA: 0x369FDF4 Offset: 0x369BDF4 VA: 0x369FDF4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x369FDFC Offset: 0x369BDFC VA: 0x369FDFC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x369FE04 Offset: 0x369BE04 VA: 0x369FE04 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x369FFC8 Offset: 0x369BFC8 VA: 0x369FFC8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
