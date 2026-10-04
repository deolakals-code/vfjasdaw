// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SacredTeachingsBuf : CountBufferBase // TypeDefIndex: 3294
{
	// Fields
	private readonly int MaxOverHealValue; // 0x28
	private int overHealValue; // 0x2C
	private int localOverHealValue; // 0x30

	// Properties
	public override SkillId SkillId { get; }
	public override CountBufferBase.CountType BufferType { get; }

	// Methods

	// RVA: 0x23443B0 Offset: 0x23403B0 VA: 0x23443B0
	public void .ctor(byte lv) { }

	// RVA: 0x23443EC Offset: 0x23403EC VA: 0x23443EC Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x23443F4 Offset: 0x23403F4 VA: 0x23443F4 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x23443FC Offset: 0x23403FC VA: 0x23443FC Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2344458 Offset: 0x2340458 VA: 0x2344458 Slot: 11
	public override void Updata() { }

	// RVA: 0x234445C Offset: 0x234045C VA: 0x234445C
	public void AddOverHeal(int healValue, int maxHp) { }

	// RVA: 0x2344518 Offset: 0x2340518 VA: 0x2344518
	public void SetOverHeal(int overHealValue, int maxHp) { }

	// RVA: 0x2344584 Offset: 0x2340584 VA: 0x2344584
	public int Damage(int damage) { }

	// RVA: 0x23444CC Offset: 0x23404CC VA: 0x23444CC
	private void UpdateCount() { }
}
