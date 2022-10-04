#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class GridViewItemDataAutomationPeer : global::Microsoft.UI.Xaml.Automation.Peers.SelectorItemAutomationPeer,global::Microsoft.UI.Xaml.Automation.Provider.IScrollItemProvider
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public GridViewItemDataAutomationPeer( object item,  global::Microsoft.UI.Xaml.Automation.Peers.GridViewAutomationPeer parent) : base(item, parent)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.Peers.GridViewItemDataAutomationPeer", "GridViewItemDataAutomationPeer.GridViewItemDataAutomationPeer(object item, GridViewAutomationPeer parent)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Peers.GridViewItemDataAutomationPeer.GridViewItemDataAutomationPeer(object, Microsoft.UI.Xaml.Automation.Peers.GridViewAutomationPeer)
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void ScrollIntoView()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.Peers.GridViewItemDataAutomationPeer", "void GridViewItemDataAutomationPeer.ScrollIntoView()");
		}
		#endif
		// Processing: Microsoft.UI.Xaml.Automation.Provider.IScrollItemProvider
	}
}
