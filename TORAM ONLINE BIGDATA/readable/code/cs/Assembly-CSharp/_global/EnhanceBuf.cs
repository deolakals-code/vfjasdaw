// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EnhanceBuf : SkillBufferDataBase // TypeDefIndex: 3148
{
	// Fields
	private EnhanceBuf.EnhanceType type; // 0x20
	private int atkUp; // 0x24
	private int matkUp; // 0x28
	private int mobDef; // 0x2C
	private int mobMdef; // 0x30
	private PlayerActionManagerBase playerAction; // 0x38
	private GameObject target; // 0x40
	private bool isViewSelfIcon; // 0x48

	// Properties
	public override SkillId SkillId { get; }
	public override int BufEffectTakeId { get; }
	public override bool IsViewSelfIcon { get; }
	public bool IsEnhanceAtk { get; }
	public bool IsEnhanceMatk { get; }

	// Methods

	// RVA: 0x232B684 Offset: 0x2327684 VA: 0x232B684 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x232B68C Offset: 0x232768C VA: 0x232B68C Slot: 8
	public override int get_BufEffectTakeId() { }

	// RVA: 0x232B6A4 Offset: 0x23276A4 VA: 0x232B6A4 Slot: 5
	public override bool get_IsViewSelfIcon() { }

	// RVA: 0x232B6AC Offset: 0x23276AC VA: 0x232B6AC
	public bool get_IsEnhanceAtk() { }

	// RVA: 0x232B6B8 Offset: 0x23276B8 VA: 0x232B6B8
	public bool get_IsEnhanceMatk() { }

	// RVA: 0x232B6C4 Offset: 0x23276C4 VA: 0x232B6C4
	public void .ctor(byte lv, int type) { }

	// RVA: 0x232B730 Offset: 0x2327730 VA: 0x232B730 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x232B768 Offset: 0x2327768 VA: 0x232B768 Slot: 11
	public override void Updata() { }

	// RVA: 0x232BEEC Offset: 0x2327EEC VA: 0x232BEEC Slot: 14
	public override Dictionary<TakeParameterType, int> GetBufferEffectAppendParameter() { }

	// RVA: 0x232BFE4 Offset: 0x2327FE4 VA: 0x232BFE4
	public void SetViewSelfIcon(bool flag) { }
}
