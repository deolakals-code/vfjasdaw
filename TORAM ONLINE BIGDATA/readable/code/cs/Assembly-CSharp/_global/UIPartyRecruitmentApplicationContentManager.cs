// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPartyRecruitmentApplicationContentManager : MonoBehaviour // TypeDefIndex: 7699
{
	// Fields
	[SerializeField]
	private UISprite[] icons; // 0x20
	[SerializeField]
	private UILabel titleLabel; // 0x28
	[SerializeField]
	private UIButtonSendCallAction selectButton; // 0x30
	private SystemTextManager sys; // 0x38
	private readonly Dictionary<byte, string> iconSpriteIds; // 0x40

	// Methods

	// RVA: 0x1BE8630 Offset: 0x1BE4630 VA: 0x1BE8630
	public void Initialize(PartyMemberFrameData data, Action<int> buttonAction) { }

	// RVA: 0x1BE8C80 Offset: 0x1BE4C80 VA: 0x1BE8C80
	public void .ctor() { }
}
