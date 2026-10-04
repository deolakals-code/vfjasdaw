// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.BBS
public class GuildBBSGetRegisterDataResponse : OperationResponseBase // TypeDefIndex: 12453
{
	// Fields
	[CompilerGenerated]
	private GuildBBSSendData <RegisterData>k__BackingField; // 0x20

	// Properties
	public GuildBBSSendData RegisterData { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x360A7CC Offset: 0x36067CC VA: 0x360A7CC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x360A7D4 Offset: 0x36067D4 VA: 0x360A7D4
	public GuildBBSSendData get_RegisterData() { }

	[CompilerGenerated]
	// RVA: 0x360A7DC Offset: 0x36067DC VA: 0x360A7DC
	public void set_RegisterData(GuildBBSSendData value) { }

	// RVA: 0x360A7E4 Offset: 0x36067E4 VA: 0x360A7E4
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x360A900 Offset: 0x3606900 VA: 0x360A900
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x360A97C Offset: 0x360697C VA: 0x360A97C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x360A984 Offset: 0x3606984 VA: 0x360A984 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x360A98C Offset: 0x360698C VA: 0x360A98C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x360A9C0 Offset: 0x36069C0 VA: 0x360A9C0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
