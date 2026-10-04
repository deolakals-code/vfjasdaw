// Assembly: mscorlib.dll
// Namespace: Mono
internal struct RuntimeClassHandle // TypeDefIndex: 9425
{
	// Fields
	private RuntimeStructs.MonoClass* value; // 0x0

	// Properties
	internal RuntimeStructs.MonoClass* Value { get; }

	// Methods

	// RVA: 0x2E658B0 Offset: 0x2E618B0 VA: 0x2E658B0
	internal void .ctor(RuntimeStructs.MonoClass* value) { }

	// RVA: 0x2E658B8 Offset: 0x2E618B8 VA: 0x2E658B8
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x2E658D8 Offset: 0x2E618D8 VA: 0x2E658D8
	internal RuntimeStructs.MonoClass* get_Value() { }

	// RVA: 0x2E658E0 Offset: 0x2E618E0 VA: 0x2E658E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2E659E4 Offset: 0x2E619E4 VA: 0x2E659E4 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2E65A0C Offset: 0x2E61A0C VA: 0x2E65A0C
	internal static IntPtr GetTypeFromClass(RuntimeStructs.MonoClass* klass) { }

	// RVA: 0x2E65A10 Offset: 0x2E61A10 VA: 0x2E65A10
	internal RuntimeTypeHandle GetTypeHandle() { }
}
