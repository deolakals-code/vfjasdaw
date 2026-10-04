// Assembly: System.dll
// Namespace: System.Net
[Serializable]
public abstract class WebResponse : MarshalByRefObject, ISerializable, IDisposable // TypeDefIndex: 14417
{
	// Fields
	private bool m_IsFromCache; // 0x18

	// Properties
	public virtual bool IsFromCache { get; }
	public virtual Uri ResponseUri { get; }
	public virtual WebHeaderCollection Headers { get; }

	// Methods

	// RVA: 0x34ED618 Offset: 0x34E9618 VA: 0x34ED618
	protected void .ctor() { }

	// RVA: 0x34F4464 Offset: 0x34F0464 VA: 0x34F4464
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x34F446C Offset: 0x34F046C VA: 0x34F446C Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x34F4478 Offset: 0x34F0478 VA: 0x34F4478 Slot: 8
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x34F447C Offset: 0x34F047C VA: 0x34F447C Slot: 9
	public virtual void Close() { }

	// RVA: 0x34F4480 Offset: 0x34F0480 VA: 0x34F4480 Slot: 7
	public void Dispose() { }

	// RVA: 0x34F44EC Offset: 0x34F04EC VA: 0x34F44EC Slot: 10
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x34F4578 Offset: 0x34F0578 VA: 0x34F4578 Slot: 11
	public virtual bool get_IsFromCache() { }

	// RVA: 0x34F4580 Offset: 0x34F0580 VA: 0x34F4580 Slot: 12
	public virtual Stream GetResponseStream() { }

	// RVA: 0x34F45A4 Offset: 0x34F05A4 VA: 0x34F45A4 Slot: 13
	public virtual Uri get_ResponseUri() { }

	// RVA: 0x34F45C8 Offset: 0x34F05C8 VA: 0x34F45C8 Slot: 14
	public virtual WebHeaderCollection get_Headers() { }
}
