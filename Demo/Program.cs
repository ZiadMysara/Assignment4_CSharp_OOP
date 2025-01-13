using Demo.Interface_Example_02;
using Demo.Interface_Example_03;

namespace Demo
{
    internal class Program
    {
        /// هبدددددددددددددددددد
        /// static void PrintTenNumbersFromSeries(TypeAS series)
        /// {
        ///     if (series is null)
        ///         return;
        ///   
        ///     for (int i = 1; i <= 10; i++)
        ///     {
        ///         Console.Write(value: $"{series.Current}\t");
        ///         series.GetNext();
        ///     }
        ///     series.Reset();
        ///     Console.WriteLine();
        /// }
        ///   
        /// static void PrintTenNumbersFromSeries(TypeBS series)
        /// {
        ///     if (series is null)
        ///         return;
        ///   
        ///     for (int i = 1; i <= 10; i++)
        ///     {
        ///         Console.Write(value: $"{series.Current}\t");
        ///         series.GetNext();
        ///     }
        ///     series.Reset();
        ///     Console.WriteLine();
        /// }

        // this method is more generic // open closed principle 
        static void PrintTenNumbersFromSeries(ISeries series)
        {
            if (series is null)
                return;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write(value: $"{series.Current}\t");
                series.GetNext();
            }
            series.Reset();
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            #region Interface Example 01
            /// IType reference;
            /// // Declare for Reference of type "IType", Containg Garbag Value
            /// // This Reference 'reference' Can Refer to an object of any "Type Implementing IType Interface'
            /// // CLR Will Allocate 4 UnInitialized Bytes in STACK for this Reference.
            /// // CLR Will Allocate 0 Bytes in HEAP.
            ///
            /// // reference = /*new IType()*/ --> INVALID;
            /// reference = new TypeA();
            /// reference.MyProperty = 10;
            /// reference.MyMethod(); // Hello World!
            /// reference.Print2(); // Default Implemented Method
            ///
            /// TypeA typeA = new TypeA();
            /// typeA.MyProperty = 20;
            /// typeA.MyMethod(); // Hello World!
            ///                   //typeA.Print2(); // Default Implemented Method //Invalid
            ///                   // the only way to reach to Default Implemented Method is through the Interface Reference
            ///
            ///
            ///
            #endregion

            #region Interface Example 02
            /// TypeAS seriesByTwo = new TypeAS();
            /// PrintTenNumbersFromSeries(seriesByTwo);
            /// 
            /// TypeBS seriesByThree = new TypeBS();
            /// PrintTenNumbersFromSeries(seriesByThree);
            /// 
            /// 

            #endregion

            #region Interface_Example_03
            /// Vechile vechile = new Car();
            /// vechile.Speed = 100;
            /// // vechile.Forward();  // not found in Class Vechile
            /// // vechile.Backward(); // not found in Class Vechile
            /// 
            /// IMoveable moveable = new Car();
            /// // moveable.Speed = 200; // speed not in Interface IMoveable
            /// moveable.Forward();  // Forward in Interface IMoveable
            /// moveable.Backward(); // Backward in Interface IMoveable
            /// 
            /// Car car = new Car();
            /// car.Speed = 300; // Speed implemented in class Car
            /// car.Forward();   // Forward implemented in class Car
            /// car.Backward();  // Backward implemented in class Car
            /// 
            /// 
            /// Airplane airplane = new Airplane();
            /// airplane.Speed = 500; // Speed implemented in class Airplane
            /// //airplane.Forward();   // I can't call Forward() method directly because it's implemented explicitly
            /// ((IMoveable)airplane).Forward(); // Forward implemented in interface IMoveable
            /// ((IFlyable)airplane).Forward(); // Forward implemented in interface IFlyable
            /// airplane.Backward(); // it same method name in both interfaces Imovable and IFlyable
            /// 
            #endregion

            #region Interface_Example_04
            // I achive Interface Segregation in this example 
            #endregion


            #region Notes
            // 1. Interface is a Reference Type.
            // 2. Interface is a Contract.

            // What You Can Write inside the Interface?
            // 1. Signature for Property
            // 2. Signature for Method
            // 3. Default Implemented Method [C# 8.0 NEW Feature (.NET Core 3.1 [2019])]
            // 4. Static Members [C# 8.0 NEW Feature (.NET Core 3.1 [2019])]

            // "public" Access Modifier is the Default Access Modifier inside the Interface.
            // "Private" Access Modifier is not allowed for the Signatures Only (Property, Method)

            // there was two options to implement the interface
            // 1. Explicit Interface Implementation
            //      when you have a class that implements multiple interfaces and you want to avoid the name conflict
            // 2. Implicit Interface Implementation
            //      the default way to implement the interface

            // Interface Members are Public by Default
            // Interface Members are Abstract by Default
            // Interface Members are Virtual by Default


            // you can't create an instance of an interface
            // IType reference = new IType(); --> INVALID;

            // you can create a reference of an interface
            // IType reference; --> VALID;

            // the only way to reach to Default Implemented Method is through the Interface Reference

            // if signature property in the interface have "get" only, you can add the "set" in the class
            // if signature property in the Abstract Class have "get" only, you can't add the "set" in the Concreate class


            #endregion
        }
    }
}
