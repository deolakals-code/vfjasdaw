// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Create
public class CreateAvatarStartResponse : PacketBase // TypeDefIndex: 11397
{
	// Fields
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 66, IsOptional = True)]
	public string UserName { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3700C10 Offset: 0x36FCC10 VA: 0x3700C10
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3700C18 Offset: 0x36FCC18 VA: 0x3700C18
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x3700C20 Offset: 0x36FCC20 VA: 0x3700C20
	public void set_UserName(string value) { }

	// RVA: 0x3700C28 Offset: 0x36FCC28 VA: 0x3700C28 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3700C30 Offset: 0x36FCC30 VA: 0x3700C30 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3700D7C Offset: 0x36FCD7C VA: 0x3700D7C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
