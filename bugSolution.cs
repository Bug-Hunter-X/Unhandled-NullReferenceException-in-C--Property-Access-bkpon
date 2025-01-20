public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize the property with a default value

    public void MyMethod()
    {
        // Check if the property has been initialized before accessing it
        int value = MyProperty == 0? 0 : MyProperty * 2;
    }
}