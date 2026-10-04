// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPointShopButtonBase : MonoBehaviour // TypeDefIndex: 6162
{
	// Fields
	[SerializeField]
	private PointShopRewarDataBase.ResultCheckType getItemFlag; // 0x20
	[SerializeField]
	private UIImageButton selectButton; // 0x28
	[SerializeField]
	private UILabel buttonLabel; // 0x30
	[SerializeField]
	private string buttonText; // 0x38
	[SerializeField]
	private UIIcon itemIcon; // 0x40
	[SerializeField]
	private UILabel itemNameLabel; // 0x48
	[SerializeField]
	private UILabel itemNumLabel; // 0x50
	[SerializeField]
	private UILabel pointNumLabel; // 0x58
	[SerializeField]
	private string overLabel; // 0x60
	[SerializeField]
	private string overLimitLabel; // 0x68
	protected UIPointShopManager manager; // 0x70
	protected PointShopRewarDataBase buttonData; // 0x78
	protected SystemTextManager systemTextManager; // 0x80
	protected int tradeItemNum; // 0x88

	// Methods

	// RVA: 0x18AA130 Offset: 0x18A6130 VA: 0x18AA130
	public void Initialize(UIPointShopManager manager, PointShopRewarDataBase data, int flag, int tradeItemNum) { }

	// RVA: 0x18AA2A4 Offset: 0x18A62A4 VA: 0x18AA2A4 Slot: 4
	protected virtual void ResultButton() { }

	// RVA: 0x18AA4A0 Offset: 0x18A64A0 VA: 0x18AA4A0 Slot: 5
	protected virtual void PointErrButton() { }

	// RVA: 0x18AA584 Offset: 0x18A6584 VA: 0x18AA584 Slot: 6
	protected virtual void LimitButton() { }

	// RVA: 0x18AA654 Offset: 0x18A6654 VA: 0x18AA654 Slot: 7
	protected virtual void UnknownButton() { }

	// RVA: 0x18AA39C Offset: 0x18A639C VA: 0x18AA39C
	private void SetRewardParamData(RewardData rewardData, string colorCode, string pointText) { }

	// RVA: 0x18AA804 Offset: 0x18A6804 VA: 0x18AA804 Slot: 8
	public virtual void OnButtonClick() { }

	// RVA: 0x18AAAD8 Offset: 0x18A6AD8 VA: 0x18AAAD8
	public void UpdateItemNameLabel(string text) { }

	// RVA: 0x18AAAF4 Offset: 0x18A6AF4 VA: 0x18AAAF4
	public void .ctor() { }
}
