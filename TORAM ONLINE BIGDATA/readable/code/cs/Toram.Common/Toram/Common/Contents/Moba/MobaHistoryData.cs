// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Contents.Moba
public class MobaHistoryData : BinaryBase // TypeDefIndex: 11208
{
	// Fields
	public const int HistoryMax = 10;
	[CompilerGenerated]
	private byte <No>k__BackingField; // 0x19
	[CompilerGenerated]
	private int <GameUniqueId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <RuleType>k__BackingField; // 0x20
	[CompilerGenerated]
	private DateTime <GameDate>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <Rank>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <Weapon>k__BackingField; // 0x32

	// Properties
	public byte No { get; set; }
	public int GameUniqueId { get; set; }
	public byte RuleType { get; set; }
	public DateTime GameDate { get; set; }
	public byte Rank { get; set; }
	public short Weapon { get; set; }

	// Methods

	// RVA: 0x35D9EBC Offset: 0x35D5EBC VA: 0x35D9EBC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35D9EC4 Offset: 0x35D5EC4 VA: 0x35D9EC4
	public byte get_No() { }

	[CompilerGenerated]
	// RVA: 0x35D9ECC Offset: 0x35D5ECC VA: 0x35D9ECC
	public void set_No(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35D9ED4 Offset: 0x35D5ED4 VA: 0x35D9ED4
	public int get_GameUniqueId() { }

	[CompilerGenerated]
	// RVA: 0x35D9EDC Offset: 0x35D5EDC VA: 0x35D9EDC
	public void set_GameUniqueId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35D9EE4 Offset: 0x35D5EE4 VA: 0x35D9EE4
	public byte get_RuleType() { }

	[CompilerGenerated]
	// RVA: 0x35D9EEC Offset: 0x35D5EEC VA: 0x35D9EEC
	public void set_RuleType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35D9EF4 Offset: 0x35D5EF4 VA: 0x35D9EF4
	public DateTime get_GameDate() { }

	[CompilerGenerated]
	// RVA: 0x35D9EFC Offset: 0x35D5EFC VA: 0x35D9EFC
	public void set_GameDate(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x35D9F04 Offset: 0x35D5F04 VA: 0x35D9F04
	public byte get_Rank() { }

	[CompilerGenerated]
	// RVA: 0x35D9F0C Offset: 0x35D5F0C VA: 0x35D9F0C
	public void set_Rank(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35D9F14 Offset: 0x35D5F14 VA: 0x35D9F14
	public short get_Weapon() { }

	[CompilerGenerated]
	// RVA: 0x35D9F1C Offset: 0x35D5F1C VA: 0x35D9F1C
	public void set_Weapon(short value) { }

	// RVA: 0x35D9F24 Offset: 0x35D5F24 VA: 0x35D9F24 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35D9FA0 Offset: 0x35D5FA0 VA: 0x35D9FA0 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
