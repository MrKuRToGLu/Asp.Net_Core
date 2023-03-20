/*
    Dependecy Inversion Prencible (DIP) =>    classlar arasındaki bağımlılıkların sıkı sıkıya (tightl-coupled) değil, gevşek (loosely-coupled) olması prenbisibir...

    YÜksek seviyeli modüller, düşük seviyeli modüllere sıkı bağımlı olmamalıdır...çünkü düşük seviyeli modüllerde yapılacak bir güncelleme yüksek seviyeli modülleri bozacaktır...

     sınıflar birbirinden soyutlanmalıdır...
 */
public interface IDIP { }
public class A : IDIP // düşük seviyeli modül...
{
}
public class C : IDIP
{
}
public class B // Yüksek seviyeli modül
{
    A a = new A();
    C c = new C();
}
// Dependency Inversion uygulanan DIP sınıf
public class DIP
{
    //IDIP dip = new IDIP(); // interfaceler instance alınabilen varlıklar değildir
    IDIP dip;
    public DIP(IDIP dIP) // constructor injection
    {
        dip = dIP;
    }
    public void test(IDIP dippppp)  // metot injection...
    { }
}


/*
    DEPENDECNY INJECTION (DI) => BAĞIMLILIKLARI ENJECTE ETMEK...
 */
public class MainProgram
{
    void Main()
    {
        A aa = new A(); // bir instance oluştur...
        // a ve b sınıflarının bağımlılıkları enjecte edilir..
        DIP dipdip = new DIP(aa); //dependency injection....

        C cc = new C();
        DIP dipdip2 = new DIP(cc); // dependecny injection...
    }
}
// DIP sınıfı IDIP interfacesi sayesinde A ve C sınıflarına gevşek bağımlıdır...

// B sınıfında A sınıfına sıkı sıkıya bağımlılık vardır...A sınıfındaki bir değişiklik B sınıfı etkileyecektir..

