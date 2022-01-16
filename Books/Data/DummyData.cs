using Books.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books.Data
{
    public class DummyData
    {
        public static void Dummy(IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<BookContext>();
            context.Database.Migrate();

            var genres = new List<Genre>()
            {
                new Genre {Name="Deneme/Yazın"},
                new Genre {Name="Roman"},
                new Genre {Name="Öykü"},
                new Genre {Name="Eğitim Etkinlik"},
                new Genre {Name="Macera"}
            };

            var authors = new List<Author>()
            {
                new Author {
                    Name = "Dan Brown",
                    Description = "Macera romanların en sevilen yazarlarından olan Dan Brown, 22 Haziran 1964 tarihinde Amerika’nın New Hampshire eyaletinde dünyaya geldi. Dan Brown, lise yıllarında müzikle ilgiliydi; çünkü hayattaki tek amacı albümleri çok satan başarılı bir müzisyen olmaktı. Okulda müzik kulübüne katıldı.Amherst Üniversitesi’nde İngilizce ve İspanyolca eğitimi aldı.İspanya’da Sevilla Üniversitesi’nde Leonardo Da Vinci’nin Son Akşam Yemeği slaytı önünde bir hocanın açıklamalarını dinledi.Bu ders ona Da Vinci Şifresi kitabı için ilham kaynağı olacaktı.",
                    ImageUrl = "dan_brown.jpg",
                    Genres=new List<Genre>(){genres[3],genres[1],genres[4]},
                    Books= new List<Book>()
                    {
                        new Book
                        {
                            Name="Hayvanlar Senfonisi",
                            Summary="Maestro Fare ve müzisyen arkadaşlarıyla ormanların ve denizlerin derinliklerinde gezin! Kitabın içinde büyük mavi bir balina, hızlı çitalar, minik böcekler ve zarif kuğularla karşılaşacaksın. Üstelik her birinin seninle paylaşacağı bir sırrı var.",
                            ImageUrl="HayvanlarSenfonisi.jpg",
                            PublishDate=2020,
                            Genres=new List<Genre>(){genres[3]},
                        },
                        new Book
                        {
                            Name="Melekler ve Şeytanlar ",
                            Summary="Harvard Üniversitesi Simgebilim Profesörü Robert Langdon efsanevi gizli örgüt Illuminati'nin -Galileo zamanından beri Katolik Kilisesi'nin bağnaz inançlarını lanetleyerek bilimin yararlarını yücelten- hala faaliyette olup cinayetler işlediğini öğrenince şok geçirir. Parlak bir fizikçi olan Leonarda Vetra cinayete kurban gitmiştir. Tek gözü oyulmuş ve göğsü örgütün sembolüyle dağlanmıştır. Bilim adamının son buluşu güçlü ve çok tehlikeli enerji kaynağı karşımadde çalınmış ve yeni Papa seçiminin gerçekleşeceği gün Vatikan Şehri'nin altına saklanmıştır. Langdon, Vetra'nın meslektaşı ve aynı zamanda kızı olan Vittoria ile medeniyeti yok olmaktan kurtarmak amacıyla Roma sokaklarında, kiliselerde ve katakomplarda soluk soluğa koşuşturarak 400 yıllık izi sürerek Illuminati'nin izini bulmaya çalışırlar.",
                            ImageUrl="melek_seytan.jpg",
                            PublishDate=2004,
                            Genres=new List<Genre>(){genres[1],genres[4]},
                        }
                    }

                },
                new Author {
                    Name = "Zülfü Livaneli",
                    Description = "Ömer Zülfü Livanelioğlu ya da bilinen adıyla Zülfü Livaneli, 1946 yılında Konya’da dünyaya gelmiş yazar, müzisyen, senarist ve politikacıdır. Kültür – Sanat dalında ülkemizin önde gelen sanatçılar arasında yer alan Zülfü Livaneli, uluslararası alanda birçok ödül kazanmıştır.Livaneli 1946 yılında Ilgın, Konya’da dünyaya gelmiştir. Küçük yaşlarda müziğe merak saran Liveneli bağlama çalmayı öğrenmiştir.Politik duruşu nedeniyle 1971 yılında yaşanan darbe neticesinde cezaevine giren Livaneli, 1972 yılında İsveç’e yerleşmiştir. Zülfi Livaneli, İsveç’te geçirdiği zaman içersinde müzik ve felsefe eğitimi alarak 1973 yılında ilk albümünu çıkarmıştır.",
                    ImageUrl = "Zülfü Livaneli.jpg",
                    Genres=new List<Genre>(){genres[1],genres[0]},
                    Books= new List<Book>()
                    {
                        new Book
                        {
                            Name="Edebiyat Mutluluktur",
                            Summary="Müzisyen, romancı, senarist, yönetmen, siyasetçi, fikir adamı… Kendi şahsında pek çok sanat dalını birleştiren Zülfü Livaneli, bu kez edebiyata açılan mutluluk penceresini aralıyor.Edebiyat Mutluluktur, ömrünü sanatsal üretime adayan ve çok sayıda dilde kendi okur kitlesini oluşturan Zülfü Livaneli’nin edebiyat dünyasına dair düşüncelerini paylaştığı denemelerden oluşuyor. Türkiye’den ve dünyadan farklı örnekleri odağına alarak sanat-toplum ilişkisini irdeliyor.",
                            ImageUrl="Edebiyat Mutluluktur.jpg",
                            PublishDate=2021,
                            Genres=new List<Genre>(){genres[0]},
                        },
                        new Book
                        {
                            Name="Bir Kedi - Bir Adam - Bir Ölüm",
                            Summary="Türkiye’nin üretken kalemi Zülfü Livaneli’nin yazmaya başladıktan 29 yıl sonra bitirdiği romanı: Bir Kedi, Bir Adam, Bir Ölü. Ünlü yazar, bu romanıyla dünyanın farklı yerlerinden, Stockholm’e sığınan devrimcilere odaklanıyor. Tüm yaşamları sınavlarla ve kayıplarla geçen bu insanların “biraz güvenlik biraz can sıkıntısı” olarak tanımladıkları mutluluk arayışlarına odaklanıyor.Türkiye’den Stockholm’e iltica eden Sami, yaşadıklarının sorumlularından biri olan eski bakanla kaldığı hastanede tesadüfen bir araya geliyor. Bu karşılaşma, intikam ve affetme gibi temel psikolojik ikilemleri tartışırken, cezalandırma ve yargılama gibi devlet mekanizmaları ekseninde ülkenin ahlaki iklimine de değiniyor.",
                            ImageUrl="Bir Kedi.jpg",
                            PublishDate=2021,
                            Genres=new List<Genre>(){genres[1]},
                        },
                        new Book
                        {
                            Name="Son Adanın Çocukları",
                            Summary="“Gazetelerin birinde ‘Yeryüzü cenneti adada satılık ev’ başlığı altında, adamızla ilgili övgülere yer veriliyordu. Bu gazete ilanı, yıllardır herkesten sakladığımız Son Adamızın, küçük topluluğumuzun herkes tarafından bilinmesi ve huzurumuzun bozulması anlamına geliyordu. Kim bilir, evi nasıl biri alacaktı?”Ada sakinlerinin karmaşadan uzak kardeşçe yaşadığı son insani köşeye, son sığınağa, Son Ada’ya bir gün bir adam gelir. Adalıların o güne dek süren hayatları, huzuru ve mutluluğu bir anda yerle bir olur.",
                            ImageUrl="Son Ada.jpg",
                            PublishDate=2020,
                            Genres=new List<Genre>(){genres[1]},

                        }
                    }

                },
                new Author {
                    Name = "Stefan Zweig",
                    Description = "Ülkemizde Satranç adlı kısa öyküsüyle ve psikolojik tahlillerle desteklediği muhteşem biyografi eserleriyle tanınan Avusturyalı roman, tiyatro, biyografi yazarı ve gazeteci Stefan Zweig, 28 Kasım 1881 yılında Viyana’da doğdu.Zweig, edebiyatla küçük yaşlarda tanıştı ve bu alanda son derece üst düzey eğitimler aldı. İngilizce, Fransızca, İtalyanca, Latince ve Yunanca öğrenen yazar aynı zamanda felsefe eğitimi de aldı. Başlangıçta şiirle ilgilenen yazar, büyük ölçüde Prag doğumlu büyük Alman şair Rainer Maria Rilke’den etkilenmişti. Charles Baudelaire’nin ve Verlaine’nin şiir çevirilerini Almancaya kazandıran Zweig, daha sonra Güney Asya’ya ve Amerika kıtasındaki birçok ülkeyi gezdi.",
                    ImageUrl = "Stefan.jpg",
                    Genres=new List<Genre>(){genres[1],genres[2]},
                    Books= new List<Book>()
                    {
                        new Book
                        {
                            Name="Bir Kadının Yaşamından Yirmi Dört Saat",
                            Summary="Zweig bu novellası'nda bir kadının yaşamını bütünüyle değiştiren yirmi dört saatlik deneyimini anlatırken, insanda içkin saplantıların ve dayanılmaz arzuların sınırlarında gezinir. Özgürce ve tutkuyla içgüdülerinin peşine takılan bir kadının bu kısa ve yoğun hikâyesi, kadın kalbinin sırlarına ermiş ustanın kaleminde olağanüstü bir anlatıya dönüşür. Yapıtı için mekân olarak muhteşem atmosferiyle Fransız Riviera'sını seçen Zweig, 1920'li yılların sonlarında Avrupa'nın \"kibar\" tabakasının ikiyüzlü ahlak anlayışına yönelik eleştirel tavrıyla dikkat çeker.",
                            ImageUrl="Bir Kadının.jpg",
                            PublishDate=2015,
                            Genres=new List<Genre>(){genres[2]},
                        },
                        new Book
                        {
                            Name="Satranç",
                            Summary="Satranç, “İncecik bir kitaba, tarihin en büyük acılarını sığdırmak mümkün müdür?” sorusunun cevabı niteliğini taşıyor. Avusturyalı Yazar Stefan Zweig tarafından 1942 yılında kaleme alınan eser, sembolik ve özlü anlatımıyla II. Dünya Savaşı’nın tüm yıkıcılığını dile getiriyor.Satranç, aynı adı aldığı tarihi oyunun sembolik ögelerini taşıyor. Savaş alanı ve birbirlerini akıl dolu hamlelerle yenmeye çalışan iki taraf… Kitabın olay örgüsü, bir gemide yapılan satranç düellosu etrafında şekilleniyor. Biri var olmak, diğeri ise yok olmamak için satranca sarılmış olan iki rakibin bu anlam dolu çekişmesinde, yakın tarihe dair derin izler bulacaksınız.",
                            ImageUrl="satranc.jpg",
                            PublishDate=2012,
                            Genres=new List<Genre>(){genres[1]},
                        },
                        new Book
                        {
                            Name="Olağanüstü Bir Gece",
                            Summary="Olağanüstü Bir Gece, seçkin bir burjuva olarak rahat ve tasasız varoluşunu sürdürürken giderek duyarsızlaşan bir adamın hayatındaki dönüştürücü deneyimin hikâyesidir. Sıradan bir Pazar gününü at yarışlarında geçirirken, belki de ilk kez burjuva ahlakından saparak \"suç\" işler. Böylece yeniden \"hissetmeye\" başladığını, kötücül ve ateşli hazları olan gerçek bir insan olduğunu fark eder. İçindeki haz dolu esrime, aynı günün akşamında onu gece âleminin son atıklarının arasına, \"hayatın en dibindeki lağımlara\" sürükleyecek, varış noktası ise ruhani bir uyanış olacaktır.",
                            ImageUrl="Bir Gece.jpg",
                            PublishDate=2015,
                            Genres=new List<Genre>(){genres[1]},

                        }
                    }

                },
                new Author {
                    Name = "Mark Twain",
                    Description = "Mark Twain, 30 Kasım 1835'te Missouri eyaletinin Florida kentinde doğdu. Asıl adı Samuel Langhorne Clemens'tir. Çiftçi olan babası öldüğünde Mark Twain, 11 yaşındaydı. İlk gençlik yıllarında bir basımevinde çalıştı. 18 yaşına gelince New York'a gitti. Kentten kente dolaştı. Daha sonra Mississippi'de buharlı gemilerde çalıştı. İç savaştan sonra gazetelere mizah yazıları yazdı. Mark Twain adı altında gazete muhabirliği ve dergi yazarlığı yaptı. İlk romanı olan Tom Sawyer'ın Serüvenleri'nin 1876 yılında yayınlanmasına kadar yazarlık konusunda değişik çalışmaları oldu. İlk kitabı Mississippi'de Hayat (1883) ve Huckleberry Finn'in Serüvenleri (1885) izledi. Bu üçleme Mark Twain'in başyapıtını oluşturdu. Mark Twain 1890'larda Avrupa'da yaşadı. Birinci kızının ölümü, ikincisininse ağır hastalığı Mark Twain'in bu dönemde kaleme aldığı yazılarına da yansıdı. Yeniden Amerika'ya dönen Mark Twain, 21 Nisan 1910'da Connecticut'taki evinde öldü.",
                    ImageUrl = "mark.png",
                    Genres=new List<Genre>(){genres[1],genres[4],genres[2],genres[3]},
                    Books= new List<Book>()
                    {
                        new Book
                        {
                            Name="Prens Oleomargarin'in Aşırılması ",
                            Summary="1879 yılında bir akşam, Mark Twain küçük kızlarıyla otururken, kızlar babalarına bir hikâye anlatsın diye yalvardılar. Bunun üzerine Twain bir dergideki resimden yola çıkarak onlara fakir bir çocuğun, Johnny'nin hikâyesini anlatmaya başladı: Elinde sihirli tohumlar olan Johnny, kendini çalınmış bir prensi kurtarmakla görevlendirilmiş buluyordu. Mark Twain daha sonra bu hikâye hakkında birtakım notlar aldı ama hikâye yarım kaldı... Yani, şimdiye dek!",
                            ImageUrl="prens.jpg",
                            PublishDate=2019,
                            Genres=new List<Genre>(){genres[3]},
                        },
                        new Book
                        {
                            Name="İnsan Nedir?",
                            Summary="İnsan Nedir? Gerek sunuluş biçimi gerekse içeriği açısından Twain’in diğer eserleri arasında farklı bir yere sahip. Kitap, iki adam arasında geçen bir diyalog biçiminde yazılmış. Kitabı okurken, ununu eleyip eleğini asmış, köşesine çekilmiş ve biraz da alaycı yaşlı bir adam ile deneyimsiz, yargılarında pek aceleci ve heyecanlı, genç bir adam arasında geçen Sokratik bir diyaloga şahit oluyoruz -tıpkı Platon’un meşhur diyaloglarında ya da diyalog biçiminde yazılmış başka birçok eserde olduğu gibi, üzerine konuşulan konuların farklı perspektiflerden değerlendirildiğini görüyoruz. Yaşlı Adam insana dair, insanın ne olduğuna dair kendi fikirlerini ortaya koyar ve gerekçelendirirken, Genç Adam ise bunlara sürekli itiraz ediyor. Ne var ki Yaşlı Adam’ın sorduğu sorular Genç Adam’ı bu itirazların haklı olup olmadığını sorgulamaya zorluyor. Twain böylece, kitabı okuyan bizleri de bu sohbete dâhil ediyor ve biz de kendimizi bu diyalogun taraflarını sorgularken buluyoruz.",
                            ImageUrl="insan.jpg",
                            PublishDate=2015,
                            Genres=new List<Genre>(){genres[2]},
                        },
                        new Book
                        {
                            Name="Huckleberry Finn'in Maceraları",
                            Summary="Büyük Amerikan romanları arasında yerini alan Huckleberry Finn'in Maceraları, Mark Twain'in de en iyi yapıtı olarak kabul edilir. Eğitimsiz, batıl inançlara sahip, ama iyi kalpli bir çocuk olan Huck, işsiz güçsüz ve ayyaş babasından kaçar. Kendisi gibi kaçak olan siyahi köle Jim'le birlikte Mississippi Nehri boyunca macera dolu bir yolculuk yaparlar. Twain, nehrin iki yakasında yaşayan her sınıftan insanı sergileyen eşsiz portreler sunarken, yer yer komik ve ironik bir üslup tutturur.",
                            ImageUrl="Huckleberry.jpg",
                            PublishDate=2014,
                            Genres=new List<Genre>(){genres[1],genres[4]},

                        }
                    }

                },
            };

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Genres.Count() == 0)
                {
                    context.Genres.AddRange(genres);
                }
                if (context.Authors.Count() == 0)
                {
                    context.Authors.AddRange(authors);
                }

                context.SaveChanges();
            }

        }
    }
}
