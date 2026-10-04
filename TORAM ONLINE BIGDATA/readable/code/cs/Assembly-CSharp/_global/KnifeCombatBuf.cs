// Assembly: Assembly-CSharp.dll
// Namespace: 
public class KnifeCombatBuf : SkillBufferDataBase // TypeDefIndex: 3220
{
	// Fields
	private static int BufferTakeId; // 0x0
	private int crtUp; // 0x20
	private int atkMpRecovery; // 0x24
	private int avoidStackRegist; // 0x28
	private int normalAtkRate; // 0x2C
	private PlayerActionManagerBase actionManager; // 0x30
	private TakeController takeController; // 0x38

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }
	private int KnifeTakeId { get; }

	// Methods

	// RVA: 0x2337BA8 Offset: 0x2333BA8 VA: 0x2337BA8 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2337BB0 Offset: 0x2333BB0 VA: 0x2337BB0 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x2337BB8 Offset: 0x2333BB8 VA: 0x2337BB8
	private int get_KnifeTakeId() { }

	// RVA: 0x2337C38 Offset: 0x2333C38 VA: 0x2337C38
	public void .ctor(byte lv, PlayerActionManagerBase playerAction) { }

	// RVA: 0x2337D1C Offset: 0x2333D1C VA: 0x2337D1C Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2337D7C Offset: 0x2333D7C VA: 0x2337D7C Slot: 11
	public override void Updata() { }

	// RVA: 0x23380C8 Offset: 0x23340C8 VA: 0x23380C8
	public void TakeStop() { }

	// RVA: 0x2337F54 Offset: 0x2333F54 VA: 0x2337F54
	private bool IsBattleActive() { }

	// RVA: 0x2337FE4 Offset: 0x2333FE4 VA: 0x2337FE4
	private bool CheckTake() { }

	// RVA: 0x233814C Offset: 0x233414C VA: 0x233814C
	private void TakeEvent(int takePlayerUid, TakeEventType eventType, int param) { }

	// RVA: 0x2338318 Offset: 0x2334318 VA: 0x2338318
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x2338368 Offset: 0x2334368 VA: 0x2338368
	private bool <TakeEvent>b__19_0(KeyValuePair<int, TakePlayer> x) { }
}
