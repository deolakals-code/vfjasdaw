// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SuppressionBonusGameManager : MonoBehaviour // TypeDefIndex: 1081
{
	// Fields
	private int uid; // 0x20
	private int killMobCount; // 0x24
	private Dictionary<int, int> killCounter; // 0x28
	private AcceptTarget acceptTarget; // 0x30
	private BonusProgressLabel progressLabel; // 0x38
	private bool isAbort; // 0x40
	private Dictionary<TakeParameterType, int> append; // 0x48
	private Dictionary<TakeParameterType, int> element; // 0x50
	private Dictionary<TakeParameterType, int> normalColor; // 0x58
	private int attackTakeId; // 0x60
	[CompilerGenerated]
	private PlayerActionManager <PlayerAcrion>k__BackingField; // 0x68
	[CompilerGenerated]
	private CharacterMove <CharaMove>k__BackingField; // 0x70

	// Properties
	private PlayerActionManager PlayerAcrion { get; set; }
	private CharacterMove CharaMove { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1F436BC Offset: 0x1F3F6BC VA: 0x1F436BC
	private PlayerActionManager get_PlayerAcrion() { }

	[CompilerGenerated]
	// RVA: 0x1F436C4 Offset: 0x1F3F6C4 VA: 0x1F436C4
	public void set_PlayerAcrion(PlayerActionManager value) { }

	[CompilerGenerated]
	// RVA: 0x1F436CC Offset: 0x1F3F6CC VA: 0x1F436CC
	private CharacterMove get_CharaMove() { }

	[CompilerGenerated]
	// RVA: 0x1F436D4 Offset: 0x1F3F6D4 VA: 0x1F436D4
	public void set_CharaMove(CharacterMove value) { }

	// RVA: 0x1F436DC Offset: 0x1F3F6DC VA: 0x1F436DC
	private void Start() { }

	[IteratorStateMachine(typeof(SuppressionBonusGameManager.<BonusGameMain>d__19))]
	// RVA: 0x1F43DA8 Offset: 0x1F3FDA8 VA: 0x1F43DA8
	private IEnumerator BonusGameMain() { }

	[IteratorStateMachine(typeof(SuppressionBonusGameManager.<CoolTime>d__20))]
	// RVA: 0x1F43E1C Offset: 0x1F3FE1C VA: 0x1F43E1C
	private IEnumerator CoolTime() { }

	[IteratorStateMachine(typeof(SuppressionBonusGameManager.<MenuLoadWait>d__21))]
	// RVA: 0x1F43E74 Offset: 0x1F3FE74 VA: 0x1F43E74
	private IEnumerator MenuLoadWait() { }

	// RVA: 0x1F43EE8 Offset: 0x1F3FEE8 VA: 0x1F43EE8
	private void Reset() { }

	// RVA: 0x1F43F50 Offset: 0x1F3FF50 VA: 0x1F43F50
	private void TargetTap(GameObject target) { }

	// RVA: 0x1F44520 Offset: 0x1F40520 VA: 0x1F44520
	private int GetTakeId(ItemDBData.ItemType WeaponType, ItemDBData.ItemType subWeaponType) { }

	// RVA: 0x1F4465C Offset: 0x1F4065C VA: 0x1F4465C
	public void .ctor() { }
}
