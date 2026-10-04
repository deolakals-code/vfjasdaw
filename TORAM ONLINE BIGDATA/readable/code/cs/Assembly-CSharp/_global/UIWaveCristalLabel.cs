// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIWaveCristalLabel : UINameLabel // TypeDefIndex: 9060
{
	// Fields
	[SerializeField]
	private GameObject distObject; // 0x88
	private IUILabel distLabel; // 0x90
	[SerializeField]
	private GameObject hpBarObject; // 0x98
	private UIGLSpriteSliced hpBar; // 0xA0
	[SerializeField]
	private GameObject damageBarObject; // 0xA8
	private UIGLSpriteSliced damageBar; // 0xB0
	private WaveRoomData roomData; // 0xB8
	private WaveRaidRoomData raidRoomData; // 0xC0
	private int uid; // 0xC8
	private float damageValue; // 0xCC

	// Methods

	// RVA: 0x1EA4EEC Offset: 0x1EA0EEC VA: 0x1EA4EEC
	public void Initialize(Transform traceObject, int uid, string text) { }

	// RVA: 0x1EA5290 Offset: 0x1EA1290 VA: 0x1EA5290
	public void SetText(string text) { }

	// RVA: 0x1EA533C Offset: 0x1EA133C VA: 0x1EA533C Slot: 8
	protected override void StatusUpdate() { }

	// RVA: 0x1EA55A8 Offset: 0x1EA15A8 VA: 0x1EA55A8
	public void .ctor() { }
}
