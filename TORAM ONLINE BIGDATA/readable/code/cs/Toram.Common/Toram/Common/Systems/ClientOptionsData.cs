// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Systems
public class ClientOptionsData : BinaryBase // TypeDefIndex: 11241
{
	// Fields
	[CompilerGenerated]
	private byte <GuardType>k__BackingField; // 0x19
	[CompilerGenerated]
	private byte <AvoidType>k__BackingField; // 0x1A
	[CompilerGenerated]
	private byte <Version>k__BackingField; // 0x1B
	[CompilerGenerated]
	private DateTime <UpdateTime>k__BackingField; // 0x20

	// Properties
	public byte GuardType { get; set; }
	public byte AvoidType { get; set; }
	public byte Version { get; set; }
	public DateTime UpdateTime { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x36CE4D8 Offset: 0x36CA4D8 VA: 0x36CE4D8
	public byte get_GuardType() { }

	[CompilerGenerated]
	// RVA: 0x36CE4E0 Offset: 0x36CA4E0 VA: 0x36CE4E0
	public void set_GuardType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36CE4E8 Offset: 0x36CA4E8 VA: 0x36CE4E8
	public byte get_AvoidType() { }

	[CompilerGenerated]
	// RVA: 0x36CE4F0 Offset: 0x36CA4F0 VA: 0x36CE4F0
	public void set_AvoidType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36CE4F8 Offset: 0x36CA4F8 VA: 0x36CE4F8
	public byte get_Version() { }

	[CompilerGenerated]
	// RVA: 0x36CE500 Offset: 0x36CA500 VA: 0x36CE500
	private void set_Version(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36CE508 Offset: 0x36CA508 VA: 0x36CE508
	public DateTime get_UpdateTime() { }

	[CompilerGenerated]
	// RVA: 0x36CE510 Offset: 0x36CA510 VA: 0x36CE510
	private void set_UpdateTime(DateTime value) { }

	// RVA: 0x36CE518 Offset: 0x36CA518 VA: 0x36CE518
	public void .ctor() { }

	// RVA: 0x36CE588 Offset: 0x36CA588 VA: 0x36CE588
	public void .ctor(byte[] binary) { }

	// RVA: 0x36CE590 Offset: 0x36CA590 VA: 0x36CE590 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36CE5EC Offset: 0x36CA5EC VA: 0x36CE5EC Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
