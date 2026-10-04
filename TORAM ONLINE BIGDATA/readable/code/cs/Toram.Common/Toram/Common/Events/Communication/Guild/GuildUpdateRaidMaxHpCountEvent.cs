// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild
public class GuildUpdateRaidMaxHpCountEvent : EventSubBase // TypeDefIndex: 12902
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <Element>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <MaxHpCount>k__BackingField; // 0x25

	// Properties
	public int GuildId { get; set; }
	public byte Element { get; set; }
	public byte MaxHpCount { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3672F68 Offset: 0x366EF68 VA: 0x3672F68
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3672F70 Offset: 0x366EF70 VA: 0x3672F70
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x3672F78 Offset: 0x366EF78 VA: 0x3672F78
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3672F80 Offset: 0x366EF80 VA: 0x3672F80
	public byte get_Element() { }

	[CompilerGenerated]
	// RVA: 0x3672F88 Offset: 0x366EF88 VA: 0x3672F88
	public void set_Element(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3672F90 Offset: 0x366EF90 VA: 0x3672F90
	public byte get_MaxHpCount() { }

	[CompilerGenerated]
	// RVA: 0x3672F98 Offset: 0x366EF98 VA: 0x3672F98
	public void set_MaxHpCount(byte value) { }

	// RVA: 0x3672FA0 Offset: 0x366EFA0 VA: 0x3672FA0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3672FA8 Offset: 0x366EFA8 VA: 0x3672FA8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3672FB0 Offset: 0x366EFB0 VA: 0x3672FB0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x36730BC Offset: 0x366F0BC VA: 0x36730BC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
