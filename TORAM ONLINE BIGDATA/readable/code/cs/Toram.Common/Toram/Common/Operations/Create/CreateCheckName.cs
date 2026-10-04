// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Create
public class CreateCheckName : PacketBase // TypeDefIndex: 11405
{
	// Fields
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 66)]
	public string UserName { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3701CF4 Offset: 0x36FDCF4 VA: 0x3701CF4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3701CFC Offset: 0x36FDCFC VA: 0x3701CFC
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x3701D04 Offset: 0x36FDD04 VA: 0x3701D04
	public void set_UserName(string value) { }

	// RVA: 0x3701D0C Offset: 0x36FDD0C VA: 0x3701D0C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3701D14 Offset: 0x36FDD14 VA: 0x3701D14 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3701E34 Offset: 0x36FDE34 VA: 0x3701E34 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
