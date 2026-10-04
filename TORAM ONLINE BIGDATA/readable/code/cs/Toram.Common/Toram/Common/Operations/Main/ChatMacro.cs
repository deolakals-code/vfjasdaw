// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main
public class ChatMacro : PacketBase // TypeDefIndex: 11895
{
	// Fields
	[CompilerGenerated]
	private byte <MacroType>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ChannelType>k__BackingField; // 0x21
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x24
	[CompilerGenerated]
	private DiceMacroElement[] <DiceMacroElements>k__BackingField; // 0x28

	// Properties
	public byte MacroType { get; set; }
	public byte ChannelType { get; set; }
	public int TargetId { get; set; }
	public DiceMacroElement[] DiceMacroElements { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x376023C Offset: 0x375C23C VA: 0x376023C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3760244 Offset: 0x375C244 VA: 0x3760244
	public byte get_MacroType() { }

	[CompilerGenerated]
	// RVA: 0x376024C Offset: 0x375C24C VA: 0x376024C
	public void set_MacroType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3760254 Offset: 0x375C254 VA: 0x3760254
	public byte get_ChannelType() { }

	[CompilerGenerated]
	// RVA: 0x376025C Offset: 0x375C25C VA: 0x376025C
	public void set_ChannelType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3760264 Offset: 0x375C264 VA: 0x3760264
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x376026C Offset: 0x375C26C VA: 0x376026C
	public void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3760274 Offset: 0x375C274 VA: 0x3760274
	public DiceMacroElement[] get_DiceMacroElements() { }

	[CompilerGenerated]
	// RVA: 0x376027C Offset: 0x375C27C VA: 0x376027C
	public void set_DiceMacroElements(DiceMacroElement[] value) { }

	// RVA: 0x3760284 Offset: 0x375C284 VA: 0x3760284 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x376028C Offset: 0x375C28C VA: 0x376028C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3760414 Offset: 0x375C414 VA: 0x3760414 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
