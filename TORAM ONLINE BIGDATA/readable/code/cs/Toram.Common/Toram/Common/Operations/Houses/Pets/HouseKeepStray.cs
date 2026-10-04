// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HouseKeepStray : OperationRequestBase // TypeDefIndex: 12314
{
	// Fields
	[CompilerGenerated]
	private int <MonsterUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ModelId>k__BackingField; // 0x24

	// Properties
	public int MonsterUuid { get; set; }
	public int ModelId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F18E4 Offset: 0x35ED8E4 VA: 0x35F18E4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35F18EC Offset: 0x35ED8EC VA: 0x35F18EC
	public int get_MonsterUuid() { }

	[CompilerGenerated]
	// RVA: 0x35F18F4 Offset: 0x35ED8F4 VA: 0x35F18F4
	public void set_MonsterUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x35F18FC Offset: 0x35ED8FC VA: 0x35F18FC
	public int get_ModelId() { }

	[CompilerGenerated]
	// RVA: 0x35F1904 Offset: 0x35ED904 VA: 0x35F1904
	public void set_ModelId(int value) { }

	// RVA: 0x35F190C Offset: 0x35ED90C VA: 0x35F190C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F1914 Offset: 0x35ED914 VA: 0x35F1914 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F191C Offset: 0x35ED91C VA: 0x35F191C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F1A88 Offset: 0x35EDA88 VA: 0x35F1A88 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
