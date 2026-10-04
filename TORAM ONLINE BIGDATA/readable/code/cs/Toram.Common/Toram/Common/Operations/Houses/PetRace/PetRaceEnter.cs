// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.PetRace
public class PetRaceEnter : OperationRequestBase // TypeDefIndex: 12234
{
	// Fields
	[CompilerGenerated]
	private int <ObjId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <PetRaceType>k__BackingField; // 0x24

	// Properties
	public int ObjId { get; set; }
	public byte PetRaceType { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E4FA4 Offset: 0x35E0FA4 VA: 0x35E4FA4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35E4FAC Offset: 0x35E0FAC VA: 0x35E4FAC
	public int get_ObjId() { }

	[CompilerGenerated]
	// RVA: 0x35E4FB4 Offset: 0x35E0FB4 VA: 0x35E4FB4
	public void set_ObjId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35E4FBC Offset: 0x35E0FBC VA: 0x35E4FBC
	public byte get_PetRaceType() { }

	[CompilerGenerated]
	// RVA: 0x35E4FC4 Offset: 0x35E0FC4 VA: 0x35E4FC4
	public void set_PetRaceType(byte value) { }

	// RVA: 0x35E4FCC Offset: 0x35E0FCC VA: 0x35E4FCC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E4FD4 Offset: 0x35E0FD4 VA: 0x35E4FD4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E4FDC Offset: 0x35E0FDC VA: 0x35E4FDC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35E50B8 Offset: 0x35E10B8 VA: 0x35E50B8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
