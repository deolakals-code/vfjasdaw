// Assembly: Toram.Common.dll
// Namespace: Toram.Common.House.BlackKnight
public class BlackKnightSaveData : BinaryBase // TypeDefIndex: 12553
{
	// Fields
	public const byte ClearVersion = 1;
	[CompilerGenerated]
	private byte <SaveId>k__BackingField; // 0x19
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x20
	[CompilerGenerated]
	private long <Crista>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte[] <EquipData>k__BackingField; // 0x30
	[CompilerGenerated]
	private List<BlackKnightRecordData> <Records>k__BackingField; // 0x38
	[CompilerGenerated]
	private long <TotalTime>k__BackingField; // 0x40
	[CompilerGenerated]
	private byte <Version>k__BackingField; // 0x48

	// Properties
	public byte SaveId { get; set; }
	public int Gold { get; set; }
	public byte Flag { get; set; }
	public long Crista { get; set; }
	public byte[] EquipData { get; set; }
	public List<BlackKnightRecordData> Records { get; set; }
	public long TotalTime { get; set; }
	public byte Version { get; set; }

	// Methods

	// RVA: 0x3620A50 Offset: 0x361CA50 VA: 0x3620A50
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3620B38 Offset: 0x361CB38 VA: 0x3620B38
	public byte get_SaveId() { }

	[CompilerGenerated]
	// RVA: 0x3620B40 Offset: 0x361CB40 VA: 0x3620B40
	public void set_SaveId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3620B48 Offset: 0x361CB48 VA: 0x3620B48
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x3620B50 Offset: 0x361CB50 VA: 0x3620B50
	public void set_Gold(int value) { }

	[CompilerGenerated]
	// RVA: 0x3620B58 Offset: 0x361CB58 VA: 0x3620B58
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x3620B60 Offset: 0x361CB60 VA: 0x3620B60
	public void set_Flag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3620B68 Offset: 0x361CB68 VA: 0x3620B68
	public long get_Crista() { }

	[CompilerGenerated]
	// RVA: 0x3620B70 Offset: 0x361CB70 VA: 0x3620B70
	public void set_Crista(long value) { }

	[CompilerGenerated]
	// RVA: 0x3620B78 Offset: 0x361CB78 VA: 0x3620B78
	public byte[] get_EquipData() { }

	[CompilerGenerated]
	// RVA: 0x3620B80 Offset: 0x361CB80 VA: 0x3620B80
	public void set_EquipData(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x3620B88 Offset: 0x361CB88 VA: 0x3620B88
	public List<BlackKnightRecordData> get_Records() { }

	[CompilerGenerated]
	// RVA: 0x3620B90 Offset: 0x361CB90 VA: 0x3620B90
	public void set_Records(List<BlackKnightRecordData> value) { }

	[CompilerGenerated]
	// RVA: 0x3620B98 Offset: 0x361CB98 VA: 0x3620B98
	public long get_TotalTime() { }

	[CompilerGenerated]
	// RVA: 0x3620BA0 Offset: 0x361CBA0 VA: 0x3620BA0
	public void set_TotalTime(long value) { }

	[CompilerGenerated]
	// RVA: 0x3620BA8 Offset: 0x361CBA8 VA: 0x3620BA8
	public byte get_Version() { }

	[CompilerGenerated]
	// RVA: 0x3620BB0 Offset: 0x361CBB0 VA: 0x3620BB0
	public void set_Version(byte value) { }

	// RVA: 0x3620BB8 Offset: 0x361CBB8 VA: 0x3620BB8
	public void Initialize() { }

	// RVA: 0x3620C44 Offset: 0x361CC44 VA: 0x3620C44
	public bool IsExistData() { }

	// RVA: 0x3620C54 Offset: 0x361CC54 VA: 0x3620C54
	public byte GetCristaCount() { }

	// RVA: 0x3620C94 Offset: 0x361CC94 VA: 0x3620C94
	public bool IsCrista(byte id) { }

	// RVA: 0x3620CA4 Offset: 0x361CCA4 VA: 0x3620CA4
	public void AddCrista(byte id) { }

	// RVA: 0x3620CBC Offset: 0x361CCBC VA: 0x3620CBC Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x3620D90 Offset: 0x361CD90 VA: 0x3620D90 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
