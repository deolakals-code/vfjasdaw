// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.Roguelike
public class RoguelikeChangePhaseEvent : EventSubBase // TypeDefIndex: 12804
{
	// Fields
	[CompilerGenerated]
	private byte <Phase>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <StageIndex>k__BackingField; // 0x21
	[CompilerGenerated]
	private int <LimitTimeSec>k__BackingField; // 0x24
	[CompilerGenerated]
	private bool <IsRecovered>k__BackingField; // 0x28
	[CompilerGenerated]
	private Tuple<short, short>[] <BuffOptions>k__BackingField; // 0x30
	[CompilerGenerated]
	private BossSymbolData <BossSymbolData>k__BackingField; // 0x38
	[CompilerGenerated]
	private MobResponseData[] <MobList>k__BackingField; // 0x40

	// Properties
	public byte Phase { get; set; }
	public byte StageIndex { get; set; }
	public int LimitTimeSec { get; set; }
	public bool IsRecovered { get; set; }
	public Tuple<short, short>[] BuffOptions { get; set; }
	public BossSymbolData BossSymbolData { get; set; }
	public MobResponseData[] MobList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x365D2E0 Offset: 0x36592E0 VA: 0x365D2E0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x365D2E8 Offset: 0x36592E8 VA: 0x365D2E8
	public byte get_Phase() { }

	[CompilerGenerated]
	// RVA: 0x365D2F0 Offset: 0x36592F0 VA: 0x365D2F0
	public void set_Phase(byte value) { }

	[CompilerGenerated]
	// RVA: 0x365D2F8 Offset: 0x36592F8 VA: 0x365D2F8
	public byte get_StageIndex() { }

	[CompilerGenerated]
	// RVA: 0x365D300 Offset: 0x3659300 VA: 0x365D300
	public void set_StageIndex(byte value) { }

	[CompilerGenerated]
	// RVA: 0x365D308 Offset: 0x3659308 VA: 0x365D308
	public int get_LimitTimeSec() { }

	[CompilerGenerated]
	// RVA: 0x365D310 Offset: 0x3659310 VA: 0x365D310
	public void set_LimitTimeSec(int value) { }

	[CompilerGenerated]
	// RVA: 0x365D318 Offset: 0x3659318 VA: 0x365D318
	public bool get_IsRecovered() { }

	[CompilerGenerated]
	// RVA: 0x365D320 Offset: 0x3659320 VA: 0x365D320
	public void set_IsRecovered(bool value) { }

	[CompilerGenerated]
	// RVA: 0x365D32C Offset: 0x365932C VA: 0x365D32C
	public Tuple<short, short>[] get_BuffOptions() { }

	[CompilerGenerated]
	// RVA: 0x365D334 Offset: 0x3659334 VA: 0x365D334
	public void set_BuffOptions(Tuple<short, short>[] value) { }

	[CompilerGenerated]
	// RVA: 0x365D33C Offset: 0x365933C VA: 0x365D33C
	public BossSymbolData get_BossSymbolData() { }

	[CompilerGenerated]
	// RVA: 0x365D344 Offset: 0x3659344 VA: 0x365D344
	public void set_BossSymbolData(BossSymbolData value) { }

	[CompilerGenerated]
	// RVA: 0x365D34C Offset: 0x365934C VA: 0x365D34C
	public MobResponseData[] get_MobList() { }

	[CompilerGenerated]
	// RVA: 0x365D354 Offset: 0x3659354 VA: 0x365D354
	public void set_MobList(MobResponseData[] value) { }

	// RVA: 0x365D35C Offset: 0x365935C VA: 0x365D35C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x365D364 Offset: 0x3659364 VA: 0x365D364 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x365D36C Offset: 0x365936C VA: 0x365D36C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x365D6A8 Offset: 0x36596A8 VA: 0x365D6A8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
