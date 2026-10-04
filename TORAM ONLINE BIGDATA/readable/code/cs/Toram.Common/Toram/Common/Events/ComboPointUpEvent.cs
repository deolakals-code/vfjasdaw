// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events
public class ComboPointUpEvent : PacketBase // TypeDefIndex: 12623
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ComboPoint>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <Exp>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 221)]
	public byte ComboPoint { get; set; }
	[PacketParameter(Code = 222, IsOptional = True)]
	public int Exp { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36336B8 Offset: 0x362F6B8 VA: 0x36336B8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36336C0 Offset: 0x362F6C0 VA: 0x36336C0
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x36336C8 Offset: 0x362F6C8 VA: 0x36336C8
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x36336D0 Offset: 0x362F6D0 VA: 0x36336D0
	public byte get_ComboPoint() { }

	[CompilerGenerated]
	// RVA: 0x36336D8 Offset: 0x362F6D8 VA: 0x36336D8
	public void set_ComboPoint(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36336E0 Offset: 0x362F6E0 VA: 0x36336E0
	public int get_Exp() { }

	[CompilerGenerated]
	// RVA: 0x36336E8 Offset: 0x362F6E8 VA: 0x36336E8
	public void set_Exp(int value) { }

	// RVA: 0x36336F0 Offset: 0x362F6F0 VA: 0x36336F0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36336F8 Offset: 0x362F6F8 VA: 0x36336F8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36338E8 Offset: 0x362F8E8 VA: 0x36338E8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
