// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Systems
public class PcPurchaseEvent : PacketBase // TypeDefIndex: 12726
{
	// Fields
	[CompilerGenerated]
	private PcPurchaseHistoryData <History>k__BackingField; // 0x20

	// Properties
	public PcPurchaseHistoryData History { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x364BCC4 Offset: 0x3647CC4 VA: 0x364BCC4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x364BCCC Offset: 0x3647CCC VA: 0x364BCCC
	public PcPurchaseHistoryData get_History() { }

	[CompilerGenerated]
	// RVA: 0x364BCD4 Offset: 0x3647CD4 VA: 0x364BCD4
	public void set_History(PcPurchaseHistoryData value) { }

	// RVA: 0x364BCDC Offset: 0x3647CDC VA: 0x364BCDC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x364BCE4 Offset: 0x3647CE4 VA: 0x364BCE4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x364BD9C Offset: 0x3647D9C VA: 0x364BD9C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
