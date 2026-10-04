// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Cultivation
public class CultivationGetList : OperationRequestBase // TypeDefIndex: 12193
{
	// Fields
	[CompilerGenerated]
	private int <GardenID>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 200)]
	public int GardenID { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35DE94C Offset: 0x35DA94C VA: 0x35DE94C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35DE954 Offset: 0x35DA954 VA: 0x35DE954
	public int get_GardenID() { }

	[CompilerGenerated]
	// RVA: 0x35DE95C Offset: 0x35DA95C VA: 0x35DE95C
	public void set_GardenID(int value) { }

	// RVA: 0x35DE964 Offset: 0x35DA964 VA: 0x35DE964 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35DE96C Offset: 0x35DA96C VA: 0x35DE96C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35DE974 Offset: 0x35DA974 VA: 0x35DE974 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35DEA94 Offset: 0x35DAA94 VA: 0x35DEA94 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
