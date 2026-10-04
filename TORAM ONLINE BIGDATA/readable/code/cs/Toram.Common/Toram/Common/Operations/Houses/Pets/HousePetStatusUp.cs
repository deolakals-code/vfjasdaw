// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HousePetStatusUp : OperationRequestBase // TypeDefIndex: 12327
{
	// Fields
	[CompilerGenerated]
	private long <PetUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private PetStatusData <PetStatusData>k__BackingField; // 0x28

	// Properties
	public long PetUuid { get; set; }
	public PetStatusData PetStatusData { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F4210 Offset: 0x35F0210 VA: 0x35F4210
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35F4218 Offset: 0x35F0218 VA: 0x35F4218
	public long get_PetUuid() { }

	[CompilerGenerated]
	// RVA: 0x35F4220 Offset: 0x35F0220 VA: 0x35F4220
	public void set_PetUuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x35F4228 Offset: 0x35F0228 VA: 0x35F4228
	public PetStatusData get_PetStatusData() { }

	[CompilerGenerated]
	// RVA: 0x35F4230 Offset: 0x35F0230 VA: 0x35F4230
	public void set_PetStatusData(PetStatusData value) { }

	// RVA: 0x35F4238 Offset: 0x35F0238 VA: 0x35F4238
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F4354 Offset: 0x35F0354 VA: 0x35F4354
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F43D0 Offset: 0x35F03D0 VA: 0x35F43D0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F43D8 Offset: 0x35F03D8 VA: 0x35F43D8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F43E0 Offset: 0x35F03E0 VA: 0x35F43E0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F4510 Offset: 0x35F0510 VA: 0x35F4510 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
