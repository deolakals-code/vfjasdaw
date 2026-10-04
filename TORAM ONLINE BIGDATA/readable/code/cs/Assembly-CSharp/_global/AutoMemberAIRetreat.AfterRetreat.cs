// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AutoMemberAIRetreat.AfterRetreat // TypeDefIndex: 404
{
	// Fields
	[CompilerGenerated]
	private AutoMemberAIRetreat <Parent>k__BackingField; // 0x10
	[CompilerGenerated]
	private Vector3 <Direction>k__BackingField; // 0x18
	public Action<AutoMemberAIRetreat.AfterRetreat> GetDirection; // 0x28
	private float referenceTime; // 0x30

	// Properties
	public AutoMemberAIRetreat Parent { get; set; }
	public Vector3 Direction { get; set; }
	public Vector3 toTargetVector { get; }
	public Vector3 LastRetreatDirection { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x173B248 Offset: 0x1737248 VA: 0x173B248
	public AutoMemberAIRetreat get_Parent() { }

	[CompilerGenerated]
	// RVA: 0x173B250 Offset: 0x1737250 VA: 0x173B250
	public void set_Parent(AutoMemberAIRetreat value) { }

	[CompilerGenerated]
	// RVA: 0x173B258 Offset: 0x1737258 VA: 0x173B258
	public Vector3 get_Direction() { }

	[CompilerGenerated]
	// RVA: 0x173B264 Offset: 0x1737264 VA: 0x173B264
	public void set_Direction(Vector3 value) { }

	// RVA: 0x173B270 Offset: 0x1737270 VA: 0x173B270
	public Vector3 get_toTargetVector() { }

	// RVA: 0x173B2E4 Offset: 0x17372E4 VA: 0x173B2E4
	public float GetElapsedTime() { }

	// RVA: 0x173B304 Offset: 0x1737304 VA: 0x173B304
	public void ResetElapsed() { }

	// RVA: 0x173B320 Offset: 0x1737320 VA: 0x173B320
	public Vector3 get_LastRetreatDirection() { }

	// RVA: 0x173B340 Offset: 0x1737340 VA: 0x173B340
	public void .ctor(Action<AutoMemberAIRetreat.AfterRetreat> func) { }

	// RVA: 0x173B370 Offset: 0x1737370 VA: 0x173B370
	public Vector3 GetIdleAction() { }
}
