// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class GeoImpactBuf : CountBufferBase // TypeDefIndex: 3176
{
	// Fields
	private int barrier; // 0x28
	private int maxHp; // 0x2C

	// Properties
	public override SkillId SkillId { get; }
	public override CountBufferBase.CountType BufferType { get; }

	// Methods

	// RVA: 0x232FB00 Offset: 0x232BB00 VA: 0x232FB00 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x232FB08 Offset: 0x232BB08 VA: 0x232FB08 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x232FB10 Offset: 0x232BB10 VA: 0x232FB10
	public void .ctor(byte lv, int barrier, int hp) { }

	// RVA: 0x232FB80 Offset: 0x232BB80 VA: 0x232FB80 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x232FB98 Offset: 0x232BB98 VA: 0x232FB98 Slot: 11
	public override void Updata() { }

	// RVA: 0x232FBEC Offset: 0x232BBEC VA: 0x232FBEC
	public int DamageCut(int damage) { }

	// RVA: 0x232FC80 Offset: 0x232BC80 VA: 0x232FC80
	public int CalcDamage(int damage) { }
}
