// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HouseExilePetResponse : OperationResponseBase // TypeDefIndex: 12313
{
	// Fields
	[CompilerGenerated]
	private long <PetUuid>k__BackingField; // 0x20

	// Properties
	public long PetUuid { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F16F4 Offset: 0x35ED6F4 VA: 0x35F16F4
	public void .ctor() { }

	// RVA: 0x35F16FC Offset: 0x35ED6FC VA: 0x35F16FC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35F1704 Offset: 0x35ED704 VA: 0x35F1704
	public long get_PetUuid() { }

	[CompilerGenerated]
	// RVA: 0x35F170C Offset: 0x35ED70C VA: 0x35F170C
	public void set_PetUuid(long value) { }

	// RVA: 0x35F1714 Offset: 0x35ED714 VA: 0x35F1714 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F171C Offset: 0x35ED71C VA: 0x35F171C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F1724 Offset: 0x35ED724 VA: 0x35F1724 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F1844 Offset: 0x35ED844 VA: 0x35F1844 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
