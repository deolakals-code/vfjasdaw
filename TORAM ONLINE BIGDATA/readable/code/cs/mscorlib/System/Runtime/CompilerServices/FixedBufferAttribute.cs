// Assembly: mscorlib.dll
// Namespace: System.Runtime.CompilerServices
[Usage(256, Inherited = False)]
public sealed class FixedBufferAttribute : Attribute // TypeDefIndex: 10495
{
	// Fields
	[CompilerGenerated]
	private readonly Type <ElementType>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly int <Length>k__BackingField; // 0x18

	// Properties
	public Type ElementType { get; }
	public int Length { get; }

	// Methods

	// RVA: 0x2F1FEDC Offset: 0x2F1BEDC VA: 0x2F1FEDC
	public void .ctor(Type elementType, int length) { }

	[CompilerGenerated]
	// RVA: 0x2F1FF18 Offset: 0x2F1BF18 VA: 0x2F1FF18
	public Type get_ElementType() { }

	[CompilerGenerated]
	// RVA: 0x2F1FF20 Offset: 0x2F1BF20 VA: 0x2F1FF20
	public int get_Length() { }
}
