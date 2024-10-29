namespace P4_1_714230037;

abstract public class Product_714230037 {
    private string myType;
    private string myTitle;

    public Product_714230037() { }

    protected Product_714230037(string myType, string myTitle) {
        this.myType = myType;
        this.myTitle = myTitle;
    }

    public string MyType {
        get { return myType; }
        set { myType = value; }
    }

    public string MyTitle {
        get { return myTitle; }
        set { myTitle = value; }
    }

    public abstract void DisplayInfo();
}