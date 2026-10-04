// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class DungeonTrapData : UnityHashBase // TypeDefIndex: 13155
{
	// Fields
	[CompilerGenerated]
	private byte <TrapId>k__BackingField; // 0x19
	[CompilerGenerated]
	private short <Hp>k__BackingField; // 0x1A
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x1C

	// Properties
	[UnityHash(Code = 23)]
	public byte TrapId { get; set; }
	[UnityHash(Code = 12)]
	public short Hp { get; set; }
	[UnityHash(Code = 46)]
	public byte Type { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36B7218 Offset: 0x36B3218 VA: 0x36B7218
	public void .ctor() { }

	// RVA: 0x36B7220 Offset: 0x36B3220 VA: 0x36B7220
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36B7228 Offset: 0x36B3228 VA: 0x36B7228
	public byte get_TrapId() { }

	[CompilerGenerated]
	// RVA: 0x36B7230 Offset: 0x36B3230 VA: 0x36B7230
	public void set_TrapId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36B7238 Offset: 0x36B3238 VA: 0x36B7238
	public short get_Hp() { }

	[CompilerGenerated]
	// RVA: 0x36B7240 Offset: 0x36B3240 VA: 0x36B7240
	public void set_Hp(short value) { }

	[CompilerGenerated]
	// RVA: 0x36B7248 Offset: 0x36B3248 VA: 0x36B7248
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x36B7250 Offset: 0x36B3250 VA: 0x36B7250
	public void set_Type(byte value) { }

	// RVA: 0x36B7258 Offset: 0x36B3258 VA: 0x36B7258 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36B7260 Offset: 0x36B3260 VA: 0x36B7260 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36B7470 Offset: 0x36B3470 VA: 0x36B7470 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
