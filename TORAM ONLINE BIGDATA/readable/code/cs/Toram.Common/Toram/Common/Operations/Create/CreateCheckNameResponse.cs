// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Create
public class CreateCheckNameResponse : PacketBase // TypeDefIndex: 11403
{
	// Fields
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 66)]
	public string UserName { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3701A90 Offset: 0x36FDA90 VA: 0x3701A90
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3701A98 Offset: 0x36FDA98 VA: 0x3701A98
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x3701AA0 Offset: 0x36FDAA0 VA: 0x3701AA0
	public void set_UserName(string value) { }

	// RVA: 0x3701AA8 Offset: 0x36FDAA8 VA: 0x3701AA8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3701AB0 Offset: 0x36FDAB0 VA: 0x3701AB0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3701BD0 Offset: 0x36FDBD0 VA: 0x3701BD0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
