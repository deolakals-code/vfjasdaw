// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UICreaterPanel : UIStatusBasePanel // TypeDefIndex: 8043
{
	// Fields
	[SerializeField]
	private UILabel[] materialLevelLabel; // 0x20
	[SerializeField]
	private UILabel[] materialPointLabel; // 0x28
	[SerializeField]
	private UISlider[] materialPointSlider; // 0x30
	[SerializeField]
	private UILabel equipCreateLabel; // 0x38
	[SerializeField]
	private UILabel dragCreateLabel; // 0x40
	[SerializeField]
	private UILabel maxMaterialPointLabel; // 0x48
	[SerializeField]
	private UILabel addMaterialParamLabel; // 0x50
	[SerializeField]
	private UILabel addCourseLabel; // 0x58
	[SerializeField]
	private UILabel smithAttentionLabel; // 0x60
	[SerializeField]
	private UILabel alchemyAttentionLabel; // 0x68
	[SerializeField]
	private UIIruna2Anchor leftAnchor; // 0x70
	[SerializeField]
	private UIIruna2Anchor rightAnchor; // 0x78
	private string pt; // 0x80
	private string lv; // 0x88
	private MaterialManager materialManager; // 0x90
	private int materialLevel; // 0x98

	// Methods

	// RVA: 0x1CAC2A8 Offset: 0x1CA82A8 VA: 0x1CAC2A8 Slot: 4
	public override void Initialize(PlayerDataManager playerDataManager, SystemTextManager systemTextManager, UIStatusMainManager manager) { }

	// RVA: 0x1CACAA8 Offset: 0x1CA8AA8 VA: 0x1CACAA8
	private void MaterialStatusUpdate(int level, SystemTextManager systemTextManager) { }

	// RVA: 0x1CACF3C Offset: 0x1CA8F3C VA: 0x1CACF3C Slot: 5
	public override void Open() { }

	// RVA: 0x1CAD024 Offset: 0x1CA9024 VA: 0x1CAD024 Slot: 6
	public override void Close() { }

	// RVA: 0x1CAD0E8 Offset: 0x1CA90E8 VA: 0x1CAD0E8 Slot: 7
	public override bool PushLeftTopButton() { }

	// RVA: 0x1CAD0F0 Offset: 0x1CA90F0 VA: 0x1CAD0F0
	public void .ctor() { }
}
