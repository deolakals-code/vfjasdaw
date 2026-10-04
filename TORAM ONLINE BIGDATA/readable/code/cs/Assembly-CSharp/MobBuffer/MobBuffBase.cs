// Assembly: Assembly-CSharp.dll
// Namespace: MobBuffer
public abstract class MobBuffBase // TypeDefIndex: 9306
{
	// Fields
	private readonly int flag; // 0x10
	[CompilerGenerated]
	private int[] <Vals>k__BackingField; // 0x18
	[CompilerGenerated]
	private float <EffectTime>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsEnd>k__BackingField; // 0x24

	// Properties
	public abstract MobBuffId Id { get; }
	public int[] Vals { get; set; }
	public float EffectTime { get; set; }
	public bool IsEnd { get; set; }
	public virtual int EffectTakeId { get; }
	public bool IsAllBoss { get; }
	public bool IsAllNotBoss { get; }
	public bool IsNotIncludingMyself { get; }
	public bool IsRemoveBuffwhenSwitchingHyperMode { get; }
	public bool IsNotOverwrite { get; }
	public bool IsCanNotRemove { get; }
	public bool IsEternalBuff { get; }

	// Methods

	// RVA: 0x1EB9B80 Offset: 0x1EB5B80 VA: 0x1EB9B80
	public void .ctor() { }

	// RVA: 0x1EB96EC Offset: 0x1EB56EC VA: 0x1EB96EC
	public void .ctor(MobActionPattern pattern) { }

	// RVA: 0x1EB9844 Offset: 0x1EB5844 VA: 0x1EB9844
	public void .ctor(MobBuffData buffData) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract MobBuffId get_Id();

	[CompilerGenerated]
	// RVA: 0x1EBAA58 Offset: 0x1EB6A58 VA: 0x1EBAA58
	public int[] get_Vals() { }

	[CompilerGenerated]
	// RVA: 0x1EBAA60 Offset: 0x1EB6A60 VA: 0x1EBAA60
	protected void set_Vals(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x1EBAA68 Offset: 0x1EB6A68 VA: 0x1EBAA68
	public float get_EffectTime() { }

	[CompilerGenerated]
	// RVA: 0x1EBAA70 Offset: 0x1EB6A70 VA: 0x1EBAA70
	protected void set_EffectTime(float value) { }

	[CompilerGenerated]
	// RVA: 0x1EBAA78 Offset: 0x1EB6A78 VA: 0x1EBAA78
	public bool get_IsEnd() { }

	[CompilerGenerated]
	// RVA: 0x1EBAA80 Offset: 0x1EB6A80 VA: 0x1EBAA80
	private void set_IsEnd(bool value) { }

	// RVA: 0x1EBAA8C Offset: 0x1EB6A8C VA: 0x1EBAA8C Slot: 5
	public virtual int get_EffectTakeId() { }

	// RVA: 0x1EBAA94 Offset: 0x1EB6A94 VA: 0x1EBAA94
	public bool get_IsAllBoss() { }

	// RVA: 0x1EBAAA0 Offset: 0x1EB6AA0 VA: 0x1EBAAA0
	public bool get_IsAllNotBoss() { }

	// RVA: 0x1EBAAAC Offset: 0x1EB6AAC VA: 0x1EBAAAC
	public bool get_IsNotIncludingMyself() { }

	// RVA: 0x1EBAAB8 Offset: 0x1EB6AB8 VA: 0x1EBAAB8
	public bool get_IsRemoveBuffwhenSwitchingHyperMode() { }

	// RVA: 0x1EBAAC4 Offset: 0x1EB6AC4 VA: 0x1EBAAC4
	public bool get_IsNotOverwrite() { }

	// RVA: 0x1EBAAD0 Offset: 0x1EB6AD0 VA: 0x1EBAAD0
	public bool get_IsCanNotRemove() { }

	// RVA: 0x1EBAADC Offset: 0x1EB6ADC VA: 0x1EBAADC
	public bool get_IsEternalBuff() { }

	// RVA: 0x1EBAAF0 Offset: 0x1EB6AF0 VA: 0x1EBAAF0 Slot: 6
	public virtual void Update() { }

	// RVA: 0x1EBA494 Offset: 0x1EB6494 VA: 0x1EBA494
	public void End() { }

	// RVA: 0x1EBAB38 Offset: 0x1EB6B38 VA: 0x1EBAB38 Slot: 7
	public virtual int GetValue() { }

	// RVA: 0x1EBA734 Offset: 0x1EB6734 VA: 0x1EBA734 Slot: 8
	public virtual MobBuffData GetSendData() { }
}
