// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Math/Gradient.bindings.h")]
[RequiredByNativeCode]
public class Gradient : IEquatable<Gradient> // TypeDefIndex: 16299
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	[FreeFunction(Name = "Gradient_Bindings::Init", IsThreadSafe = True)]
	// RVA: 0x37E0C2C Offset: 0x37DCC2C VA: 0x37E0C2C
	private static IntPtr Init() { }

	[FreeFunction(Name = "Gradient_Bindings::Cleanup", IsThreadSafe = True, HasExplicitThis = True)]
	// RVA: 0x37E0C54 Offset: 0x37DCC54 VA: 0x37E0C54
	private void Cleanup() { }

	[FreeFunction("Gradient_Bindings::Internal_Equals", IsThreadSafe = True, HasExplicitThis = True)]
	// RVA: 0x37E0C90 Offset: 0x37DCC90 VA: 0x37E0C90
	private bool Internal_Equals(IntPtr other) { }

	[RequiredByNativeCode]
	// RVA: 0x37E0CD4 Offset: 0x37DCCD4 VA: 0x37E0CD4
	public void .ctor() { }

	// RVA: 0x37E0D1C Offset: 0x37DCD1C VA: 0x37E0D1C Slot: 1
	protected override void Finalize() { }

	// RVA: 0x37E0DD4 Offset: 0x37DCDD4 VA: 0x37E0DD4 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x37E0EE0 Offset: 0x37DCEE0 VA: 0x37E0EE0 Slot: 4
	public bool Equals(Gradient other) { }

	// RVA: 0x37E0FA8 Offset: 0x37DCFA8 VA: 0x37E0FA8 Slot: 2
	public override int GetHashCode() { }
}
