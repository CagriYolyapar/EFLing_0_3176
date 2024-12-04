using EFLing_0.DesignPatterns.SingletonPattern;
using EFLing_0.Models;
using EFLing_0.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFLing_0
{
    public partial class Form1 : Form
    {
        /*
             LINQ(Language Integrated Query) / Linquery Expression(Lambda Expression)(Lambda Operatoru  =>   )
        C# icerisinde T-SQL'in gayet kolay bir şekilde anlayabilecegi sorgu komutları yazmaktır...

        Bu destegi sunan metotlar kendi parametrelerine Expression tipinde argüman beklerler...

        Where

        _db.Products.Where( x => x.UnitPrice < 20 ).ToList();


        _db.Categories.Where( x => x.CategoryName.Contains("bev"))


        LINQ yazımında, Ling destekleyen metotlarınız kendilerinden önce hagi yapı geliyorsa (üstteki kodlarda sırasıyla önce Products, sonra Categories geliyor) Expression argümanı (x), Lambda operatoru yazıldıgı anda argüman icin kullanılan harfi veya kelimeyi o yapıyı tekil olarak algılayarak  onun suretine bürünür...
         
         
         
         
         
         
         
         
         
         
         
         
         */

        NorthwindEntities _db;




        public Form1()
        {
            InitializeComponent();
            _db = DBTool.DbInstance;





        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnWhere_Click(object sender, EventArgs e)
        {
            //Fiyatı 20'den fazla olan ve 30'dan az olan ürünleri listelemek istiyoruz

            DgvResult.DataSource = _db.Products.Where(x => x.UnitPrice > 20 && x.UnitPrice < 30).ToList(); //Bu ifade bana ilişkisel kısa devre ve operatoru sayesinde fiyatı 20'den fazla ve 30'dan az olan ürünleri getirecektir...
        }

        private void BtnOrderBy_Click(object sender, EventArgs e)
        {
            //OrderByAscending() metodu yoktur...Cünkü OrderBy() metodu zaten default olarak ascending yani artan sırada  veri getirir. Onun yerine OrderByDescending() metodumuz vardır...

            //DgvResult.DataSource = _db.Products.OrderBy(x => x.UnitPrice).Where(x => x.UnitPrice < 30 ).ToList();

            DgvResult.DataSource = _db.Products.OrderByDescending(x => x.UnitPrice).Where(x => x.UnitPrice < 30).ToList();

        }

        private void BtnTake_Click(object sender, EventArgs e)
        {
            //Take: SQL'deki Top komutunun buradaki karsılıgıdır...Yani size dönen sonuctan Take metodunun icerisine verdiginiz int argüman kadar satırı listeler...

            //En pahalı ürünümü gösterin
            DgvResult.DataSource = _db.Products.OrderByDescending(x => x.UnitPrice).Take(1).ToList();
        }

        private void BtnSkip_Click(object sender, EventArgs e)
        {
            //skip => Verdiginiz sayı kadar satırı atlar (listeye almaz) sonraki kayıtları getirir


            //ikinci en pahalı ürünüm

            DgvResult.DataSource = _db.Products.OrderByDescending(x => x.UnitPrice).Skip(1).Take(1).ToList(); //Gelen ilk veriyi atla kalandan 1 tanesini al ve listele
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            //Find : İlgili tablonun PK kolonunda arama yapar...Size tek bir nesne döndürür...

            //Siz sadece IQueryable Interface'inden miras almıs tipleri veya bizzat o tipleri ToList()'e cevirebilirsiniz...




            #region Notlar
            //Product p = _db.Products.Find(1);

            //List<Product> products = new List<Product>
            //{
            //    p
            //};

            //DgvResult.DataSource = products; 
            #endregion


            //Textbox'a yazdıgım sayıdaki ID'li Product'i DataGridView'da gösterin

            //try
            //{
            //    Product p = _db.Products.Find(Convert.ToInt32(TxtId.Text));
            //    List<Product> products = new List<Product> { p };
            //    DgvResult.DataSource = products;
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}



            try
            {
                int id = Convert.ToInt32(TxtId.Text);

                DgvResult.DataSource = _db.Products.Where(x => x.ProductID == id).ToList();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void BtnSingle_Click(object sender, EventArgs e)
        {
            //Product p = _db.Products.Single(x => x.ProductName == "Chai");

            //Single() metodu sizin Linq sorgunuzdan gelen yapıyı tekil bir degişkene atmanızı veya tekil bir halde kullanmanızı saglar...Ancak Single() metodunda dikkat etmeniz gereken cok önemli bir yer vardır...Eger Linq sorgusundan birden fazla sonuc dönüyorsa ve siz buna ragmen Single() metodu kullanırsanız o zaman hata alırsınız...

            Product p = _db.Products.FirstOrDefault(x => x.ProductName.StartsWith("c"));

            //FirstOrDefault metodu eger birden fazla veri geliyorsa gelen verilerin ilkini alır...Hata vermez...Hic veri gelmiyorsa da ilgili alana göre default (varsayılan) degeri verir...
            MessageBox.Show(p.ProductName);

        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            DgvResult.DataSource = _db.Products.ToList();
        }

        private void BtnContains_Click(object sender, EventArgs e)
        {
            DgvResult.DataSource = _db.Categories.Where(x => x.CategoryName.Contains("a")).ToList();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            DgvResult.DataSource = _db.Categories.Where(x => x.CategoryName.Contains(TxtSearch.Text)).ToList();
        }

        private void BtnVia_Click(object sender, EventArgs e)
        {
            //Seafood,Beverages,Condiments,Dairy Products

            //bu butona tıklandıgında Kategorisinin ismi Textbox'a(TxtKategori) yazılmıs kategorideki ürünler gelsin


            //elimdeki nesnenin nesnesinin ismini kontrol etmek istiyoruz
            // Product nesnesinin Kategorisinin ismini 

            // x.Category.CategoryName

            DgvResult.DataSource = _db.Products.Where(x => x.Category.CategoryName == TxtKategori.Text).ToList();
        }

        private void BtnAny_Click(object sender, EventArgs e)
        {
            //Any metodu sizin verdiginiz kriterlere göre bir veritabanında ilgili sartlara uyan veri var mı yok mu onu sorgular (bool deger döndürür)
            if (_db.Employees.Any(x => x.FirstName == TxtIsim.Text && x.LastName == TxtSoyIsim.Text))
            {
                MessageBox.Show("Hosgeldiniz");
            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı bulunamadı");
            }
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            #region Dynamic

            //dynamic a = 2;

            //a = "asdadasd";

            //a = true;






            #endregion

            #region AnonymusTypes

            //Anonim Tipler



            //CategoryName, Description

            //Anonim tipleri sadece object'e, var'a veya dynamic'e atabilirsiniz
            //var a = new { CategoryName = "Tatlılar", Description = "Test verisi" };

            //dynamic b = new { Categoryname = "Tuzlular", Description = "Cok tuzlular" };

            //object c = new { Categoryname = "Tuzlular", Description = "Cok tuzlular" };


            //Anonim tipleri Linq ifadelerinde sadece Select metodu destekler...




            //DgvResult.DataSource = _db.Categories.Select(x => new
            //{
            //    KategoriIsmi = x.CategoryName,
            //    Aciklama = x.Description
            //}).ToList();


            //Anonim tipleri en cok hardware haberlesmelerinde tercih ederiz...Bunun dısında tercih edildigi noktalar Framework tarafından iclerini otomatik ayrıstırmayı bilen kütüphaneler kullandıgınızda karsınıza cıkan hazır  metotlardır...



            //DgvResult.DataSource = _db.Categories.Select(x => new CategoryVM
            //{
            //    CategoryName = x.CategoryName,
            //    Description = x.Description
            //}).ToList();
            #endregion

            //DataGridView'da listelenecek ürünlerin sadece ürün ismi ,fiyatı ve kategori isimlerinin cıkmasını saglansın...Bir Anonim tip ile yapın bir de normal bir tiple yapın...

            //DgvResult.DataSource = _db.Products.Select(x => new
            //{
            //    ProductName = x.ProductName,
            //    UnitPrice = x.UnitPrice,
            //    CategoryName = x.Category.CategoryName
            //}).ToList();

            DgvResult.DataSource = _db.Products.Select(x => new ProductVM
            {
                ProductName = x.ProductName,
                UnitPrice = x.UnitPrice,
                CategoryName = x.Category.CategoryName


            }).ToList();
        }
    }
}
