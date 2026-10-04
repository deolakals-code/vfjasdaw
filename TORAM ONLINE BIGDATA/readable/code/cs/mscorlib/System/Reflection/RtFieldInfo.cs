// Assembly: mscorlib.dll
// Namespace: System.Reflection
internal abstract class RtFieldInfo : FieldInfo // TypeDefIndex: 10648
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 31
	internal abstract object UnsafeGetValue(object obj);

	// RVA: -1 Offset: -1 Slot: 32
	internal abstract void UnsafeSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture);

	// RVA: -1 Offset: -1 Slot: 33
	internal abstract void CheckConsistency(object target);

	// RVA: 0x2F372B8 Offset: 0x2F332B8 VA: 0x2F372B8
	protected void .ctor() { }
}
