// Assembly: mscorlib.dll
// Namespace: System.Reflection
[Serializable]
public abstract class Module : ICustomAttributeProvider, ISerializable, _Module // TypeDefIndex: 10608
{
	// Fields
	public static readonly TypeFilter FilterTypeName; // 0x0
	public static readonly TypeFilter FilterTypeNameIgnoreCase; // 0x8
	private const BindingFlags DefaultLookup = 28;

	// Properties
	public virtual Assembly Assembly { get; }
	public virtual Guid ModuleVersionId { get; }
	public virtual string ScopeName { get; }

	// Methods

	// RVA: 0x2F2C26C Offset: 0x2F2826C VA: 0x2F2C26C
	protected void .ctor() { }

	// RVA: 0x2F2C274 Offset: 0x2F28274 VA: 0x2F2C274 Slot: 8
	public virtual Assembly get_Assembly() { }

	// RVA: 0x2F2C29C Offset: 0x2F2829C VA: 0x2F2C29C Slot: 9
	public virtual Guid get_ModuleVersionId() { }

	// RVA: 0x2F2C2C4 Offset: 0x2F282C4 VA: 0x2F2C2C4 Slot: 10
	public virtual string get_ScopeName() { }

	// RVA: 0x2F2C2EC Offset: 0x2F282EC VA: 0x2F2C2EC Slot: 11
	public virtual bool IsResource() { }

	// RVA: 0x2F2C314 Offset: 0x2F28314 VA: 0x2F2C314 Slot: 12
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x2F2C33C Offset: 0x2F2833C VA: 0x2F2C33C Slot: 13
	public virtual object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x2F2C364 Offset: 0x2F28364 VA: 0x2F2C364 Slot: 14
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x2F2C38C Offset: 0x2F2838C VA: 0x2F2C38C Slot: 15
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F2C3B4 Offset: 0x2F283B4 VA: 0x2F2C3B4 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x2F2C3BC Offset: 0x2F283BC VA: 0x2F2C3BC Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F2C3C4 Offset: 0x2F283C4 VA: 0x2F2C3C4
	public static bool op_Equality(Module left, Module right) { }

	// RVA: 0x2F2C3F0 Offset: 0x2F283F0 VA: 0x2F2C3F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2F2C3FC Offset: 0x2F283FC VA: 0x2F2C3FC
	private static bool FilterTypeNameImpl(Type cls, object filterCriteria) { }

	// RVA: 0x2F2C52C Offset: 0x2F2852C VA: 0x2F2C52C
	private static bool FilterTypeNameIgnoreCaseImpl(Type cls, object filterCriteria) { }

	// RVA: 0x2F2C68C Offset: 0x2F2868C VA: 0x2F2C68C Slot: 16
	internal virtual Guid GetModuleVersionId() { }

	// RVA: 0x2F2C6C4 Offset: 0x2F286C4 VA: 0x2F2C6C4
	private static void .cctor() { }
}
