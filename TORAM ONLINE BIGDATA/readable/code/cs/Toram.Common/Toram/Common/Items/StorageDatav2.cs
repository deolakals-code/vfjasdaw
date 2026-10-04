// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Items
public class StorageDatav2 : BinaryBase // TypeDefIndex: 12491
{
	// Fields
	[CompilerGenerated]
	private byte <StorageNo>k__BackingField; // 0x19
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Info>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <Capacity>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <Num>k__BackingField; // 0x32

	// Properties
	public byte StorageNo { get; set; }
	public string Name { get; set; }
	public string Info { get; set; }
	public short Capacity { get; set; }
	public short Num { get; set; }

	// Methods

	// RVA: 0x360F6CC Offset: 0x360B6CC VA: 0x360F6CC
	public void .ctor() { }

	// RVA: 0x360F6D4 Offset: 0x360B6D4 VA: 0x360F6D4
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x360F6DC Offset: 0x360B6DC VA: 0x360F6DC
	public byte get_StorageNo() { }

	[CompilerGenerated]
	// RVA: 0x360F6E4 Offset: 0x360B6E4 VA: 0x360F6E4
	public void set_StorageNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x360F6EC Offset: 0x360B6EC VA: 0x360F6EC
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x360F6F4 Offset: 0x360B6F4 VA: 0x360F6F4
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x360F6FC Offset: 0x360B6FC VA: 0x360F6FC
	public string get_Info() { }

	[CompilerGenerated]
	// RVA: 0x360F704 Offset: 0x360B704 VA: 0x360F704
	public void set_Info(string value) { }

	[CompilerGenerated]
	// RVA: 0x360F70C Offset: 0x360B70C VA: 0x360F70C
	public short get_Capacity() { }

	[CompilerGenerated]
	// RVA: 0x360F714 Offset: 0x360B714 VA: 0x360F714
	public void set_Capacity(short value) { }

	[CompilerGenerated]
	// RVA: 0x360F71C Offset: 0x360B71C VA: 0x360F71C
	public short get_Num() { }

	[CompilerGenerated]
	// RVA: 0x360F724 Offset: 0x360B724 VA: 0x360F724
	public void set_Num(short value) { }

	// RVA: 0x360F72C Offset: 0x360B72C VA: 0x360F72C Slot: 3
	public override string ToString() { }

	// RVA: 0x360F940 Offset: 0x360B940 VA: 0x360F940 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x360F9AC Offset: 0x360B9AC VA: 0x360F9AC Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
