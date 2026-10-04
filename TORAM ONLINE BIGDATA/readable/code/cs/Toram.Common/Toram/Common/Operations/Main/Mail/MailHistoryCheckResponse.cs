// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Mail
public class MailHistoryCheckResponse : OperationResponseBase // TypeDefIndex: 12024
{
	// Fields
	[CompilerGenerated]
	private MailHistoryData[] <HistoryList>k__BackingField; // 0x20

	// Properties
	public MailHistoryData[] HistoryList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3778D90 Offset: 0x3774D90 VA: 0x3778D90
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3778D98 Offset: 0x3774D98 VA: 0x3778D98
	public MailHistoryData[] get_HistoryList() { }

	[CompilerGenerated]
	// RVA: 0x3778DA0 Offset: 0x3774DA0 VA: 0x3778DA0
	public void set_HistoryList(MailHistoryData[] value) { }

	// RVA: 0x3778DA8 Offset: 0x3774DA8 VA: 0x3778DA8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3778DB0 Offset: 0x3774DB0 VA: 0x3778DB0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3778DB8 Offset: 0x3774DB8 VA: 0x3778DB8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3778EA0 Offset: 0x3774EA0 VA: 0x3778EA0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
