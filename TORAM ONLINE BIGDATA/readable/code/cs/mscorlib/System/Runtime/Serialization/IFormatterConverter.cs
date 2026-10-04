// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization
[CLSCompliant(False)]
public interface IFormatterConverter // TypeDefIndex: 10331
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object Convert(object value, Type type);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool ToBoolean(object value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int ToInt32(object value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract long ToInt64(object value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract float ToSingle(object value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string ToString(object value);
}
