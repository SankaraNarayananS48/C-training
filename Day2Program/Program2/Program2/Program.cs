class PhotoBook
{
    protected int numPages;
    public void setnumPages(int pages)
    {
        this.numPages = pages;
    }
    public int getnumPages()
    {
        return this.numPages;
    }

    public PhotoBook(){
        this.numPages = 16;
    }

    public PhotoBook(int page)
    {
        this.numPages=page;
    }
}

class BigPhotoBook:PhotoBook
{
   
    public BigPhotoBook(int a):base(a)
    { }

    public int getnumPages()
    {
        return this.numPages;
    }
}

class PhotoBookTest
{
    static void Main(String[] args)
    {
        PhotoBook book = new PhotoBook();
        Console.WriteLine("No of pages is"+" "+book.getnumPages());

        PhotoBook book1 = new PhotoBook(24);
        Console.WriteLine("No of pages is" + " " + book1.getnumPages());

        BigPhotoBook book2 = new BigPhotoBook(64);
        Console.WriteLine("No of BigPhotoBookpages is" + " " + book2.getnumPages());
    }
}