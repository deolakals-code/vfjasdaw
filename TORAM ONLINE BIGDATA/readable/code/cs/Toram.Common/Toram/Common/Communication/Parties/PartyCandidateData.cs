// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication.Parties
public class PartyCandidateData : BinaryBase // TypeDefIndex: 13001
{
	// Fields
	[CompilerGenerated]
	private byte <FrameNo>k__BackingField; // 0x19
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <Role>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <Level>k__BackingField; // 0x2A
	[CompilerGenerated]
	private byte <Weapon>k__BackingField; // 0x2C
	[CompilerGenerated]
	private byte <SubWeapon>k__BackingField; // 0x2D

	// Properties
	public byte FrameNo { get; set; }
	public int ArchetypeId { get; set; }
	public string UserName { get; set; }
	public byte Role { get; set; }
	public short Level { get; set; }
	public byte Weapon { get; set; }
	public byte SubWeapon { get; set; }

	// Methods

	// RVA: 0x368AE00 Offset: 0x3686E00 VA: 0x368AE00
	public void .ctor() { }

	// RVA: 0x368AE08 Offset: 0x3686E08 VA: 0x368AE08
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x368AE10 Offset: 0x3686E10 VA: 0x368AE10
	public byte get_FrameNo() { }

	[CompilerGenerated]
	// RVA: 0x368AE18 Offset: 0x3686E18 VA: 0x368AE18
	private void set_FrameNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x368AE20 Offset: 0x3686E20 VA: 0x368AE20
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x368AE28 Offset: 0x3686E28 VA: 0x368AE28
	private void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x368AE30 Offset: 0x3686E30 VA: 0x368AE30
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x368AE38 Offset: 0x3686E38 VA: 0x368AE38
	private void set_UserName(string value) { }

	[CompilerGenerated]
	// RVA: 0x368AE40 Offset: 0x3686E40 VA: 0x368AE40
	public byte get_Role() { }

	[CompilerGenerated]
	// RVA: 0x368AE48 Offset: 0x3686E48 VA: 0x368AE48
	private void set_Role(byte value) { }

	[CompilerGenerated]
	// RVA: 0x368AE50 Offset: 0x3686E50 VA: 0x368AE50
	public short get_Level() { }

	[CompilerGenerated]
	// RVA: 0x368AE58 Offset: 0x3686E58 VA: 0x368AE58
	private void set_Level(short value) { }

	[CompilerGenerated]
	// RVA: 0x368AE60 Offset: 0x3686E60 VA: 0x368AE60
	public byte get_Weapon() { }

	[CompilerGenerated]
	// RVA: 0x368AE68 Offset: 0x3686E68 VA: 0x368AE68
	private void set_Weapon(byte value) { }

	[CompilerGenerated]
	// RVA: 0x368AE70 Offset: 0x3686E70 VA: 0x368AE70
	public byte get_SubWeapon() { }

	[CompilerGenerated]
	// RVA: 0x368AE78 Offset: 0x3686E78 VA: 0x368AE78
	private void set_SubWeapon(byte value) { }

	// RVA: 0x368AE80 Offset: 0x3686E80 VA: 0x368AE80 Slot: 3
	public override string ToString() { }

	// RVA: 0x368B0B0 Offset: 0x36870B0 VA: 0x368B0B0
	public string ToRole() { }

	// RVA: 0x368B240 Offset: 0x3687240 VA: 0x368B240 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x368B2CC Offset: 0x36872CC VA: 0x368B2CC Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
