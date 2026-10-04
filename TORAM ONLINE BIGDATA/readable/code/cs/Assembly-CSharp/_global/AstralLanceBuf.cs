// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AstralLanceBuf : CountBufferBase // TypeDefIndex: 3070
{
	// Fields
	public PlayerBattleManager battleManager; // 0x28
	public MobaPlayerBattleManager mobaBattleManager; // 0x30
	private const int cost = 5;
	private int nextCount; // 0x38

	// Properties
	public override SkillId SkillId { get; }
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x231E108 Offset: 0x231A108 VA: 0x231E108 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x231E110 Offset: 0x231A110 VA: 0x231E110 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x231E118 Offset: 0x231A118 VA: 0x231E118 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x231E130 Offset: 0x231A130 VA: 0x231E130
	public void .ctor(byte lv, PlayerActionManagerBase playerAction) { }

	// RVA: 0x231E3F8 Offset: 0x231A3F8 VA: 0x231E3F8 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x231E410 Offset: 0x231A410 VA: 0x231E410 Slot: 11
	public override void Updata() { }

	// RVA: 0x2310328 Offset: 0x230C328 VA: 0x2310328
	public void StartSkill(SkillActionBase action) { }

	// RVA: 0x231E464 Offset: 0x231A464 VA: 0x231E464
	public void StartAstralLanceAttack() { }

	// RVA: 0x231E474 Offset: 0x231A474 VA: 0x231E474
	public void EndAstralLanceAttack() { }
}
