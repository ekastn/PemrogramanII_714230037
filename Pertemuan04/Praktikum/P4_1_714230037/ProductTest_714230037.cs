namespace P4_1_714230037;

internal class ProductTest_714230037 {
    static void Main(string[] args) {
        Product_714230037 product1 = new Book_714230037("Book", "C# Object Oriented Solution", "300");
        Product_714230037 product2 = new DVD_714230037("Ethernal sunshine of the spotless mind", "145");
        
        product1.DisplayInfo();
        product2.DisplayInfo();
    }
}