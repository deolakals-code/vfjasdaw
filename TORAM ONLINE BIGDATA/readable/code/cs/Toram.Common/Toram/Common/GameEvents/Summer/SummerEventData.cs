// Assembly: Toram.Common.dll
// Namespace: Toram.Common.GameEvents.Summer
public class SummerEventData : GameEventDataBase // TypeDefIndex: 11190
{
	// Fields
	public const int SummerVersion = 2019;
	public const byte NowSeaGoodsVersion = 1;
	public const byte StaminaMax = 10;
	public const byte StaminaOrbRecovery = 3;
	public const byte RecoverableStamina = 7;
	public static readonly int StaminaRecvCoolHourTime; // 0x0
	public static readonly double EatCountCoolSecond; // 0x8
	public readonly short EventMaxHp; // 0x1A
	private GameEventScenarioData scenarioData; // 0x20
	protected readonly short[] seaGoods; // 0x28
	protected readonly Dictionary<short, int> alreadyExchList; // 0x30
	[CompilerGenerated]
	private byte <Stamina>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <Point>k__BackingField; // 0x3C
	[CompilerGenerated]
	private DateTime <StaminaRecvStartTime>k__BackingField; // 0x40
	[CompilerGenerated]
	private byte <EatCount>k__BackingField; // 0x48
	[CompilerGenerated]
	private DateTime <EatStartTime>k__BackingField; // 0x50
	[CompilerGenerated]
	private int <Hp>k__BackingField; // 0x58
	[CompilerGenerated]
	private SummerResultData <SummerResult>k__BackingField; // 0x60
	[CompilerGenerated]
	private byte <InnerVersion>k__BackingField; // 0x68
	[CompilerGenerated]
	private byte <SeaGoodsVersion>k__BackingField; // 0x69

	// Properties
	protected virtual byte NowInnerVersion { get; }
	public override int Version { get; }
	public override byte Code { get; }
	public byte Stamina { get; set; }
	public int Point { get; set; }
	[CLSCompliant(False)]
	public Dictionary<short, int> AlreadyExchList { get; }
	public DateTime StaminaRecvStartTime { get; set; }
	public byte EatCount { get; set; }
	public DateTime EatStartTime { get; set; }
	public short Harpoon { get; set; }
	public short SeaManDrink { get; set; }
	public short MermaidFin { get; set; }
	public short SuperMory { get; set; }
	public int Hp { get; set; }
	public SummerResultData SummerResult { get; set; }
	public byte InnerVersion { get; set; }
	public byte SeaGoodsVersion { get; set; }

	// Methods

	// RVA: 0x35D4878 Offset: 0x35D0878 VA: 0x35D4878 Slot: 11
	protected virtual byte get_NowInnerVersion() { }

	// RVA: 0x35D4880 Offset: 0x35D0880 VA: 0x35D4880
	public void .ctor() { }

	// RVA: 0x35D4940 Offset: 0x35D0940 VA: 0x35D4940 Slot: 7
	public override int get_Version() { }

	// RVA: 0x35D4948 Offset: 0x35D0948 VA: 0x35D4948 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x35D4950 Offset: 0x35D0950 VA: 0x35D4950
	public byte get_Stamina() { }

	[CompilerGenerated]
	// RVA: 0x35D4958 Offset: 0x35D0958 VA: 0x35D4958
	public void set_Stamina(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35D4960 Offset: 0x35D0960 VA: 0x35D4960
	public int get_Point() { }

	[CompilerGenerated]
	// RVA: 0x35D4968 Offset: 0x35D0968 VA: 0x35D4968
	public void set_Point(int value) { }

	// RVA: 0x35D4970 Offset: 0x35D0970 VA: 0x35D4970
	public Dictionary<short, int> get_AlreadyExchList() { }

	[CompilerGenerated]
	// RVA: 0x35D4978 Offset: 0x35D0978 VA: 0x35D4978
	public DateTime get_StaminaRecvStartTime() { }

	[CompilerGenerated]
	// RVA: 0x35D4980 Offset: 0x35D0980 VA: 0x35D4980
	public void set_StaminaRecvStartTime(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x35D4988 Offset: 0x35D0988 VA: 0x35D4988
	public byte get_EatCount() { }

	[CompilerGenerated]
	// RVA: 0x35D4990 Offset: 0x35D0990 VA: 0x35D4990
	public void set_EatCount(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35D4998 Offset: 0x35D0998 VA: 0x35D4998
	public DateTime get_EatStartTime() { }

	[CompilerGenerated]
	// RVA: 0x35D49A0 Offset: 0x35D09A0 VA: 0x35D49A0
	public void set_EatStartTime(DateTime value) { }

	// RVA: 0x35D49A8 Offset: 0x35D09A8 VA: 0x35D49A8
	public short get_Harpoon() { }

	// RVA: 0x35D49D4 Offset: 0x35D09D4 VA: 0x35D49D4
	public void set_Harpoon(short value) { }

	// RVA: 0x35D4A00 Offset: 0x35D0A00 VA: 0x35D4A00
	public short get_SeaManDrink() { }

	// RVA: 0x35D4A2C Offset: 0x35D0A2C VA: 0x35D4A2C
	public void set_SeaManDrink(short value) { }

	// RVA: 0x35D4A58 Offset: 0x35D0A58 VA: 0x35D4A58
	public short get_MermaidFin() { }

	// RVA: 0x35D4A84 Offset: 0x35D0A84 VA: 0x35D4A84
	public void set_MermaidFin(short value) { }

	// RVA: 0x35D4AB0 Offset: 0x35D0AB0 VA: 0x35D4AB0
	public short get_SuperMory() { }

	// RVA: 0x35D4ADC Offset: 0x35D0ADC VA: 0x35D4ADC
	public void set_SuperMory(short value) { }

	[CompilerGenerated]
	// RVA: 0x35D4B08 Offset: 0x35D0B08 VA: 0x35D4B08
	public int get_Hp() { }

	[CompilerGenerated]
	// RVA: 0x35D4B10 Offset: 0x35D0B10 VA: 0x35D4B10
	protected void set_Hp(int value) { }

	[CompilerGenerated]
	// RVA: 0x35D4B18 Offset: 0x35D0B18 VA: 0x35D4B18
	public SummerResultData get_SummerResult() { }

	[CompilerGenerated]
	// RVA: 0x35D4B20 Offset: 0x35D0B20 VA: 0x35D4B20
	protected void set_SummerResult(SummerResultData value) { }

	[CompilerGenerated]
	// RVA: 0x35D4B28 Offset: 0x35D0B28 VA: 0x35D4B28
	public byte get_InnerVersion() { }

	[CompilerGenerated]
	// RVA: 0x35D4B30 Offset: 0x35D0B30 VA: 0x35D4B30
	public void set_InnerVersion(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35D4B38 Offset: 0x35D0B38 VA: 0x35D4B38
	public byte get_SeaGoodsVersion() { }

	[CompilerGenerated]
	// RVA: 0x35D4B40 Offset: 0x35D0B40 VA: 0x35D4B40
	public void set_SeaGoodsVersion(byte value) { }

	// RVA: 0x35D4B48 Offset: 0x35D0B48 VA: 0x35D4B48 Slot: 8
	protected override bool VersionInitialize() { }

	// RVA: 0x35D4CA4 Offset: 0x35D0CA4 VA: 0x35D4CA4 Slot: 9
	protected override void Serialize(MemoryStream ms) { }

	// RVA: 0x35D4FC8 Offset: 0x35D0FC8 VA: 0x35D4FC8 Slot: 10
	protected override bool Deserialize(MemoryStream ms, bool isInitialize) { }

	// RVA: 0x35D555C Offset: 0x35D155C VA: 0x35D555C Slot: 12
	public virtual SummerResultData GetSummerResultData(byte[] binary) { }

	// RVA: 0x35D55C4 Offset: 0x35D15C4 VA: 0x35D55C4
	private static void .cctor() { }
}
