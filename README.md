# SignaturePadMemoryTest
Example for blog post [Prevent Xamarin Forms SignaturePad Memory Leak on Android](https://markolazic.com/prevent-xamarin-forms-signaturepad-memory-leak-android/).

The code demonstrates theat the memory leak issue exists. To prevent the issue go to line 27 of SignaturePage.xaml.cs and uncomment GC.Collect() call.