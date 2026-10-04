// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPartyRequestInviteElement : MonoBehaviour // TypeDefIndex: 7719
{
	// Fields
	[SerializeField]
	private UILabel nameLabel; // 0x20
	[SerializeField]
	private UILabel descriptionLabel; // 0x28
	[SerializeField]
	private UISprite weaponIcon; // 0x30
	[SerializeField]
	private UISprite subWeaponIcon; // 0x38
	[SerializeField]
	private LocalizeText timeLabel; // 0x40
	[SerializeField]
	private GameObject[] buttonObjects; // 0x48
	private byte frameNo; // 0x50
	private int targetAvatarUuid; // 0x54
	private float waitTime; // 0x58
	private Action<byte, int> callBack; // 0x60

	// Methods

	// RVA: 0x1BE2398 Offset: 0x1BDE398 VA: 0x1BE2398
	public void Initialize(PartyCandidateData data, float time, Action<byte, int> callBack) { }

	// RVA: 0x1BF04AC Offset: 0x1BEC4AC VA: 0x1BF04AC
	public void OnClick() { }

	// RVA: 0x1BE3D90 Offset: 0x1BDFD90 VA: 0x1BE3D90
	public void SetSelectedIndex(int avatarUuid) { }

	// RVA: 0x1BE277C Offset: 0x1BDE77C VA: 0x1BE277C
	public void SetSelected(bool selected) { }

	// RVA: 0x1BF04D4 Offset: 0x1BEC4D4 VA: 0x1BF04D4
	private void Update() { }

	// RVA: 0x1BF06D0 Offset: 0x1BEC6D0 VA: 0x1BF06D0
	public void .ctor() { }
}
