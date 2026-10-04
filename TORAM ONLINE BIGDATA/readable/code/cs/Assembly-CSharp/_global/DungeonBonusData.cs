// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DungeonBonusData // TypeDefIndex: 1746
{
	// Fields
	private BonusData bonusData; // 0x10
	[CompilerGenerated]
	private byte <Count>k__BackingField; // 0x18
	public readonly DungeonEventType DungeonEventType; // 0x1C
	private readonly DateTime startTime; // 0x20
	private readonly int endTime; // 0x28

	// Properties
	public BonusData BonusData { get; }
	public byte Count { get; set; }
	public bool IsEnd { get; }

	// Methods

	// RVA: 0x20C0EB0 Offset: 0x20BCEB0 VA: 0x20C0EB0
	public BonusData get_BonusData() { }

	[CompilerGenerated]
	// RVA: 0x20C0EB8 Offset: 0x20BCEB8 VA: 0x20C0EB8
	public byte get_Count() { }

	[CompilerGenerated]
	// RVA: 0x20C0EC0 Offset: 0x20BCEC0 VA: 0x20C0EC0
	private void set_Count(byte value) { }

	// RVA: 0x20C0EC8 Offset: 0x20BCEC8 VA: 0x20C0EC8
	public bool get_IsEnd() { }

	// RVA: 0x20C0F7C Offset: 0x20BCF7C VA: 0x20C0F7C
	public void .ctor(DungeonEventType eventType) { }

	// RVA: 0x20C1004 Offset: 0x20BD004 VA: 0x20C1004
	public void CountUp() { }

	// RVA: 0x20C1024 Offset: 0x20BD024 VA: 0x20C1024
	public void SetBonusData(BonusData bonusData) { }

	// RVA: 0x20C102C Offset: 0x20BD02C VA: 0x20C102C
	public IList<BonusParameter> GetBonusParameter() { }
}
