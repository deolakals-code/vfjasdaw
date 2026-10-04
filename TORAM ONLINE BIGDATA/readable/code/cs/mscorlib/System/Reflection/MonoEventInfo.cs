// Assembly: mscorlib.dll
// Namespace: System.Reflection
internal struct MonoEventInfo // TypeDefIndex: 10646
{
	// Fields
	public Type declaring_type; // 0x0
	public Type reflected_type; // 0x8
	public string name; // 0x10
	public MethodInfo add_method; // 0x18
	public MethodInfo remove_method; // 0x20
	public MethodInfo raise_method; // 0x28
	public EventAttributes attrs; // 0x30
	public MethodInfo[] other_methods; // 0x38
}
