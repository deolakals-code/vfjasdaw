// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions.PetAction
public class PetResponseData : UnityHashBase // TypeDefIndex: 13219
{
	// Fields
	[CompilerGenerated]
	private long <PetUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x30

	// Properties
	public long PetUuid { get; set; }
	public short[] Position { get; set; }
	public short Rotation { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36E3DF0 Offset: 0x36DFDF0 VA: 0x36E3DF0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36E3DF8 Offset: 0x36DFDF8 VA: 0x36E3DF8
	public long get_PetUuid() { }

	[CompilerGenerated]
	// RVA: 0x36E3E00 Offset: 0x36DFE00 VA: 0x36E3E00
	public void set_PetUuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x36E3E08 Offset: 0x36DFE08 VA: 0x36E3E08
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x36E3E10 Offset: 0x36DFE10 VA: 0x36E3E10
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36E3E18 Offset: 0x36DFE18 VA: 0x36E3E18
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x36E3E20 Offset: 0x36DFE20 VA: 0x36E3E20
	public void set_Rotation(short value) { }

	// RVA: 0x36E3E28 Offset: 0x36DFE28 VA: 0x36E3E28 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36E3E30 Offset: 0x36DFE30 VA: 0x36E3E30 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36E40C0 Offset: 0x36E00C0 VA: 0x36E40C0 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
