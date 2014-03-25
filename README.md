maiti_xamarin
=============

A Xamarin wrapper library for the Riverbed MAITI framework (https://github.com/riverbed/maiti)

This Xamarin wrapper compiles as a library project with a Xamarin project for iOS.  Add the library project to your project, and add the riverbed_preferences.plist to your main project (preferences values are documented in the MAITI project: https://github.com/riverbed/maiti).  

You can interact with the MAITI library as follows:
```
  eue = new EUEPerformanceLibrary("customerID", "appID");
	string transactionid = eue.TransactionStart ("User Login");
	eue.setUserTag1 ("jsmith");

  ... [user logs in] ...

	eue.TransactionEnd (transactionid);
```
