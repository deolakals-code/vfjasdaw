// Assembly: UnityEngine.AndroidJNIModule.dll
// Namespace: UnityEngine
public class AndroidJavaProxy // TypeDefIndex: 17065
{
	// Fields
	public readonly AndroidJavaClass javaInterface; // 0x10
	internal IntPtr proxyObject; // 0x18
	private static readonly GlobalJavaObjectRef s_JavaLangSystemClass; // 0x0
	private static readonly IntPtr s_HashCodeMethodID; // 0x8

	// Methods

	// RVA: 0x37C0A5C Offset: 0x37BCA5C VA: 0x37C0A5C
	public void .ctor(string javaInterface) { }

	// RVA: 0x37C1004 Offset: 0x37BD004 VA: 0x37C1004
	public void .ctor(AndroidJavaClass javaInterface) { }

	// RVA: 0x37C1038 Offset: 0x37BD038 VA: 0x37C1038 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x37C10D0 Offset: 0x37BD0D0 VA: 0x37C10D0 Slot: 4
	public virtual AndroidJavaObject Invoke(string methodName, object[] args) { }

	// RVA: 0x37C2710 Offset: 0x37BE710 VA: 0x37C2710 Slot: 5
	public virtual AndroidJavaObject Invoke(string methodName, AndroidJavaObject[] javaArgs) { }

	// RVA: 0x37C0BC8 Offset: 0x37BCBC8 VA: 0x37C0BC8 Slot: 6
	public virtual IntPtr Invoke(string methodName, IntPtr javaArgs) { }

	// RVA: 0x37C3588 Offset: 0x37BF588 VA: 0x37C3588 Slot: 7
	public virtual bool equals(AndroidJavaObject obj) { }

	// RVA: 0x37C35E0 Offset: 0x37BF5E0 VA: 0x37C35E0 Slot: 8
	public virtual int hashCode() { }

	// RVA: 0x37C3794 Offset: 0x37BF794 VA: 0x37C3794 Slot: 9
	public virtual string toString() { }

	// RVA: 0x37C37F8 Offset: 0x37BF7F8 VA: 0x37C37F8
	internal AndroidJavaObject GetProxyObject() { }

	// RVA: 0x37C369C Offset: 0x37BF69C VA: 0x37C369C
	internal IntPtr GetRawProxy() { }

	// RVA: 0x37C3808 Offset: 0x37BF808 VA: 0x37C3808
	private static void .cctor() { }
}
