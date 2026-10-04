// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HousePetUsePotion : OperationRequestBase // TypeDefIndex: 12338
{
	// Fields
	[CompilerGenerated]
	private long <PetUuid>k__BackingField; // 0x20

	// Properties
	public long PetUuid { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F6E2C Offset: 0x35F2E2C VA: 0x35F6E2C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35F6E34 Offset: 0x35F2E34 VA: 0x35F6E34
	public long get_PetUuid() { }

	[CompilerGenerated]
	// RVA: 0x35F6E3C Offset: 0x35F2E3C VA: 0x35F6E3C
	public void set_PetUuid(long value) { }

	// RVA: 0x35F6E44 Offset: 0x35F2E44 VA: 0x35F6E44 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F6E4C Offset: 0x35F2E4C VA: 0x35F6E4C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F6E54 Offset: 0x35F2E54 VA: 0x35F6E54 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F6F74 Offset: 0x35F2F74 VA: 0x35F6F74 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
