// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Systems
public class AreaBonusResultResponse : PacketBase // TypeDefIndex: 11946
{
	// Fields
	[CompilerGenerated]
	private AreaPopData <AreaPop>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 240, IsOptional = True)]
	public AreaPopData AreaPop { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x376BF38 Offset: 0x3767F38 VA: 0x376BF38
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x376BF40 Offset: 0x3767F40 VA: 0x376BF40
	public AreaPopData get_AreaPop() { }

	[CompilerGenerated]
	// RVA: 0x376BF48 Offset: 0x3767F48 VA: 0x376BF48
	public void set_AreaPop(AreaPopData value) { }

	// RVA: 0x376BF50 Offset: 0x3767F50 VA: 0x376BF50 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x376BF58 Offset: 0x3767F58 VA: 0x376BF58 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x376C0F4 Offset: 0x37680F4 VA: 0x376C0F4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
