// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.BBS
public class GuildBBSGetRequestersListResponse : OperationResponseBase // TypeDefIndex: 12448
{
	// Fields
	[CompilerGenerated]
	private bool <IsCompress>k__BackingField; // 0x20
	[CompilerGenerated]
	private GuildBBSRequesterData[] <RequestersList>k__BackingField; // 0x28

	// Properties
	public bool IsCompress { get; set; }
	public GuildBBSRequesterData[] RequestersList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x360961C Offset: 0x360561C VA: 0x360961C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3609624 Offset: 0x3605624 VA: 0x3609624
	public bool get_IsCompress() { }

	[CompilerGenerated]
	// RVA: 0x360962C Offset: 0x360562C VA: 0x360962C
	public void set_IsCompress(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3609638 Offset: 0x3605638 VA: 0x3609638
	public GuildBBSRequesterData[] get_RequestersList() { }

	[CompilerGenerated]
	// RVA: 0x3609640 Offset: 0x3605640 VA: 0x3609640
	public void set_RequestersList(GuildBBSRequesterData[] value) { }

	// RVA: 0x3609648 Offset: 0x3605648 VA: 0x3609648
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x36097DC Offset: 0x36057DC VA: 0x36097DC
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x360992C Offset: 0x360592C VA: 0x360992C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3609934 Offset: 0x3605934 VA: 0x3609934 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x360993C Offset: 0x360593C VA: 0x360993C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3609970 Offset: 0x3605970 VA: 0x3609970 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
