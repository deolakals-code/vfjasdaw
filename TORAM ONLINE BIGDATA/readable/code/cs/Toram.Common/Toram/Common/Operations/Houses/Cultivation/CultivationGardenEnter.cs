// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Cultivation
public class CultivationGardenEnter : OperationRequestBase // TypeDefIndex: 12195
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

	// RVA: 0x35DEE80 Offset: 0x35DAE80 VA: 0x35DEE80
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35DEE88 Offset: 0x35DAE88 VA: 0x35DEE88
	public int get_GardenID() { }

	[CompilerGenerated]
	// RVA: 0x35DEE90 Offset: 0x35DAE90 VA: 0x35DEE90
	public void set_GardenID(int value) { }

	// RVA: 0x35DEE98 Offset: 0x35DAE98 VA: 0x35DEE98 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35DEEA0 Offset: 0x35DAEA0 VA: 0x35DEEA0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35DEEA8 Offset: 0x35DAEA8 VA: 0x35DEEA8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35DEFC8 Offset: 0x35DAFC8 VA: 0x35DEFC8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
