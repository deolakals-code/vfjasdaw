// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SkinBreakParts : MonoBehaviour // TypeDefIndex: 1149
{
	// Fields
	[SerializeField]
	private SkinnedMeshRenderer baseSkin; // 0x20
	[SerializeField]
	private GameObject[] breakPartsAObject; // 0x28
	private SkinnedMeshRenderer[] breakPartsA; // 0x30
	[SerializeField]
	private GameObject[] breakPartsBObject; // 0x38
	private SkinnedMeshRenderer[] breakPartsB; // 0x40
	[SerializeField]
	private int[] partsIdS; // 0x48
	public bool[] breakFlag; // 0x50
	[SerializeField]
	private float targetDist; // 0x58
	private bool[] nonTarget; // 0x60
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x68
	private bool baseColor; // 0x6C
	[CompilerGenerated]
	private Color <baseColorR>k__BackingField; // 0x70
	[CompilerGenerated]
	private Color <baseColorG>k__BackingField; // 0x80
	[CompilerGenerated]
	private Color <baseColorB>k__BackingField; // 0x90
	private float brightness; // 0xA0
	private float colorA; // 0xA4
	private bool initialize; // 0xA8
	private bool isMaterialUpdate; // 0xA9

	// Properties
	public int[] PartsIdS { get; }
	public int TargetId { get; set; }
	public Color baseColorR { get; set; }
	public Color baseColorG { get; set; }
	public Color baseColorB { get; set; }

	// Methods

	// RVA: 0x1F656BC Offset: 0x1F616BC VA: 0x1F656BC
	public int[] get_PartsIdS() { }

	[CompilerGenerated]
	// RVA: 0x1F656C4 Offset: 0x1F616C4 VA: 0x1F656C4
	private void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x1F656CC Offset: 0x1F616CC VA: 0x1F656CC
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x1F656D4 Offset: 0x1F616D4 VA: 0x1F656D4
	private void set_baseColorR(Color value) { }

	[CompilerGenerated]
	// RVA: 0x1F656E0 Offset: 0x1F616E0 VA: 0x1F656E0
	public Color get_baseColorR() { }

	[CompilerGenerated]
	// RVA: 0x1F656EC Offset: 0x1F616EC VA: 0x1F656EC
	private void set_baseColorG(Color value) { }

	[CompilerGenerated]
	// RVA: 0x1F656F8 Offset: 0x1F616F8 VA: 0x1F656F8
	public Color get_baseColorG() { }

	[CompilerGenerated]
	// RVA: 0x1F65704 Offset: 0x1F61704 VA: 0x1F65704
	private void set_baseColorB(Color value) { }

	[CompilerGenerated]
	// RVA: 0x1F65710 Offset: 0x1F61710 VA: 0x1F65710
	public Color get_baseColorB() { }

	// RVA: 0x1F6571C Offset: 0x1F6171C VA: 0x1F6571C
	public void InitializeColor(Color r, Color g, Color b) { }

	// RVA: 0x1F65740 Offset: 0x1F61740 VA: 0x1F65740
	public void ChnageColor(byte bit, Color r, Color g, Color b) { }

	// RVA: 0x1F65934 Offset: 0x1F61934 VA: 0x1F65934
	private void SetMaterialColor(SkinnedMeshRenderer skin, Color colorR, Color colorG, Color colorB) { }

	// RVA: 0x1F65948 Offset: 0x1F61948 VA: 0x1F65948
	public void Start() { }

	// RVA: 0x1F6626C Offset: 0x1F6226C VA: 0x1F6626C
	public void ActiveUpdateMateril(bool active) { }

	// RVA: 0x1F66278 Offset: 0x1F62278 VA: 0x1F66278
	public void SetBattleTarget(int id) { }

	// RVA: 0x1F6638C Offset: 0x1F6238C VA: 0x1F6638C
	public void SetBattleNoTarget(int id) { }

	// RVA: 0x1F66280 Offset: 0x1F62280 VA: 0x1F66280
	private void SetNonTargetFlag(int id, bool setFlag) { }

	// RVA: 0x1F66394 Offset: 0x1F62394 VA: 0x1F66394
	private void Update() { }

	// RVA: 0x1F66418 Offset: 0x1F62418 VA: 0x1F66418
	private float UpdateMaterialParam(string name, float param) { }

	// RVA: 0x1F65FFC Offset: 0x1F61FFC VA: 0x1F65FFC
	private SkinnedMeshRenderer SetPartsInit(GameObject parts, bool active, Color colorR, Color colorG, Color colorB) { }

	// RVA: 0x1F6664C Offset: 0x1F6264C VA: 0x1F6664C
	public void BreakPoint(int id) { }

	// RVA: 0x1F66654 Offset: 0x1F62654 VA: 0x1F66654
	public void BreakPoint(int id, bool flag) { }

	// RVA: 0x1F668CC Offset: 0x1F628CC VA: 0x1F668CC
	public int TargetNearId(Vector3 position) { }

	// RVA: 0x1F66C54 Offset: 0x1F62C54 VA: 0x1F66C54
	public Vector3 TargetPosition(int targetId) { }

	// RVA: 0x1F669D4 Offset: 0x1F629D4 VA: 0x1F669D4
	private Vector3 GetPartsPosition(bool breakedPartsFlag, int id) { }

	// RVA: 0x1F66CD0 Offset: 0x1F62CD0 VA: 0x1F66CD0
	public int GetBreakBit() { }

	// RVA: 0x1F66D50 Offset: 0x1F62D50 VA: 0x1F66D50
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1F66D68 Offset: 0x1F62D68 VA: 0x1F66D68
	private void <Start>b__35_0(bool f, GameObject x) { }
}
