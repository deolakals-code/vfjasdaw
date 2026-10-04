// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.GuildStaff
public class RegistletChangeGemCartFlagResponse : OperationResponseBase // TypeDefIndex: 12418
{
	// Fields
	[CompilerGenerated]
	private GemCartData <GemCartData>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 199)]
	public GemCartData GemCartData { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3604420 Offset: 0x3600420 VA: 0x3604420
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3604428 Offset: 0x3600428 VA: 0x3604428
	public GemCartData get_GemCartData() { }

	[CompilerGenerated]
	// RVA: 0x3604430 Offset: 0x3600430 VA: 0x3604430
	public void set_GemCartData(GemCartData value) { }

	// RVA: 0x3604438 Offset: 0x3600438 VA: 0x3604438 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3604440 Offset: 0x3600440 VA: 0x3604440 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3604448 Offset: 0x3600448 VA: 0x3604448 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x36044D0 Offset: 0x36004D0 VA: 0x36044D0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
