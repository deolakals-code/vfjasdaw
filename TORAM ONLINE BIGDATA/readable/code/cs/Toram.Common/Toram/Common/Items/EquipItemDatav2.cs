// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Items
public class EquipItemDatav2 : ItemDatav2 // TypeDefIndex: 12494
{
	// Fields
	[CLSCompliant(False)]
	protected short _function; // 0x2A
	[CLSCompliant(False)]
	protected byte _slotMax; // 0x2C
	[CLSCompliant(False)]
	protected int _slot1; // 0x30
	[CLSCompliant(False)]
	protected int _slot2; // 0x34
	[CLSCompliant(False)]
	protected short _potential; // 0x38
	[CLSCompliant(False)]
	protected byte _refine; // 0x3A
	[CLSCompliant(False)]
	protected byte _ability; // 0x3B
	[CLSCompliant(False)]
	protected int _model; // 0x3C
	[CLSCompliant(False)]
	protected int _rproperty; // 0x40
	[CLSCompliant(False)]
	protected byte _premium; // 0x44
	[CLSCompliant(False)]
	protected string _creater; // 0x48
	[CLSCompliant(False)]
	protected long _uniqueId; // 0x50
	[CLSCompliant(False)]
	protected byte[] _color; // 0x58
	[CLSCompliant(False)]
	protected short[] _capId; // 0x60
	[CLSCompliant(False)]
	protected short[] _capVal; // 0x68

	// Properties
	public override byte ItemDataType { get; }
	public override short Index { get; }
	public override short Function { get; }
	public override byte SlotMax { get; }
	public override int Slot1 { get; }
	public override int Slot2 { get; }
	public override short Potential { get; }
	public override byte Refine { get; }
	public override byte AbilityValue { get; }
	public override byte BattleCustomize { get; }
	public override int Model { get; }
	public override int Rproperty { get; }
	public short OreBonus { get; }
	public override byte Premium { get; }
	public override string Creater { get; }
	public override long UniqueId { get; }
	public override byte[] Color { get; }
	public override short[] CapId { get; }
	public override short[] CapVal { get; }

	// Methods

	// RVA: 0x3610930 Offset: 0x360C930 VA: 0x3610930
	public void .ctor() { }

	// RVA: 0x3610A0C Offset: 0x360CA0C VA: 0x3610A0C
	public void .ctor(MemoryStream ms) { }

	// RVA: 0x3610AF8 Offset: 0x360CAF8 VA: 0x3610AF8 Slot: 29
	public override byte get_ItemDataType() { }

	// RVA: 0x3610B00 Offset: 0x360CB00 VA: 0x3610B00 Slot: 30
	public override short get_Index() { }

	// RVA: 0x3610B08 Offset: 0x360CB08 VA: 0x3610B08 Slot: 31
	public override short get_Function() { }

	// RVA: 0x3610B10 Offset: 0x360CB10 VA: 0x3610B10 Slot: 32
	public override byte get_SlotMax() { }

	// RVA: 0x3610B18 Offset: 0x360CB18 VA: 0x3610B18 Slot: 33
	public override int get_Slot1() { }

	// RVA: 0x3610B20 Offset: 0x360CB20 VA: 0x3610B20 Slot: 34
	public override int get_Slot2() { }

	// RVA: 0x3610B28 Offset: 0x360CB28 VA: 0x3610B28 Slot: 35
	public override short get_Potential() { }

	// RVA: 0x3610B30 Offset: 0x360CB30 VA: 0x3610B30 Slot: 36
	public override byte get_Refine() { }

	// RVA: 0x3610B38 Offset: 0x360CB38 VA: 0x3610B38 Slot: 37
	public override byte get_AbilityValue() { }

	// RVA: 0x3610B40 Offset: 0x360CB40 VA: 0x3610B40 Slot: 38
	public override byte get_BattleCustomize() { }

	// RVA: 0x3610B4C Offset: 0x360CB4C VA: 0x3610B4C Slot: 39
	public override int get_Model() { }

	// RVA: 0x3610B54 Offset: 0x360CB54 VA: 0x3610B54 Slot: 40
	public override int get_Rproperty() { }

	// RVA: 0x3610B5C Offset: 0x360CB5C VA: 0x3610B5C
	public short get_OreBonus() { }

	// RVA: 0x3610B64 Offset: 0x360CB64 VA: 0x3610B64 Slot: 41
	public override byte get_Premium() { }

	// RVA: 0x3610B6C Offset: 0x360CB6C VA: 0x3610B6C Slot: 42
	public override string get_Creater() { }

	// RVA: 0x3610B74 Offset: 0x360CB74 VA: 0x3610B74 Slot: 43
	public override long get_UniqueId() { }

	// RVA: 0x3610B7C Offset: 0x360CB7C VA: 0x3610B7C Slot: 44
	public override byte[] get_Color() { }

	// RVA: 0x3610B84 Offset: 0x360CB84 VA: 0x3610B84 Slot: 45
	public override short[] get_CapId() { }

	// RVA: 0x3610B8C Offset: 0x360CB8C VA: 0x3610B8C Slot: 46
	public override short[] get_CapVal() { }

	// RVA: 0x3610B94 Offset: 0x360CB94 VA: 0x3610B94 Slot: 3
	public override string ToString() { }

	// RVA: 0x3610E6C Offset: 0x360CE6C VA: 0x3610E6C Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36110D4 Offset: 0x360D0D4 VA: 0x36110D4 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x3611060 Offset: 0x360D060 VA: 0x3611060
	private byte GetCapNum() { }
}
