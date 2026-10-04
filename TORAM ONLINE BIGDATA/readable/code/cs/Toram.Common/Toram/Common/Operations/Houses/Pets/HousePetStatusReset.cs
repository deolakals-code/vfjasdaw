// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HousePetStatusReset : OperationRequestBase // TypeDefIndex: 12325
{
	// Fields
	[CompilerGenerated]
	private long <PetUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x28

	// Properties
	public long PetUuid { get; set; }
	public int Orb { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F3C30 Offset: 0x35EFC30 VA: 0x35F3C30
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35F3C38 Offset: 0x35EFC38 VA: 0x35F3C38
	public long get_PetUuid() { }

	[CompilerGenerated]
	// RVA: 0x35F3C40 Offset: 0x35EFC40 VA: 0x35F3C40
	public void set_PetUuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x35F3C48 Offset: 0x35EFC48 VA: 0x35F3C48
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x35F3C50 Offset: 0x35EFC50 VA: 0x35F3C50
	public void set_Orb(int value) { }

	// RVA: 0x35F3C58 Offset: 0x35EFC58 VA: 0x35F3C58 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F3C60 Offset: 0x35EFC60 VA: 0x35F3C60 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F3C68 Offset: 0x35EFC68 VA: 0x35F3C68 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F3DE0 Offset: 0x35EFDE0 VA: 0x35F3DE0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
