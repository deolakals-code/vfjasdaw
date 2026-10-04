// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIScoreAttackMainListContent : MonoBehaviour // TypeDefIndex: 6246
{
	// Fields
	[SerializeField]
	private UILabel bossNameLabel; // 0x20
	[SerializeField]
	private UILabel timerLabel; // 0x28
	[SerializeField]
	private UIButton button; // 0x30
	[SerializeField]
	private GameObject disableObj; // 0x38
	private ScoreAttackBossData bossData; // 0x40
	private EnemyTextManager enemyTextManager; // 0x48
	private SystemTextManager systemTextManager; // 0x50

	// Methods

	// RVA: 0x18CBA60 Offset: 0x18C7A60 VA: 0x18CBA60
	public void Initialize(ScoreAttackBossData bossData, bool isOpen, TimeSpan remainingTime) { }

	// RVA: 0x18CBE68 Offset: 0x18C7E68 VA: 0x18CBE68
	public void ChangeEnable(bool flag) { }

	// RVA: 0x18CBEB0 Offset: 0x18C7EB0 VA: 0x18CBEB0
	public void .ctor() { }
}
