// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Status
public class DeterminePersonality : PacketBase // TypeDefIndex: 12077
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <Personality>k__BackingField; // 0x24

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 168)]
	public byte Personality { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3782B0C Offset: 0x377EB0C VA: 0x3782B0C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3782B14 Offset: 0x377EB14 VA: 0x3782B14
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3782B1C Offset: 0x377EB1C VA: 0x3782B1C
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3782B24 Offset: 0x377EB24 VA: 0x3782B24
	public byte get_Personality() { }

	[CompilerGenerated]
	// RVA: 0x3782B2C Offset: 0x377EB2C VA: 0x3782B2C
	public void set_Personality(byte value) { }

	// RVA: 0x3782B34 Offset: 0x377EB34 VA: 0x3782B34 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3782B3C Offset: 0x377EB3C VA: 0x3782B3C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3782CB4 Offset: 0x377ECB4 VA: 0x3782CB4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
