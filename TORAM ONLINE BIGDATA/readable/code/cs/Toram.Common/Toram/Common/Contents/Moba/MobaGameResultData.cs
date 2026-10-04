// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Contents.Moba
public class MobaGameResultData // TypeDefIndex: 11216
{
	// Fields
	public const byte Timeout = 1;
	public const byte Annihilation = 2;
	[CompilerGenerated]
	private MobaRecordData[] <Records>k__BackingField; // 0x10
	[CompilerGenerated]
	private MobaGroupRecordData[] <Groups>k__BackingField; // 0x18
	[CompilerGenerated]
	private MobaBattleRecordData <BattleRecord>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <ErrorString>k__BackingField; // 0x28

	// Properties
	public MobaRecordData[] Records { get; set; }
	public MobaGroupRecordData[] Groups { get; set; }
	public MobaBattleRecordData BattleRecord { get; set; }
	private string ErrorString { set; }

	// Methods

	// RVA: 0x35DBFD0 Offset: 0x35D7FD0 VA: 0x35DBFD0
	public void .ctor() { }

	// RVA: 0x35DBFD8 Offset: 0x35D7FD8 VA: 0x35DBFD8
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x35DC460 Offset: 0x35D8460 VA: 0x35DC460
	public MobaRecordData[] get_Records() { }

	[CompilerGenerated]
	// RVA: 0x35DC468 Offset: 0x35D8468 VA: 0x35DC468
	protected void set_Records(MobaRecordData[] value) { }

	[CompilerGenerated]
	// RVA: 0x35DC470 Offset: 0x35D8470 VA: 0x35DC470
	public MobaGroupRecordData[] get_Groups() { }

	[CompilerGenerated]
	// RVA: 0x35DC478 Offset: 0x35D8478 VA: 0x35DC478
	protected void set_Groups(MobaGroupRecordData[] value) { }

	[CompilerGenerated]
	// RVA: 0x35DC480 Offset: 0x35D8480 VA: 0x35DC480
	public MobaBattleRecordData get_BattleRecord() { }

	[CompilerGenerated]
	// RVA: 0x35DC488 Offset: 0x35D8488 VA: 0x35DC488
	protected void set_BattleRecord(MobaBattleRecordData value) { }

	[CompilerGenerated]
	// RVA: 0x35DC490 Offset: 0x35D8490 VA: 0x35DC490
	private void set_ErrorString(string value) { }

	// RVA: 0x35DC004 Offset: 0x35D8004 VA: 0x35DC004
	private void Deserialize(byte[] binary) { }
}
