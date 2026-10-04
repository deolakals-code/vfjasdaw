// Assembly: Assembly-CSharp.dll
// Namespace: 
public class LightningHailBuf : SkillBufferDataBase // TypeDefIndex: 3228
{
	// Fields
	private PlayerActionManagerBase playerAction; // 0x20
	private Dictionary<int, Vector3> takeList; // 0x28
	private Vector3 effectPos; // 0x30
	private int element; // 0x3C
	private int bufEffectTakeId; // 0x40

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }
	public override int BufEffectTakeId { get; }
	public int takeCount { get; }

	// Methods

	// RVA: 0x2339588 Offset: 0x2335588 VA: 0x2339588 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2339590 Offset: 0x2335590 VA: 0x2339590 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x23395AC Offset: 0x23355AC VA: 0x23395AC Slot: 8
	public override int get_BufEffectTakeId() { }

	// RVA: 0x23395B4 Offset: 0x23355B4 VA: 0x23395B4
	public int get_takeCount() { }

	// RVA: 0x2339604 Offset: 0x2335604 VA: 0x2339604
	public void .ctor(byte lv, int element, PlayerActionManagerBase playerAction) { }

	// RVA: 0x2339710 Offset: 0x2335710 VA: 0x2339710 Slot: 11
	public override void Updata() { }

	// RVA: 0x2339714 Offset: 0x2335714 VA: 0x2339714 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x23397A0 Offset: 0x23357A0 VA: 0x23397A0 Slot: 14
	public override Dictionary<TakeParameterType, int> GetBufferEffectAppendParameter() { }

	// RVA: 0x23398CC Offset: 0x23358CC VA: 0x23398CC
	public void AddEffect(Vector3 pos) { }

	// RVA: 0x233998C Offset: 0x233598C VA: 0x233998C
	public bool GetEffect(out Vector3 pos, out int uid) { }

	// RVA: 0x2339A98 Offset: 0x2335A98 VA: 0x2339A98
	public void RemoveEffect(int uid) { }

	// RVA: 0x2339B50 Offset: 0x2335B50 VA: 0x2339B50
	public void ClearEffect() { }
}
