// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HousePetStatusResetResponse : OperationResponseBase // TypeDefIndex: 12326
{
	// Fields
	[CompilerGenerated]
	private long <PetUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private PetStatusData <PetStatus>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <PaidOrb>k__BackingField; // 0x34

	// Properties
	public long PetUuid { get; set; }
	public int Orb { get; set; }
	public int PaidOrb { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F3EC4 Offset: 0x35EFEC4 VA: 0x35F3EC4
	public void .ctor() { }

	// RVA: 0x35F3ECC Offset: 0x35EFECC VA: 0x35F3ECC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35F3ED4 Offset: 0x35EFED4 VA: 0x35F3ED4
	public long get_PetUuid() { }

	[CompilerGenerated]
	// RVA: 0x35F3EDC Offset: 0x35EFEDC VA: 0x35F3EDC
	public void set_PetUuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x35F3EE4 Offset: 0x35EFEE4 VA: 0x35F3EE4
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x35F3EEC Offset: 0x35EFEEC VA: 0x35F3EEC
	public void set_Orb(int value) { }

	[CompilerGenerated]
	// RVA: 0x35F3EF4 Offset: 0x35EFEF4 VA: 0x35F3EF4
	public int get_PaidOrb() { }

	[CompilerGenerated]
	// RVA: 0x35F3EFC Offset: 0x35EFEFC VA: 0x35F3EFC
	public void set_PaidOrb(int value) { }

	// RVA: 0x35F3F04 Offset: 0x35EFF04 VA: 0x35F3F04 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F3F0C Offset: 0x35EFF0C VA: 0x35F3F0C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F3F14 Offset: 0x35EFF14 VA: 0x35F3F14 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F4104 Offset: 0x35F0104 VA: 0x35F4104 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
