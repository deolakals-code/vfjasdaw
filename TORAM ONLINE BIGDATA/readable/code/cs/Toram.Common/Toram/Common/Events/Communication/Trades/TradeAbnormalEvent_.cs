// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Trades
public class TradeAbnormalEvent_ : EventSubBase // TypeDefIndex: 12891
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x20

	// Properties
	public int ArchetypeId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3670B68 Offset: 0x366CB68 VA: 0x3670B68
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3670B70 Offset: 0x366CB70 VA: 0x3670B70
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x3670B78 Offset: 0x366CB78 VA: 0x3670B78
	public void set_ArchetypeId(int value) { }

	// RVA: 0x3670B80 Offset: 0x366CB80 VA: 0x3670B80 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3670B88 Offset: 0x366CB88 VA: 0x3670B88 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3670B90 Offset: 0x366CB90 VA: 0x3670B90 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3670C30 Offset: 0x366CC30 VA: 0x3670C30 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
