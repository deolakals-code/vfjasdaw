// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.BBS
public class GuildBBSUpdateRegisterDataResponse : OperationResponseBase // TypeDefIndex: 12451
{
	// Fields
	[CompilerGenerated]
	private GuildBBSSendData <RegisterData>k__BackingField; // 0x20

	// Properties
	public GuildBBSSendData RegisterData { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3609E78 Offset: 0x3605E78 VA: 0x3609E78
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3609E80 Offset: 0x3605E80 VA: 0x3609E80
	public GuildBBSSendData get_RegisterData() { }

	[CompilerGenerated]
	// RVA: 0x3609E88 Offset: 0x3605E88 VA: 0x3609E88
	public void set_RegisterData(GuildBBSSendData value) { }

	// RVA: 0x3609E90 Offset: 0x3605E90 VA: 0x3609E90
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3609FAC Offset: 0x3605FAC VA: 0x3609FAC
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x360A028 Offset: 0x3606028 VA: 0x360A028 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x360A030 Offset: 0x3606030 VA: 0x360A030 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x360A038 Offset: 0x3606038 VA: 0x360A038 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x360A06C Offset: 0x360606C VA: 0x360A06C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
