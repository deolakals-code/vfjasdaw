// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMercenaryIcon : MonoBehaviour // TypeDefIndex: 7419
{
	// Fields
	[SerializeField]
	private UIIcon icon; // 0x20
	[SerializeField]
	private TweenScale scaleAnimation; // 0x28
	[SerializeField]
	private TweenAlpha alphaAnimation; // 0x30
	private Action<int, int> onClickListner; // 0x38
	private int typeId; // 0x40
	private int manageId; // 0x44

	// Methods

	// RVA: 0x1B446AC Offset: 0x1B406AC VA: 0x1B446AC
	public void SetSkillIconInfomation(int skillId, int paramId) { }

	// RVA: 0x1B446E8 Offset: 0x1B406E8 VA: 0x1B446E8
	public void SetConditionInfomation(AIActionCondition condition, int paramId) { }

	// RVA: 0x1B46E04 Offset: 0x1B42E04 VA: 0x1B46E04
	public void SetButtonListener(Action<int, int> buttonCallBack) { }

	// RVA: 0x1B46E0C Offset: 0x1B42E0C VA: 0x1B46E0C
	public void SelectButton(bool select) { }

	// RVA: 0x1B46D20 Offset: 0x1B42D20 VA: 0x1B46D20
	private string GetConditionIconName(AIActionCondition condition) { }

	// RVA: 0x1B46ECC Offset: 0x1B42ECC VA: 0x1B46ECC
	private void OnClick() { }

	// RVA: 0x1B46FE4 Offset: 0x1B42FE4 VA: 0x1B46FE4
	public void .ctor() { }
}
