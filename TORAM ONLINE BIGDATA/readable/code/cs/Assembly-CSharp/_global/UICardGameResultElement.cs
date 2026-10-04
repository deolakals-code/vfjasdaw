// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UICardGameResultElement // TypeDefIndex: 5715
{
	// Fields
	private GameObject obj; // 0x10
	private UILabel name; // 0x18
	private UILabel scoreLabel; // 0x20
	private GameObject scoreBase; // 0x28
	private TweenPosition tweenPos; // 0x30
	private TweenRotation tweenRot; // 0x38
	private int score; // 0x40
	private int totalScore; // 0x44
	private bool fall; // 0x48

	// Properties
	public bool IsMax { get; }
	public int Score { get; }

	// Methods

	// RVA: 0x17CF614 Offset: 0x17CB614 VA: 0x17CF614
	public bool get_IsMax() { }

	// RVA: 0x17CF624 Offset: 0x17CB624 VA: 0x17CF624
	public int get_Score() { }

	// RVA: 0x17CF62C Offset: 0x17CB62C VA: 0x17CF62C
	public void .ctor(GameObject element, GameObject parent) { }

	// RVA: 0x17CF890 Offset: 0x17CB890 VA: 0x17CF890
	public void Initialize(string name, int score) { }

	// RVA: 0x17CF960 Offset: 0x17CB960 VA: 0x17CF960
	public void OnDestroy() { }

	// RVA: 0x17CF9BC Offset: 0x17CB9BC VA: 0x17CF9BC
	public void SetPosition(Vector3 pos) { }

	// RVA: 0x17CFA90 Offset: 0x17CBA90 VA: 0x17CFA90
	public void OpenScore() { }

	// RVA: 0x17CFAF0 Offset: 0x17CBAF0 VA: 0x17CFAF0
	public void SetTotalScore(int total) { }

	// RVA: 0x17CFAF8 Offset: 0x17CBAF8 VA: 0x17CFAF8
	public void AddScore() { }

	// RVA: 0x17CFB48 Offset: 0x17CBB48 VA: 0x17CFB48
	public void FallUI() { }
}
