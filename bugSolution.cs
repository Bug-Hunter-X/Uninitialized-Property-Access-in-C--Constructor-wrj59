public class MyClass {
    public int MyProperty { get; set; }

    public MyClass() {
        MyProperty = 0;
    }

    public void MyMethod() {
        // Solution: Ensure MyProperty is initialized before accessing it
        Console.WriteLine(MyProperty); 
    }
}