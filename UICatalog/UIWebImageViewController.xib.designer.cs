// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace escoz {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("UIWebImageViewController")]
	public partial class UIWebImageViewController {
		
		#pragma warning disable 0169
		[MonoTouch.Foundation.Export("onNextImage:")]
		partial void onNextImage (MonoTouch.UIKit.UIButton sender);

		[MonoTouch.Foundation.Connect("view")]
		private MonoTouch.UIKit.UIView view {
			get {
				return ((MonoTouch.UIKit.UIView)(this.GetNativeField("view")));
			}
			set {
				this.SetNativeField("view", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("uiWebImageView")]
		private UIWebImageView uiWebImageView {
			get {
				return ((UIWebImageView)(this.GetNativeField("uiWebImageView")));
			}
			set {
				this.SetNativeField("uiWebImageView", value);
			}
		}
	}
	
	// Base type probably should be MonoTouch.UIKit.UIImageView or subclass
	[MonoTouch.Foundation.Register("UIWebImageView")]
	public partial class UIWebImageView {
	}
}
