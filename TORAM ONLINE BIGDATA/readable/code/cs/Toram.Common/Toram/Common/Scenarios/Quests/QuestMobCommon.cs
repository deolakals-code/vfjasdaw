// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Scenarios.Quests
public class QuestMobCommon : BinaryBase, IScenarioMob // TypeDefIndex: 11093
{
	// Fields
	[CompilerGenerated]
	private byte <No>k__BackingField; // 0x19
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <MonsterUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Current>k__BackingField; // 0x24
	[CompilerGenerated]
	private short <SubdueNum>k__BackingField; // 0x26

	// Properties
	[BinaryParameter]
	public byte No { get; set; }
	[BinaryParameter]
	public int FieldId { get; set; }
	[BinaryParameter]
	public int MonsterUuid { get; set; }
	[BinaryParameter]
	public short Current { get; set; }
	[BinaryParameter]
	public short SubdueNum { get; set; }

	// Methods

	// RVA: 0x35B7D84 Offset: 0x35B3D84 VA: 0x35B7D84
	public void .ctor() { }

	// RVA: 0x35B6744 Offset: 0x35B2744 VA: 0x35B6744
	public void .ctor(MemoryStream ms) { }

	[CompilerGenerated]
	// RVA: 0x35B7D8C Offset: 0x35B3D8C VA: 0x35B7D8C Slot: 8
	public byte get_No() { }

	[CompilerGenerated]
	// RVA: 0x35B7D94 Offset: 0x35B3D94 VA: 0x35B7D94 Slot: 14
	public void set_No(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35B7D9C Offset: 0x35B3D9C VA: 0x35B7D9C Slot: 9
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x35B7DA4 Offset: 0x35B3DA4 VA: 0x35B7DA4 Slot: 15
	public void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35B7DAC Offset: 0x35B3DAC VA: 0x35B7DAC Slot: 10
	public int get_MonsterUuid() { }

	[CompilerGenerated]
	// RVA: 0x35B7DB4 Offset: 0x35B3DB4 VA: 0x35B7DB4 Slot: 16
	public void set_MonsterUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x35B7DBC Offset: 0x35B3DBC VA: 0x35B7DBC Slot: 11
	public short get_Current() { }

	[CompilerGenerated]
	// RVA: 0x35B7DC4 Offset: 0x35B3DC4 VA: 0x35B7DC4 Slot: 12
	public void set_Current(short value) { }

	[CompilerGenerated]
	// RVA: 0x35B7DCC Offset: 0x35B3DCC VA: 0x35B7DCC Slot: 13
	public short get_SubdueNum() { }

	[CompilerGenerated]
	// RVA: 0x35B7DD4 Offset: 0x35B3DD4 VA: 0x35B7DD4 Slot: 17
	public void set_SubdueNum(short value) { }

	// RVA: 0x35B7DDC Offset: 0x35B3DDC VA: 0x35B7DDC Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35B7F24 Offset: 0x35B3F24 VA: 0x35B7F24 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
