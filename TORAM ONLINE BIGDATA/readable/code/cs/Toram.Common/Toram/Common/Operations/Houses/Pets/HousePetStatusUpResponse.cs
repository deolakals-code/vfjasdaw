// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HousePetStatusUpResponse : OperationResponseBase // TypeDefIndex: 12328
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

	// RVA: 0x35F45BC Offset: 0x35F05BC VA: 0x35F45BC
	public void .ctor() { }

	// RVA: 0x35F45C4 Offset: 0x35F05C4 VA: 0x35F45C4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35F45CC Offset: 0x35F05CC VA: 0x35F45CC
	public long get_PetUuid() { }

	[CompilerGenerated]
	// RVA: 0x35F45D4 Offset: 0x35F05D4 VA: 0x35F45D4
	public void set_PetUuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x35F45DC Offset: 0x35F05DC VA: 0x35F45DC
	public PetStatusData get_PetStatusData() { }

	[CompilerGenerated]
	// RVA: 0x35F45E4 Offset: 0x35F05E4 VA: 0x35F45E4
	public void set_PetStatusData(PetStatusData value) { }

	// RVA: 0x35F45EC Offset: 0x35F05EC VA: 0x35F45EC
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F4708 Offset: 0x35F0708 VA: 0x35F4708
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F4784 Offset: 0x35F0784 VA: 0x35F4784 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F478C Offset: 0x35F078C VA: 0x35F478C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F4794 Offset: 0x35F0794 VA: 0x35F4794 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F48C4 Offset: 0x35F08C4 VA: 0x35F48C4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
