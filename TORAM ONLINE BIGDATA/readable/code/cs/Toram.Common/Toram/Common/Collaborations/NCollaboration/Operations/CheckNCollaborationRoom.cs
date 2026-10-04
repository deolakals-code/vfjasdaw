// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Collaborations.NCollaboration.Operations
public class CheckNCollaborationRoom : OperationRequestBase // TypeDefIndex: 13041
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

	// RVA: 0x3694C00 Offset: 0x3690C00 VA: 0x3694C00
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3694C08 Offset: 0x3690C08 VA: 0x3694C08
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x3694C10 Offset: 0x3690C10 VA: 0x3694C10
	public void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3694C18 Offset: 0x3690C18 VA: 0x3694C18
	public byte get_RoomId() { }

	[CompilerGenerated]
	// RVA: 0x3694C20 Offset: 0x3690C20 VA: 0x3694C20
	public void set_RoomId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3694C28 Offset: 0x3690C28 VA: 0x3694C28
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x3694C30 Offset: 0x3690C30 VA: 0x3694C30
	public void set_Flag(byte value) { }

	// RVA: 0x3694C38 Offset: 0x3690C38 VA: 0x3694C38 Slot: 3
	public override string ToString() { }

	// RVA: 0x3694CF4 Offset: 0x3690CF4 VA: 0x3694CF4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3694CFC Offset: 0x3690CFC VA: 0x3694CFC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3694D04 Offset: 0x3690D04 VA: 0x3694D04 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3694EC8 Offset: 0x3690EC8 VA: 0x3694EC8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
