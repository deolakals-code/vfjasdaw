// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.BBS
public class GuildBBSGetMyRequestResponse : OperationResponseBase // TypeDefIndex: 12464
{
	// Fields
	[CompilerGenerated]
	private string <GuildName>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <MasterName>k__BackingField; // 0x28

	// Properties
	public string GuildName { get; set; }
	public string MasterName { get; set; }
	public bool IsSending { get; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x360C2E8 Offset: 0x36082E8 VA: 0x360C2E8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x360C2F0 Offset: 0x36082F0 VA: 0x360C2F0
	public string get_GuildName() { }

	[CompilerGenerated]
	// RVA: 0x360C2F8 Offset: 0x36082F8 VA: 0x360C2F8
	public void set_GuildName(string value) { }

	[CompilerGenerated]
	// RVA: 0x360C300 Offset: 0x3608300 VA: 0x360C300
	public string get_MasterName() { }

	[CompilerGenerated]
	// RVA: 0x360C308 Offset: 0x3608308 VA: 0x360C308
	public void set_MasterName(string value) { }

	// RVA: 0x360C310 Offset: 0x3608310 VA: 0x360C310
	public bool get_IsSending() { }

	// RVA: 0x360C34C Offset: 0x360834C VA: 0x360C34C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x360C354 Offset: 0x3608354 VA: 0x360C354 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x360C35C Offset: 0x360835C VA: 0x360C35C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x360C3EC Offset: 0x36083EC VA: 0x360C3EC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
