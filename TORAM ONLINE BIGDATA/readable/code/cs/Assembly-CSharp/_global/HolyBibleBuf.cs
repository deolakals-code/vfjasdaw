// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HolyBibleBuf : SkillBufferDataBase // TypeDefIndex: 3196
{
	// Fields
	private float coolTime; // 0x20
	private int darkElementDmgRate; // 0x24
	private int activePercent; // 0x28
	private PlayerStatusBase playerStatus; // 0x30

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }
	public bool ActivePersuit { get; }
	public float CoolTime { get; }

	// Methods

	// RVA: 0x2333A3C Offset: 0x232FA3C VA: 0x2333A3C Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2333A44 Offset: 0x232FA44 VA: 0x2333A44 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x2333A4C Offset: 0x232FA4C VA: 0x2333A4C
	public bool get_ActivePersuit() { }

	// RVA: 0x2333A5C Offset: 0x232FA5C VA: 0x2333A5C
	public float get_CoolTime() { }

	// RVA: 0x2333A64 Offset: 0x232FA64 VA: 0x2333A64
	public void .ctor(byte lv) { }

	// RVA: 0x2333B1C Offset: 0x232FB1C VA: 0x2333B1C
	public void Initialize(PlayerStatusBase playerStatus, float time) { }

	// RVA: 0x2333B48 Offset: 0x232FB48 VA: 0x2333B48 Slot: 11
	public override void Updata() { }

	// RVA: 0x2333BBC Offset: 0x232FBBC VA: 0x2333BBC Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2333BEC Offset: 0x232FBEC VA: 0x2333BEC
	public void OnAction() { }
}
