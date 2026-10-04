// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.GuildRaid
public class GuildGetRaidBossDataResponse : OperationResponseBase // TypeDefIndex: 12434
{
	// Fields
	[CompilerGenerated]
	private BossSymbolData <BossSymbolData>k__BackingField; // 0x20
	[CompilerGenerated]
	private MonsterDropDetailData[] <DetailDatas>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <MaxHpCount>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <CurrentHpCount>k__BackingField; // 0x31
	[CompilerGenerated]
	private int <Damage>k__BackingField; // 0x34
	[CompilerGenerated]
	private GuildRaidRandomPropertyData[] <RandomPropertyList>k__BackingField; // 0x38
	[CompilerGenerated]
	private AbnormalHitData[] <AbnormalHitList>k__BackingField; // 0x40
	[CompilerGenerated]
	private int <Stamina>k__BackingField; // 0x48

	// Properties
	public BossSymbolData BossSymbolData { get; set; }
	public MonsterDropDetailData[] DetailDatas { get; set; }
	public byte MaxHpCount { get; set; }
	public byte CurrentHpCount { get; set; }
	public int Damage { get; set; }
	public GuildRaidRandomPropertyData[] RandomPropertyList { get; set; }
	public AbnormalHitData[] AbnormalHitList { get; set; }
	public int Stamina { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3606FEC Offset: 0x3602FEC VA: 0x3606FEC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3606FF4 Offset: 0x3602FF4 VA: 0x3606FF4
	public BossSymbolData get_BossSymbolData() { }

	[CompilerGenerated]
	// RVA: 0x3606FFC Offset: 0x3602FFC VA: 0x3606FFC
	public void set_BossSymbolData(BossSymbolData value) { }

	[CompilerGenerated]
	// RVA: 0x3607004 Offset: 0x3603004 VA: 0x3607004
	public MonsterDropDetailData[] get_DetailDatas() { }

	[CompilerGenerated]
	// RVA: 0x360700C Offset: 0x360300C VA: 0x360700C
	public void set_DetailDatas(MonsterDropDetailData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3607014 Offset: 0x3603014 VA: 0x3607014
	public byte get_MaxHpCount() { }

	[CompilerGenerated]
	// RVA: 0x360701C Offset: 0x360301C VA: 0x360701C
	public void set_MaxHpCount(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3607024 Offset: 0x3603024 VA: 0x3607024
	public byte get_CurrentHpCount() { }

	[CompilerGenerated]
	// RVA: 0x360702C Offset: 0x360302C VA: 0x360702C
	public void set_CurrentHpCount(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3607034 Offset: 0x3603034 VA: 0x3607034
	public int get_Damage() { }

	[CompilerGenerated]
	// RVA: 0x360703C Offset: 0x360303C VA: 0x360703C
	public void set_Damage(int value) { }

	[CompilerGenerated]
	// RVA: 0x3607044 Offset: 0x3603044 VA: 0x3607044
	public GuildRaidRandomPropertyData[] get_RandomPropertyList() { }

	[CompilerGenerated]
	// RVA: 0x360704C Offset: 0x360304C VA: 0x360704C
	public void set_RandomPropertyList(GuildRaidRandomPropertyData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3607054 Offset: 0x3603054 VA: 0x3607054
	public AbnormalHitData[] get_AbnormalHitList() { }

	[CompilerGenerated]
	// RVA: 0x360705C Offset: 0x360305C VA: 0x360705C
	public void set_AbnormalHitList(AbnormalHitData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3607064 Offset: 0x3603064 VA: 0x3607064
	public int get_Stamina() { }

	[CompilerGenerated]
	// RVA: 0x360706C Offset: 0x360306C VA: 0x360706C
	public void set_Stamina(int value) { }

	// RVA: 0x3607074 Offset: 0x3603074 VA: 0x3607074 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x360707C Offset: 0x360307C VA: 0x360707C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3607084 Offset: 0x3603084 VA: 0x3607084 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x360756C Offset: 0x360356C VA: 0x360756C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
