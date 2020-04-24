using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Stripe.Stripeterminal.Model.External {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='DeviceType']"
	[global::Android.Runtime.Register ("com/stripe/stripeterminal/model/external/DeviceType", DoNotGenerateAcw=true)]
	public sealed partial class DeviceType : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='DeviceType']/field[@name='CHIPPER_2X']"
		[Register ("CHIPPER_2X")]
		public static global::Com.Stripe.Stripeterminal.Model.External.DeviceType Chipper2x {
			get {
				const string __id = "CHIPPER_2X.Lcom/stripe/stripeterminal/model/external/DeviceType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.DeviceType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/stripe/stripeterminal/model/external/DeviceType", typeof (DeviceType));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal DeviceType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='DeviceType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/stripe/stripeterminal/model/external/DeviceType;", "")]
		public static unsafe global::Com.Stripe.Stripeterminal.Model.External.DeviceType ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/stripe/stripeterminal/model/external/DeviceType;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Stripe.Stripeterminal.Model.External.DeviceType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.stripe.stripeterminal.model.external']/class[@name='DeviceType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/stripe/stripeterminal/model/external/DeviceType;", "")]
		public static unsafe global::Com.Stripe.Stripeterminal.Model.External.DeviceType[] Values ()
		{
			const string __id = "values.()[Lcom/stripe/stripeterminal/model/external/DeviceType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Stripe.Stripeterminal.Model.External.DeviceType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Stripe.Stripeterminal.Model.External.DeviceType));
			} finally {
			}
		}

	}
}