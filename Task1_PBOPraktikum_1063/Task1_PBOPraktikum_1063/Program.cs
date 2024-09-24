using System.Threading.Channels;

public class Program
{
    static void Main(string[] args)
    {
        KebunBinatang kebunBinatang = new KebunBinatang();
        Singa singaDarat = new Singa("Leo", 16, 4);
        Gajah gajahDarat = new Gajah("Gajah India", 8, 4);
        Ular ularDarat = new Ular("Python", 5, 20.5);
        Buaya buayaDarat = new Buaya("Aligator Serem", 12, 5.5);

        Pembatas();
        kebunBinatang.TambahHewan(singaDarat);
        kebunBinatang.TambahHewan(gajahDarat);
        kebunBinatang.TambahHewan(ularDarat);
        kebunBinatang.TambahHewan(buayaDarat);

        Pembatas();
        kebunBinatang.DaftarHewan();

        Pembatas();
        singaDarat.Suara();
        gajahDarat.Suara();
        ularDarat.Suara();
        buayaDarat.Suara();

        singaDarat.Mengaum();
        Pembatas();
    }

    public static void Pembatas(int panjang=50)
    {
        Console.WriteLine(new string('=', panjang));
    }
}

public class Hewan
{
    public string Nama;
    public int Umur;

    public Hewan(string Nama, int Umur)
    {
        this.Nama = Nama;
        this.Umur = Umur;
    }

    public virtual string Suara()
    {
        return "Hewan ini bersuara";
    }

    public void InfoHewan()
    {
        Console.WriteLine($"Hewan ini bernama {Nama} dan berumur {Umur} tahun");
    }
}

public class Mamalia : Hewan
{
    public int jumlahKaki;

    public Mamalia(string Nama, int Umur, int jumlahKaki) : base(Nama, Umur)
    {
        this.jumlahKaki = jumlahKaki;
    }

    public override string Suara()
    {
        return "Mamalia ini bersuara lucu";
    }
}

public class Reptil : Hewan
{
    public double panjangTubuh;

    public Reptil(string Nama, int Umur, double panjangTubuh) : base(Nama, Umur)
    {
        this.panjangTubuh = panjangTubuh;
    }

    public override string Suara()
    {
        return "Reptil ini bersuara menyeramkan";
    }
}

public class Singa : Mamalia
{
    public Singa(string Nama, int Umur, int jumlahKaki) : base(Nama, Umur, jumlahKaki)
    {

    }

    public void Mengaum()
    {
        Console.WriteLine("Singa sedang mengaum dengan santai");
    }
    public override string Suara()
    {
        return "Singa ini bersuara sangat jantan dan menyeramkan";
    }
}

public class Gajah : Mamalia
{
    public Gajah(string Nama, int Umur, int jumlahKaki) : base(Nama, Umur, jumlahKaki)
    {

    }
    public override string Suara()
    {
        return "Gajah ini bersuara sangat keras dan memikat gajah lain";
    }
}

public class Ular : Reptil
{
    public Ular(string Nama, int Umur, double panjangTubuh) : base(Nama, Umur, panjangTubuh)
    {

    }

    public void Merayap()
    {
        Console.WriteLine("Ular sedang merayap dengan santai");
    }
    public override string Suara()
    {
        return "Ular ini bersuara sstttttttt";
    }
}

public class Buaya : Reptil
{
    public Buaya(string Nama, int Umur, double panjangTubuh) : base(Nama, Umur, panjangTubuh)
    {

    }
    public override string Suara()
    {
        return "Reptil ini bersuara menyeramkan";
    }
}

public class KebunBinatang
{
    public List<Hewan> koleksiHewan = new List<Hewan>();
   
    public void TambahHewan(Hewan hewan)
    {
        koleksiHewan.Add(hewan);
        Console.WriteLine($"Hewan {hewan.Nama} telah ditambahkan ke kebun binatang");
    }

    public void DaftarHewan()
    {
        foreach (var hewan in koleksiHewan)
        {
            Console.WriteLine($"Hewan bernama {hewan.Nama} bersuara {hewan.Suara()}");
        }
    }
}