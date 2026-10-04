// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BossScoreData.Score // TypeDefIndex: 2319
{
	// Fields
	private long attacker; // 0x10
	private int defender; // 0x18
	private int supporter; // 0x1C
	private int breaker; // 0x20
	private int assister; // 0x24
	private Dictionary<int, float> mobHateList; // 0x28
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <DeadCount>k__BackingField; // 0x34

	// Properties
	public int ArchetypeId { get; set; }
	public long AttackerScore { get; }
	public int DefenderScore { get; }
	public int SupporterScore { get; }
	public int BreakerScore { get; }
	public int AssisterScore { get; }
	public int DeadCount { get; set; }
	public float DeadRate { get; }

	// Methods

	// RVA: 0x2184E94 Offset: 0x2180E94 VA: 0x2184E94
	public void .ctor(int archetypeId) { }

	[CompilerGenerated]
	// RVA: 0x218508C Offset: 0x218108C VA: 0x218508C
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x2185094 Offset: 0x2181094 VA: 0x2185094
	private void set_ArchetypeId(int value) { }

	// RVA: 0x218509C Offset: 0x218109C VA: 0x218509C
	public long get_AttackerScore() { }

	// RVA: 0x218514C Offset: 0x218114C VA: 0x218514C
	public int get_DefenderScore() { }

	// RVA: 0x21852B8 Offset: 0x21812B8 VA: 0x21852B8
	public int get_SupporterScore() { }

	// RVA: 0x21852F4 Offset: 0x21812F4 VA: 0x21852F4
	public int get_BreakerScore() { }

	// RVA: 0x2185330 Offset: 0x2181330 VA: 0x2185330
	public int get_AssisterScore() { }

	[CompilerGenerated]
	// RVA: 0x218536C Offset: 0x218136C VA: 0x218536C
	public int get_DeadCount() { }

	[CompilerGenerated]
	// RVA: 0x2185374 Offset: 0x2181374 VA: 0x2185374
	private void set_DeadCount(int value) { }

	// RVA: 0x21850D0 Offset: 0x21810D0 VA: 0x21850D0
	public float get_DeadRate() { }

	// RVA: 0x2184BE0 Offset: 0x2180BE0 VA: 0x2184BE0
	public void Update() { }

	// RVA: 0x2184F2C Offset: 0x2180F2C VA: 0x2184F2C
	public void UpdateScore(byte type, long val, byte flag, int uid) { }
}
