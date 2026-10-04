// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class AbnormalData // TypeDefIndex: 1641
{
	// Fields
	[CompilerGenerated]
	private AbnormalType <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private float <EffectTime>k__BackingField; // 0x14
	[CompilerGenerated]
	private float <ResistTime>k__BackingField; // 0x18
	[CompilerGenerated]
	private byte <LocalId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private bool <IsEnd>k__BackingField; // 0x1D
	[CompilerGenerated]
	private bool <IsForce>k__BackingField; // 0x1E
	[CompilerGenerated]
	private Action<AbnormalData> <Callback>k__BackingField; // 0x20

	// Properties
	public AbnormalType Type { get; set; }
	public float EffectTime { get; set; }
	public float ResistTime { get; set; }
	public byte LocalId { get; set; }
	public bool IsEnd { get; set; }
	public bool IsForce { get; set; }
	public Action<AbnormalData> Callback { get; set; }
	public bool IsNotAbnormal { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x209FBA8 Offset: 0x209BBA8 VA: 0x209FBA8
	public AbnormalType get_Type() { }

	[CompilerGenerated]
	// RVA: 0x209FBB0 Offset: 0x209BBB0 VA: 0x209FBB0
	private void set_Type(AbnormalType value) { }

	[CompilerGenerated]
	// RVA: 0x209FBB8 Offset: 0x209BBB8 VA: 0x209FBB8
	public float get_EffectTime() { }

	[CompilerGenerated]
	// RVA: 0x209FBC0 Offset: 0x209BBC0 VA: 0x209FBC0
	protected void set_EffectTime(float value) { }

	[CompilerGenerated]
	// RVA: 0x209FBC8 Offset: 0x209BBC8 VA: 0x209FBC8
	public float get_ResistTime() { }

	[CompilerGenerated]
	// RVA: 0x209FBD0 Offset: 0x209BBD0 VA: 0x209FBD0
	protected void set_ResistTime(float value) { }

	[CompilerGenerated]
	// RVA: 0x209FBD8 Offset: 0x209BBD8 VA: 0x209FBD8
	public byte get_LocalId() { }

	[CompilerGenerated]
	// RVA: 0x209FBE0 Offset: 0x209BBE0 VA: 0x209FBE0
	private void set_LocalId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x209FBE8 Offset: 0x209BBE8 VA: 0x209FBE8
	public bool get_IsEnd() { }

	[CompilerGenerated]
	// RVA: 0x209FBF0 Offset: 0x209BBF0 VA: 0x209FBF0
	protected void set_IsEnd(bool value) { }

	[CompilerGenerated]
	// RVA: 0x209FBFC Offset: 0x209BBFC VA: 0x209FBFC
	public bool get_IsForce() { }

	[CompilerGenerated]
	// RVA: 0x209FC04 Offset: 0x209BC04 VA: 0x209FC04
	private void set_IsForce(bool value) { }

	[CompilerGenerated]
	// RVA: 0x209FC10 Offset: 0x209BC10 VA: 0x209FC10
	public Action<AbnormalData> get_Callback() { }

	[CompilerGenerated]
	// RVA: 0x209FC18 Offset: 0x209BC18 VA: 0x209FC18
	private void set_Callback(Action<AbnormalData> value) { }

	// RVA: 0x209FC20 Offset: 0x209BC20 VA: 0x209FC20
	public bool get_IsNotAbnormal() { }

	// RVA: 0x209FC58 Offset: 0x209BC58 VA: 0x209FC58
	public void .ctor(AbnormalType type, float time, float resistTime, byte localId, bool isForce, Action<AbnormalData> callback) { }

	// RVA: 0x209FCE4 Offset: 0x209BCE4 VA: 0x209FCE4 Slot: 4
	public virtual bool Update(float dtime) { }

	// RVA: 0x209FD18 Offset: 0x209BD18 VA: 0x209FD18
	public void UpdateResistTime(float dtime) { }
}
