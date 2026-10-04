// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class CardGameTakeBase // TypeDefIndex: 4257
{
	// Fields
	private CardGameManager gameManager; // 0x10
	private CardGameBattleManager takePlayer; // 0x18
	private float castTime; // 0x20
	private int hitTakeId; // 0x24
	protected int attackTakeId; // 0x28
	protected int atkTakePlayId; // 0x2C
	private int chargePlayId; // 0x30
	protected List<CardGameTakeBase.TakeEvent> eventList; // 0x38
	protected CardGameTakeBase.TakeEvent currentEvent; // 0x40
	protected CardGameManager.CardGameAttackCardData attackData; // 0x48
	protected CardGameMemberModel model; // 0x50
	protected CardGameBossModel target; // 0x58
	protected float waitTimer; // 0x60
	private bool isHit; // 0x64
	private int eventTakeId; // 0x68
	private bool isLast; // 0x6C
	[CompilerGenerated]
	private bool <EndAttack>k__BackingField; // 0x6D

	// Properties
	public int ArchetypeId { get; }
	public CardGameMemberModel Model { get; }
	public CardGameBossModel Target { get; }
	public abstract CardGameBattleCameraManager.BattleCameraMode CameraMode { get; }
	protected bool EndAttack { get; set; }

	// Methods

	// RVA: 0x24B8870 Offset: 0x24B4870 VA: 0x24B8870
	public int get_ArchetypeId() { }

	// RVA: 0x24B888C Offset: 0x24B488C VA: 0x24B888C
	public CardGameMemberModel get_Model() { }

	// RVA: 0x24B8894 Offset: 0x24B4894 VA: 0x24B8894
	public CardGameBossModel get_Target() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract CardGameBattleCameraManager.BattleCameraMode get_CameraMode();

	[CompilerGenerated]
	// RVA: 0x24B889C Offset: 0x24B489C VA: 0x24B889C
	protected bool get_EndAttack() { }

	[CompilerGenerated]
	// RVA: 0x24B88A4 Offset: 0x24B48A4 VA: 0x24B88A4
	private void set_EndAttack(bool value) { }

	// RVA: 0x24B88B0 Offset: 0x24B48B0 VA: 0x24B88B0
	public void .ctor() { }

	// RVA: 0x24B83C0 Offset: 0x24B43C0 VA: 0x24B83C0
	public void Init(CardGameManager.CardGameAttackCardData atk, CardGameBattleManager player, bool last) { }

	// RVA: 0x24B8974 Offset: 0x24B4974 VA: 0x24B8974 Slot: 5
	public virtual void StartTake() { }

	// RVA: 0x24B6CA4 Offset: 0x24B2CA4 VA: 0x24B6CA4
	public void Update() { }

	// RVA: 0x24B8A04 Offset: 0x24B4A04 VA: 0x24B8A04
	protected void End() { }

	// RVA: 0x24B8A6C Offset: 0x24B4A6C VA: 0x24B8A6C Slot: 6
	protected virtual void Finish() { }

	// RVA: 0x24B8A9C Offset: 0x24B4A9C VA: 0x24B8A9C
	private void EndEvent() { }

	// RVA: 0x24B8A34 Offset: 0x24B4A34 VA: 0x24B8A34
	private void Damaged() { }

	// RVA: 0x24B91A4 Offset: 0x24B51A4 VA: 0x24B91A4
	public void SetEventTakeId(int takeId) { }

	// RVA: 0x24B91AC Offset: 0x24B51AC VA: 0x24B91AC
	public void SetCastTime(float time) { }

	// RVA: 0x24B91B4 Offset: 0x24B51B4 VA: 0x24B91B4
	protected void onTakeEvent(int uid, TakeEventType eventType, int param) { }
}
