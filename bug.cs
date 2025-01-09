public class MyClass {
    public int MyProperty { get; set; }

    public MyClass() {
        MyProperty = 0;
    }

    public void MyMethod() {
        // Bug: Accessing MyProperty before it's initialized in the constructor
        Console.WriteLine(MyProperty); 
    }
}