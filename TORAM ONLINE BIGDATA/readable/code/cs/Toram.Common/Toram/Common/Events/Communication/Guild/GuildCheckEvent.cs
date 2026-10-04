// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild
public class GuildCheckEvent : EventSubBase // TypeDefIndex: 12901
{
	// Fields
	[CompilerGenerated]
	private GuildLoginData <GuildLogin>k__BackingField; // 0x20
	[CompilerGenerated]
	private GuildReserveData[] <GuildReserve>k__BackingField; // 0x28

	// Properties
	public GuildLoginData GuildLogin { get; set; }
	public GuildReserveData[] GuildReserve { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3672C1C Offset: 0x366EC1C VA: 0x3672C1C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3672C24 Offset: 0x366EC24 VA: 0x3672C24
	public GuildLoginData get_GuildLogin() { }

	[CompilerGenerated]
	// RVA: 0x3672C2C Offset: 0x366EC2C VA: 0x3672C2C
	public void set_GuildLogin(GuildLoginData value) { }

	[CompilerGenerated]
	// RVA: 0x3672C34 Offset: 0x366EC34 VA: 0x3672C34
	public GuildReserveData[] get_GuildReserve() { }

	[CompilerGenerated]
	// RVA: 0x3672C3C Offset: 0x366EC3C VA: 0x3672C3C
	public void set_GuildReserve(GuildReserveData[] value) { }

	// RVA: 0x3672C44 Offset: 0x366EC44 VA: 0x3672C44 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3672C4C Offset: 0x366EC4C VA: 0x3672C4C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3672C54 Offset: 0x366EC54 VA: 0x3672C54 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3672D18 Offset: 0x366ED18 VA: 0x3672D18 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
