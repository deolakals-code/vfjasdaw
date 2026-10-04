// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Rooms.ScoreAttack
public class ScoreAttackResultData : BossResultData // TypeDefIndex: 11343
{
	// Fields
	[CompilerGenerated]
	private bool <IsSolo>k__BackingField; // 0x71
	[CompilerGenerated]
	private long <TotalDamage>k__BackingField; // 0x78
	[CompilerGenerated]
	private Tuple<ArchetypeUid, long>[] <DamageScoreList>k__BackingField; // 0x80
	[CompilerGenerated]
	private Tuple<byte, byte>[] <BonusScoreList>k__BackingField; // 0x88
	[CompilerGenerated]
	private long <AttackerScore>k__BackingField; // 0x90
	[CompilerGenerated]
	private int <DefenderScore>k__BackingField; // 0x98
	[CompilerGenerated]
	private int <SupporterScore>k__BackingField; // 0x9C
	[CompilerGenerated]
	private int <BreakerScore>k__BackingField; // 0xA0
	[CompilerGenerated]
	private int <AssisterScore>k__BackingField; // 0xA4

	// Properties
	public bool IsSolo { get; set; }
	public long TotalDamage { get; set; }
	public Tuple<ArchetypeUid, long>[] DamageScoreList { get; set; }
	public Tuple<byte, byte>[] BonusScoreList { get; set; }
	public long TotalScore { get; }
	public long AttackerScore { get; set; }
	public int DefenderScore { get; set; }
	public int SupporterScore { get; set; }
	public int BreakerScore { get; set; }
	public int AssisterScore { get; set; }

	// Methods

	// RVA: 0x36EED84 Offset: 0x36EAD84 VA: 0x36EED84
	public void .ctor() { }

	// RVA: 0x36EED8C Offset: 0x36EAD8C VA: 0x36EED8C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36EED94 Offset: 0x36EAD94 VA: 0x36EED94
	public bool get_IsSolo() { }

	[CompilerGenerated]
	// RVA: 0x36EED9C Offset: 0x36EAD9C VA: 0x36EED9C
	public void set_IsSolo(bool value) { }

	[CompilerGenerated]
	// RVA: 0x36EEDA8 Offset: 0x36EADA8 VA: 0x36EEDA8
	public long get_TotalDamage() { }

	[CompilerGenerated]
	// RVA: 0x36EEDB0 Offset: 0x36EADB0 VA: 0x36EEDB0
	public void set_TotalDamage(long value) { }

	[CompilerGenerated]
	// RVA: 0x36EEDB8 Offset: 0x36EADB8 VA: 0x36EEDB8
	public Tuple<ArchetypeUid, long>[] get_DamageScoreList() { }

	[CompilerGenerated]
	// RVA: 0x36EEDC0 Offset: 0x36EADC0 VA: 0x36EEDC0
	public void set_DamageScoreList(Tuple<ArchetypeUid, long>[] value) { }

	[CompilerGenerated]
	// RVA: 0x36EEDC8 Offset: 0x36EADC8 VA: 0x36EEDC8
	public Tuple<byte, byte>[] get_BonusScoreList() { }

	[CompilerGenerated]
	// RVA: 0x36EEDD0 Offset: 0x36EADD0 VA: 0x36EEDD0
	public void set_BonusScoreList(Tuple<byte, byte>[] value) { }

	// RVA: 0x36EEDD8 Offset: 0x36EADD8 VA: 0x36EEDD8
	public long get_TotalScore() { }

	[CompilerGenerated]
	// RVA: 0x36EEEEC Offset: 0x36EAEEC VA: 0x36EEEEC
	public long get_AttackerScore() { }

	[CompilerGenerated]
	// RVA: 0x36EEEF4 Offset: 0x36EAEF4 VA: 0x36EEEF4
	public void set_AttackerScore(long value) { }

	[CompilerGenerated]
	// RVA: 0x36EEEFC Offset: 0x36EAEFC VA: 0x36EEEFC
	public int get_DefenderScore() { }

	[CompilerGenerated]
	// RVA: 0x36EEF04 Offset: 0x36EAF04 VA: 0x36EEF04
	public void set_DefenderScore(int value) { }

	[CompilerGenerated]
	// RVA: 0x36EEF0C Offset: 0x36EAF0C VA: 0x36EEF0C
	public int get_SupporterScore() { }

	[CompilerGenerated]
	// RVA: 0x36EEF14 Offset: 0x36EAF14 VA: 0x36EEF14
	public void set_SupporterScore(int value) { }

	[CompilerGenerated]
	// RVA: 0x36EEF1C Offset: 0x36EAF1C VA: 0x36EEF1C
	public int get_BreakerScore() { }

	[CompilerGenerated]
	// RVA: 0x36EEF24 Offset: 0x36EAF24 VA: 0x36EEF24
	public void set_BreakerScore(int value) { }

	[CompilerGenerated]
	// RVA: 0x36EEF2C Offset: 0x36EAF2C VA: 0x36EEF2C
	public int get_AssisterScore() { }

	[CompilerGenerated]
	// RVA: 0x36EEF34 Offset: 0x36EAF34 VA: 0x36EEF34
	public void set_AssisterScore(int value) { }

	// RVA: 0x36EEF3C Offset: 0x36EAF3C VA: 0x36EEF3C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36EFA10 Offset: 0x36EBA10 VA: 0x36EFA10 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
