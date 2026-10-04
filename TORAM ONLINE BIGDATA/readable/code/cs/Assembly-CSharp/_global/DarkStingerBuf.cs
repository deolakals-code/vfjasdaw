// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DarkStingerBuf : SkillBufferDataBase // TypeDefIndex: 3120
{
	// Fields
	private const float DefaultTime = 30;
	private const int MAX_STACK = 5;
	private int maxHp; // 0x20
	private int stack; // 0x24

	// Properties
	public override SkillId SkillId { get; }

	// Methods

	// RVA: 0x23291A8 Offset: 0x23251A8 VA: 0x23291A8 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x23291B0 Offset: 0x23251B0 VA: 0x23291B0
	public void .ctor(byte lv) { }

	// RVA: 0x23291E0 Offset: 0x23251E0 VA: 0x23291E0 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x232921C Offset: 0x232521C VA: 0x232921C Slot: 11
	public override void Updata() { }

	// RVA: 0x2329270 Offset: 0x2325270 VA: 0x2329270
	public void Stack() { }
}
