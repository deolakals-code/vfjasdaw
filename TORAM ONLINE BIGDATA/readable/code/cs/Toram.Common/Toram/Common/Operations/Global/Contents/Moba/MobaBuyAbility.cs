// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents.Moba
public class MobaBuyAbility : OperationRequestBase // TypeDefIndex: 11587
{
	// Fields
	[CompilerGenerated]
	private int <AbilityId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Price>k__BackingField; // 0x24

	// Properties
	public int AbilityId { get; set; }
	public int Price { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x371F88C Offset: 0x371B88C VA: 0x371F88C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x371F894 Offset: 0x371B894 VA: 0x371F894
	public int get_AbilityId() { }

	[CompilerGenerated]
	// RVA: 0x371F89C Offset: 0x371B89C VA: 0x371F89C
	public void set_AbilityId(int value) { }

	[CompilerGenerated]
	// RVA: 0x371F8A4 Offset: 0x371B8A4 VA: 0x371F8A4
	public int get_Price() { }

	[CompilerGenerated]
	// RVA: 0x371F8AC Offset: 0x371B8AC VA: 0x371F8AC
	public void set_Price(int value) { }

	// RVA: 0x371F8B4 Offset: 0x371B8B4 VA: 0x371F8B4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371F8BC Offset: 0x371B8BC VA: 0x371F8BC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x371F8C4 Offset: 0x371B8C4 VA: 0x371F8C4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x371F98C Offset: 0x371B98C VA: 0x371F98C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
