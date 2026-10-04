// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Status
public class SaveRespawnPositionResponse : PacketBase // TypeDefIndex: 12086
{
	// Fields
	[CompilerGenerated]
	private AreaPopData <AreaPop>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 240, IsOptional = True)]
	public AreaPopData AreaPop { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x37845E8 Offset: 0x37805E8 VA: 0x37845E8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37845F0 Offset: 0x37805F0 VA: 0x37845F0
	public AreaPopData get_AreaPop() { }

	[CompilerGenerated]
	// RVA: 0x37845F8 Offset: 0x37805F8 VA: 0x37845F8
	public void set_AreaPop(AreaPopData value) { }

	// RVA: 0x3784600 Offset: 0x3780600 VA: 0x3784600 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3784608 Offset: 0x3780608 VA: 0x3784608 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37847A4 Offset: 0x37807A4 VA: 0x37847A4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
