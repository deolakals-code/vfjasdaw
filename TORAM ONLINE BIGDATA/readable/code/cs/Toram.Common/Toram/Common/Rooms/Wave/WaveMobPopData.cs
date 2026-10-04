// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Rooms.Wave
public class WaveMobPopData : BinaryBase // TypeDefIndex: 11310
{
	// Fields
	[CompilerGenerated]
	private int <MonsterId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private short <StartRot>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <MapPointDataId>k__BackingField; // 0x22
	[CompilerGenerated]
	private byte <PopType>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <PopMax>k__BackingField; // 0x25
	[CompilerGenerated]
	private byte <PopLimit>k__BackingField; // 0x26
	[CompilerGenerated]
	private byte <PopInterval>k__BackingField; // 0x27
	[CompilerGenerated]
	private byte <FirstPopDelay>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x29
	private byte version; // 0x2A

	// Properties
	[BinaryParameter]
	public int MonsterId { get; set; }
	public short StartRot { get; set; }
	[BinaryParameter]
	public short MapPointDataId { get; set; }
	[BinaryParameter]
	public byte PopType { get; set; }
	[BinaryParameter]
	public byte PopMax { get; set; }
	[BinaryParameter]
	public byte PopLimit { get; set; }
	[BinaryParameter]
	public byte PopInterval { get; set; }
	[BinaryParameter]
	public byte FirstPopDelay { get; set; }
	[BinaryParameter]
	public byte Flag { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x36DC698 Offset: 0x36D8698 VA: 0x36DC698
	public int get_MonsterId() { }

	[CompilerGenerated]
	// RVA: 0x36DC6A0 Offset: 0x36D86A0 VA: 0x36DC6A0
	private void set_MonsterId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36DC6A8 Offset: 0x36D86A8 VA: 0x36DC6A8
	public short get_StartRot() { }

	[CompilerGenerated]
	// RVA: 0x36DC6B0 Offset: 0x36D86B0 VA: 0x36DC6B0
	private void set_StartRot(short value) { }

	[CompilerGenerated]
	// RVA: 0x36DC6B8 Offset: 0x36D86B8 VA: 0x36DC6B8
	public short get_MapPointDataId() { }

	[CompilerGenerated]
	// RVA: 0x36DC6C0 Offset: 0x36D86C0 VA: 0x36DC6C0
	private void set_MapPointDataId(short value) { }

	[CompilerGenerated]
	// RVA: 0x36DC6C8 Offset: 0x36D86C8 VA: 0x36DC6C8
	public byte get_PopType() { }

	[CompilerGenerated]
	// RVA: 0x36DC6D0 Offset: 0x36D86D0 VA: 0x36DC6D0
	private void set_PopType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36DC6D8 Offset: 0x36D86D8 VA: 0x36DC6D8
	public byte get_PopMax() { }

	[CompilerGenerated]
	// RVA: 0x36DC6E0 Offset: 0x36D86E0 VA: 0x36DC6E0
	private void set_PopMax(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36DC6E8 Offset: 0x36D86E8 VA: 0x36DC6E8
	public byte get_PopLimit() { }

	[CompilerGenerated]
	// RVA: 0x36DC6F0 Offset: 0x36D86F0 VA: 0x36DC6F0
	private void set_PopLimit(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36DC6F8 Offset: 0x36D86F8 VA: 0x36DC6F8
	public byte get_PopInterval() { }

	[CompilerGenerated]
	// RVA: 0x36DC700 Offset: 0x36D8700 VA: 0x36DC700
	private void set_PopInterval(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36DC708 Offset: 0x36D8708 VA: 0x36DC708
	public byte get_FirstPopDelay() { }

	[CompilerGenerated]
	// RVA: 0x36DC710 Offset: 0x36D8710 VA: 0x36DC710
	private void set_FirstPopDelay(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36DC718 Offset: 0x36D8718 VA: 0x36DC718
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x36DC720 Offset: 0x36D8720 VA: 0x36DC720
	private void set_Flag(byte value) { }

	// RVA: 0x36DC728 Offset: 0x36D8728 VA: 0x36DC728
	public void .ctor() { }

	// RVA: 0x36DB4DC Offset: 0x36D74DC VA: 0x36DB4DC
	public void .ctor(MemoryStream ms, byte version) { }

	// RVA: 0x36DC730 Offset: 0x36D8730 VA: 0x36DC730 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36DC8E0 Offset: 0x36D88E0 VA: 0x36DC8E0 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36DB94C Offset: 0x36D794C VA: 0x36DB94C
	public void GetBinary(MemoryStream ms, byte version) { }
}
