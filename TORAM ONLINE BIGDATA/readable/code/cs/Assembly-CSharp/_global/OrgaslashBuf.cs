// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OrgaslashBuf : CountBufferBase // TypeDefIndex: 3261
{
	// Fields
	private const float IntervalDamageCoolTime = 1;
	private CountBufferBase.CountType countViewType; // 0x28
	private bool isActive; // 0x2C
	private byte payStackNum; // 0x2D
	private float attackAreaCoolTime; // 0x30
	private float damageCoolTime; // 0x34

	// Properties
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x234011C Offset: 0x233C11C VA: 0x234011C
	public void .ctor(byte lv) { }

	// RVA: 0x2340134 Offset: 0x233C134 VA: 0x2340134 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x234013C Offset: 0x233C13C VA: 0x234013C Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2340144 Offset: 0x233C144 VA: 0x2340144 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x234014C Offset: 0x233C14C VA: 0x234014C Slot: 11
	public override void Updata() { }

	// RVA: 0x2340220 Offset: 0x233C220 VA: 0x2340220 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2340228 Offset: 0x233C228 VA: 0x2340228
	public bool CheckStackAttackArea() { }

	// RVA: 0x2340238 Offset: 0x233C238 VA: 0x2340238
	public void StackAttackArea(float chargeLeftTime) { }

	// RVA: 0x2340254 Offset: 0x233C254 VA: 0x2340254
	public void StackDamage(bool guard) { }

	// RVA: 0x2340288 Offset: 0x233C288 VA: 0x2340288
	public byte Pay() { }

	// RVA: 0x23402A8 Offset: 0x233C2A8 VA: 0x23402A8
	public bool CheckValidEffect() { }

	// RVA: 0x23402B0 Offset: 0x233C2B0 VA: 0x23402B0
	public bool CheckValidEffect(out byte payStackNum) { }

	// RVA: 0x23402DC Offset: 0x233C2DC VA: 0x23402DC
	public void ValidEffect(byte payStackNum) { }

	// RVA: 0x234020C Offset: 0x233C20C VA: 0x234020C
	public void InvalidEffect() { }
}
