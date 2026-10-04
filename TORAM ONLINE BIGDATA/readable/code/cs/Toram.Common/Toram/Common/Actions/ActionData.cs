// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class ActionData : UnityHashBase, IActionData // TypeDefIndex: 13107
{
	// Fields
	private static readonly bool[] managed; // 0x0
	[CompilerGenerated]
	private byte <ActionCode>k__BackingField; // 0x19
	[CompilerGenerated]
	private short <Revision>k__BackingField; // 0x1A
	[CompilerGenerated]
	private short <Relevance>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x1E
	[CompilerGenerated]
	private int <Timestamp>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x28
	[CompilerGenerated]
	private MobData[] <MobList>k__BackingField; // 0x30
	[CompilerGenerated]
	private Dictionary<object, object> <ActionParam>k__BackingField; // 0x38

	// Properties
	public byte ActionCode { get; set; }
	public short Revision { get; set; }
	public short Relevance { get; set; }
	public byte Flag { get; set; }
	public int Timestamp { get; set; }
	public byte ArchetypeType { get; set; }
	public int ArchetypeId { get; set; }
	public MobData[] MobList { get; set; }
	public Dictionary<object, object> ActionParam { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36A2B14 Offset: 0x369EB14 VA: 0x36A2B14
	private static void .cctor() { }

	// RVA: 0x36A2C18 Offset: 0x369EC18 VA: 0x36A2C18
	public void .ctor() { }

	// RVA: 0x36A2C64 Offset: 0x369EC64 VA: 0x36A2C64
	public void .ctor(byte code) { }

	// RVA: 0x36A2CBC Offset: 0x369ECBC VA: 0x36A2CBC
	public void .ctor(byte code, Dictionary<object, object> actionParam) { }

	// RVA: 0x36A2D18 Offset: 0x369ED18 VA: 0x36A2D18
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36A2D20 Offset: 0x369ED20 VA: 0x36A2D20 Slot: 8
	public byte get_ActionCode() { }

	[CompilerGenerated]
	// RVA: 0x36A2D28 Offset: 0x369ED28 VA: 0x36A2D28
	public void set_ActionCode(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36A2D30 Offset: 0x369ED30 VA: 0x36A2D30 Slot: 7
	public short get_Revision() { }

	[CompilerGenerated]
	// RVA: 0x36A2D38 Offset: 0x369ED38 VA: 0x36A2D38
	public void set_Revision(short value) { }

	[CompilerGenerated]
	// RVA: 0x36A2D40 Offset: 0x369ED40 VA: 0x36A2D40 Slot: 9
	public short get_Relevance() { }

	[CompilerGenerated]
	// RVA: 0x36A2D48 Offset: 0x369ED48 VA: 0x36A2D48
	public void set_Relevance(short value) { }

	[CompilerGenerated]
	// RVA: 0x36A2D50 Offset: 0x369ED50 VA: 0x36A2D50
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x36A2D58 Offset: 0x369ED58 VA: 0x36A2D58
	public void set_Flag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36A2D60 Offset: 0x369ED60 VA: 0x36A2D60
	public int get_Timestamp() { }

	[CompilerGenerated]
	// RVA: 0x36A2D68 Offset: 0x369ED68 VA: 0x36A2D68
	public void set_Timestamp(int value) { }

	[CompilerGenerated]
	// RVA: 0x36A2D70 Offset: 0x369ED70 VA: 0x36A2D70
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x36A2D78 Offset: 0x369ED78 VA: 0x36A2D78
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36A2D80 Offset: 0x369ED80 VA: 0x36A2D80
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x36A2D88 Offset: 0x369ED88 VA: 0x36A2D88
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36A2D90 Offset: 0x369ED90 VA: 0x36A2D90
	public MobData[] get_MobList() { }

	[CompilerGenerated]
	// RVA: 0x36A2D98 Offset: 0x369ED98 VA: 0x36A2D98
	public void set_MobList(MobData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36A2DA0 Offset: 0x369EDA0 VA: 0x36A2DA0
	public Dictionary<object, object> get_ActionParam() { }

	[CompilerGenerated]
	// RVA: 0x36A2DA8 Offset: 0x369EDA8 VA: 0x36A2DA8
	public void set_ActionParam(Dictionary<object, object> value) { }

	// RVA: 0x36A2DB0 Offset: 0x369EDB0 VA: 0x36A2DB0 Slot: 10
	public bool IsConfirmed() { }

	// RVA: 0x36A2DBC Offset: 0x369EDBC VA: 0x36A2DBC
	public bool IsResend() { }

	// RVA: 0x36A2DC8 Offset: 0x369EDC8 VA: 0x36A2DC8
	public void SetRevision(short revision) { }

	// RVA: 0x36A2DD0 Offset: 0x369EDD0 VA: 0x36A2DD0
	public void SetTimestamp(int timestamp) { }

	// RVA: 0x36A2DD8 Offset: 0x369EDD8 VA: 0x36A2DD8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36A2DE0 Offset: 0x369EDE0 VA: 0x36A2DE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x36A2FD0 Offset: 0x369EFD0 VA: 0x36A2FD0 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36A3638 Offset: 0x369F638 VA: 0x36A3638 Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x36A3988 Offset: 0x369F988 VA: 0x36A3988
	public static byte GetMiniGameId(Dictionary<object, object> parameters) { }
}
