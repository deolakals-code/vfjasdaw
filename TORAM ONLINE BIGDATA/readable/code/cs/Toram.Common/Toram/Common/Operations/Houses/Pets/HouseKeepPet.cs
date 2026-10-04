// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HouseKeepPet : OperationRequestBase // TypeDefIndex: 12310
{
	// Fields
	[CompilerGenerated]
	private int <ItemUuid>k__BackingField; // 0x20

	// Properties
	public int ItemUuid { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F0FC8 Offset: 0x35ECFC8 VA: 0x35F0FC8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35F0FD0 Offset: 0x35ECFD0 VA: 0x35F0FD0
	public int get_ItemUuid() { }

	[CompilerGenerated]
	// RVA: 0x35F0FD8 Offset: 0x35ECFD8 VA: 0x35F0FD8
	public void set_ItemUuid(int value) { }

	// RVA: 0x35F0FE0 Offset: 0x35ECFE0 VA: 0x35F0FE0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F0FE8 Offset: 0x35ECFE8 VA: 0x35F0FE8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F0FF0 Offset: 0x35ECFF0 VA: 0x35F0FF0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F1110 Offset: 0x35ED110 VA: 0x35F1110 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
