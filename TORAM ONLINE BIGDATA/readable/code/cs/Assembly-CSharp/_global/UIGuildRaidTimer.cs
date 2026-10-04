// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildRaidTimer : MonoBehaviour // TypeDefIndex: 6529
{
	// Fields
	[SerializeField]
	private GameObject buttonObject; // 0x20
	[SerializeField]
	private UIGLSpriteSlicedNew mainSprite; // 0x28
	[SerializeField]
	private UIGLLabel mainLabel; // 0x30
	[SerializeField]
	private GameObject subTimeOverLabelObject; // 0x38
	[SerializeField]
	private GameObject subLabelObject; // 0x40
	[SerializeField]
	private BoxCollider panelObject; // 0x48
	private GuildRaidRoomData roomData; // 0x50
	private BCollaborationRoomData bCollabRoomData; // 0x58
	private ScoreAttackRoomData scoreAttackRoomData; // 0x60
	private SystemTextManager systemTextManager; // 0x68
	private float timer; // 0x70
	private string timeLocalize; // 0x78
	private int countDownCheck; // 0x80
	private float fade; // 0x84
	private int step; // 0x88

	// Properties
	private float LeftTime { get; }
	private BossResultData BossResultData { get; }

	// Methods

	// RVA: 0x196CF2C Offset: 0x1968F2C VA: 0x196CF2C
	private float get_LeftTime() { }

	// RVA: 0x196D010 Offset: 0x1969010 VA: 0x196D010
	private BossResultData get_BossResultData() { }

	// RVA: 0x196D0D8 Offset: 0x19690D8 VA: 0x196D0D8
	public void ActiveTimer() { }

	// RVA: 0x196D67C Offset: 0x196967C VA: 0x196D67C
	private void LateUpdate() { }

	// RVA: 0x196DFCC Offset: 0x1969FCC VA: 0x196DFCC
	public void OnClick() { }

	// RVA: 0x196DDE4 Offset: 0x1969DE4 VA: 0x196DDE4
	private bool GetNullRoomData() { }

	// RVA: 0x196E118 Offset: 0x196A118 VA: 0x196E118
	public void .ctor() { }
}
