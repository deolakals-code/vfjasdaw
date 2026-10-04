// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents.Moba
public class MobaBuyAbilityResponse : OperationResponseBase // TypeDefIndex: 11588
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

	// RVA: 0x371FAF8 Offset: 0x371BAF8 VA: 0x371FAF8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x371FB00 Offset: 0x371BB00 VA: 0x371FB00
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x371FB08 Offset: 0x371BB08 VA: 0x371FB08
	public void set_ReturnCode(short value) { }

	[CompilerGenerated]
	// RVA: 0x371FB10 Offset: 0x371BB10 VA: 0x371FB10
	public int get_AbilityId() { }

	[CompilerGenerated]
	// RVA: 0x371FB18 Offset: 0x371BB18 VA: 0x371FB18
	public void set_AbilityId(int value) { }

	[CompilerGenerated]
	// RVA: 0x371FB20 Offset: 0x371BB20 VA: 0x371FB20
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x371FB28 Offset: 0x371BB28 VA: 0x371FB28
	public void set_Gold(int value) { }

	// RVA: 0x371FB30 Offset: 0x371BB30 VA: 0x371FB30 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371FB38 Offset: 0x371BB38 VA: 0x371FB38 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x371FB40 Offset: 0x371BB40 VA: 0x371FB40 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x371FC4C Offset: 0x371BC4C VA: 0x371FC4C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
