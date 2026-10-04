// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Guild.BBS
public class GuildBBSSendData : BinaryBase // TypeDefIndex: 11236
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private string <GuildName>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <MasterName>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <Num>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <Limit>k__BackingField; // 0x32
	[CompilerGenerated]
	private string <Comment>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte <JoinType>k__BackingField; // 0x40
	[CompilerGenerated]
	private byte <ConditionsType>k__BackingField; // 0x41
	[CompilerGenerated]
	private int <ConditionsValue>k__BackingField; // 0x44
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x48

	// Properties
	public int GuildId { get; set; }
	public string GuildName { get; set; }
	public string MasterName { get; set; }
	public short Num { get; set; }
	public short Limit { get; set; }
	public string Comment { get; set; }
	public byte JoinType { get; set; }
	public byte ConditionsType { get; set; }
	public int ConditionsValue { get; set; }
	public byte Flag { get; set; }

	// Methods

	// RVA: 0x36CCA24 Offset: 0x36C8A24 VA: 0x36CCA24
	public void .ctor() { }

	// RVA: 0x36CCA9C Offset: 0x36C8A9C VA: 0x36CCA9C
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x36CCAA4 Offset: 0x36C8AA4 VA: 0x36CCAA4 Slot: 8
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x36CCAAC Offset: 0x36C8AAC VA: 0x36CCAAC
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36CCAB4 Offset: 0x36C8AB4 VA: 0x36CCAB4 Slot: 9
	public string get_GuildName() { }

	[CompilerGenerated]
	// RVA: 0x36CCABC Offset: 0x36C8ABC VA: 0x36CCABC
	public void set_GuildName(string value) { }

	[CompilerGenerated]
	// RVA: 0x36CCAC4 Offset: 0x36C8AC4 VA: 0x36CCAC4 Slot: 10
	public string get_MasterName() { }

	[CompilerGenerated]
	// RVA: 0x36CCACC Offset: 0x36C8ACC VA: 0x36CCACC
	public void set_MasterName(string value) { }

	[CompilerGenerated]
	// RVA: 0x36CCAD4 Offset: 0x36C8AD4 VA: 0x36CCAD4 Slot: 11
	public short get_Num() { }

	[CompilerGenerated]
	// RVA: 0x36CCADC Offset: 0x36C8ADC VA: 0x36CCADC
	public void set_Num(short value) { }

	[CompilerGenerated]
	// RVA: 0x36CCAE4 Offset: 0x36C8AE4 VA: 0x36CCAE4 Slot: 12
	public short get_Limit() { }

	[CompilerGenerated]
	// RVA: 0x36CCAEC Offset: 0x36C8AEC VA: 0x36CCAEC
	public void set_Limit(short value) { }

	[CompilerGenerated]
	// RVA: 0x36CCAF4 Offset: 0x36C8AF4 VA: 0x36CCAF4 Slot: 13
	public string get_Comment() { }

	[CompilerGenerated]
	// RVA: 0x36CCAFC Offset: 0x36C8AFC VA: 0x36CCAFC
	public void set_Comment(string value) { }

	[CompilerGenerated]
	// RVA: 0x36CCB04 Offset: 0x36C8B04 VA: 0x36CCB04 Slot: 14
	public byte get_JoinType() { }

	[CompilerGenerated]
	// RVA: 0x36CCB0C Offset: 0x36C8B0C VA: 0x36CCB0C
	public void set_JoinType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36CCB14 Offset: 0x36C8B14 VA: 0x36CCB14 Slot: 15
	public byte get_ConditionsType() { }

	[CompilerGenerated]
	// RVA: 0x36CCB1C Offset: 0x36C8B1C VA: 0x36CCB1C
	public void set_ConditionsType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36CCB24 Offset: 0x36C8B24 VA: 0x36CCB24 Slot: 16
	public int get_ConditionsValue() { }

	[CompilerGenerated]
	// RVA: 0x36CCB2C Offset: 0x36C8B2C VA: 0x36CCB2C
	public void set_ConditionsValue(int value) { }

	[CompilerGenerated]
	// RVA: 0x36CCB34 Offset: 0x36C8B34 VA: 0x36CCB34
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x36CCB3C Offset: 0x36C8B3C VA: 0x36CCB3C
	public void set_Flag(byte value) { }

	// RVA: 0x36CCB44 Offset: 0x36C8B44 VA: 0x36CCB44 Slot: 3
	public override string ToString() { }

	// RVA: 0x36CCEFC Offset: 0x36C8EFC VA: 0x36CCEFC Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36CD0CC Offset: 0x36C90CC VA: 0x36CD0CC Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
