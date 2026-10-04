// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents.Moba
public class MobaSellAbilityResponse : OperationResponseBase // TypeDefIndex: 11614
{
	// Fields
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <AbilityId>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x28

	// Properties
	public short ReturnCode { get; set; }
	public int AbilityId { get; set; }
	public int Gold { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x372544C Offset: 0x372144C VA: 0x372544C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3725454 Offset: 0x3721454 VA: 0x3725454
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x372545C Offset: 0x372145C VA: 0x372545C
	public void set_ReturnCode(short value) { }

	[CompilerGenerated]
	// RVA: 0x3725464 Offset: 0x3721464 VA: 0x3725464
	public int get_AbilityId() { }

	[CompilerGenerated]
	// RVA: 0x372546C Offset: 0x372146C VA: 0x372546C
	public void set_AbilityId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3725474 Offset: 0x3721474 VA: 0x3725474
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x372547C Offset: 0x372147C VA: 0x372547C
	public void set_Gold(int value) { }

	// RVA: 0x3725484 Offset: 0x3721484 VA: 0x3725484 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x372548C Offset: 0x372148C VA: 0x372548C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3725494 Offset: 0x3721494 VA: 0x3725494 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x37255A0 Offset: 0x37215A0 VA: 0x37255A0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
