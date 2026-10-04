// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Trades
public class TradeApprovalStartEvent_ : EventSubBase // TypeDefIndex: 12892
{
	// Fields
	[CompilerGenerated]
	private TradeData_ <SenderData>k__BackingField; // 0x20
	[CompilerGenerated]
	private TradeData_ <TargetData>k__BackingField; // 0x28

	// Properties
	public TradeData_ SenderData { get; set; }
	public TradeData_ TargetData { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3670D50 Offset: 0x366CD50 VA: 0x3670D50
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3670D58 Offset: 0x366CD58 VA: 0x3670D58
	public TradeData_ get_SenderData() { }

	[CompilerGenerated]
	// RVA: 0x3670D60 Offset: 0x366CD60 VA: 0x3670D60
	public void set_SenderData(TradeData_ value) { }

	[CompilerGenerated]
	// RVA: 0x3670D68 Offset: 0x366CD68 VA: 0x3670D68
	public TradeData_ get_TargetData() { }

	[CompilerGenerated]
	// RVA: 0x3670D70 Offset: 0x366CD70 VA: 0x3670D70
	public void set_TargetData(TradeData_ value) { }

	// RVA: 0x3670D78 Offset: 0x366CD78 VA: 0x3670D78 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3670D80 Offset: 0x366CD80 VA: 0x3670D80 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3670D88 Offset: 0x366CD88 VA: 0x3670D88 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3670E3C Offset: 0x366CE3C VA: 0x3670E3C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
