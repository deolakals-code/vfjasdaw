// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Status
public class SystemRespawnResponse : PacketBase // TypeDefIndex: 12090
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Hp>k__BackingField; // 0x24
	[CompilerGenerated]
	private short <Mp>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <ExHp>k__BackingField; // 0x2C
	[CompilerGenerated]
	private short <ExMp>k__BackingField; // 0x30

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 25, IsOptional = True)]
	public int Hp { get; set; }
	[PacketParameter(Code = 26, IsOptional = True)]
	public short Mp { get; set; }
	[PacketParameter(Code = 202, IsOptional = True)]
	public int ExHp { get; set; }
	[PacketParameter(Code = 203, IsOptional = True)]
	public short ExMp { get; set; }

	// Methods

	// RVA: 0x3785498 Offset: 0x3781498 VA: 0x3785498
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x37854A0 Offset: 0x37814A0 VA: 0x37854A0 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x37854A8 Offset: 0x37814A8 VA: 0x37854A8
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x37854B0 Offset: 0x37814B0 VA: 0x37854B0
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x37854B8 Offset: 0x37814B8 VA: 0x37854B8
	public int get_Hp() { }

	[CompilerGenerated]
	// RVA: 0x37854C0 Offset: 0x37814C0 VA: 0x37854C0
	public void set_Hp(int value) { }

	[CompilerGenerated]
	// RVA: 0x37854C8 Offset: 0x37814C8 VA: 0x37854C8
	public short get_Mp() { }

	[CompilerGenerated]
	// RVA: 0x37854D0 Offset: 0x37814D0 VA: 0x37854D0
	public void set_Mp(short value) { }

	[CompilerGenerated]
	// RVA: 0x37854D8 Offset: 0x37814D8 VA: 0x37854D8
	public void set_ExHp(int value) { }

	[CompilerGenerated]
	// RVA: 0x37854E0 Offset: 0x37814E0 VA: 0x37854E0
	public int get_ExHp() { }

	[CompilerGenerated]
	// RVA: 0x37854E8 Offset: 0x37814E8 VA: 0x37854E8
	public void set_ExMp(short value) { }

	[CompilerGenerated]
	// RVA: 0x37854F0 Offset: 0x37814F0 VA: 0x37854F0
	public short get_ExMp() { }

	// RVA: 0x37854F8 Offset: 0x37814F8 VA: 0x37854F8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37857C0 Offset: 0x37817C0 VA: 0x37857C0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
