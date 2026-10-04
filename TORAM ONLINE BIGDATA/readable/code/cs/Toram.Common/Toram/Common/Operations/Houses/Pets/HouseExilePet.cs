// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HouseExilePet : OperationRequestBase // TypeDefIndex: 12312
{
	// Fields
	[CompilerGenerated]
	private long <PetUuid>k__BackingField; // 0x20

	// Properties
	public long PetUuid { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F150C Offset: 0x35ED50C VA: 0x35F150C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35F1514 Offset: 0x35ED514 VA: 0x35F1514
	public long get_PetUuid() { }

	[CompilerGenerated]
	// RVA: 0x35F151C Offset: 0x35ED51C VA: 0x35F151C
	public void set_PetUuid(long value) { }

	// RVA: 0x35F1524 Offset: 0x35ED524 VA: 0x35F1524 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F152C Offset: 0x35ED52C VA: 0x35F152C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F1534 Offset: 0x35ED534 VA: 0x35F1534 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F1654 Offset: 0x35ED654 VA: 0x35F1654 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
