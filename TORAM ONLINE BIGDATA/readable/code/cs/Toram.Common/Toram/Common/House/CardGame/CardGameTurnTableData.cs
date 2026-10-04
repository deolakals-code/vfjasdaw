// Assembly: Toram.Common.dll
// Namespace: Toram.Common.House.CardGame
public class CardGameTurnTableData : BinaryBase // TypeDefIndex: 12544
{
	// Fields
	[CompilerGenerated]
	private byte <TurnCount>k__BackingField; // 0x19
	[CompilerGenerated]
	private List<byte> <Hand>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <Market1>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <Market2>k__BackingField; // 0x29
	[CompilerGenerated]
	private byte <Market3>k__BackingField; // 0x2A
	[CompilerGenerated]
	private byte <BossAHp>k__BackingField; // 0x2B
	[CompilerGenerated]
	private byte <BossBHp>k__BackingField; // 0x2C
	[CompilerGenerated]
	private byte <BossCHp>k__BackingField; // 0x2D
	[CompilerGenerated]
	private byte <BossDHp>k__BackingField; // 0x2E
	[CompilerGenerated]
	private byte <BossExHp>k__BackingField; // 0x2F
	[CompilerGenerated]
	private byte <ServerBossAHp>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <ServerBossBHp>k__BackingField; // 0x31
	[CompilerGenerated]
	private byte <ServerBossCHp>k__BackingField; // 0x32
	[CompilerGenerated]
	private byte <ServerBossDHp>k__BackingField; // 0x33
	[CompilerGenerated]
	private byte <ServerBossExHp>k__BackingField; // 0x34
	[CompilerGenerated]
	private short <BossAReward>k__BackingField; // 0x36
	[CompilerGenerated]
	private short <BossBReward>k__BackingField; // 0x38
	[CompilerGenerated]
	private short <BossCReward>k__BackingField; // 0x3A
	[CompilerGenerated]
	private short <BossDReward>k__BackingField; // 0x3C
	[CompilerGenerated]
	private short <BossExReward>k__BackingField; // 0x3E
	[CompilerGenerated]
	private bool <BossANewest>k__BackingField; // 0x40
	[CompilerGenerated]
	private bool <BossBNewest>k__BackingField; // 0x41
	[CompilerGenerated]
	private bool <BossCNewest>k__BackingField; // 0x42
	[CompilerGenerated]
	private bool <BossDNewest>k__BackingField; // 0x43
	[CompilerGenerated]
	private bool <BossExNewest>k__BackingField; // 0x44
	[CompilerGenerated]
	private short <Spina>k__BackingField; // 0x46
	[CompilerGenerated]
	private bool <TurnLimit>k__BackingField; // 0x48
	[CompilerGenerated]
	private List<byte> <DrawCardIndexs>k__BackingField; // 0x50
	[CompilerGenerated]
	private CardGameTurnCardData <TurnEndAttack>k__BackingField; // 0x58
	[CompilerGenerated]
	private List<byte> <TurnEndMarketBuy>k__BackingField; // 0x60
	[CompilerGenerated]
	private List<byte> <TurnEndMarketSell>k__BackingField; // 0x68

	// Properties
	public byte TurnCount { get; set; }
	public List<byte> Hand { get; set; }
	public byte Market1 { get; set; }
	public byte Market2 { get; set; }
	public byte Market3 { get; set; }
	public byte BossAHp { get; set; }
	public byte BossBHp { get; set; }
	public byte BossCHp { get; set; }
	public byte BossDHp { get; set; }
	public byte BossExHp { get; set; }
	public byte ServerBossAHp { get; set; }
	public byte ServerBossBHp { get; set; }
	public byte ServerBossCHp { get; set; }
	public byte ServerBossDHp { get; set; }
	public byte ServerBossExHp { get; set; }
	public short BossAReward { get; set; }
	public short BossBReward { get; set; }
	public short BossCReward { get; set; }
	public short BossDReward { get; set; }
	public short BossExReward { get; set; }
	public bool BossANewest { get; set; }
	public bool BossBNewest { get; set; }
	public bool BossCNewest { get; set; }
	public bool BossDNewest { get; set; }
	public bool BossExNewest { get; set; }
	public short Spina { get; set; }
	public bool TurnLimit { get; set; }
	public List<byte> DrawCardIndexs { get; set; }
	public CardGameTurnCardData TurnEndAttack { get; set; }
	public List<byte> TurnEndMarketBuy { get; set; }
	public List<byte> TurnEndMarketSell { get; set; }

	// Methods

	// RVA: 0x361EFA0 Offset: 0x361AFA0 VA: 0x361EFA0
	public void .ctor() { }

	// RVA: 0x361F054 Offset: 0x361B054 VA: 0x361F054
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x361F05C Offset: 0x361B05C VA: 0x361F05C
	public byte get_TurnCount() { }

	[CompilerGenerated]
	// RVA: 0x361F064 Offset: 0x361B064 VA: 0x361F064
	public void set_TurnCount(byte value) { }

	[CompilerGenerated]
	// RVA: 0x361F06C Offset: 0x361B06C VA: 0x361F06C
	public List<byte> get_Hand() { }

	[CompilerGenerated]
	// RVA: 0x361F074 Offset: 0x361B074 VA: 0x361F074
	public void set_Hand(List<byte> value) { }

	[CompilerGenerated]
	// RVA: 0x361F07C Offset: 0x361B07C VA: 0x361F07C
	public byte get_Market1() { }

	[CompilerGenerated]
	// RVA: 0x361F084 Offset: 0x361B084 VA: 0x361F084
	public void set_Market1(byte value) { }

	[CompilerGenerated]
	// RVA: 0x361F08C Offset: 0x361B08C VA: 0x361F08C
	public byte get_Market2() { }

	[CompilerGenerated]
	// RVA: 0x361F094 Offset: 0x361B094 VA: 0x361F094
	public void set_Market2(byte value) { }

	[CompilerGenerated]
	// RVA: 0x361F09C Offset: 0x361B09C VA: 0x361F09C
	public byte get_Market3() { }

	[CompilerGenerated]
	// RVA: 0x361F0A4 Offset: 0x361B0A4 VA: 0x361F0A4
	public void set_Market3(byte value) { }

	[CompilerGenerated]
	// RVA: 0x361F0AC Offset: 0x361B0AC VA: 0x361F0AC
	public byte get_BossAHp() { }

	[CompilerGenerated]
	// RVA: 0x361F0B4 Offset: 0x361B0B4 VA: 0x361F0B4
	public void set_BossAHp(byte value) { }

	[CompilerGenerated]
	// RVA: 0x361F0BC Offset: 0x361B0BC VA: 0x361F0BC
	public byte get_BossBHp() { }

	[CompilerGenerated]
	// RVA: 0x361F0C4 Offset: 0x361B0C4 VA: 0x361F0C4
	public void set_BossBHp(byte value) { }

	[CompilerGenerated]
	// RVA: 0x361F0CC Offset: 0x361B0CC VA: 0x361F0CC
	public byte get_BossCHp() { }

	[CompilerGenerated]
	// RVA: 0x361F0D4 Offset: 0x361B0D4 VA: 0x361F0D4
	public void set_BossCHp(byte value) { }

	[CompilerGenerated]
	// RVA: 0x361F0DC Offset: 0x361B0DC VA: 0x361F0DC
	public byte get_BossDHp() { }

	[CompilerGenerated]
	// RVA: 0x361F0E4 Offset: 0x361B0E4 VA: 0x361F0E4
	public void set_BossDHp(byte value) { }

	[CompilerGenerated]
	// RVA: 0x361F0EC Offset: 0x361B0EC VA: 0x361F0EC
	public byte get_BossExHp() { }

	[CompilerGenerated]
	// RVA: 0x361F0F4 Offset: 0x361B0F4 VA: 0x361F0F4
	public void set_BossExHp(byte value) { }

	[CompilerGenerated]
	// RVA: 0x361F0FC Offset: 0x361B0FC VA: 0x361F0FC
	public byte get_ServerBossAHp() { }

	[CompilerGenerated]
	// RVA: 0x361F104 Offset: 0x361B104 VA: 0x361F104
	public void set_ServerBossAHp(byte value) { }

	[CompilerGenerated]
	// RVA: 0x361F10C Offset: 0x361B10C VA: 0x361F10C
	public byte get_ServerBossBHp() { }

	[CompilerGenerated]
	// RVA: 0x361F114 Offset: 0x361B114 VA: 0x361F114
	public void set_ServerBossBHp(byte value) { }

	[CompilerGenerated]
	// RVA: 0x361F11C Offset: 0x361B11C VA: 0x361F11C
	public byte get_ServerBossCHp() { }

	[CompilerGenerated]
	// RVA: 0x361F124 Offset: 0x361B124 VA: 0x361F124
	public void set_ServerBossCHp(byte value) { }

	[CompilerGenerated]
	// RVA: 0x361F12C Offset: 0x361B12C VA: 0x361F12C
	public byte get_ServerBossDHp() { }

	[CompilerGenerated]
	// RVA: 0x361F134 Offset: 0x361B134 VA: 0x361F134
	public void set_ServerBossDHp(byte value) { }

	[CompilerGenerated]
	// RVA: 0x361F13C Offset: 0x361B13C VA: 0x361F13C
	public byte get_ServerBossExHp() { }

	[CompilerGenerated]
	// RVA: 0x361F144 Offset: 0x361B144 VA: 0x361F144
	public void set_ServerBossExHp(byte value) { }

	[CompilerGenerated]
	// RVA: 0x361F14C Offset: 0x361B14C VA: 0x361F14C
	public short get_BossAReward() { }

	[CompilerGenerated]
	// RVA: 0x361F154 Offset: 0x361B154 VA: 0x361F154
	public void set_BossAReward(short value) { }

	[CompilerGenerated]
	// RVA: 0x361F15C Offset: 0x361B15C VA: 0x361F15C
	public short get_BossBReward() { }

	[CompilerGenerated]
	// RVA: 0x361F164 Offset: 0x361B164 VA: 0x361F164
	public void set_BossBReward(short value) { }

	[CompilerGenerated]
	// RVA: 0x361F16C Offset: 0x361B16C VA: 0x361F16C
	public short get_BossCReward() { }

	[CompilerGenerated]
	// RVA: 0x361F174 Offset: 0x361B174 VA: 0x361F174
	public void set_BossCReward(short value) { }

	[CompilerGenerated]
	// RVA: 0x361F17C Offset: 0x361B17C VA: 0x361F17C
	public short get_BossDReward() { }

	[CompilerGenerated]
	// RVA: 0x361F184 Offset: 0x361B184 VA: 0x361F184
	public void set_BossDReward(short value) { }

	[CompilerGenerated]
	// RVA: 0x361F18C Offset: 0x361B18C VA: 0x361F18C
	public short get_BossExReward() { }

	[CompilerGenerated]
	// RVA: 0x361F194 Offset: 0x361B194 VA: 0x361F194
	public void set_BossExReward(short value) { }

	[CompilerGenerated]
	// RVA: 0x361F19C Offset: 0x361B19C VA: 0x361F19C
	public bool get_BossANewest() { }

	[CompilerGenerated]
	// RVA: 0x361F1A4 Offset: 0x361B1A4 VA: 0x361F1A4
	public void set_BossANewest(bool value) { }

	[CompilerGenerated]
	// RVA: 0x361F1B0 Offset: 0x361B1B0 VA: 0x361F1B0
	public bool get_BossBNewest() { }

	[CompilerGenerated]
	// RVA: 0x361F1B8 Offset: 0x361B1B8 VA: 0x361F1B8
	public void set_BossBNewest(bool value) { }

	[CompilerGenerated]
	// RVA: 0x361F1C4 Offset: 0x361B1C4 VA: 0x361F1C4
	public bool get_BossCNewest() { }

	[CompilerGenerated]
	// RVA: 0x361F1CC Offset: 0x361B1CC VA: 0x361F1CC
	public void set_BossCNewest(bool value) { }

	[CompilerGenerated]
	// RVA: 0x361F1D8 Offset: 0x361B1D8 VA: 0x361F1D8
	public bool get_BossDNewest() { }

	[CompilerGenerated]
	// RVA: 0x361F1E0 Offset: 0x361B1E0 VA: 0x361F1E0
	public void set_BossDNewest(bool value) { }

	[CompilerGenerated]
	// RVA: 0x361F1EC Offset: 0x361B1EC VA: 0x361F1EC
	public bool get_BossExNewest() { }

	[CompilerGenerated]
	// RVA: 0x361F1F4 Offset: 0x361B1F4 VA: 0x361F1F4
	public void set_BossExNewest(bool value) { }

	[CompilerGenerated]
	// RVA: 0x361F200 Offset: 0x361B200 VA: 0x361F200
	public short get_Spina() { }

	[CompilerGenerated]
	// RVA: 0x361F208 Offset: 0x361B208 VA: 0x361F208
	public void set_Spina(short value) { }

	[CompilerGenerated]
	// RVA: 0x361F210 Offset: 0x361B210 VA: 0x361F210
	public bool get_TurnLimit() { }

	[CompilerGenerated]
	// RVA: 0x361F218 Offset: 0x361B218 VA: 0x361F218
	public void set_TurnLimit(bool value) { }

	[CompilerGenerated]
	// RVA: 0x361F224 Offset: 0x361B224 VA: 0x361F224
	public List<byte> get_DrawCardIndexs() { }

	[CompilerGenerated]
	// RVA: 0x361F22C Offset: 0x361B22C VA: 0x361F22C
	public void set_DrawCardIndexs(List<byte> value) { }

	[CompilerGenerated]
	// RVA: 0x361F234 Offset: 0x361B234 VA: 0x361F234
	public CardGameTurnCardData get_TurnEndAttack() { }

	[CompilerGenerated]
	// RVA: 0x361F23C Offset: 0x361B23C VA: 0x361F23C
	public void set_TurnEndAttack(CardGameTurnCardData value) { }

	[CompilerGenerated]
	// RVA: 0x361F244 Offset: 0x361B244 VA: 0x361F244
	public List<byte> get_TurnEndMarketBuy() { }

	[CompilerGenerated]
	// RVA: 0x361F24C Offset: 0x361B24C VA: 0x361F24C
	public void set_TurnEndMarketBuy(List<byte> value) { }

	[CompilerGenerated]
	// RVA: 0x361F254 Offset: 0x361B254 VA: 0x361F254
	public List<byte> get_TurnEndMarketSell() { }

	[CompilerGenerated]
	// RVA: 0x361F25C Offset: 0x361B25C VA: 0x361F25C
	public void set_TurnEndMarketSell(List<byte> value) { }

	// RVA: 0x361F264 Offset: 0x361B264 VA: 0x361F264 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x361F844 Offset: 0x361B844 VA: 0x361F844 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x361FFF4 Offset: 0x361BFF4 VA: 0x361FFF4 Slot: 3
	public override string ToString() { }
}
