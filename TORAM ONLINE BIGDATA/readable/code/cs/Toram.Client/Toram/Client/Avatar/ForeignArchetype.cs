// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Avatar
public class ForeignArchetype : Archetype // TypeDefIndex: 15148
{
	// Fields
	private IActorListener listener; // 0x50

	// Properties
	public override bool IsMine { get; }

	// Methods

	[CLSCompliant(False)]
	// RVA: 0x35AC778 Offset: 0x35A8778 VA: 0x35AC778
	public void .ctor(Game game, byte archetypeType, int archetypeId) { }

	// RVA: 0x35AC77C Offset: 0x35A877C VA: 0x35AC77C Slot: 5
	public override bool get_IsMine() { }

	// RVA: 0x35AC784 Offset: 0x35A8784 VA: 0x35AC784
	public void SetListener(IActorListener listener) { }

	// RVA: 0x35AC78C Offset: 0x35A878C VA: 0x35AC78C Slot: 7
	public override void SetAdditionnalData(AdditionalData additionalData) { }

	// RVA: 0x35AC80C Offset: 0x35A880C VA: 0x35AC80C Slot: 8
	internal override void OnOperation(PacketBase operation) { }

	// RVA: 0x35AC900 Offset: 0x35A8900 VA: 0x35AC900 Slot: 9
	internal override void OnEvent(PacketBase events) { }

	// RVA: 0x35AD13C Offset: 0x35A913C VA: 0x35AD13C Slot: 10
	internal override void OnActionEvent(ArchetypeActionEvent action) { }

	// RVA: 0x35AE100 Offset: 0x35AA100 VA: 0x35AE100
	private void HandleMobAttack(MobAttackEventData attackData) { }

	// RVA: 0x35AE268 Offset: 0x35AA268 VA: 0x35AE268
	private void MiniGameActionA(Dictionary<object, object> action) { }

	// RVA: 0x35AE41C Offset: 0x35AA41C VA: 0x35AE41C
	private void MiniGameActionB(Dictionary<object, object> action) { }

	// RVA: 0x35AE548 Offset: 0x35AA548 VA: 0x35AE548
	private void MiniGameActionC(Dictionary<object, object> action) { }

	// RVA: 0x35AE674 Offset: 0x35AA674 VA: 0x35AE674
	private void MiniGameAttack(Dictionary<object, object> action) { }

	// RVA: 0x35AE7A0 Offset: 0x35AA7A0 VA: 0x35AE7A0
	private void MiniGameSkillAttack(Dictionary<object, object> action) { }

	// RVA: 0x35AE8CC Offset: 0x35AA8CC VA: 0x35AE8CC
	private void MiniGameDamege(Dictionary<object, object> action) { }

	// RVA: 0x35AE9F8 Offset: 0x35AA9F8 VA: 0x35AE9F8
	private void MiniGameDead(Dictionary<object, object> action) { }

	// RVA: 0x35AEB24 Offset: 0x35AAB24 VA: 0x35AEB24
	private void MiniGameResurrection(Dictionary<object, object> action) { }

	// RVA: 0x35AEC50 Offset: 0x35AAC50 VA: 0x35AEC50
	private void MiniGameGetItem(Dictionary<object, object> action) { }

	// RVA: 0x35AED7C Offset: 0x35AAD7C VA: 0x35AED7C
	private void MiniGameUseItem(Dictionary<object, object> action) { }
}
