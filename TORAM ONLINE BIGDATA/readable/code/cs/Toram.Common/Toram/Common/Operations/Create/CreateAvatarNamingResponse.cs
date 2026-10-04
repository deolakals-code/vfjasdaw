// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Create
public class CreateAvatarNamingResponse : PacketBase // TypeDefIndex: 11396
{
	// Fields
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x20

	// Properties
	public string UserName { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x37009FC Offset: 0x36FC9FC VA: 0x37009FC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3700A04 Offset: 0x36FCA04 VA: 0x3700A04
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x3700A0C Offset: 0x36FCA0C VA: 0x3700A0C
	public void set_UserName(string value) { }

	// RVA: 0x3700A14 Offset: 0x36FCA14 VA: 0x3700A14 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3700A1C Offset: 0x36FCA1C VA: 0x3700A1C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3700B68 Offset: 0x36FCB68 VA: 0x3700B68 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
