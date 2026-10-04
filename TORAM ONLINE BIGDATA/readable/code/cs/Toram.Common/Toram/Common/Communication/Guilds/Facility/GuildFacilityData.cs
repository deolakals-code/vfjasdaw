// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication.Guilds.Facility
public class GuildFacilityData : BinaryBase // TypeDefIndex: 13037
{
	// Fields
	[CompilerGenerated]
	private int <FacilityId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private short <Lv>k__BackingField; // 0x20

	// Properties
	public int FacilityId { get; set; }
	public short Lv { get; set; }

	// Methods

	// RVA: 0x3693AC0 Offset: 0x368FAC0 VA: 0x3693AC0
	public void .ctor() { }

	// RVA: 0x3693AC8 Offset: 0x368FAC8 VA: 0x3693AC8
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x3693AD0 Offset: 0x368FAD0 VA: 0x3693AD0
	public int get_FacilityId() { }

	[CompilerGenerated]
	// RVA: 0x3693AD8 Offset: 0x368FAD8 VA: 0x3693AD8
	protected void set_FacilityId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3693AE0 Offset: 0x368FAE0 VA: 0x3693AE0
	public short get_Lv() { }

	[CompilerGenerated]
	// RVA: 0x3693AE8 Offset: 0x368FAE8 VA: 0x3693AE8
	protected void set_Lv(short value) { }

	// RVA: 0x3693AF0 Offset: 0x368FAF0 VA: 0x3693AF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x3693BAC Offset: 0x368FBAC VA: 0x3693BAC Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x3693BE8 Offset: 0x368FBE8 VA: 0x3693BE8 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
