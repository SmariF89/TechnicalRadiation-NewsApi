using System;
using System.Collections.Generic;
using TechnicalRadiation.Models.Entities;

namespace TechnicalRadiation.Repositories.Data
{
    public static class DataContext
    {
        private static List<Category> _categories = new List<Category>
        {
            new Category
            {
                Id = 1,
                Name =  "World",
                Slug = "world",
                ModifiedBy = "Smari",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Category
            {
                Id = 2,
                Name =  "Business",
                Slug = "business",
                ModifiedBy = "Smari",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Category
            {
                Id = 3,
                Name =  "Gossip",
                Slug = "gossip",
                ModifiedBy = "Smari",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Category
            {
                Id = 4,
                Name =  "Politics",
                Slug = "politics",
                ModifiedBy = "Thorir",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Category
            {
                Id  = 5,
                Name = "Nature",
                Slug = "nature",
                ModifiedBy = "Smari",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Category
            {
                Id = 6,
                Name =  "Weather",
                Slug = "weather",
                ModifiedBy = "Smari",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Category
            {
                Id = 7,
                Name = "Celebrities",
                Slug = "celebrities",
                ModifiedBy = "Thorir",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Category
            {
                Id = 8,
                Name = "Economics",
                Slug = "economics",
                ModifiedBy = "Smari",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Category
            {
                Id = 9,
                Name = "Science",
                Slug = "science",
                ModifiedBy = "Smari",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            }
        };

        private static List<Author> _authors = new List<Author>
        {
            new Author
            {
                Id = 1,
                Name =  "Smari",
                ProfileImgSource = "http://dummyimage.com/116x142.png/5fa2dd/ffffff",
                Bio = "Mf kiel sepen sia. Hemi emfazado fratineto log um. Dio sh trans akuzativo neoficiala, nu eksa timi tial pli. Malcit tagnokto enz gv, krom anstataŭ uj nul. Vi iama kunskribo.",
                ModifiedBy = "Smari",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Author
            {
                Id = 2,
                Name =  "Thorir",
                ProfileImgSource = "http://dummyimage.com/178x190.png/dddddd/000000",
                Bio = "Zeta mallongigo ont o. Nul it avio zeta neigi, mili ekkria pro ej, neigi neoficiala sin tc. Por li tiuj kioma geedzo, negi tagnokto geinstruisto nj nia. Ie per trans.",
                ModifiedBy = "Smari",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Author
            {
                Id = 3,
                Name =  "Barnie",
                ProfileImgSource = "http://dummyimage.com/236x227.png/ff4444/ffffff",
                Bio = "Multe nedifina transitiva unt ok, ng mega daŭrigi praantaŭlasta sen. Peto montrovorto dio gv, danke tiele ja duo. Kialo mekao poste ot ien, al edzo vasta duo, kuo el otek.",
                ModifiedBy = "Smari",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Author
            {
                Id = 4,
                Name =  "Terrel",
                ProfileImgSource = "http://dummyimage.com/119x207.png/cc0000/ffffff",
                Bio = "Ilia eksploda dikfingro cia em, am pre nomo turpa. Danke esperanto gv nia. Nur ik ator subigi, so nura kvaronhoro kia. Neigi dekuma cis ek, poe kv latina alimaniere, tia.",
                ModifiedBy = "Thorir",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Author
            {
                Id  = 5,
                Name = "Faustina",
                ProfileImgSource = "http://dummyimage.com/194x177.png/dddddd/000000",
                Bio = "Peti hago malantaŭa vol an, vic patro itismo konjunkcio om, kaŭze kvintiliono postpriskribo fri om. Geto inter anstataŭi nia ut. Ojd vavo nano intera in, vendo transigi tre da hop.",
                ModifiedBy = "Smari",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Author
            {
                Id = 6,
                Name =  "Artemas",
                ProfileImgSource = "http://dummyimage.com/129x203.png/5fa2dd/ffffff",
                Bio = "Viro minca alikvante ili to, on diesa poste rolmontrilo duo. Internacia praantaŭhieraŭ nul ab, plue lasi esperanto i. Peri multa ad baf, ro kaj dank' familiano literaturo. Orda participo renkonten.",
                ModifiedBy = "Smari",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Author
            {
                Id = 7,
                Name = "Novelia",
                ProfileImgSource = "http://dummyimage.com/147x129.png/ff4444/ffffff",
                Bio = "Ed vela mezurunuo int, os solstariva suprenstreko tro, nea po ilia suprenstreko. Io finno elnombrado sob, plena decimala tempodaŭro is iam. Pov lasi kiel vi. Lo turpa suomio deloke end.",
                ModifiedBy = "Thorir",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Author
            {
                Id = 8,
                Name = "Grove",
                ProfileImgSource = "http://dummyimage.com/100x201.png/5fa2dd/ffffff",
                Bio = "Paki transigi duonvokalo kz vol. Fo gingivalo netransitiva dis, um grupa sanktoleo enz. So plue nano gardi laringalo. Hot ec hoketo prepozitivo, ab nevo vavo orda ien. Duon eksploda eksteraĵo.",
                ModifiedBy = "Smari",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new Author
            {
                Id = 9,
                Name = "Sydney",
                ProfileImgSource = "http://dummyimage.com/188x124.png/cc0000/ffffff",
                Bio = "Frida anstataŭe bis ts. Sia eksbi volus morgaŭa fo, drumo unujn mallongigoj ses ho, iu pro kiomas matematiko. Be for kvanto frazospeco kunskribado. Danki s'joro ido id, ali multo makro.",
                ModifiedBy = "Smari",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            }
        };

        private static List<NewsItem> _newsItems = new List<NewsItem>
        {
            new NewsItem
            {
                Id = 1,
                Title = "Lorem ipsum dolor sit ame",
                ImgSource = "http://dummyimage.com/112x222.png/ff4444/ffffff",
                ShortDescription = "Lorem ipsum dolor sit amet, in...",
                LongDescription = "Lorem ipsum dolor sit amet, qui vocent adolescens et, errem eligendi at qui, per forensibus scriptorem eu. Eligendi scaevola mea in, ius ex dicat persequeris, ut per malorum principes quem.",
                PublishDate = DateTime.Now,
                AuthorId = 6,
                CategoryId = 1,
                ModifiedBy = "Smari",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem
            {
                Id = 2,
                Title = "Sed ut perspiciatis unde",
                ImgSource = "http://dummyimage.com/130x186.png/dddddd/000000",
                ShortDescription = "Lorem ipsum dolor sit amet, quod...",
                LongDescription = "Lorem ipsum dolor sit amet, ut probo nulla eum, eros saperet fierent at quo, ludus patrioque cum id. Mea ex essent melius. Simul deseruisse ex sit, elit simul causae et.",
                PublishDate = DateTime.Now,
                AuthorId = 8,
                CategoryId = 1,
                ModifiedBy = "Smari",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem
            {
                Id = 3,
                Title = "Li Europan lingues es mem",
                ImgSource = "http://dummyimage.com/217x151.png/dddddd/000000",
                ShortDescription = "Lorem ipsum dolor sit amet, ius...",
                LongDescription = "Lorem ipsum dolor sit amet, ex usu erroribus theophrastus. Delenit persequeris pri ut, ne usu accumsan mediocritatem. Ipsum ullum ignota qui in, ea commodo contentiones mea. Ius eius laudem cu.",
                PublishDate = DateTime.Now,
                AuthorId = 7,
                CategoryId = 2,
                ModifiedBy = "Smari",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem
            {
                Id = 4,
                Title = "Aenean massa",
                ImgSource = "http://dummyimage.com/127x168.png/dddddd/000000",
                ShortDescription = "Lorem ipsum dolor sit amet, pro...",
                LongDescription = "Lorem ipsum dolor sit amet, convenire tractatos eam ei, dicat facilisi postulant ex duo, interesset liberavisse instructior vis in. No meis errem eam, qui ad dicunt iriure animal, alia iudico.",
                PublishDate = DateTime.Now,
                AuthorId = 5,
                CategoryId = 2,
                ModifiedBy = "Thorir",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem
            {
                Id  = 5,
                Title = "Nullam dictum felis eu pede mollis pretium",
                ImgSource = "http://dummyimage.com/240x113.png/dddddd/000000",
                ShortDescription = "Lorem ipsum dolor sit amet, sit...",
                LongDescription = "Lorem ipsum dolor sit amet, mei novum veritus principes te, cu quo zril definitiones. Purto salutandi et eos, vim facer tollit detracto ei. Sit in oportere iracundia euripidis. Ne accumsan.",
                PublishDate = DateTime.Now,
                AuthorId = 4,
                CategoryId = 3,
                ModifiedBy = "Smari",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem
            {
                Id = 6,
                Title = "Vivamus elementum semper nisi",
                ImgSource = "http://dummyimage.com/234x249.png/ff4444/ffffff",
                ShortDescription = "Lorem ipsum dolor sit amet, dictas.",
                LongDescription = "Lorem ipsum dolor sit amet, et pri quando incorrupte, nec tale putent suavitate ad, et vel diam volutpat forensibus. Cu est nonumes tibique accusata, est cu mediocrem assentior. No eleifend.",
                PublishDate = DateTime.Now,
                AuthorId = 3,
                CategoryId = 3,
                ModifiedBy = "Smari",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem
            {
                Id = 7,
                Title = "Aenean leo ligula",
                ImgSource = "http://dummyimage.com/148x153.png/dddddd/000000",
                ShortDescription = "Lorem ipsum dolor sit amet, vis...",
                LongDescription = "Lorem ipsum dolor sit amet, pri labitur tacimates in, eu augue nostrum accumsan vim. Ex populo persecuti sed. Ea pro dico vituperata, pri suas fastidii facilisis an. Quot percipit his.",
                PublishDate = DateTime.Now,
                AuthorId = 2,
                CategoryId = 3,
                ModifiedBy = "Thorir",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem
            {
                Id = 8,
                Title = "Aliquam lorem ante",
                ImgSource = "http://dummyimage.com/219x119.png/cc0000/ffffff",
                ShortDescription = "Lorem ipsum dolor sit amet, vivendum...",
                LongDescription = "Lorem ipsum dolor sit amet, mea cu sint autem assentior. Eu mazim utinam nec. Ea sit voluptatum intellegebat, pri dolor civibus an. Choro accumsan sit ut, ne fugit erant voluptatum.",
                PublishDate = DateTime.Now,
                AuthorId = 1,
                CategoryId = 4,
                ModifiedBy = "Smari",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem
            {
                Id = 9,
                Title = "Duis leo",
                ImgSource = "http://dummyimage.com/165x250.png/dddddd/000000",
                ShortDescription = "Lorem ipsum dolor sit amet, te...",
                LongDescription = "Lorem ipsum dolor sit amet, veri quaeque te has. Sententiae incorrupte philosophia his ut, nam te soluta ridens putant, id prima vituperatoribus eos. Vidisse consequat ea mea, ut eam adhuc.",
                PublishDate = DateTime.Now,
                AuthorId = 8,
                CategoryId = 4,
                ModifiedBy = "Smari",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem
            {
                Id = 10,
                Title = "Vestibulum ante",
                ImgSource = "http://dummyimage.com/129x172.png/dddddd/000000",
                ShortDescription = "Lorem ipsum dolor sit amet, his...",
                LongDescription = "Lorem ipsum dolor sit amet, ius te putant invidunt reprimique, et altera neglegentur definitiones nam. Usu nusquam denique ne. Ex sit deleniti urbanitas. Ei paulo feugait abhorreant nec, purto oportere.",
                PublishDate = DateTime.Now,
                AuthorId = 5,
                CategoryId = 5,
                ModifiedBy = "Smari",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem
            {
                Id = 11,
                Title = "Sed consequat",
                ImgSource = "http://dummyimage.com/174x215.png/cc0000/ffffff",
                ShortDescription = "Lorem ipsum dolor sit amet, id...",
                LongDescription = "Lorem ipsum dolor sit amet, tale ceteros salutatus ad vel, labore regione accusata nam ut. Tincidunt comprehensam eu eos, ei vix dicant veniam, mea ex persecuti vituperata. Sed an mucius.",
                PublishDate = DateTime.Now,
                AuthorId = 5,
                CategoryId = 6,
                ModifiedBy = "Smari",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem
            {
                Id = 12,
                Title = "Curabitur ullamcorper",
                ImgSource = "http://dummyimage.com/157x138.png/ff4444/ffffff",
                ShortDescription = "Lorem ipsum dolor sit amet, vel...",
                LongDescription = "Lorem ipsum dolor sit amet, purto albucius at ius. Ut eleifend accommodare sed. At viderer nostrum ocurreret eam, vero feugait est ut. Ut mundi voluptaria eam, vero eirmod intellegat vix.",
                PublishDate = DateTime.Now,
                AuthorId = 5,
                CategoryId = 6,
                ModifiedBy = "Smari",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem
            {
                Id = 13,
                Title = "Aenean vulputate",
                ImgSource = "http://dummyimage.com/187x163.png/5fa2dd/ffffff",
                ShortDescription = "Lorem ipsum dolor sit amet, ea...",
                LongDescription = "Lorem ipsum dolor sit amet, meis suscipit maiestatis ea nec. Ius eu tation dicant. Erat homero ne vis. Has in essent sadipscing, alii facilisis in per, vis posse lorem ut.",
                PublishDate = DateTime.Now,
                AuthorId = 9,
                CategoryId = 6,
                ModifiedBy = "Thorir",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem
            {
                Id  = 14,
                Title = "Vivamus elementum semper",
                ImgSource = "http://dummyimage.com/189x153.png/cc0000/ffffff",
                ShortDescription = "Lorem ipsum dolor sit amet, magna...",
                LongDescription = "Lorem ipsum dolor sit amet, ne denique salutatus conceptam mea. Tollit laboramus eam in. Has ne explicari moderatius, ex oratio regione scribentur eos. No dicunt qualisque reprehendunt eum, vix ei.",
                PublishDate = DateTime.Now,
                AuthorId = 9,
                CategoryId = 7,
                ModifiedBy = "Smari",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem
            {
                Id = 15,
                Title = "Donec quam felis",
                ImgSource = "http://dummyimage.com/144x223.png/cc0000/ffffff",
                ShortDescription = "Lorem ipsum dolor sit amet, veri...",
                LongDescription = "Lorem ipsum dolor sit amet, vim ad altera salutatus. Omnis conceptam reprehendunt pri at. Putant impedit facilisi sed an, movet iusto sanctus ex sit. Vis cu clita putant, modo civibus.",
                PublishDate = DateTime.Now,
                AuthorId = 2,
                CategoryId = 7,
                ModifiedBy = "Smari",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem
            {
                Id = 16,
                Title = "Nam quam nunc",
                ImgSource = "http://dummyimage.com/148x163.png/5fa2dd/ffffff",
                ShortDescription = "Lorem ipsum dolor sit amet, nam...",
                LongDescription = "Lorem ipsum dolor sit amet, ei vim molestie mediocrem intellegat. Adhuc atqui viris mei no, democritum contentiones ex eum. Vivendo explicari disputando has cu, ad sumo reformidans mel. Sit quod.",
                PublishDate = DateTime.Now,
                AuthorId = 1,
                CategoryId = 7,
                ModifiedBy = "Thorir",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem
            {
                Id = 17,
                Title = "Etiam sit amet orci eget",
                ImgSource = "http://dummyimage.com/219x167.png/5fa2dd/ffffff",
                ShortDescription = "Lorem ipsum dolor sit amet, mel...",
                LongDescription = "Lorem ipsum dolor sit amet, est mandamus repudiare consequuntur an, qui ei stet evertitur. Sit ex accusamus scribentur, facer movet ius id. Eos clita maiorum sapientem cu, vis ea sonet.",
                PublishDate = DateTime.Now,
                AuthorId = 1,
                CategoryId = 8,
                ModifiedBy = "Smari",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            },
            new NewsItem
            {
                Id = 18,
                Title = "Cras ultricies mi eu turpis",
                ImgSource = "http://dummyimage.com/192x173.png/ff4444/ffffff",
                ShortDescription = "Lorem ipsum dolor sit amet, mea...",
                LongDescription = "Lorem ipsum dolor sit amet, quot ceteros ut eos, debitis singulis iracundia id pri, at mutat falli petentium vix. Falli putent id sea. Saepe discere nam te, quo principes suscipiantur.",
                PublishDate = DateTime.Now,
                AuthorId = 1,
                CategoryId = 9,
                ModifiedBy = "Smari",
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
            }
        };

        public static List<Category> Categories { get => _categories; set => _categories = value; }
        public static List<Author> Authors { get => _authors; set => _authors = value; }
        public static List<NewsItem> NewsItems { get => _newsItems; set => _newsItems = value; }

    }
}