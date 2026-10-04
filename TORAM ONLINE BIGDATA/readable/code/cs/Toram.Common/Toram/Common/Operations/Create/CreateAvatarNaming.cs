// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Create
public class CreateAvatarNaming : PacketBase // TypeDefIndex: 11395
{
	// Fields
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x20

	// Properties
	public string UserName { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3700818 Offset: 0x36FC818 VA: 0x3700818
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3700820 Offset: 0x36FC820 VA: 0x3700820
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x3700828 Offset: 0x36FC828 VA: 0x3700828
	public void set_UserName(string value) { }

	// RVA: 0x3700830 Offset: 0x36FC830 VA: 0x3700830 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3700838 Offset: 0x36FC838 VA: 0x3700838 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3700958 Offset: 0x36FC958 VA: 0x3700958 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
