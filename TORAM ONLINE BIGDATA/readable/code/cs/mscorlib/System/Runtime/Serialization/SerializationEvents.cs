// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization
internal sealed class SerializationEvents // TypeDefIndex: 10344
{
	// Fields
	private readonly List<MethodInfo> _onSerializingMethods; // 0x10
	private readonly List<MethodInfo> _onSerializedMethods; // 0x18
	private readonly List<MethodInfo> _onDeserializingMethods; // 0x20
	private readonly List<MethodInfo> _onDeserializedMethods; // 0x28

	// Properties
	internal bool HasOnSerializingEvents { get; }

	// Methods

	// RVA: 0x2EFB240 Offset: 0x2EF7240 VA: 0x2EFB240
	internal void .ctor(Type t) { }

	// RVA: 0x2EFB3A0 Offset: 0x2EF73A0 VA: 0x2EFB3A0
	private List<MethodInfo> GetMethodsWithAttribute(Type attribute, Type t) { }

	// RVA: 0x2EFB5E8 Offset: 0x2EF75E8 VA: 0x2EFB5E8
	internal bool get_HasOnSerializingEvents() { }

	// RVA: 0x2EFB608 Offset: 0x2EF7608 VA: 0x2EFB608
	internal void InvokeOnSerializing(object obj, StreamingContext context) { }

	// RVA: 0x2EFB6AC Offset: 0x2EF76AC VA: 0x2EFB6AC
	internal void InvokeOnDeserializing(object obj, StreamingContext context) { }

	// RVA: 0x2EFB700 Offset: 0x2EF7700 VA: 0x2EFB700
	internal void InvokeOnDeserialized(object obj, StreamingContext context) { }

	// RVA: 0x2EFB754 Offset: 0x2EF7754 VA: 0x2EFB754
	internal SerializationEventHandler AddOnSerialized(object obj, SerializationEventHandler handler) { }

	// RVA: 0x2EFB9A4 Offset: 0x2EF79A4 VA: 0x2EFB9A4
	internal SerializationEventHandler AddOnDeserialized(object obj, SerializationEventHandler handler) { }

	// RVA: 0x2EFB65C Offset: 0x2EF765C VA: 0x2EFB65C
	private static void InvokeOnDelegate(object obj, StreamingContext context, List<MethodInfo> methods) { }

	// RVA: 0x2EFB768 Offset: 0x2EF7768 VA: 0x2EFB768
	private static SerializationEventHandler AddOnDelegate(object obj, SerializationEventHandler handler, List<MethodInfo> methods) { }
}
