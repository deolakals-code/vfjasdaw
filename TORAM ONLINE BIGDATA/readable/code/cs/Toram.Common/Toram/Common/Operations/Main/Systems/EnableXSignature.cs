// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Systems
public class EnableXSignature : PacketBase // TypeDefIndex: 11953
{
	// Fields
	[CompilerGenerated]
	private string <Cookie>k__BackingField; // 0x20
	[CompilerGenerated]
	private float <Value>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte[] <UCookie>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x38

	// Properties
	[PacketParameter(Code = 2, IsOptional = True)]
	public string Cookie { get; set; }
	[PacketParameter(Code = 195, IsOptional = True)]
	public float Value { get; set; }
	[PacketParameter(Code = 19, IsOptional = True)]
	public byte[] UCookie { get; set; }
	[PacketParameter(Code = 232, IsOptional = True)]
	public byte Type { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x376D478 Offset: 0x3769478 VA: 0x376D478
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x376D480 Offset: 0x3769480 VA: 0x376D480
	public string get_Cookie() { }

	[CompilerGenerated]
	// RVA: 0x376D488 Offset: 0x3769488 VA: 0x376D488
	public void set_Cookie(string value) { }

	[CompilerGenerated]
	// RVA: 0x376D490 Offset: 0x3769490 VA: 0x376D490
	public float get_Value() { }

	[CompilerGenerated]
	// RVA: 0x376D498 Offset: 0x3769498 VA: 0x376D498
	public void set_Value(float value) { }

	[CompilerGenerated]
	// RVA: 0x376D4A0 Offset: 0x37694A0 VA: 0x376D4A0
	public byte[] get_UCookie() { }

	[CompilerGenerated]
	// RVA: 0x376D4A8 Offset: 0x37694A8 VA: 0x376D4A8
	public void set_UCookie(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x376D4B0 Offset: 0x37694B0 VA: 0x376D4B0
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x376D4B8 Offset: 0x37694B8 VA: 0x376D4B8
	public void set_Type(byte value) { }

	// RVA: 0x376D4C0 Offset: 0x37694C0 VA: 0x376D4C0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x376D4C8 Offset: 0x37694C8 VA: 0x376D4C8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x376D790 Offset: 0x3769790 VA: 0x376D790 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
