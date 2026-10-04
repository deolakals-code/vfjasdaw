// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildNameChange : PacketBase // TypeDefIndex: 12409
{
	// Fields
	[CompilerGenerated]
	private string <GuildName>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 220)]
	public string GuildName { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3602FC4 Offset: 0x35FEFC4 VA: 0x3602FC4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3602FCC Offset: 0x35FEFCC VA: 0x3602FCC
	public string get_GuildName() { }

	[CompilerGenerated]
	// RVA: 0x3602FD4 Offset: 0x35FEFD4 VA: 0x3602FD4
	public void set_GuildName(string value) { }

	// RVA: 0x3602FDC Offset: 0x35FEFDC VA: 0x3602FDC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3602FE4 Offset: 0x35FEFE4 VA: 0x3602FE4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3603104 Offset: 0x35FF104 VA: 0x3603104 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
