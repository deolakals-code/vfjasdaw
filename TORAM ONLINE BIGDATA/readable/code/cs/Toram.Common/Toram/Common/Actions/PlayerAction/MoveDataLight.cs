// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions.PlayerAction
public class MoveDataLight : BinaryBase, IMoveData // TypeDefIndex: 13221
{
	// Fields
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <Speed>k__BackingField; // 0x2A
	[CompilerGenerated]
	private bool <IsSpeed>k__BackingField; // 0x2C

	// Properties
	public short[] Position { get; set; }
	public short Rotation { get; set; }
	public short Speed { get; set; }
	public bool IsSpeed { get; set; }

	// Methods

	// RVA: 0x36E46A8 Offset: 0x36E06A8 VA: 0x36E46A8
	public void .ctor() { }

	// RVA: 0x36E46B0 Offset: 0x36E06B0 VA: 0x36E46B0
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x36E46B8 Offset: 0x36E06B8 VA: 0x36E46B8 Slot: 8
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x36E46C0 Offset: 0x36E06C0 VA: 0x36E46C0 Slot: 12
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36E46C8 Offset: 0x36E06C8 VA: 0x36E46C8 Slot: 9
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x36E46D0 Offset: 0x36E06D0 VA: 0x36E46D0 Slot: 13
	public void set_Rotation(short value) { }

	[CompilerGenerated]
	// RVA: 0x36E46D8 Offset: 0x36E06D8 VA: 0x36E46D8 Slot: 10
	public short get_Speed() { }

	[CompilerGenerated]
	// RVA: 0x36E46E0 Offset: 0x36E06E0 VA: 0x36E46E0 Slot: 14
	public void set_Speed(short value) { }

	[CompilerGenerated]
	// RVA: 0x36E46E8 Offset: 0x36E06E8 VA: 0x36E46E8 Slot: 11
	public bool get_IsSpeed() { }

	[CompilerGenerated]
	// RVA: 0x36E46F0 Offset: 0x36E06F0 VA: 0x36E46F0
	private void set_IsSpeed(bool value) { }

	// RVA: 0x36E46FC Offset: 0x36E06FC VA: 0x36E46FC Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36E480C Offset: 0x36E080C VA: 0x36E480C Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
