// Assembly: Assembly-CSharp-firstpass.dll
// Namespace: 
public interface WebView.WebViewListener // TypeDefIndex: 17095
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnShouldOverrideLoading(string url);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnPageStarted();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnPageFinished();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnReceivedError();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnTouchEvent();
}
