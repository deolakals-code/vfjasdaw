// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIClickableEventArea : MonoBehaviour // TypeDefIndex: 7185
{
	// Fields
	[SerializeField]
	private UILabel chatLabel; // 0x20
	[SerializeField]
	private GameObject sendEventTarget; // 0x28
	[SerializeField]
	private string functionName; // 0x30
	private BoxCollider boxCol; // 0x38
	private UISprite boxSprite; // 0x40
	[CompilerGenerated]
	private int <Uid>k__BackingField; // 0x48
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x50
	[CompilerGenerated]
	private byte <UserRegionCode>k__BackingField; // 0x58

	// Properties
	public int Uid { get; set; }
	public string UserName { get; set; }
	public byte UserRegionCode { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1ACEE20 Offset: 0x1ACAE20 VA: 0x1ACEE20
	public int get_Uid() { }

	[CompilerGenerated]
	// RVA: 0x1ACEE28 Offset: 0x1ACAE28 VA: 0x1ACEE28
	private void set_Uid(int value) { }

	[CompilerGenerated]
	// RVA: 0x1ACEE30 Offset: 0x1ACAE30 VA: 0x1ACEE30
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x1ACEE38 Offset: 0x1ACAE38 VA: 0x1ACEE38
	private void set_UserName(string value) { }

	[CompilerGenerated]
	// RVA: 0x1ACEE40 Offset: 0x1ACAE40 VA: 0x1ACEE40
	public byte get_UserRegionCode() { }

	[CompilerGenerated]
	// RVA: 0x1ACEE48 Offset: 0x1ACAE48 VA: 0x1ACEE48
	private void set_UserRegionCode(byte value) { }

	// RVA: 0x1ACEE50 Offset: 0x1ACAE50 VA: 0x1ACEE50
	private void Awake() { }

	// RVA: 0x1ACEB64 Offset: 0x1ACAB64 VA: 0x1ACEB64
	public void SetLocalPosition(int offsetIndex, float offsetSize) { }

	// RVA: 0x1ACEC04 Offset: 0x1ACAC04 VA: 0x1ACEC04
	public void SetSendValue(int uid, string userName, byte regionCode) { }

	// RVA: 0x1ACEC38 Offset: 0x1ACAC38 VA: 0x1ACEC38
	public void SetTextArea(string areaText) { }

	// RVA: 0x1ACEEE0 Offset: 0x1ACAEE0 VA: 0x1ACEEE0
	private void onClick() { }

	// RVA: 0x1ACEF70 Offset: 0x1ACAF70 VA: 0x1ACEF70
	private void OnPress(bool ispress) { }

	// RVA: 0x1ACEF7C Offset: 0x1ACAF7C VA: 0x1ACEF7C
	public void .ctor() { }
}
