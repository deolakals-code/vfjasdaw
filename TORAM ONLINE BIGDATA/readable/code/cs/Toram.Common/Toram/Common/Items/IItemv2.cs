// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Items
public interface IItemv2 // TypeDefIndex: 12496
{
	// Properties
	public abstract byte ItemDataType { get; }
	public abstract int Id { get; }
	public abstract short Type { get; }
	public abstract short Max { get; }
	public abstract byte Flag { get; }
	public abstract short Function { get; }
	public abstract byte SlotMax { get; }
	public abstract int Slot1 { get; }
	public abstract int Slot2 { get; }
	public abstract short Potential { get; }
	public abstract byte Refine { get; }
	public abstract byte AbilityValue { get; }
	public abstract int Model { get; }
	public abstract int Rproperty { get; }
	public abstract byte Premium { get; }
	public abstract string Creater { get; }
	public abstract long UniqueId { get; }
	public abstract byte[] Color { get; }
	public abstract short[] CapId { get; }
	public abstract short[] CapVal { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract byte get_ItemDataType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_Id();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract short get_Type();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract short get_Max();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract byte get_Flag();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract short get_Function();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract byte get_SlotMax();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_Slot1();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_Slot2();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract short get_Potential();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract byte get_Refine();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract byte get_AbilityValue();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int get_Model();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract int get_Rproperty();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract byte get_Premium();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract string get_Creater();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract long get_UniqueId();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract byte[] get_Color();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract short[] get_CapId();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract short[] get_CapVal();
}
