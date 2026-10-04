// Assembly: Toram.Common.dll
// Namespace: Toram.Common.ScoreAttack
public class ScoreAttackScoreData_Solo : ScoreAttackScoreDataBase // TypeDefIndex: 11267
{
	// Fields
	[CompilerGenerated]
	private ScoreAttackRankingCompanionData[] <CompanionList>k__BackingField; // 0x30

	// Properties
	public ScoreAttackRankingCompanionData[] CompanionList { get; set; }

	// Methods

	// RVA: 0x36D3BB4 Offset: 0x36CFBB4 VA: 0x36D3BB4
	public void .ctor() { }

	// RVA: 0x36D3BBC Offset: 0x36CFBBC VA: 0x36D3BBC
	public void .ctor(byte[] binary) { }

	// RVA: 0x36D3BC4 Offset: 0x36CFBC4 VA: 0x36D3BC4
	public void .ctor(long point, byte mainWeapon, byte subWeapon, short lv, byte[] cBinary) { }

	[CompilerGenerated]
	// RVA: 0x36D3F0C Offset: 0x36CFF0C VA: 0x36D3F0C
	public ScoreAttackRankingCompanionData[] get_CompanionList() { }

	[CompilerGenerated]
	// RVA: 0x36D3F14 Offset: 0x36CFF14 VA: 0x36D3F14
	public void set_CompanionList(ScoreAttackRankingCompanionData[] value) { }

	// RVA: 0x36D3F1C Offset: 0x36CFF1C VA: 0x36D3F1C Slot: 3
	public override string ToString() { }

	// RVA: 0x36D4194 Offset: 0x36D0194 VA: 0x36D4194 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36D4440 Offset: 0x36D0440 VA: 0x36D4440 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36D41D4 Offset: 0x36D01D4 VA: 0x36D41D4
	public static byte[] SerializeCompanionList(ScoreAttackRankingCompanionData[] list) { }

	// RVA: 0x36D3C2C Offset: 0x36CFC2C VA: 0x36D3C2C
	public static ScoreAttackRankingCompanionData[] DeserializeCompanionList(byte[] bytes) { }
}
