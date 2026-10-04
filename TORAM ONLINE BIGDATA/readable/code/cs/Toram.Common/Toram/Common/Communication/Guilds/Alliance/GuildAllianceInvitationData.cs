// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication.Guilds.Alliance
public class GuildAllianceInvitationData : BinaryBase // TypeDefIndex: 13040
{
	// Fields
	[CompilerGenerated]
	private int <AllianceId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private string <GuildName>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <MasterName>k__BackingField; // 0x28
	[CompilerGenerated]
	private DateTime <InviteDate>k__BackingField; // 0x30

	// Properties
	public int AllianceId { get; set; }
	public string GuildName { get; set; }
	public string MasterName { get; set; }
	public DateTime InviteDate { get; set; }

	// Methods

	// RVA: 0x3694A58 Offset: 0x3690A58 VA: 0x3694A58
	public void .ctor() { }

	// RVA: 0x3694A60 Offset: 0x3690A60 VA: 0x3694A60
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x3694A68 Offset: 0x3690A68 VA: 0x3694A68
	public int get_AllianceId() { }

	[CompilerGenerated]
	// RVA: 0x3694A70 Offset: 0x3690A70 VA: 0x3694A70
	public void set_AllianceId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3694A78 Offset: 0x3690A78 VA: 0x3694A78
	public string get_GuildName() { }

	[CompilerGenerated]
	// RVA: 0x3694A80 Offset: 0x3690A80 VA: 0x3694A80
	public void set_GuildName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3694A88 Offset: 0x3690A88 VA: 0x3694A88
	public string get_MasterName() { }

	[CompilerGenerated]
	// RVA: 0x3694A90 Offset: 0x3690A90 VA: 0x3694A90
	public void set_MasterName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3694A98 Offset: 0x3690A98 VA: 0x3694A98
	public DateTime get_InviteDate() { }

	[CompilerGenerated]
	// RVA: 0x3694AA0 Offset: 0x3690AA0 VA: 0x3694AA0
	public void set_InviteDate(DateTime value) { }

	// RVA: 0x3694AA8 Offset: 0x3690AA8 VA: 0x3694AA8 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x3694B04 Offset: 0x3690B04 VA: 0x3694B04 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
