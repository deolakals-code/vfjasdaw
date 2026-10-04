// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIScoreAttackRewardsContent : MonoBehaviour // TypeDefIndex: 6271
{
	// Fields
	[SerializeField]
	private UILabel bossNameLabel; // 0x20
	[SerializeField]
	private UILabel categoryLabel; // 0x28
	[SerializeField]
	private UILabel rewardLabel; // 0x30
	[SerializeField]
	private UIImageButton receiveButton; // 0x38
	[SerializeField]
	private UILabel receiveButtonLabel; // 0x40
	private int index; // 0x48
	private SystemTextManager sys; // 0x50
	private EnemyTextManager enemy; // 0x58
	private bool isReceived; // 0x60
	private Action<int> rewardReceiveCallAction; // 0x68
	private readonly int[] rewardCount; // 0x70

	// Properties
	public bool IsReveivable { get; }

	// Methods

	// RVA: 0x18D7208 Offset: 0x18D3208 VA: 0x18D7208
	public bool get_IsReveivable() { }

	// RVA: 0x18D7210 Offset: 0x18D3210 VA: 0x18D7210
	public void Initialize(ScoreAttackRotationData[] rotationDatas, int index, ScoreAttackRewardData reward, Action<int> rewardReceiveCallAction) { }

	// RVA: 0x18CEB58 Offset: 0x18CAB58 VA: 0x18CEB58
	public void InitializeRankChanged(ScoreAttackRotationData[] rotationDatas, int index, ScoreAttackRankUpData rankUpData) { }

	// RVA: 0x18D7900 Offset: 0x18D3900 VA: 0x18D7900
	public void OnClickReceive() { }

	// RVA: 0x18D799C Offset: 0x18D399C VA: 0x18D799C
	public void ChangeReceiveFlag(bool flag) { }

	// RVA: 0x18D76E4 Offset: 0x18D36E4 VA: 0x18D76E4
	private void ChangeButtonEnable() { }

	// RVA: 0x18D79A8 Offset: 0x18D39A8 VA: 0x18D79A8
	public void .ctor() { }
}
