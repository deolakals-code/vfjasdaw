// Assembly: System.dll
// Namespace: System.ComponentModel.Design.Serialization
public sealed class InstanceDescriptor // TypeDefIndex: 14290
{
	// Fields
	[CompilerGenerated]
	private readonly ICollection <Arguments>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly bool <IsComplete>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly MemberInfo <MemberInfo>k__BackingField; // 0x20

	// Properties
	public ICollection Arguments { get; }
	public MemberInfo MemberInfo { get; }

	// Methods

	// RVA: 0x34D03F0 Offset: 0x34CC3F0 VA: 0x34D03F0
	public void .ctor(MemberInfo member, ICollection arguments) { }

	// RVA: 0x34D03F8 Offset: 0x34CC3F8 VA: 0x34D03F8
	public void .ctor(MemberInfo member, ICollection arguments, bool isComplete) { }

	[CompilerGenerated]
	// RVA: 0x34D092C Offset: 0x34CC92C VA: 0x34D092C
	public ICollection get_Arguments() { }

	[CompilerGenerated]
	// RVA: 0x34D0934 Offset: 0x34CC934 VA: 0x34D0934
	public MemberInfo get_MemberInfo() { }

	// RVA: 0x34C27FC Offset: 0x34BE7FC VA: 0x34C27FC
	public object Invoke() { }
}
