using System;

namespace VDOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //SampleClass mSample = new SampleClass();
            //Console.WriteLine(mSample.sampleField);

            // DerivedClass mDerive = new DerivedClass();
            //mDerive.sampleMethod("test");
            // mDerive.MethodOfDerive();
            // DerivedClass mTest = (DerivedClass) new SampleClass();
            // mTest.sampleMethod("mTest");
            // mTest.myMethod();
            SampleClass mTest = new DerivedClass();
            mTest.sampleMethod("mTest");

        }
    }

    class SampleClass
    {
        // Constructor
        public SampleClass()
        {
            // Add code here
            // Console.WriteLine("Constructor SampleClass");
            // sampleField = "test sample Filed";
            // Console.WriteLine(sampleField);
            // sampleMethod(sampleField);
        }

        // Attrubites
        public string sampleField;

        // Methods
        public virtual void sampleMethod(string sampleParam) 
        {
            Console.WriteLine("sampleMethod " + sampleParam);
            // Console.WriteLine(sampleField);
        } 

    }

    class DerivedClass:SampleClass {
        public void MethodOfDerive() {
            Console.WriteLine("MethodOfDerive");
        }

        public override void sampleMethod(string sampleParam) 
        {
            Console.WriteLine("sampleMethod of  DerivedClass " + sampleParam);
        } 

        public void myMethod() {
            Console.WriteLine("myMethod");

        }
    }

    class DerivedClass2:SampleClass {
        public void MethodOfDerive() {
            Console.WriteLine("MethodOfDerive2");
        }

        public override void sampleMethod(string sampleParam) 
        {
            Console.WriteLine("sampleMethod of  DerivedClass2 " + sampleParam);
        } 
    }
}
