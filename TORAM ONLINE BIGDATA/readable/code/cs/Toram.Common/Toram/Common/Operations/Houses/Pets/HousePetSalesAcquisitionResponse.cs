// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HousePetSalesAcquisitionResponse : OperationResponseBase // TypeDefIndex: 12301
{
	// Fields
	[CompilerGenerated]
	private int <Sales>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x24

	// Properties
	public int Sales { get; set; }
	public int Gold { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35EEF34 Offset: 0x35EAF34 VA: 0x35EEF34
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35EEF3C Offset: 0x35EAF3C VA: 0x35EEF3C
	public int get_Sales() { }

	[CompilerGenerated]
	// RVA: 0x35EEF44 Offset: 0x35EAF44 VA: 0x35EEF44
	public void set_Sales(int value) { }

	[CompilerGenerated]
	// RVA: 0x35EEF4C Offset: 0x35EAF4C VA: 0x35EEF4C
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x35EEF54 Offset: 0x35EAF54 VA: 0x35EEF54
	public void set_Gold(int value) { }

	// RVA: 0x35EEF5C Offset: 0x35EAF5C VA: 0x35EEF5C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35EEF64 Offset: 0x35EAF64 VA: 0x35EEF64 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35EEF6C Offset: 0x35EAF6C VA: 0x35EEF6C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35EF034 Offset: 0x35EB034 VA: 0x35EF034 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
