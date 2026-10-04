// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Items
public class ConsumeItemDatav2 : ItemDatav2 // TypeDefIndex: 12497
{
	// Fields
	[CLSCompliant(False)]
	protected string _creater; // 0x30
	[CLSCompliant(False)]
	protected long _uniqueId; // 0x38

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
	public override byte Premium { get; }
	public override string Creater { get; }
	public override long UniqueId { get; }
	public override byte[] Color { get; }
	public override short[] CapId { get; }
	public override short[] CapVal { get; }

	// Methods

	// RVA: 0x3611420 Offset: 0x360D420 VA: 0x3611420
	public void .ctor() { }

	// RVA: 0x3611478 Offset: 0x360D478 VA: 0x3611478
	public void .ctor(MemoryStream ms) { }

	// RVA: 0x36114E0 Offset: 0x360D4E0 VA: 0x36114E0 Slot: 29
	public override byte get_ItemDataType() { }

	// RVA: 0x36114E8 Offset: 0x360D4E8 VA: 0x36114E8 Slot: 30
	public override short get_Index() { }

	// RVA: 0x36114F0 Offset: 0x360D4F0 VA: 0x36114F0 Slot: 31
	public override short get_Function() { }

	// RVA: 0x36114F8 Offset: 0x360D4F8 VA: 0x36114F8 Slot: 32
	public override byte get_SlotMax() { }

	// RVA: 0x3611500 Offset: 0x360D500 VA: 0x3611500 Slot: 33
	public override int get_Slot1() { }

	// RVA: 0x3611508 Offset: 0x360D508 VA: 0x3611508 Slot: 34
	public override int get_Slot2() { }

	// RVA: 0x3611510 Offset: 0x360D510 VA: 0x3611510 Slot: 35
	public override short get_Potential() { }

	// RVA: 0x3611518 Offset: 0x360D518 VA: 0x3611518 Slot: 36
	public override byte get_Refine() { }

	// RVA: 0x3611520 Offset: 0x360D520 VA: 0x3611520 Slot: 37
	public override byte get_AbilityValue() { }

	// RVA: 0x3611528 Offset: 0x360D528 VA: 0x3611528 Slot: 38
	public override byte get_BattleCustomize() { }

	// RVA: 0x3611530 Offset: 0x360D530 VA: 0x3611530 Slot: 39
	public override int get_Model() { }

	// RVA: 0x3611538 Offset: 0x360D538 VA: 0x3611538 Slot: 40
	public override int get_Rproperty() { }

	// RVA: 0x3611540 Offset: 0x360D540 VA: 0x3611540 Slot: 41
	public override byte get_Premium() { }

	// RVA: 0x3611548 Offset: 0x360D548 VA: 0x3611548 Slot: 42
	public override string get_Creater() { }

	// RVA: 0x3611550 Offset: 0x360D550 VA: 0x3611550 Slot: 43
	public override long get_UniqueId() { }

	// RVA: 0x3611558 Offset: 0x360D558 VA: 0x3611558 Slot: 44
	public override byte[] get_Color() { }

	// RVA: 0x3611560 Offset: 0x360D560 VA: 0x3611560 Slot: 45
	public override short[] get_CapId() { }

	// RVA: 0x3611568 Offset: 0x360D568 VA: 0x3611568 Slot: 46
	public override short[] get_CapVal() { }

	// RVA: 0x3611570 Offset: 0x360D570 VA: 0x3611570 Slot: 3
	public override string ToString() { }

	// RVA: 0x3611848 Offset: 0x360D848 VA: 0x3611848 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36118C4 Offset: 0x360D8C4 VA: 0x36118C4 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
