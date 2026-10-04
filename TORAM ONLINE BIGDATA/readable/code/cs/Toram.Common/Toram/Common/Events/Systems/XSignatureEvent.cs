// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Systems
public class XSignatureEvent : PacketBase // TypeDefIndex: 12735
{
	// Fields
	[CompilerGenerated]
	private string <Seed>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte[] <USeed>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 2, IsOptional = True)]
	public string Seed { get; set; }
	[PacketParameter(Code = 96, IsOptional = True)]
	public byte[] USeed { get; set; }
	[PacketParameter(Code = 232, IsOptional = True)]
	public byte Type { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x364D5E4 Offset: 0x36495E4 VA: 0x364D5E4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x364D5EC Offset: 0x36495EC VA: 0x364D5EC
	public string get_Seed() { }

	[CompilerGenerated]
	// RVA: 0x364D5F4 Offset: 0x36495F4 VA: 0x364D5F4
	public void set_Seed(string value) { }

	[CompilerGenerated]
	// RVA: 0x364D5FC Offset: 0x36495FC VA: 0x364D5FC
	public byte[] get_USeed() { }

	[CompilerGenerated]
	// RVA: 0x364D604 Offset: 0x3649604 VA: 0x364D604
	public void set_USeed(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x364D60C Offset: 0x364960C VA: 0x364D60C
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x364D614 Offset: 0x3649614 VA: 0x364D614
	public void set_Type(byte value) { }

	// RVA: 0x364D61C Offset: 0x364961C VA: 0x364D61C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x364D624 Offset: 0x3649624 VA: 0x364D624 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x364D874 Offset: 0x3649874 VA: 0x364D874 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
