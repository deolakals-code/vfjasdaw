// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Create
public class CreateNewAvatarResponse : PacketBase // TypeDefIndex: 11407
{
	// Fields
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 66)]
	public string UserName { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x37022C0 Offset: 0x36FE2C0 VA: 0x37022C0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37022C8 Offset: 0x36FE2C8 VA: 0x37022C8
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x37022D0 Offset: 0x36FE2D0 VA: 0x37022D0
	public void set_UserName(string value) { }

	// RVA: 0x37022D8 Offset: 0x36FE2D8 VA: 0x37022D8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37022E0 Offset: 0x36FE2E0 VA: 0x37022E0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3702400 Offset: 0x36FE400 VA: 0x3702400 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
