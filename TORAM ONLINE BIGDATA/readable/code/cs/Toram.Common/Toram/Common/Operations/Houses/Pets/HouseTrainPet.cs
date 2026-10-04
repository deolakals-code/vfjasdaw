// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HouseTrainPet : OperationRequestBase // TypeDefIndex: 12336
{
	// Fields
	[CompilerGenerated]
	private long <PetUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <TrainingType>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x2C

	// Properties
	public long PetUuid { get; set; }
	public byte TrainingType { get; set; }
	public int Orb { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F6348 Offset: 0x35F2348 VA: 0x35F6348
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35F6350 Offset: 0x35F2350 VA: 0x35F6350
	public long get_PetUuid() { }

	[CompilerGenerated]
	// RVA: 0x35F6358 Offset: 0x35F2358 VA: 0x35F6358
	public void set_PetUuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x35F6360 Offset: 0x35F2360 VA: 0x35F6360
	public byte get_TrainingType() { }

	[CompilerGenerated]
	// RVA: 0x35F6368 Offset: 0x35F2368 VA: 0x35F6368
	public void set_TrainingType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35F6370 Offset: 0x35F2370 VA: 0x35F6370
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x35F6378 Offset: 0x35F2378 VA: 0x35F6378
	public void set_Orb(int value) { }

	// RVA: 0x35F6380 Offset: 0x35F2380 VA: 0x35F6380 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F6388 Offset: 0x35F2388 VA: 0x35F6388 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F6390 Offset: 0x35F2390 VA: 0x35F6390 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F658C Offset: 0x35F258C VA: 0x35F658C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
