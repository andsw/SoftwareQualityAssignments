namespace ECommerceProj.Tests
{
  public class Tests
  {
    [SetUp]
    public void Setup()
    {
    }

    // test Id attribute
    [Test]
    public void GetProductId_ValidMinValue()
    {
      var product = new Product(1, "Test Product Name", 11, 5);
      Assert.That(product.Id, Is.EqualTo(1));
    }

    [Test]
    public void GetProductId_ValidMaxValue()
    {
      var product = new Product(10000, "Test Product Name", 11, 5);
      Assert.That(product.Id, Is.EqualTo(10000));
    }

    [Test]
    public void GetProductId_ValidMidValue()
    {
      var product = new Product(5000, "Test Product Name", 11, 5);
      Assert.That(product.Id, Is.EqualTo(5000));
    }

    // test Name attribute
    [Test]
    public void GetProductName_ValidNameValue()
    {
      var product = new Product(1, "Valid Name", 11, 5);
      Assert.That(product.Name, Is.EqualTo("Valid Name"));
    }

    [Test]
    public void GetProductName_EmptyStringValue()
    {
      var product = new Product(10000, "", 11, 5);
      Assert.That(product.Name, Is.EqualTo(""));
    }

    [Test]
    public void GetProductName_BlankStringValue()
    {
      var product = new Product(5000, "     ", 11, 5);
      Assert.That(product.Name, Is.EqualTo("     "));
    }

    // test Price attribute
    [Test]
    public void GetPrice_ValidMinValue()
    {
      var product = new Product(1, "Test Product Name", 1m, 5);
      Assert.That(product.Price, Is.EqualTo(1m));
    }

    [Test]
    public void GetPrice_ValidMaxValue()
    {
      var product = new Product(1, "Test Product Name", 5000m, 5);
      Assert.That(product.Price, Is.EqualTo(5000m));
    }

    [Test]
    public void GetPrice_ValidMidValue()
    {
      var product = new Product(1, "Test Product Name", 2500m, 5);
      Assert.That(product.Price, Is.EqualTo(2500m));
    }

    // test Stock attribute
    [Test]
    public void GetStock_ValidMinValue()
    {
      var product = new Product(1, "Test Product Name", 11, 1);
      Assert.That(product.Stock, Is.EqualTo(1));
    }

    [Test]
    public void GetStock_ValidMaxValue()
    {
      var product = new Product(1, "Test Product Name", 11, 100000);
      Assert.That(product.Stock, Is.EqualTo(100000));
    }

    [Test]
    public void GetStock_ValidMidValue()
    {
      var product = new Product(1, "Test Product Name", 11, 50000);
      Assert.That(product.Stock, Is.EqualTo(50000));
    }

    // Test IncreaseStock method
    [Test]
    public void IncreaseStock_ValidIncrease()
    {
      var product = new Product(1, "Test Product Name", 11, 5);
      product.IncreaseStock(10);
      Assert.That(product.Stock, Is.EqualTo(15));
    }

    [Test]
    public void IncreaseStock_IncreaseByZero()
    {
      var product = new Product(1, "Test Product Name", 11, 5);
      product.IncreaseStock(0);
      Assert.That(product.Stock, Is.EqualTo(5));
    }

    [Test]
    public void IncreaseStock_IncreaseByNegative_ThrowsException()
    {
      var product = new Product(1, "Test Product Name", 11, 5);
      Assert.Throws<ArgumentException>(() => product.IncreaseStock(-1));
    }

    // Test DecreaseStock method
    [Test]
    public void DecreaseStock_ValidDecrease()
    {
      var product = new Product(1, "Test Product Name", 11, 5);
      product.DecreaseStock(3);
      Assert.That(product.Stock, Is.EqualTo(2));
    }

    [Test]
    public void DecreaseStock_DecreaseByZero()
    {
      var product = new Product(1, "Test Product Name", 11, 5);
      product.DecreaseStock(0);
      Assert.That(product.Stock, Is.EqualTo(5));
    }

    [Test]
    public void DecreaseStock_DecreaseByNegative_ThrowsException()
    {
      var product = new Product(1, "Test Product Name", 11, 5);
      Assert.Throws<ArgumentException>(() => product.DecreaseStock(-1));
    }

    [Test]
    public void DecreaseStock_TooMuchToDecrease_ThrowsException()
    {
      var product = new Product(1, "Test Product Name", 11, 5);
      Assert.Throws<InvalidOperationException>(() => product.DecreaseStock(6));
    }
  }
}