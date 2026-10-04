// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms
public class ManaMagicChargeResponse : PacketBase // TypeDefIndex: 11743
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private MaterialData[] <MaterialList>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <MagicGauge>k__BackingField; // 0x30
	[CompilerGenerated]
	private TimeSpan <MagicTimeSapn>k__BackingField; // 0x38

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketClass(Code = 147, IsOptional = True)]
	public MaterialData[] MaterialList { get; set; }
	[PacketClass(Code = 205)]
	public short MagicGauge { get; set; }
	[PacketClass(Code = 172)]
	public TimeSpan MagicTimeSapn { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x37404F0 Offset: 0x373C4F0 VA: 0x37404F0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37404F8 Offset: 0x373C4F8 VA: 0x37404F8
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3740500 Offset: 0x373C500 VA: 0x3740500
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3740508 Offset: 0x373C508 VA: 0x3740508
	public MaterialData[] get_MaterialList() { }

	[CompilerGenerated]
	// RVA: 0x3740510 Offset: 0x373C510 VA: 0x3740510
	public void set_MaterialList(MaterialData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3740518 Offset: 0x373C518 VA: 0x3740518
	public short get_MagicGauge() { }

	[CompilerGenerated]
	// RVA: 0x3740520 Offset: 0x373C520 VA: 0x3740520
	public void set_MagicGauge(short value) { }

	[CompilerGenerated]
	// RVA: 0x3740528 Offset: 0x373C528 VA: 0x3740528
	public TimeSpan get_MagicTimeSapn() { }

	[CompilerGenerated]
	// RVA: 0x3740530 Offset: 0x373C530 VA: 0x3740530
	public void set_MagicTimeSapn(TimeSpan value) { }

	// RVA: 0x3740538 Offset: 0x373C538 VA: 0x3740538 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3740540 Offset: 0x373C540 VA: 0x3740540 Slot: 3
	public override string ToString() { }

	// RVA: 0x37405C4 Offset: 0x373C5C4 VA: 0x37405C4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3740848 Offset: 0x373C848 VA: 0x3740848 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
