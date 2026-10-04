// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class MobPartData : UnityHashBase // TypeDefIndex: 13174
{
	// Fields
	[CompilerGenerated]
	private byte <PartId>k__BackingField; // 0x19
	[CompilerGenerated]
	private int <Hp>k__BackingField; // 0x1C

	// Properties
	[UnityHash(Code = 25)]
	public byte PartId { get; set; }
	[UnityHash(Code = 12)]
	public int Hp { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36BD8B4 Offset: 0x36B98B4 VA: 0x36BD8B4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36BD8BC Offset: 0x36B98BC VA: 0x36BD8BC
	public byte get_PartId() { }

	[CompilerGenerated]
	// RVA: 0x36BD8C4 Offset: 0x36B98C4 VA: 0x36BD8C4
	public void set_PartId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36BD8CC Offset: 0x36B98CC VA: 0x36BD8CC
	public int get_Hp() { }

	[CompilerGenerated]
	// RVA: 0x36BD8D4 Offset: 0x36B98D4 VA: 0x36BD8D4
	public void set_Hp(int value) { }

	// RVA: 0x36BD8DC Offset: 0x36B98DC VA: 0x36BD8DC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36BD8E4 Offset: 0x36B98E4 VA: 0x36BD8E4 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36BDA90 Offset: 0x36B9A90 VA: 0x36BDA90 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
