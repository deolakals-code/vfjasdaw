// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Contents.Moba
public class MobaGroupRecordData : BinaryBase // TypeDefIndex: 11218
{
	// Fields
	[CompilerGenerated]
	private int <GroupId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private short <Rank>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Time>k__BackingField; // 0x22
	[CompilerGenerated]
	private int <CrystalDamage>k__BackingField; // 0x24
	[CompilerGenerated]
	private int[] <MemberIds>k__BackingField; // 0x28

	// Properties
	public int GroupId { get; set; }
	public short Rank { get; set; }
	public short Time { get; set; }
	public int CrystalDamage { get; set; }
	public int[] MemberIds { get; set; }

	// Methods

	// RVA: 0x35DC498 Offset: 0x35D8498 VA: 0x35DC498
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35DC4A0 Offset: 0x35D84A0 VA: 0x35DC4A0
	public int get_GroupId() { }

	[CompilerGenerated]
	// RVA: 0x35DC4A8 Offset: 0x35D84A8 VA: 0x35DC4A8
	public void set_GroupId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35DC4B0 Offset: 0x35D84B0 VA: 0x35DC4B0
	public short get_Rank() { }

	[CompilerGenerated]
	// RVA: 0x35DC4B8 Offset: 0x35D84B8 VA: 0x35DC4B8
	public void set_Rank(short value) { }

	[CompilerGenerated]
	// RVA: 0x35DC4C0 Offset: 0x35D84C0 VA: 0x35DC4C0
	public short get_Time() { }

	[CompilerGenerated]
	// RVA: 0x35DC4C8 Offset: 0x35D84C8 VA: 0x35DC4C8
	public void set_Time(short value) { }

	[CompilerGenerated]
	// RVA: 0x35DC4D0 Offset: 0x35D84D0 VA: 0x35DC4D0
	public int get_CrystalDamage() { }

	[CompilerGenerated]
	// RVA: 0x35DC4D8 Offset: 0x35D84D8 VA: 0x35DC4D8
	public void set_CrystalDamage(int value) { }

	[CompilerGenerated]
	// RVA: 0x35DC4E0 Offset: 0x35D84E0 VA: 0x35DC4E0
	public int[] get_MemberIds() { }

	[CompilerGenerated]
	// RVA: 0x35DC4E8 Offset: 0x35D84E8 VA: 0x35DC4E8
	public void set_MemberIds(int[] value) { }

	// RVA: 0x35DC4F0 Offset: 0x35D84F0 VA: 0x35DC4F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x35DC6E0 Offset: 0x35D86E0 VA: 0x35DC6E0 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35DC74C Offset: 0x35D874C VA: 0x35DC74C Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
