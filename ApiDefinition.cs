using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace maiti_xamarin
{
	// The first step to creating a binding is to add your native library ("libNativeLibrary.a")
	// to the project by right-clicking (or Control-clicking) the folder containing this source
	// file and clicking "Add files..." and then simply select the native library (or libraries)
	// that you want to bind.
	//
	// When you do that, you'll notice that MonoDevelop generates a code-behind file for each
	// native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
	// architectures that the native library supports and fills in that information for you,
	// however, it cannot auto-detect any Frameworks or other system libraries that the
	// native library may depend on, so you'll need to fill in that information yourself.
	//
	// Once you've done that, you're ready to move on to binding the API...
	//
	//
	// Here is where you'd define your API definition for the native Objective-C library.
	//
	// For example, to bind the following Objective-C class:
	//
	//     @interface Widget : NSObject {
	//     }
	//
	// The C# binding would look like this:
	//
	//     [BaseType (typeof (NSObject))]
	//     interface Widget {
	//     }
	//
	// To bind Objective-C properties, such as:
	//
	//     @property (nonatomic, readwrite, assign) CGPoint center;
	//
	// You would add a property definition in the C# interface like so:
	//
	//     [Export ("center")]
	//     PointF Center { get; set; }
	//
	// To bind an Objective-C method, such as:
	//
	//     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
	//
	// You would add a method definition to the C# interface like so:
	//
	//     [Export ("doSomething:atIndex:")]
	//     void DoSomething (NSObject object, int index);
	//
	// Objective-C "constructors" such as:
	//
	//     -(id)initWithElmo:(ElmoMuppet *)elmo;
	//
	// Can be bound as:
	//
	//     [Export ("initWithElmo:")]
	//     IntPtr Constructor (ElmoMuppet elmo);
	//
	// For more information, see http://docs.xamarin.com/ios/advanced_topics/binding_objective-c_types
	//



	[BaseType (typeof (NSObject))]
	interface PerformanceLibrary
	{
		[Export ("initWithCustomerId:appId:")]
		IntPtr Constructor (string customerId, string appId);

		[Export ("SetDisabled:")]
		void SetDisabled(bool disabled);

		[Export ("TransactionStart:")]
		string TransactionStart(string name );

		[Export ("TransactionStart:parentTransactionId:")]
		string TransactionStart(string name, string parentTransactionId );

		[Export ("TransactionEnd:")]
		void TransactionEnd(string transactionId);

		[Export ("SetTransactionEvent:transactionId:")]
		void setTransactionEvent(string eventName, string transactionId);

		[Export ("SetErrorMessage:transactionId:")]
		void setErrorMessage(string errorMessage, string transactionId);

		
		[Export ("SetUserData:transactionId:")]
		void setUserData(string data, string transactionId);
		[Export ("SetUserTag1:transactionId:")]
		void setUserTag1(string tag, string transactionId);
		[Export ("SetUserTag2:transactionId:")]
		void setUserTag2(string tag, string transactionId);
		[Export ("SetUserTag3:transactionId:")]
		void setUserTag3(string tag, string transactionId);

		[Export ("Notification:userTag1:")]
		void Notification(string name, string userTag1 );
	}
}
/*
-(id)initWithCustomerId:(NSString*) customerId;

// Interval Transaction
// Interval Transaction Start
-(NSString*)TransactionStart:(NSString*)name error:(NSError**)error;
-(NSString*)TransactionStart:(NSString*)name parentTransactionId:(NSString*)parentTransactionId error:(NSError**)error;

// Interval Transaction End
-(void)TransactionEnd:(NSString*)transactionId;


// Interval Event Transaction
-(void)SetTransactionEvent:(NSString*)eventName transactionId:(NSString*)transactionId;
-(void)SetErrorMessage:(NSString*)errorMessage transactionId:(NSString*)transactionId;
-(void)SetUserTag1:(NSString*)tag transactionId:(NSString*)transactionId;
-(void)SetUserTag2:(NSString*)tag transactionId:(NSString*)transactionId;
-(void)SetUserTag3:(NSString*)tag transactionId:(NSString*)transactionId;
-(void)SetUserData:(NSString*)data transactionId:(NSString*)transactionId;

// Notification Transaction
-(void)Notification:(NSString*)name userTag1:(NSString*)userTag1 error:(NSError**)error;
*/
