// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Status
public class DeterminePersonalityResponse : PacketBase // TypeDefIndex: 12078
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

	// RVA: 0x3782DC4 Offset: 0x377EDC4 VA: 0x3782DC4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3782DCC Offset: 0x377EDCC VA: 0x3782DCC
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3782DD4 Offset: 0x377EDD4 VA: 0x3782DD4
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3782DDC Offset: 0x377EDDC VA: 0x3782DDC
	public byte get_Personality() { }

	[CompilerGenerated]
	// RVA: 0x3782DE4 Offset: 0x377EDE4 VA: 0x3782DE4
	public void set_Personality(byte value) { }

	// RVA: 0x3782DEC Offset: 0x377EDEC VA: 0x3782DEC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3782DF4 Offset: 0x377EDF4 VA: 0x3782DF4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3782F6C Offset: 0x377EF6C VA: 0x3782F6C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
