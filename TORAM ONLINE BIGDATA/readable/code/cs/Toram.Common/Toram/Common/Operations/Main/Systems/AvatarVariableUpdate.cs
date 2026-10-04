// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Systems
public class AvatarVariableUpdate : PacketBase // TypeDefIndex: 11949
{
	// Fields
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ValueI>k__BackingField; // 0x24

	// Properties
	public byte Type { get; set; }
	public int ValueI { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x376C5F8 Offset: 0x37685F8 VA: 0x376C5F8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x376C600 Offset: 0x3768600 VA: 0x376C600
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x376C608 Offset: 0x3768608 VA: 0x376C608
	public void set_Type(byte value) { }

	[CompilerGenerated]
	// RVA: 0x376C610 Offset: 0x3768610 VA: 0x376C610
	public int get_ValueI() { }

	[CompilerGenerated]
	// RVA: 0x376C618 Offset: 0x3768618 VA: 0x376C618
	public void set_ValueI(int value) { }

	// RVA: 0x376C620 Offset: 0x3768620 VA: 0x376C620 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x376C628 Offset: 0x3768628 VA: 0x376C628 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x376C7CC Offset: 0x37687CC VA: 0x376C7CC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
