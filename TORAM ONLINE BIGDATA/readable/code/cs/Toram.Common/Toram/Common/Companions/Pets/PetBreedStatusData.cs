// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Companions.Pets
public class PetBreedStatusData : BinaryBase // TypeDefIndex: 12949
{
	// Fields
	public static readonly long FeedEffectTime; // 0x0
	public const int StaminaMax = 10000;
	public const int AffinityMax = 10000;
	public const int TrainMax = 10000;
	protected int value; // 0x1C
	[CompilerGenerated]
	private short <Affinity>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Stamina>k__BackingField; // 0x22
	[CompilerGenerated]
	private DateTime <StaminaTime>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <Train>k__BackingField; // 0x30
	[CompilerGenerated]
	private DateTime <FeedTime>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte <FeedEffect>k__BackingField; // 0x40
	[CompilerGenerated]
	private byte <State>k__BackingField; // 0x41

	// Properties
	public short Affinity { get; set; }
	public short Stamina { get; set; }
	public DateTime StaminaTime { get; set; }
	public short Train { get; set; }
	public DateTime FeedTime { get; set; }
	public byte FeedEffect { get; set; }
	public byte State { get; set; }
	public byte LimitExp { get; }
	public bool NotLimitup { get; }

	// Methods

	// RVA: 0x367F488 Offset: 0x367B488 VA: 0x367F488
	public void .ctor() { }

	// RVA: 0x367F514 Offset: 0x367B514 VA: 0x367F514
	public void .ctor(byte[] binary) { }

	// RVA: 0x367F51C Offset: 0x367B51C VA: 0x367F51C
	public void .ctor(MemoryStream ms) { }

	[CompilerGenerated]
	// RVA: 0x367F524 Offset: 0x367B524 VA: 0x367F524
	public short get_Affinity() { }

	[CompilerGenerated]
	// RVA: 0x367F52C Offset: 0x367B52C VA: 0x367F52C
	protected void set_Affinity(short value) { }

	[CompilerGenerated]
	// RVA: 0x367F534 Offset: 0x367B534 VA: 0x367F534
	public short get_Stamina() { }

	[CompilerGenerated]
	// RVA: 0x367F53C Offset: 0x367B53C VA: 0x367F53C
	protected void set_Stamina(short value) { }

	[CompilerGenerated]
	// RVA: 0x367F544 Offset: 0x367B544 VA: 0x367F544
	public DateTime get_StaminaTime() { }

	[CompilerGenerated]
	// RVA: 0x367F54C Offset: 0x367B54C VA: 0x367F54C
	protected void set_StaminaTime(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x367F554 Offset: 0x367B554 VA: 0x367F554
	public short get_Train() { }

	[CompilerGenerated]
	// RVA: 0x367F55C Offset: 0x367B55C VA: 0x367F55C
	protected void set_Train(short value) { }

	[CompilerGenerated]
	// RVA: 0x367F564 Offset: 0x367B564 VA: 0x367F564
	public DateTime get_FeedTime() { }

	[CompilerGenerated]
	// RVA: 0x367F56C Offset: 0x367B56C VA: 0x367F56C
	protected void set_FeedTime(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x367F574 Offset: 0x367B574 VA: 0x367F574
	public byte get_FeedEffect() { }

	[CompilerGenerated]
	// RVA: 0x367F57C Offset: 0x367B57C VA: 0x367F57C
	protected void set_FeedEffect(byte value) { }

	[CompilerGenerated]
	// RVA: 0x367F584 Offset: 0x367B584 VA: 0x367F584
	public byte get_State() { }

	[CompilerGenerated]
	// RVA: 0x367F58C Offset: 0x367B58C VA: 0x367F58C
	protected void set_State(byte value) { }

	// RVA: 0x367F594 Offset: 0x367B594 VA: 0x367F594
	public byte get_LimitExp() { }

	// RVA: 0x367F59C Offset: 0x367B59C VA: 0x367F59C
	public bool get_NotLimitup() { }

	// RVA: 0x367F5A8 Offset: 0x367B5A8 VA: 0x367F5A8
	protected long GetConvertElapsedTicks(DateTime now, DateTime baseTime) { }

	// RVA: 0x367F644 Offset: 0x367B644 VA: 0x367F644
	public bool IsGroggy() { }

	// RVA: 0x367F650 Offset: 0x367B650 VA: 0x367F650 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x367F7D4 Offset: 0x367B7D4 VA: 0x367F7D4
	public void GetSpecialBinary(MemoryStream ms) { }

	// RVA: 0x367F8D0 Offset: 0x367B8D0 VA: 0x367F8D0
	public byte[] GetSpecialBinary() { }

	// RVA: 0x367FAB4 Offset: 0x367BAB4 VA: 0x367FAB4 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x367FB50 Offset: 0x367BB50 VA: 0x367FB50
	private static void .cctor() { }
}
