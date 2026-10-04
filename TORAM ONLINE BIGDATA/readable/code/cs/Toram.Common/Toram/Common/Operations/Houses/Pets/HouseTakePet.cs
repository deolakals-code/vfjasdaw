// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HouseTakePet : OperationRequestBase // TypeDefIndex: 12332
{
	// Fields
	[CompilerGenerated]
	private long <PetUuid>k__BackingField; // 0x20

	// Properties
	public long PetUuid { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F5798 Offset: 0x35F1798 VA: 0x35F5798
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35F57A0 Offset: 0x35F17A0 VA: 0x35F57A0
	public long get_PetUuid() { }

	[CompilerGenerated]
	// RVA: 0x35F57A8 Offset: 0x35F17A8 VA: 0x35F57A8
	public void set_PetUuid(long value) { }

	// RVA: 0x35F57B0 Offset: 0x35F17B0 VA: 0x35F57B0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F57B8 Offset: 0x35F17B8 VA: 0x35F57B8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F57C0 Offset: 0x35F17C0 VA: 0x35F57C0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F58E0 Offset: 0x35F18E0 VA: 0x35F58E0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
