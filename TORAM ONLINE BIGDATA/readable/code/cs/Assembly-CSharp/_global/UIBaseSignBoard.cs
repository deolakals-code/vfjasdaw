// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBaseSignBoard : MonoBehaviour // TypeDefIndex: 8839
{
	// Fields
	[CompilerGenerated]
	private Transform <TraceObject>k__BackingField; // 0x20
	[CompilerGenerated]
	private SignboardType <BoardType>k__BackingField; // 0x28
	protected float size; // 0x2C
	protected float colSize; // 0x30
	protected Vector3 initScale; // 0x34
	protected bool tapEnabled; // 0x40
	protected bool isChagneScale; // 0x41
	protected PlayerDataManager playerDataManager; // 0x48
	protected float radLimit; // 0x50
	protected const float MaxEnableRange = 12;
	protected float enableRange; // 0x54
	protected OtherPlayer otherPlayerData; // 0x58
	protected EmotionPlayer otherEmotionPlayer; // 0x60
	protected const int BaseWidthSize = 350;
	protected const int BaseZeroWidthSize = 83;
	protected readonly Vector3 LeftIconPos; // 0x68
	protected bool isMouseOver; // 0x74
	protected GameObject d3GLObj; // 0x78
	protected D3GLSignboard d3GLSign; // 0x80
	protected bool isMine; // 0x88
	[SerializeField]
	protected BoxCollider tapCollider; // 0x90
	[SerializeField]
	protected GameObject panelObj; // 0x98
	[SerializeField]
	protected UIGLSpriteSlicedNew baseObj; // 0xA0
	[SerializeField]
	protected UIGLSprite IconObj; // 0xA8
	[SerializeField]
	protected UIGLLabel itemLabel; // 0xB0
	[SerializeField]
	private UIAtlas mainAtlas; // 0xB8
	[SerializeField]
	private UIAtlas iconAtlas; // 0xC0
	[SerializeField]
	private UIFont font; // 0xC8

	// Properties
	public Transform TraceObject { get; set; }
	public virtual bool IsRemoveState { get; }
	public string Text { get; }
	public string IconName { get; }
	public string BaseSpriteName { get; }
	public D3GLSignboard D3GLSidn { get; }
	public SignboardType BoardType { get; set; }
	public UIGLSpriteSlicedNew BaseSprite { get; }
	public UIGLLabel Label { get; }
	public float AddPosY { get; }
	public bool IsMouseOver { get; }
	protected virtual bool ActiveFlag { get; }
	public virtual bool IsEnabled { get; }
	public virtual bool IsActive { get; }
	public virtual bool IsStopMouseOver { get; }
	protected SignboardPropertyData otherBoardPropertyData { get; }
	protected bool IsBan { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1E30BB8 Offset: 0x1E2CBB8 VA: 0x1E30BB8
	protected void set_TraceObject(Transform value) { }

	[CompilerGenerated]
	// RVA: 0x1E30BC0 Offset: 0x1E2CBC0 VA: 0x1E30BC0
	public Transform get_TraceObject() { }

	// RVA: 0x1E30BC8 Offset: 0x1E2CBC8 VA: 0x1E30BC8 Slot: 4
	public virtual bool get_IsRemoveState() { }

	// RVA: 0x1E304EC Offset: 0x1E2C4EC VA: 0x1E304EC
	public string get_Text() { }

	// RVA: 0x1E30B70 Offset: 0x1E2CB70 VA: 0x1E30B70
	public string get_IconName() { }

	// RVA: 0x1E30B54 Offset: 0x1E2CB54 VA: 0x1E30B54
	public string get_BaseSpriteName() { }

	// RVA: 0x1E30D20 Offset: 0x1E2CD20 VA: 0x1E30D20
	public D3GLSignboard get_D3GLSidn() { }

	[CompilerGenerated]
	// RVA: 0x1E30D28 Offset: 0x1E2CD28 VA: 0x1E30D28
	public SignboardType get_BoardType() { }

	[CompilerGenerated]
	// RVA: 0x1E30D30 Offset: 0x1E2CD30 VA: 0x1E30D30
	private void set_BoardType(SignboardType value) { }

	// RVA: 0x1E30D38 Offset: 0x1E2CD38 VA: 0x1E30D38
	public UIGLSpriteSlicedNew get_BaseSprite() { }

	// RVA: 0x1E30D40 Offset: 0x1E2CD40 VA: 0x1E30D40
	public UIGLLabel get_Label() { }

	// RVA: 0x1E30D48 Offset: 0x1E2CD48 VA: 0x1E30D48
	public float get_AddPosY() { }

	// RVA: 0x1E30D50 Offset: 0x1E2CD50 VA: 0x1E30D50
	public bool get_IsMouseOver() { }

	// RVA: 0x1E30D58 Offset: 0x1E2CD58 VA: 0x1E30D58 Slot: 5
	protected virtual bool get_ActiveFlag() { }

	// RVA: 0x1E30D60 Offset: 0x1E2CD60 VA: 0x1E30D60 Slot: 6
	public virtual bool get_IsEnabled() { }

	// RVA: 0x1E30D68 Offset: 0x1E2CD68 VA: 0x1E30D68 Slot: 7
	public virtual bool get_IsActive() { }

	// RVA: 0x1E30D88 Offset: 0x1E2CD88 VA: 0x1E30D88 Slot: 8
	public virtual bool get_IsStopMouseOver() { }

	// RVA: 0x1E30C04 Offset: 0x1E2CC04 VA: 0x1E30C04
	protected SignboardPropertyData get_otherBoardPropertyData() { }

	// RVA: 0x1E30D90 Offset: 0x1E2CD90 VA: 0x1E30D90
	protected bool get_IsBan() { }

	// RVA: 0x1E30E58 Offset: 0x1E2CE58 VA: 0x1E30E58
	private void OnDestroy() { }

	// RVA: 0x1E30EFC Offset: 0x1E2CEFC VA: 0x1E30EFC
	private void OnEnable() { }

	// RVA: 0x1E30F9C Offset: 0x1E2CF9C VA: 0x1E30F9C
	private void OnDisable() { }

	// RVA: 0x1E30FA4 Offset: 0x1E2CFA4 VA: 0x1E30FA4 Slot: 9
	protected virtual void StatusInit() { }

	// RVA: 0x1E30FA8 Offset: 0x1E2CFA8 VA: 0x1E30FA8 Slot: 10
	public virtual void UpdateActiveBoard(bool isPrint, int index, bool isUpdateOrbItem, bool isFirst) { }

	// RVA: 0x1E31194 Offset: 0x1E2D194 VA: 0x1E31194 Slot: 11
	public virtual void onClick() { }

	// RVA: 0x1E311A4 Offset: 0x1E2D1A4 VA: 0x1E311A4 Slot: 12
	public virtual void OnMouseOver() { }

	// RVA: 0x1E311A8 Offset: 0x1E2D1A8 VA: 0x1E311A8 Slot: 13
	public virtual void OnMouseOut() { }

	// RVA: 0x1E311AC Offset: 0x1E2D1AC VA: 0x1E311AC Slot: 14
	protected virtual bool CheckCanClick() { }

	// RVA: 0x1E31348 Offset: 0x1E2D348 VA: 0x1E31348 Slot: 15
	protected virtual void ChangeOpenBoard(bool isOpen) { }

	// RVA: 0x1E30E5C Offset: 0x1E2CE5C VA: 0x1E30E5C
	protected void D3Destroy() { }

	// RVA: 0x1E31604 Offset: 0x1E2D604 VA: 0x1E31604
	public void SetTapEnabled(bool enabled) { }

	// RVA: 0x1E31610 Offset: 0x1E2D610 VA: 0x1E31610
	public void SetChangeScale(bool flag) { }

	// RVA: 0x1E3161C Offset: 0x1E2D61C VA: 0x1E3161C
	public float GetCameraMeter(GameObject obj) { }

	// RVA: 0x1E316FC Offset: 0x1E2D6FC VA: 0x1E316FC
	public void D2DimensionEnable(bool isD2) { }

	// RVA: 0x1E31794 Offset: 0x1E2D794 VA: 0x1E31794 Slot: 16
	public virtual void Initialize(Transform traceObject, SignboardType type) { }

	// RVA: 0x1E31ACC Offset: 0x1E2DACC VA: 0x1E31ACC
	public void Create3DSignBoard() { }

	// RVA: 0x1E31BF4 Offset: 0x1E2DBF4 VA: 0x1E31BF4 Slot: 17
	public virtual bool PositionUpdate(float dist) { }

	// RVA: 0x1E32098 Offset: 0x1E2E098 VA: 0x1E32098
	public void SetIcon(string spriteName) { }

	// RVA: 0x1E320BC Offset: 0x1E2E0BC VA: 0x1E320BC
	public void SetText(string text) { }

	// RVA: 0x1E31494 Offset: 0x1E2D494 VA: 0x1E31494
	public void SetTextEnable(bool isEnable) { }

	// RVA: 0x1E313EC Offset: 0x1E2D3EC VA: 0x1E313EC
	public void SetBaseWidth(int width) { }

	// RVA: 0x1E32158 Offset: 0x1E2E158 VA: 0x1E32158
	public void SetBaseSpriteColor(Color color) { }

	// RVA: 0x1E31530 Offset: 0x1E2D530 VA: 0x1E31530
	public void SetIconPos(Vector3 pos) { }

	// RVA: 0x1E32220 Offset: 0x1E2E220 VA: 0x1E32220
	public void Render(Camera camera) { }

	// RVA: 0x1E30F04 Offset: 0x1E2CF04 VA: 0x1E30F04
	private void ChangeD3Active(bool isActive) { }

	// RVA: 0x1E3252C Offset: 0x1E2E52C VA: 0x1E3252C
	public void .ctor() { }
}
