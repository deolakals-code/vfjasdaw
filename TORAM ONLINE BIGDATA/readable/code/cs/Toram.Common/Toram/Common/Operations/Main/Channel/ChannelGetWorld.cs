// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Channel
public class ChannelGetWorld : PacketBase // TypeDefIndex: 12043
{
	// Fields
	[CompilerGenerated]
	private byte <AccountWorldType>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <CustomerPlatform>k__BackingField; // 0x22

	// Properties
	public byte AccountWorldType { get; set; }
	public short CustomerPlatform { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x377C804 Offset: 0x3778804 VA: 0x377C804
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x377C80C Offset: 0x377880C VA: 0x377C80C
	public byte get_AccountWorldType() { }

	[CompilerGenerated]
	// RVA: 0x377C814 Offset: 0x3778814 VA: 0x377C814
	public void set_AccountWorldType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x377C81C Offset: 0x377881C VA: 0x377C81C
	public short get_CustomerPlatform() { }

	[CompilerGenerated]
	// RVA: 0x377C824 Offset: 0x3778824 VA: 0x377C824
	public void set_CustomerPlatform(short value) { }

	// RVA: 0x377C82C Offset: 0x377882C VA: 0x377C82C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x377C834 Offset: 0x3778834 VA: 0x377C834 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x377C9F8 Offset: 0x37789F8 VA: 0x377C9F8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
